# C# app dynamically loads a native DLL (CSLoadLibrary)
## Requires
* Visual Studio 2008
## License
* MS-LPL
## Technologies
* .NET Framework
## Topics
* Interop
* LoadLibrary
## IsPublished
* True
## ModifiedDate
* 2012-08-22 03:45:24
## Description

<h1>CONSOLE APPLICATION (CSLoadLibrary)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">CSLoadLibrary in C# mimics the behavior of CppLoadLibrary to dynamically load a native DLL (LoadLibrary) get the address of a function in the
<span class="GramE">export<span style="">&nbsp; </span>table</span> (GetProcAddress,
<span class="SpellE">Marshal.GetDelegateForFunctionPointer</span>), and call it.
</p>
<p class="MsoNormal">The technology is called Dynamic P/Invoke. It serves as a supplement for the P/Invoke technique and is useful especially when the target DLL is not in the search path of P/Invoke. If you use P/Invoke, CLR will search the
<span class="SpellE">dll</span> in your assembly's directory first, then search the
<span class="SpellE">dll</span> in directories listed in PATH environment variable. If the dll is not in any of those directories, you have to use the so called Dynamic PInvoke technique that is demonstrated in this code sample.
</p>
<h1>DYNAMIC LINK LIBRARY (CppDynamicLinkLibrary ) </h1>
<h2>Introduction </h2>
<p class="MsoNormal">A dynamic-link library (DLL) is <span class="GramE">a module that contain</span> functions and data that can be used by another module (application or DLL). This Win32 DLL code sample demonstrates exporting data, functions and classes
 for use in <span class="SpellE">executables</span>.</p>
<h2>Implementation <span class="SpellE">CSLoadLibrary</span> </h2>
<p class="MsoNormal">1. P/Invoke the API LoadLibrary to dynamically load a native DLL.
</p>
<p class="MsoNormal">2. P/Invoke the API GetProcAddress to get the function pointer of a specified function in the DLL's export table.
</p>
<p class="MsoNormal">3. Call Marshal.GetDelegateForFunctionPointer to convert the function pointer to a delegate object.
</p>
<p class="MsoNormal">4. Call the delegate. </p>
<p class="MsoNormal">5. Call FreeLibrary on the unmanaged dll. (Be careful of calling kernel32<span class="GramE">!FreeLibrary</span> from managed code! This is unsafe and can crash if done wrong.)</p>
<h2>Implementation <span class="SpellE">CppDynamicLinkLibrary</span> </h2>
<h3>A. Creating the project </h3>
<p class="MsoNormal">Step1. Create a Visual C&#43;&#43; / Win32 / Win32 Project named &quot;<span class="SpellE">CppDynamicLinkLibrary</span>&quot; in Visual Studio 2008.
</p>
<p class="MsoNormal">Step2. In the page &quot;Application Settings&quot; of Win32 Application Wizard, select Application type as DLL, and check the Export symbols checkbox. Click Finish.
</p>
<h3>B. Exporting symbols from a DLL using .DEF files</h3>
<p class="MsoNormal"><a href="http://msdn.microsoft.com/en-us/library/d91k01sh.aspx">http://msdn.microsoft.com/en-us/library/d91k01sh.aspx</a>
</p>
<p class="MsoNormal">A module-definition (.def) file is a text file containing one or more module statements that describe various attributes of a DLL. It provides the linker with information about exports, attributes, and other information about the program
 to be linked. </p>
<p class="MsoNormal">Step1. Declare the data and functions to be exported in the header file, and define them in the .cpp file.
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">
int g_nVal1;
int /*__cdecl*/ GetStringLength1(PCWSTR pszString)
int __stdcall GetStringLength1(PCWSTR pszString)
int __stdcall CompareInts(int a, int b, PFN_COMPARE cmpFunc)

</pre>
<pre id="codePreview" class="cplusplus">
int g_nVal1;
int /*__cdecl*/ GetStringLength1(PCWSTR pszString)
int __stdcall GetStringLength1(PCWSTR pszString)
int __stdcall CompareInts(int a, int b, PFN_COMPARE cmpFunc)

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step2. Add a .DEF file named CppDynamicLinkLibrary.def to the project. The first statement in the file must be the LIBRARY statement. This statement identifies the .<span class="SpellE">def</span> file as belonging to a DLL. The LIBRARY
 statement is followed by the name of the DLL. The linker places this name in the DLL's import library. Next, the EXPORTS statement lists the names and, optionally, the ordinal values of the data and functions exported by the DLL.
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">
   LIBRARY   CppDynamicLinkLibrary
   EXPORTS
   GetStringLength1     @1
   CompareInts          @2
   g_nVal1              DATA

</pre>
<pre id="codePreview" class="cplusplus">
   LIBRARY   CppDynamicLinkLibrary
   EXPORTS
   GetStringLength1     @1
   CompareInts          @2
   g_nVal1              DATA

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"></p>
<p class="MsoNormal">Step3. In order that the DLL project invoke the .def file during the linker phase, right-click the project and open its Properties dialog. In the Linker / Input page, set the value of Module Definition File (/<span class="GramE">DEF:</span>)
 to be &quot;CppDynamicLinkLibrary.def&quot;. </p>
<h3>C. Exporting symbols from a DLL using __<span class="GramE">declspec(</span>dllexport)
</h3>
<p class="MsoNormal">Step1. Create the following #ifdef block in the header file to make exporting &amp; importing from a DLL simpler (This should be automatically added if you check the &quot;Export symbols&quot; checkbox when you create the project). All
 files within this DLL are compiled with the CPPDYNAMICLINKLIBRARY_EXPORTS symbol defined on the command line (see the C/C&#43;&#43; / Preprocessor page in the project Properties dialog). This symbol should not be defined on any project that uses this DLL. This way
 any other project whose source files include this file see SYMBOL_DECLSPEC functions as being imported from a DLL, whereas this DLL sees symbols defined with this macro as being exported.
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">
#ifdef CPPDYNAMICLINKLIBRARY_EXPORTS
#define SYMBOL_DECLSPEC __declspec(dllexport)
#else
#define SYMBOL_DECLSPEC __declspec(dllimport)
#endif

</pre>
<pre id="codePreview" class="cplusplus">
#ifdef CPPDYNAMICLINKLIBRARY_EXPORTS
#define SYMBOL_DECLSPEC __declspec(dllexport)
#else
#define SYMBOL_DECLSPEC __declspec(dllimport)
#endif

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step2. Declare the data, functions, and classes to be exported in the header file. Add SYMBOL_DECLSPEC in the signatures. For those data and functions that may be accessed from the C language modules or dynamically linked by any
<span class="SpellE">executables</span>, add EXTERN_C (i.e. extern &quot;C&quot;) at the beginning to specify C linkage. This removes the C&#43;&#43; type-safe naming (aka. name decoration).
</p>
<p class="MsoNormal">Initialize the data and implement the functions and classes in the .cpp file.
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">
EXTERN_C SYMBOL_DECLSPEC int g_nVal2;
EXTERN_C SYMBOL_DECLSPEC int /*__cdecl*/ GetStringLength2(PCWSTR pszString);
EXTERN_C SYMBOL_DECLSPEC int __stdcall GetStringLength2(PCWSTR pszString);
class SYMBOL_DECLSPEC CSimpleObject
{
    ...
};

</pre>
<pre id="codePreview" class="cplusplus">
EXTERN_C SYMBOL_DECLSPEC int g_nVal2;
EXTERN_C SYMBOL_DECLSPEC int /*__cdecl*/ GetStringLength2(PCWSTR pszString);
EXTERN_C SYMBOL_DECLSPEC int __stdcall GetStringLength2(PCWSTR pszString);
class SYMBOL_DECLSPEC CSimpleObject
{
    ...
};

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<h2>Using the Code</h2>
<p class="MsoNormal">The sample DLL exports these data, functions and classes: </p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">
// Global Data
int g_nVal1
int g_nVal2


// Ordinary Functions
int __cdecl GetStringLength1(PCWSTR pszString);
int __stdcall GetStringLength2(PCWSTR pszString);


// Callback Function
int __stdcall CompareInts(int a, int b, PFN_COMPARE cmpFunc)


// Class
class CSimpleObject
{
public:
    CSimpleObject(void);  // Constructor
    virtual ~CSimpleObject(void);  // Destructor
      
    // Property
    float get_FloatProperty(void);
    void set_FloatProperty(float newVal);


    // Method
    HRESULT ToString(PWSTR pszBuffer, DWORD dwSize);


    // Static method
    static int GetStringLength(PCWSTR pszString);


private:
    float m_fField;
}; 

</pre>
<pre id="codePreview" class="cplusplus">
// Global Data
int g_nVal1
int g_nVal2


// Ordinary Functions
int __cdecl GetStringLength1(PCWSTR pszString);
int __stdcall GetStringLength2(PCWSTR pszString);


// Callback Function
int __stdcall CompareInts(int a, int b, PFN_COMPARE cmpFunc)


// Class
class CSimpleObject
{
public:
    CSimpleObject(void);  // Constructor
    virtual ~CSimpleObject(void);  // Destructor
      
    // Property
    float get_FloatProperty(void);
    void set_FloatProperty(float newVal);


    // Method
    HRESULT ToString(PWSTR pszBuffer, DWORD dwSize);


    // Static method
    static int GetStringLength(PCWSTR pszString);


private:
    float m_fField;
}; 

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"></p>
<h2>Two methods are used to export the symbols from the sample DLL<span style="font-size:11.0pt; line-height:115%; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;">
</span></h2>
<h3>1. Export symbols from a DLL using .DEF files </h3>
<p class="MsoNormal" style="margin-bottom:0cm; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
A module-definition (.DEF) file is a text file containing one or more module statements that describe various attributes of a DLL. Create a .DEF file and use the .<span class="SpellE">def</span> file when building the DLL. Using this approach, we can export
 functions from the DLL by ordinal rather than by name. </p>
<h3>2. Export symbols from a DLL using __<span class="GramE">declspec(</span>dllexport)
<span style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;"></span></h3>
<p class="MsoNormal" style="margin-bottom:0cm; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
__<span class="GramE">declspec(</span>dllexport) adds the export directive to the object file so we do not need to use a .def file. This convenience is most apparent when trying
<span class="SpellE">toexport</span> decorated C&#43;&#43; function names. </p>
<h2>More Information</h2>
<p class="MsoNormal" style="margin-bottom:0cm; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:NSimSun"></span></p>
<p class="MsoListParagraphCxSpFirst" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://blogs.msdn.com/jmstall/archive/2007/01/06/Typesafe-GetProcAddress.aspx">Type-safe Managed wrappers for kernel32!GetProcAddress</a>
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://blogs.msdn.com/junfeng/archive/2004/07/14/181932.aspx">Dynamic PInvoke</a>
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://msdn.microsoft.com/en-us/library/z4zxe9k8.aspx">MSDN: Exporting from a DLL</a>
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://msdn.microsoft.com/en-us/library/d91k01sh.aspx">MSDN: Exporting from a DLL Using DEF Files</a>
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://msdn.microsoft.com/en-us/library/a90k134d.aspx">MSDN: Exporting from a DLL Using __<span class="SpellE">declspec</span>(<span class="SpellE">dllexport</span>)</a>
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://msdn.microsoft.com/en-us/library/ms235636.aspx">MSDN: Creating and Using a Dynamic Link Library (C&#43;&#43;)</a>
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://support.microsoft.com/kb/90530">HOWTO: How To Export Data from a DLL or an Application</a>
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:5.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.5pt; font-family:NSimSun"><a href="http://en.wikipedia.org/wiki/Dynamic_link_library">Dynamic-link library</a>
</span></p>
<p class="MsoListParagraphCxSpLast"></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>
