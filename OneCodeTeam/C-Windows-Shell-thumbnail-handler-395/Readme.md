# C++ Windows Shell thumbnail handler (CppShellExtThumbnailHandler)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Shell
## Topics
* Shell Extension
* Thumbnail Handler
## IsPublished
* True
## ModifiedDate
* 2012-01-15 09:30:22
## Description

<p style="font-family:Courier New">&nbsp;</p>
<h2>DYNAMIC LINK LIBRARY : CppShellExtThumbnailHandler Project Overview</h2>
<p style="font-family:Courier New">&nbsp;</p>
<h3>Summary:</h3>
<p style="font-family:Courier New"><br>
The code sample demonstrates the C&#43;&#43; implementation of a thumbnail handler <br>
for a new file type registered with the .recipe extension. <br>
<br>
A thumbnail image handler provides an image to represent the item. It lets <br>
you customize the thumbnail of files with a specific file extension. Windows <br>
Vista and newer operating systems make greater use of file-specific thumbnail <br>
images than earlier versions of Windows. Thumbnails of 32-bit resolution and <br>
as large as 256x256 pixels are often used. File format owners should be <br>
prepared to display their thumbnails at that size. <br>
<br>
The example thumbnail handler has the class ID (CLSID): <br>
&nbsp; &nbsp;{4D2FBA8D-621B-4447-AF6D-5794F479C4A5}<br>
<br>
The handler implements the IInitializeWithStream and IThumbnailProvider <br>
interfaces, and provides thumbnails for .recipe files. The .recipe file type <br>
is simply an XML file registered as a unique file name extension. It includes <br>
an element called &quot;Picture&quot;, embedding an image file. The thumbnail handler <br>
extracts the embedded image and asks the Shell to display it as a thumbnail.<br>
<br>
</p>
<h3>Prerequisite:</h3>
<p style="font-family:Courier New"><br>
The example thumbnail handler must be registered on Windows Vista or newer <br>
operating systems.<br>
<br>
</p>
<h3>Setup and Removal:</h3>
<p style="font-family:Courier New"><br>
A. Setup<br>
<br>
If you are going to use the Shell extension in a x64 Windows system, please <br>
configure the Visual C&#43;&#43; project to target 64-bit platforms using project <br>
configurations (<a href="&lt;a target=" target="_blank">http://msdn.microsoft.com/en-us/library/9yb4317s.aspx).</a>'&gt;<a href="http://msdn.microsoft.com/en-us/library/9yb4317s.aspx)." target="_blank">http://msdn.microsoft.com/en-us/library/9yb4317s.aspx).</a>
<br>
<br>
If the extension is to be loaded in a 32-bit Windows system, you can use the <br>
default Win32 project configuration to build the project.<br>
<br>
In a command prompt running as administrator, navigate to the folder that <br>
contains the build result CppShellExtThumbnailHandler.dll and enter the <br>
command:<br>
<br>
&nbsp; &nbsp;Regsvr32.exe CppShellExtThumbnailHandler.dll<br>
<br>
The thumbnail handler is registered successfully if you see a message box <br>
saying:<br>
<br>
&nbsp; &nbsp;&quot;DllRegisterServer in CppShellExtThumbnailHandler.dll succeeded.&quot;<br>
<br>
B. Removal<br>
<br>
In a command prompt running as administrator, navigate to the folder that <br>
contains the build result CppShellExtThumbnailHandler.dll and enter the <br>
command:<br>
<br>
&nbsp; &nbsp;Regsvr32.exe /u CppShellExtThumbnailHandler.dll<br>
<br>
The thumbnail handler is unregistered successfully if you see a message box <br>
saying:<br>
<br>
&nbsp; &nbsp;&quot;DllUnregisterServer in CppShellExtThumbnailHandler.dll succeeded.&quot;<br>
<br>
</p>
<h3>Demo:</h3>
<p style="font-family:Courier New"><br>
The following steps walk through a demonstration of the thumbnail handler <br>
code sample.<br>
<br>
Step1. If you are going to use the Shell extension in a x64 Windows system, <br>
please configure the Visual C&#43;&#43; project to target 64-bit platforms using <br>
project configurations (<a href="&lt;a target=" target="_blank">http://msdn.microsoft.com/en-us/library/9yb4317s.aspx).</a>'&gt;<a href="http://msdn.microsoft.com/en-us/library/9yb4317s.aspx)." target="_blank">http://msdn.microsoft.com/en-us/library/9yb4317s.aspx).</a>
<br>
If the extension is to be loaded in a 32-bit Windows system, you can use the <br>
default Win32 project configuration.<br>
<br>
Step2. After you successfully build the sample project in Visual Studio 2010, <br>
you will get a DLL: CppShellExtThumbnailHandler.dll. Start a command prompt <br>
as administrator, navigate to the folder that contains the file and enter the <br>
command:<br>
<br>
&nbsp; &nbsp;Regsvr32.exe CppShellExtThumbnailHandler.dll<br>
<br>
The thumbnail handler is registered successfully if you see a message box <br>
saying:<br>
<br>
&nbsp; &nbsp;&quot;DllRegisterServer in CppShellExtThumbnailHandler.dll succeeded.&quot;<br>
<br>
Step3. Find the chocolatechipcookies.recipe file in the sample folder. You <br>
will see a picture of chocoate chip cookies as its thumbnail. <br>
<br>
The .recipe file type is simply an XML file registered as a unique file name <br>
extension. It includes an element called &quot;Picture&quot;, embedding an image file. <br>
The thumbnail handler extracts the embedded image and asks the Shell to <br>
display it as a thumbnail. <br>
<br>
Step4. In the same command prompt, run the command <br>
<br>
&nbsp; &nbsp;Regsvr32.exe /u CppShellExtThumbnailHandler.dll<br>
<br>
to unregister the Shell thumbnail handler.<br>
<br>
</p>
<h3>Implementation:</h3>
<p style="font-family:Courier New"><br>
A. Creating and configuring the project<br>
<br>
In Visual Studio 2010, create a Visual C&#43;&#43; / Win32 / Win32 Project named <br>
&quot;CppShellExtThumbnailHandler&quot;. In the &quot;Application Settings&quot; page of Win32 <br>
Application Wizard, select the application type as &quot;DLL&quot; and check the &quot;Empty <br>
project&quot; option. After you click the Finish button, an empty Win32 DLL <br>
project is created.<br>
<br>
-----------------------------------------------------------------------------<br>
<br>
B. Implementing a basic Component Object Model (COM) DLL<br>
<br>
Shell extension handlers are COM objects implemented as DLLs. Making a basic <br>
COM includes implementing DllGetClassObject, DllCanUnloadNow, <br>
DllRegisterServer, and DllUnregisterServer in (and exporting them from) the <br>
DLL, adding a COM class with the basic implementation of the IUnknown <br>
interface, preparing the class factory for your COM class. The relevant files <br>
in this code sample are:<br>
<br>
&nbsp;dllmain.cpp - implements DllMain and the DllGetClassObject, DllCanUnloadNow,
<br>
&nbsp; &nbsp;DllRegisterServer, DllUnregisterServer functions that are necessary for a
<br>
&nbsp; &nbsp;COM DLL. <br>
<br>
&nbsp;GlobalExportFunctions.def - exports the DllGetClassObject, DllCanUnloadNow,
<br>
&nbsp; &nbsp;DllRegisterServer, DllUnregisterServer functions from the DLL through the
<br>
&nbsp; &nbsp;module-definition file. You need to pass the .def file to the linker by
<br>
&nbsp; &nbsp;configuring the Module Definition File property in the project's Property
<br>
&nbsp; &nbsp;Pages / Linker / Input property page.<br>
<br>
&nbsp;Reg.h/cpp - defines the reusable helper functions to register or unregister
<br>
&nbsp; &nbsp;in-process COM components in the registry: <br>
&nbsp; &nbsp;RegisterInprocServer, UnregisterInprocServer<br>
<br>
&nbsp;RecipeThumbnailProvider.h/cpp - defines the COM class. You can find the basic
<br>
&nbsp; &nbsp;implementation of the IUnknown interface in the files.<br>
<br>
&nbsp;ClassFactory.h/cpp - defines the class factory for the COM class. <br>
<br>
-----------------------------------------------------------------------------<br>
<br>
C. Implementing the thumbnail handler and registering it for a certain file <br>
class<br>
<br>
-----------<br>
Implementing the thumbnail handler:<br>
<br>
The RecipeThumbnailProvider.h/cpp files define a thumbnail provider. It <br>
implements the IInitializeWithStream and IThumbnailProvider interfaces, and <br>
provides thumbnails for .recipe files. <br>
<br>
&nbsp; &nbsp;class RecipeThumbnailProvider : <br>
&nbsp; &nbsp; &nbsp; &nbsp;public IInitializeWithStream, <br>
&nbsp; &nbsp; &nbsp; &nbsp;public IThumbnailProvider<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp;public:<br>
&nbsp; &nbsp; &nbsp; &nbsp;// IInitializeWithStream<br>
&nbsp; &nbsp; &nbsp; &nbsp;IFACEMETHODIMP Initialize(IStream *pStream, DWORD grfMode);<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;// IThumbnailProvider<br>
&nbsp; &nbsp; &nbsp; &nbsp;IFACEMETHODIMP GetThumbnail(UINT cx, HBITMAP *phbmp, WTS_ALPHATYPE *pdwAlpha);<br>
&nbsp; &nbsp;};<br>
<br>
&nbsp;1. Implementing IThumbnailProvider<br>
&nbsp;<br>
&nbsp;The IThumbnailProvider interface has been introduced in Windows Vista to <br>
&nbsp;make providing a thumbnail easier and more straightforward than in the past,
<br>
&nbsp;when IExtractImage would have been used instead. Note, that existing code <br>
&nbsp;that uses IExtractImage is still valid under Windows Vista. However, <br>
&nbsp;IExtractImage is not supported in the Details pane. <br>
<br>
&nbsp;IThumbnailProvider has only one method��GetThumbnail��that is called with the
<br>
&nbsp;largest desired size of the image, in pixels. Although the parameter is <br>
&nbsp;called cx, this is used as the maximum size of both the x and y dimensions.
<br>
&nbsp;If the retrieved thumbnail is not square, then the longer axis is limited <br>
&nbsp;by cx and the aspect ratio of the original image respected.<br>
<br>
&nbsp;On exit, GetThumbnail provides a handle to the retrieved image. It also <br>
&nbsp;provides a value that indicates the color format of the image and whether <br>
&nbsp;it has valid alpha information.<br>
<br>
&nbsp; &nbsp;IFACEMETHODIMP RecipeThumbnailProvider::GetThumbnail(UINT cx, HBITMAP *phbmp,
<br>
&nbsp; &nbsp; &nbsp; &nbsp;WTS_ALPHATYPE *pdwAlpha)<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp;// Load the XML document.<br>
&nbsp; &nbsp; &nbsp; &nbsp;IXMLDOMDocument *pXMLDoc = NULL;<br>
&nbsp; &nbsp; &nbsp; &nbsp;HRESULT hr = LoadXMLDocument(&amp;pXMLDoc);<br>
&nbsp; &nbsp; &nbsp; &nbsp;if (SUCCEEDED(hr))<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;// Read the preview image from the XML document.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;hr = GetRecipeImage(pXMLDoc, cx, phbmp, pdwAlpha);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;pXMLDoc-&gt;Release();<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;return hr;<br>
&nbsp; &nbsp;}<br>
<br>
&nbsp;The .recipe file type is simply an XML file registered as a unique file <br>
&nbsp;name extension. It includes an element called Picture that embeds images <br>
&nbsp;to be used as the thumbnail for this particular .recipe file. The XML <br>
&nbsp;may provide images of different sizes, and the code can query image <br>
&nbsp;matching the desired size specified by the cx parameter of GetThumbnail. <br>
&nbsp;For simplicity, this sample omits the cx paramter and provides only one <br>
&nbsp;image for all situations.<br>
<br>
&nbsp;2. Implementing IInitializeWithStream/IInitializeWithItem/IInitializeWithFile<br>
<br>
&nbsp;IThumbnailProvider must always be implemented in concert with one of these <br>
&nbsp;interfaces: <br>
&nbsp;<br>
&nbsp; &nbsp;IInitializeWithStream - provides the file stream<br>
&nbsp; &nbsp;IInitializeWithItem - provides the IShellItem<br>
&nbsp; &nbsp;IInitializeWithFile - provides the file path<br>
<br>
&nbsp;Whenever possible, it is recommended that initialization be done through a <br>
&nbsp;stream using IInitializeWithStream. Benefits of this include increased <br>
&nbsp;security and stability.<br>
<br>
&nbsp; &nbsp;IStream *m_pStream;<br>
<br>
&nbsp; &nbsp;IFACEMETHODIMP RecipeThumbnailProvider::Initialize(IStream *pStream, DWORD grfMode)<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp;// A handler instance should be initialized only once in its lifetime.
<br>
&nbsp; &nbsp; &nbsp; &nbsp;HRESULT hr = HRESULT_FROM_WIN32(ERROR_ALREADY_INITIALIZED);<br>
&nbsp; &nbsp; &nbsp; &nbsp;if (m_pStream == NULL)<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;// Take a reference to the stream if it has not been initialized yet.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;hr = pStream-&gt;QueryInterface(&amp;m_pStream);<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;return hr;<br>
&nbsp; &nbsp;}<br>
<br>
-----------<br>
Registering the handler for a certain file class:<br>
<br>
The CLSID of the handler is declared at the beginning of dllmain.cpp.<br>
<br>
// {4D2FBA8D-621B-4447-AF6D-5794F479C4A5}<br>
const CLSID CLSID_RecipeThumbnailProvider = <br>
{ 0x4D2FBA8D, 0x621B, 0x4447, { 0xAF, 0x6D, 0x57, 0x94, 0xF4, 0x79, 0xC4, 0xA5 } };<br>
<br>
When you write your own handler, you must create a new CLSID by using the <br>
&quot;Create GUID&quot; tool in the Tools menu, and specify the CLSID value here.<br>
<br>
Thumbnail handlers can be associated with a file class. The handlers are <br>
registered by setting the default value of the following registry key to be <br>
the CLSID the handler class. <br>
<br>
&nbsp; &nbsp;HKEY_CLASSES_ROOT\&lt;File Type&gt;\shellex\{e357fccd-a995-4576-b01f-234630154e96}<br>
<br>
The registration of the thumbnail handler is implemented in the <br>
DllRegisterServer function of dllmain.cpp. DllRegisterServer first calls the <br>
RegisterInprocServer function in Reg.h/cpp to register the COM component. <br>
Next, it calls RegisterShellExtThumbnailHandler to associate the handler <br>
with a certain file type. If the file type starts with '.', it tries to read <br>
the default value of the HKCR\&lt;File Type&gt; key which may contain the Program
<br>
ID to which the file type is linked. If the default value is not empty, use <br>
the Program ID as the file type to proceed the registration. <br>
<br>
For example, this code sample associates the handler with '.recipe' files. <br>
The following keys and values are added in the registration process of the <br>
sample handler. <br>
<br>
&nbsp; &nbsp;HKCR<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp;NoRemove CLSID<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;ForceRemove {4D2FBA8D-621B-4447-AF6D-5794F479C4A5} =
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;s 'CppShellExtThumbnailHandler.RecipeThumbnailProvider Class'<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;InprocServer32 = s '&lt;Path of CppShellExtThumbnailHandler.DLL file&gt;'<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;val ThreadingModel = s 'Apartment'<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;NoRemove .recipe<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;NoRemove shellex<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{e357fccd-a995-4576-b01f-234630154e96} =
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;s '{4D2FBA8D-621B-4447-AF6D-5794F479C4A5}'<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp;}<br>
<br>
The unregistration is implemented in the DllUnregisterServer function of <br>
dllmain.cpp. It removes the HKCR\CLSID\{&lt;CLSID&gt;} key and the <br>
HKCR\&lt;File Type&gt;\shellex\{e357fccd-a995-4576-b01f-234630154e96} key.<br>
<br>
</p>
<h3>Diagnostic:</h3>
<p style="font-family:Courier New"><br>
Debugging thumbnail handlers is difficult for several reasons.<br>
<br>
1) The Windows Explorer hosts thumbnail providers in an isolated process to <br>
get robustness and improve security. Because of this it is difficult to debug <br>
your handler as you cannot set breakpoints on your code in the explorer.exe <br>
process as it is not loaded there. The isolated process is DllHost.exe and <br>
this is used for other purposes so finding the right instance of this process <br>
is difficult. <br>
<br>
2) Once a thumbnail is computed for a particular file it is cached and your <br>
handler won't be called again for that item unless you invalidate the cache <br>
by updating the modification date of the file. Note that this cache works <br>
even if the files are renamed or moved.<br>
<br>
Given all of these issues the easiest way to debug your code in a test <br>
application then once you have proven it works there test it in the context <br>
of the explorer. <br>
<br>
Another thing to do is to disable the process isolation feature of explorer. <br>
You can do this by putting the following named value on the CLSID of your <br>
handler<br>
<br>
&nbsp; &nbsp;HKCR\CLSID\{CLSID of Your Handler}<br>
&nbsp; &nbsp; &nbsp; &nbsp;DisableProcessIsolation=REG_DWORD:1<br>
<br>
Be sure to not ship your handler with this on as customers require the <br>
security and robustness benefits of the isolated process feature.<br>
<br>
</p>
<h3>References:</h3>
<p style="font-family:Courier New"><br>
MSDN: Thumbnail Handlers<br>
<a href="http://msdn.microsoft.com/en-us/library/cc144118.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/cc144118.aspx</a><br>
<br>
MSDN: Building Thumbnail Handlers<br>
<a href="http://msdn.microsoft.com/en-us/library/cc144114.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/cc144114.aspx</a><br>
<br>
MSDN: Thumbnail Handler Guidelines<br>
<a href="http://msdn.microsoft.com/en-us/library/cc144115.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/cc144115.aspx</a><br>
<br>
MSDN: IThumbnailProvider Interface<br>
<a href="http://msdn.microsoft.com/en-us/library/bb774614.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/bb774614.aspx</a><br>
<br>
<br>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt="">
</a></div>
