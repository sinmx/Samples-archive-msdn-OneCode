# VB ActiveX control (VBActiveX)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* COM
* Windows SDK
## Topics
* COM
* Interop
* ActiveX
## IsPublished
* True
## ModifiedDate
* 2012-03-02 12:00:24
## Description

<h1><span style="font-family:������">ACTIVEX CONTROL DLL</span> (<span style="font-family:������">VBActiveX</span>)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">The sample demonstrates an ActiveX control written in VB.NET. ActiveX controls (formerly known as OLE controls) are small program building blocks that can work in a variety of different containers, ranging from software development tools
 to end-user productivity tools. For example, it can be used to create distributed applications that work over the Internet through web browsers. ActiveX controls can be written in MFC, ATL, C&#43;&#43;, C#,
<span class="GramE">Borland<span style="">&nbsp; </span>Delphi</span> and Visual Basic. In this sample, we focus on writing an ActiveX control using VB.NET. We will go through the basic steps of adding UI, properties, methods, and events to the control. Please
 note that ActiveX controls or COM components written in .NET languages cannot be referenced by .NET applications in the form of interop assemblies. If you &quot;add reference&quot; to such a TLB, or drag &amp; drop such an ActiveX control to your .NET application,
 you will get an error &quot;The ActiveX type library 'XXXXX.tlb' was exported from a .NET assembly and cannot be added as a reference.&quot;. The correct approach is to add a reference to the .NET assembly directly.
</p>
<h3>VBActiveX exposes the following items: </h3>
<p class="MsoNormal">1. A VB.NET ActiveX control.<span style=""> </span></p>
<table class="MsoTableGrid" border="1" cellspacing="0" cellpadding="0" style="border-collapse:collapse; border:none">
<tbody>
<tr style="">
<td width="295" valign="top" style="width:221.4pt; border:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">Program ID<span style=""> </span></p>
</td>
<td width="295" valign="top" style="width:221.4pt; border:solid windowtext 1.0pt; border-left:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"><span class="SpellE">VBActiveX.VBActiveXCtrl</span><span style="">
</span></p>
</td>
</tr>
<tr style="">
<td width="295" valign="top" style="width:221.4pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"><span class="SpellE">CLSID_VBActiveXCtrl</span><span style="">
</span></p>
</td>
<td width="295" valign="top" style="width:221.4pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">81F71529-0F1C-3905-94E5-82ADBB9DFB5B<span style=""> </span>
</p>
</td>
</tr>
<tr style="">
<td width="295" valign="top" style="width:221.4pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">DIID__<span class="SpellE">VBActiveXCtrl</span><span style="">
</span></p>
</td>
<td width="295" valign="top" style="width:221.4pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">916F51ED-11DA-317B-988E-427C2B5032C5<span style=""> </span>
</p>
</td>
</tr>
<tr style="">
<td width="295" valign="top" style="width:221.4pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">DIID___<span class="SpellE">VBActiveXCtrl</span><span style="">
</span></p>
</td>
<td width="295" valign="top" style="width:221.4pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">2994FDB9-EBD0-4708-9197-D2B90E261E4F (<span class="SpellE">EventID</span>)<span style="">
</span></p>
</td>
</tr>
<tr style="">
<td width="295" valign="top" style="width:221.4pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"><span class="SpellE">LIBID_VBActiveX</span><span style="">
</span></p>
</td>
<td width="295" valign="top" style="width:221.4pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">418E907A-3490-4879-8C15-FFC464374407<span style=""> </span>
</p>
</td>
</tr>
</tbody>
</table>
<p class="MsoNormal"><span style=""></span></p>
<table class="MsoTableGrid" border="1" cellspacing="0" cellpadding="0" style="border-collapse:collapse; border:none">
<tbody>
<tr style="">
<td width="197" valign="top" style="width:147.6pt; border:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"></p>
</td>
<td width="237" valign="top" style="width:178.05pt; border:solid windowtext 1.0pt; border-left:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"><b style=""><span style="">name </span></b></p>
</td>
<td width="350" valign="top" style="width:262.25pt; border:solid windowtext 1.0pt; border-left:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"><b style=""><span style="">description </span></b></p>
</td>
</tr>
<tr style="">
<td width="197" valign="top" style="width:147.6pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">UI</p>
</td>
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"><span class="SpellE">VBActiveXCtrl</span></p>
</td>
<td width="350" valign="top" style="width:262.25pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">The main UI of the control</p>
</td>
</tr>
<tr style="">
<td width="197" rowspan="5" style="width:147.6pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">Properties</p>
</td>
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">Visible As Boolean</p>
</td>
<td width="350" rowspan="4" valign="top" style="width:262.25pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">Typical control properties</p>
</td>
</tr>
<tr style="">
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">Enabled As Boolean</p>
</td>
</tr>
<tr style="">
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal"><span class="SpellE">ForeColor</span> As Integer</p>
</td>
</tr>
<tr style="height:41.3pt">
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt; height:41.3pt">
<p class="MsoNormal"><span class="SpellE">BackColor</span> As Intege<span style="">r
</span></p>
</td>
</tr>
<tr style="height:25.05pt">
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt; height:25.05pt">
<p class="MsoNormal"><span class="SpellE">FloatProperty</span> As Singl<span style="">e
</span></p>
</td>
<td width="350" valign="top" style="width:262.25pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt; height:25.05pt">
<p class="MsoNormal" align="center" style="text-align:center">Custom properties</p>
</td>
</tr>
<tr style="">
<td width="197" rowspan="2" valign="top" style="width:147.6pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">Methods<span style="">
</span></p>
<p class="MsoNormal"></p>
</td>
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">Sub Refresh()</p>
</td>
<td width="350" valign="top" style="width:262.25pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">Typical control methods</p>
</td>
</tr>
<tr style="">
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">Function <span class="SpellE">HelloWorld</span>() As String</p>
</td>
<td width="350" valign="top" style="width:262.25pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">Custom methods</p>
</td>
</tr>
<tr style="">
<td width="197" rowspan="2" valign="top" style="width:147.6pt; border:solid windowtext 1.0pt; border-top:none; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">Events<span style="">
</span></p>
<p class="MsoNormal"></p>
</td>
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal">Event Click()</p>
</td>
<td width="350" valign="top" style="width:262.25pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt">
<p class="MsoNormal" align="center" style="text-align:center">Typical control events</p>
</td>
</tr>
<tr style="height:106.9pt">
<td width="237" valign="top" style="width:178.05pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt; height:106.9pt">
<p class="MsoNormal">Event <span class="SpellE"><span class="GramE">FloatPropertyChanging</span></span><span class="GramE">(</span><span class="SpellE">ByVal</span>
<span class="SpellE">NewValue</span> As Single, ByRef Cancel As Boolean).<span style="">&nbsp;
</span></p>
</td>
<td width="350" valign="top" style="width:262.25pt; border-top:none; border-left:none; border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt; padding:0cm 5.4pt 0cm 5.4pt; height:106.9pt">
<p class="MsoNormal">Custom events<span style=""> </span></p>
<p class="MsoNormal"><span style="">&nbsp;</span><span class="SpellE">FloatPropertyChanging</span> is fired before new value is set to the FloatProperty
</p>
<p class="MsoNormal">' property. The Cancel parameter allows the client to cancel the change of
</p>
<p class="MsoNormal"><span class="GramE">' <span class="SpellE">FloatProperty</span></span>.</p>
</td>
</tr>
</tbody>
</table>
<p class="MsoNormal"></p>
<h2><span style="">Building</span> the Sample</h2>
<p class="MsoListParagraphCxSpFirst" style=""><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Run your Visual Studio as Administrator. </span>
</p>
<p class="MsoListParagraphCxSpLast" style=""><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Build the solution. </span></p>
<h2><span style="">Using the code </span></h2>
<h3><span style="">A. Creating the project </span></h3>
<p class="MsoNormal">Step1. Create a Visual Basic / Class Library project named VBActiveX in Visual Studio 2010. Delete the default Class1.vb file.
</p>
<p class="MsoNormal">Step2. In order to make the .NET assembly COM-visible, first, open the property of the project. Click the Assembly Information button in the Application page, and select the &quot;Make Assembly COM-Visible&quot; box. This corresponds
 to the assembly attribute ComVisible in AssemblyInfo.vb: </p>
<p class="MsoNormal">The GUID value in the dialog is the libid of the component:
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
&lt;Assembly: ComVisible(True)&gt; 


'The following GUID is for the ID of the typelib if this project is exposed to COM
&lt;Assembly: Guid(&quot;418e907a-3490-4879-8c15-ffc464374407&quot;)&gt; 

</pre>
<pre id="codePreview" class="vb">
&lt;Assembly: ComVisible(True)&gt; 


'The following GUID is for the ID of the typelib if this project is exposed to COM
&lt;Assembly: Guid(&quot;418e907a-3490-4879-8c15-ffc464374407&quot;)&gt; 

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Second, in the Compile page of the project's property, select the option &quot;Register for COM interop&quot;. This option specifies whether your managed application will expose a COM object (a COM-callable wrapper) that allows a COM
 object to interact with your managed application. </p>
<h3><span style="">B. Adding the ActiveXCtrlHelper class </span></h3>
<p class="MsoNormal">ActiveXCtrlHelper provides the helper functions to register/unregister an ActiveX control, and helps to handle the focus and tabbing across the container and the .NET controls.
</p>
<h3><span style="">C. Adding a user control and expose it as an ActiveX control </span>
</h3>
<p class="MsoNormal">Step1. Right-click the project and choose Add / User Control in the context menu. Name the control as VBActiveXCtrl. Next, double-click the control to open its design view and design the UI.
</p>
<p class="MsoNormal">Step2. Inside the VBActiveXCtrl class, define Class ID, Interface ID, and Event ID:
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
   ' These  GUIDs provide the COM identity for this class and its COM 
   ' interfaces. If you change them, existing clients will no longer be 
   ' able to access the class.


   Public Const ClassId As String _
   = &quot;81F71529-0F1C-3905-94E5-82ADBB9DFB5B&quot;
   Public Const InterfaceId As String _
   = &quot;916F51ED-11DA-317B-988E-427C2B5032C5&quot;
   Public Const EventsId As String _
   = &quot;2994FDB9-EBD0-4708-9197-D2B90E261E4F&quot;

</pre>
<pre id="codePreview" class="vb">
   ' These  GUIDs provide the COM identity for this class and its COM 
   ' interfaces. If you change them, existing clients will no longer be 
   ' able to access the class.


   Public Const ClassId As String _
   = &quot;81F71529-0F1C-3905-94E5-82ADBB9DFB5B&quot;
   Public Const InterfaceId As String _
   = &quot;916F51ED-11DA-317B-988E-427C2B5032C5&quot;
   Public Const EventsId As String _
   = &quot;2994FDB9-EBD0-4708-9197-D2B90E261E4F&quot;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Attach ComClassAttribute to the class VBActiveXCtrl, and specify its _ClassID, _InterfaceID, and _EventID to be the above const values:
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
&lt;ComClass(VBActiveXCtrl.ClassId, VBActiveXCtrl.InterfaceId, _
          VBActiveXCtrl.EventsId)&gt; _
Public Class VBActiveXCtrl

</pre>
<pre id="codePreview" class="vb">
&lt;ComClass(VBActiveXCtrl.ClassId, VBActiveXCtrl.InterfaceId, _
          VBActiveXCtrl.EventsId)&gt; _
Public Class VBActiveXCtrl

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">The Microsoft.VisualBasic.ComClassAttribute attribute instructs the compiler to add metadata that allows a class to be exposed as a COM object in an easyway, when compared with the use of COM interface and the ComSourceInterfaces attribute
 in C# (see: CSActiveX). </p>
<h3><span style="">D. ActiveX Control Registration </span></h3>
<p class="MsoNormal">Additional registry keys/values are required to be set for ActiveX controls when compared with ordinary COM components. The default COM registration routine does not meet the need. Inside VBActiveXCtrl, add the functions Register, Unregister
 and decorate them with ComRegisterFunctionAttribute, ComUnregisterFunctionAttribute. The custom routine gets called after Regasm
</p>
<p class="MsoNormal">finishes the default behaviors. The Register and Unregister functions call the helper methods in ActiveXCtrlHelper.
</p>
<h3><span style="">E. Adding Properties to the ActiveX control </span></h3>
<p class="MsoNormal">Step1. Inside the VBActiveXCtrl class, add a public property. All public properties are exposed from the control. For example,
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
    Public Property FloatProperty() As Single
        Get
            Return Me.fField
        End Get
        Set(ByVal value As Single)
            Me.fField = value
        End Set
    End Property

</pre>
<pre id="codePreview" class="vb">
    Public Property FloatProperty() As Single
        Get
            Return Me.fField
        End Get
        Set(ByVal value As Single)
            Me.fField = value
        End Set
    End Property

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<h3><span style="">F. Adding Methods to the ActiveX control </span></h3>
<p class="MsoNormal">Step1. Inside the VBActiveXCtrl class, add a public method. All public methods are exposed from the control. For example,
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Public Function HelloWorld() As String
    Return &quot;HelloWorld&quot;
End Function

</pre>
<pre id="codePreview" class="vb">
Public Function HelloWorld() As String
    Return &quot;HelloWorld&quot;
End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<h3><span style="">G. Adding Events to the ActiveX control </span></h3>
<p class="MsoNormal">Step1. Inside the VBActiveXCtrl class, add a public event. For example,
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Public Event FloatPropertyChanging(ByVal NewValue As Single, _
                                   ByRef Cancel As Boolean)

</pre>
<pre id="codePreview" class="vb">
Public Event FloatPropertyChanging(ByVal NewValue As Single, _
                                   ByRef Cancel As Boolean)

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Then raise the event in the proper places. For example, </p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Dim cancel As Boolean = False
RaiseEvent FloatPropertyChanging(value, cancel)

</pre>
<pre id="codePreview" class="vb">
Dim cancel As Boolean = False
RaiseEvent FloatPropertyChanging(value, cancel)

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<h3><span style="">H. Adding the ToolBox Bitmap resource </span></h3>
<p class="MsoNormal">The ToolBox bitmap resource is specified in the regsitry key:<span style="">
</span>HKCR\CLSID\{CLSID of the control}\ToolBoxBitmap32\<span style=""> </span>(see the RegisterControl method in ActiveXCtrlHelper)<span style="">
</span>ToolBoxBitmap32 is used to identify the module name and the resource ID for a 16 x 16 bitmap as the toolbar button face. Each specified icon must be embedded as a win32 resource in the assembly. In order to embed the bitmap
</p>
<p class="MsoNormal">CSActiveX.bmp into the assembly as a win32 resource, we need to
</p>
<p class="MsoNormal">Step1. Place the VBActiveX.bmp file in the root folder of the project.
</p>
<p class="MsoNormal">Step2. Add a .rc file (VBActiveX.rc) to the project with the content:
</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>101 BITMAP VBActiveX.bmp </p>
<p class="MsoNormal">101 is the resource ID, BITMAP is the resource type, and VBActiveX.bmp is theresource name.
</p>
<p class="MsoNormal">Step3. Open Project Properties, turn to the Compile page and click the Build Events button. In Pre-build event command line, enter this command:
</p>
<p class="MsoNormal"><span style=""><span style="">&nbsp;&nbsp;&nbsp; </span></span>@echo.
</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp; </span>IF EXIST &quot;$(DevEnvDir)..\..\..\Microsoft SDKs\Windows\v6.0A\bin\rc.exe&quot; (&quot;$(DevEnvDir)..\..\..\Microsoft SDKs\Windows\v6.0A\bin\rc.exe&quot; /r &quot;$(ProjectDir)VBActiveX.rc&quot;)
 ELSE (IF EXIST &quot;$(DevEnvDir)..\..\SDK\v2.0\Bin\rc.exe&quot; (&quot;$(DevEnvDir)..\..\SDK\v2.0\Bin\rc.exe&quot; /r &quot;$(ProjectDir)VBActiveX.rc&quot;) ELSE (IF EXIST &quot;$(DevEnvDir)..\Tools\Bin\rc.exe&quot; (&quot;$(DevEnvDir)..\Tools\Bin\rc.exe&quot;
 /r &quot;$(ProjectDir)VBActiveX.rc&quot;) ELSE (IF EXIST &quot;$(DevEnvDir)..\..\VC\Bin\rc.exe&quot; (&quot;$(DevEnvDir)..\..\VC\Bin\rc.exe&quot; /r &quot;$(ProjectDir)VBActiveX.rc&quot;) ELSE (IF EXIST &quot;C:\Program Files (x86)\microsoft sdks\windows\v6.0A\bin\rc.exe&quot;
 (&quot;c:\Program Files (x86)\microsoft sdks\windows\v6.0A\bin\rc.exe&quot; /r &quot;$(ProjectDir)VBActiveX.rc&quot;) ELSE (IF EXIST &quot;C:\Program Files\microsoft sdks\windows\v6.0A\bin\rc.exe&quot; (&quot;c:\Program Files\microsoft sdks\windows\v6.0A\bin\rc.exe&quot;
 /r &quot;$(ProjectDir)VBActiveX.rc&quot;) ELSE (@Echo Unable to find rc.exe, using default manifest instead))))))
</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp; </span>@echo. </p>
<p class="MsoNormal">The command searches for the Resource Compiler (rc.exe), and use the tool to compile the resource definition file and the resource files (binary files such as icon, bitmap, and cursor files) into a binary resource (.RES) file: VBActiveX.RES.
</p>
<p class="MsoNormal">Step4. Open the project file (VBActiveX.vbproj) in Notepad, and add the below XML element under &lt;PropertyGroup&gt;.
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
Dim cancel As Boolean = False
RaiseEvent FloatPropertyChanging(value, cancel)

</pre>
<pre id="codePreview" class="xml">
Dim cancel As Boolean = False
RaiseEvent FloatPropertyChanging(value, cancel)

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">This specifies the VBActiveX.res file generated in step 3 to be the win32 resource of the assembly.
</p>
<h2>More Information </h2>
<p class="MsoListParagraph" style=""><span style="font-family:Symbol"><span style="">��<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><a href="http://msdn.microsoft.com/en-us/vbasic/bb419144.aspx"><span class="SpellE">Interop</span> Forms Toolkit 2.0</a>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>