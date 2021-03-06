# Add button to  IE toolbar (CSIEToolbarButton)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Internet Explorer
## Topics
* Command Bar
## IsPublished
* True
## ModifiedDate
* 2012-06-05 01:45:32
## Description
================================================================================<br>
&nbsp; &nbsp; &nbsp; Windows APPLICATION: CSIEToolbarButton Overview &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br>
===============================================================================<br>
/////////////////////////////////////////////////////////////////////////////<br>
Summary:<br>
The sample demonstrates how to create and deploy an IE Toolbar button and menu item.<br>
<br>
When you click an IE Toolbar button or menu item, IE can<br>
1. Implement the Exec method of the COM object.<br>
2. Run a script.<br>
3. Run an executable file.<br>
<br>
<br>
/////////////////////////////////////////////////////////////////////////////<br>
Setup and Removal:<br>
<br>
--------------------------------------<br>
In the Development Environment<br>
<br>
A. Setup<br>
<br>
For 32bit IE on x86 or x64 OS, run 'Visual Studio Command Prompt (2010)' in the <br>
Microsoft Visual Studio 2010 \ Visual Studio Tools menu as administrator. For 64bit<br>
IE on x64 OS, run Visual Studio x64 Win64 Command Prompt (2010).<br>
<br>
Navigate to the folder that contains the build result CSIEToolbarButton.dll and <br>
enter the command:<br>
<br>
&nbsp; &nbsp;Regasm.exe CSIEToolbarButton.dll /codebase<br>
<br>
The Toolbar button is registered successfully if the command prints:<br>
&nbsp; &nbsp;&quot;Types registered successfully&quot;<br>
<br>
B. Removal<br>
<br>
For 32bit IE on x86 or x64 OS, run 'Visual Studio Command Prompt (2010)' in the <br>
Microsoft Visual Studio 2010 \ Visual Studio Tools menu as administrator. For 64bit<br>
IE on x64 OS, run Visual Studio x64 Win64 Command Prompt (2010).<br>
<br>
Navigate to the folder that contains the build result CSIEToolbarButton.dll and <br>
enter the command:<br>
<br>
&nbsp; &nbsp;Regasm.exe CSIEToolbarButton.dll /unregister<br>
<br>
The Toolbar button is unregistered successfully if the command prints:<br>
<br>
&nbsp; &nbsp;&quot;Types un-registered successfully&quot;<br>
<br>
--------------------------------------<br>
In the Deployment Environment<br>
<br>
A. Setup<br>
<br>
For 32bit IE on x86 or x64 OS, install CSIEToolbarButtonSetup(x86).msi, the output<br>
of the CSIEToolbarButtonSetup(x86) setup project.<br>
<br>
For 64bit IE on x64 OS, install CSIEToolbarButtonSetup(x64).msi outputted by the <br>
CSIEToolbarButtonSetup(x64) setup project.<br>
<br>
B. Removal<br>
<br>
For 32bit IE on x86 or x64 OS, uninstall CSIEToolbarButtonSetup(x86).msi, the <br>
output of the CSIEToolbarButtonSetup(x86) setup project. <br>
<br>
For 64bit IE on x64 OS, uninstall CSIEToolbarButtonSetup(x64).msi, the output of<br>
the CSIEToolbarButtonSetup(x64) setup project.<br>
<br>
<br>
<br>
////////////////////////////////////////////////////////////////////////////////<br>
Demo:<br>
<br>
Step1. Open this project in VS2010 and set the platform of the solution to x86. Make<br>
&nbsp; &nbsp; &nbsp; sure that the projects CSIEToolbarButton and CSIEToolbarButtonSetup(x86)<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; are selected to build in Configuration Manager.<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; NOTE: If you want to use this Toolbar button in 64bit IE, set the platform to x64 and
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; select CSIEToolbarButton and CSIEToolbarButtonSetup(x64) to build.<br>
&nbsp; &nbsp; &nbsp; &nbsp;<br>
Step2. Build the solution.<br>
<br>
Step3. Right click the project CSIEToolbarButtonSetup(x86) in Solution Explorer, <br>
&nbsp; &nbsp; &nbsp; and choose &quot;Install&quot;.<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; After the installation, open 32bit IE and click Tools=&gt;Manage Add-ons, in the
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; Manage Add-ons dialog, you can find <br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 1. The item &quot;Note Pad&quot; in Browser Extension group.<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 2. A new button &quot;Note Pad&quot; on the IE toolbar (command bar).<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 3. A menu item &quot;Note Pad&quot; in IE Tools menu.<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; You may have to restart IE to make it take effect.
<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; NOTE: You can also use the Regasm command in the &quot;Setup and Removal&quot; section.<br>
<br>
Step4. Open IE and visit http://www.microsoft.com/. After the page was loaded <br>
&nbsp; &nbsp; &nbsp; completely, then click button &quot;Note Pad&quot; on the IE toolbar (command bar) or
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; the menu item &quot;Note Pad&quot; in IE Tools menu, you will see:<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 1. IE shows a dialog &quot;Images in the page &quot; which list all the image links in
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;this page. Click OK.<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 2. IE shows a &quot;Message from webpage&quot; dialog which asks you whether &quot;Copy image<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;links on this page to clipboard&quot;. Click OK.<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 3. IE shows a Message from webpage&quot; dialog which tells you that &quot;Use Crtl&#43;V to
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;paste the links to the NotePad.&quot;. Click OK.<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 4. NotePad.exe is launched, press &quot;Ctrl&#43;V&quot;, all the &nbsp;&nbsp;&nbsp;&nbsp;image links in this page
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;will be pasted to it.&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br>
<br>
/////////////////////////////////////////////////////////////////////////////<br>
Implementation:<br>
<br>
A. Create the project and add references<br>
<br>
In Visual Studio 2010, create a Visual C# / Windows / Class Library project <br>
named &quot;CSIEToolbarButton&quot;. <br>
<br>
Right click the project in Solution Explorer and choose &quot;Add Reference&quot;. Add<br>
&quot;Microsoft HTML Object Library&quot; and &quot;Microsoft Internet Controls&quot; in COM tab.<br>
-----------------------------------------------------------------------------<br>
<br>
B. Implement a basic Component Object Model (COM) DLL<br>
<br>
A Toolbar button is a COM object implemented as a DLL. Making a basic <br>
.NET COM component is very straightforward. You just need to define a <br>
'public' class with ComVisible(true), use the Guid attribute to specify its <br>
CLSID, and explicitly implements certain COM interfaces. For example, <br>
<br>
&nbsp; &nbsp;[ClassInterface(ClassInterfaceType.None)]<br>
&nbsp; &nbsp;[Guid(&quot;69FA02A4-19BE-4C49-8D8F-E284E6B01363&quot;), ComVisible(true)]<br>
&nbsp; &nbsp;public class SimpleObject : ISimpleObject<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp;... // Implements the interface<br>
&nbsp; &nbsp;}<br>
<br>
You even do not need to implement IUnknown and class factory by yourself <br>
because .NET Framework handles them for you.<br>
<br>
-----------------------------------------------------------------------------<br>
<br>
C. Implement the Toolbar button and registering it for a certain file class<br>
<br>
-----------<br>
Implement the preview handler:<br>
<br>
The NotePadToolbarButton.cs file defines the Toolbar button. <br>
<br>
The GuidAttribute is attached to the NotePadToolbarButton class to specify <br>
its CLSID. When you write your own handler, you must create a new CLSID by <br>
using the &quot;Create GUID&quot; tool in the Tools menu for ToolbarButton class, <br>
and specify the value in the Guid attribute. <br>
<br>
&nbsp; &nbsp;...<br>
&nbsp; &nbsp;[ComVisible(true)]<br>
&nbsp; &nbsp;[Guid(&quot;c0e8ae32-0758-4c8d-ab71-23b361fe8964&quot;)]<br>
&nbsp; &nbsp;public class NotePadToolbarButton : ...<br>
<br>
The class also implements the interface IObjectWithSite. In the SetSite method, you
<br>
can get an instance implemented the interface InternetExplorer. n order to invoke
<br>
a Component Object Model (COM) object from Internet Explorer, it must implement <br>
IOleCommandTarget. <br>
<br>
&nbsp; &nbsp;<br>
<br>
-----------<br>
Register the Toolbar Button:<br>
<br>
The registration and unregistration logic of the &nbsp;Toolbar Button are also implemented in
<br>
this class. To register it, <br>
1. Create a new key (using the GUID as the name) in the registry under: <br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}<br>
&nbsp;{GUID} is the valid GUID that you created in step 1.<br>
<br>
2. Create the following string values in the registry under the new key:<br>
<br>
&nbsp;ButtonText - Set the value to the label you want for the toolbar button.<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\ButtonText<br>
&nbsp;<br>
&nbsp;HotIcon - Set the full path of the .ico file that contains the three color icons.<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\HotIcon<br>
&nbsp;<br>
&nbsp;Icon - Set the full path of the .ico file that contains the three grayscale icons.<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\Icon<br>
<br>
&nbsp;Default Visible - To make the toolbar button to appear on the Internet Explorer toolbar
<br>
&nbsp;by default, set Default Visible to &quot;Yes&quot;, otherwise set Default Visible to &quot;No&quot;.
<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\Default Visible<br>
<br>
&nbsp;MenuText - This is the text you want to be displayed in the menu. This text does not support
<br>
&nbsp;any underlining of characters for shortcut keys, because there is no way to prevent conflicts.
<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\MenuText<br>
<br>
&nbsp;MenuCustomize - Set the value to &quot;help&quot; to have the menu item appear in the Help menu. If<br>
&nbsp;this string value doesn't exist or is set to something other than &quot;help&quot;, the menu item will
<br>
&nbsp;appear in the Tools menu. <br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\MenuCustomize<br>
<br>
&nbsp;MenuStatusBar - This is the text you want displayed in the status bar when the menu item
<br>
&nbsp;is highlighted. This text should describe what the script associated with this menu item will do.
<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\MenuStatusBar<br>
<br>
3. The following register key values are required to complete the creation of a toolbar button<br>
&nbsp;that implements a COM object.<br>
&nbsp;<br>
&nbsp;CLSID - set the value equal to {1FBA04EE-3024-11d2-8F1F-0000F87ABD16}. This value indicates
<br>
&nbsp;that the extension is of the CLSID_Shell_ToolbarExtExec class. <br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\CLSID<br>
<br>
&nbsp;ClsidExtension - Set the value of ClsidExtension equal to the GUID of the COM object.<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\ClsidExtension &nbsp;
<br>
<br>
4. The following register key values are required to complete the creation of a toolbar button that
<br>
&nbsp;runs a script.<br>
&nbsp;<br>
&nbsp;CLSID - set the value equal to {1FBA04EE-3024-11d2-8F1F-0000F87ABD16}. This value indicates
<br>
&nbsp;that the extension is of the CLSID_Shell_ToolbarExtExec class. <br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\CLSID<br>
&nbsp;<br>
&nbsp;Script - Set the value of Script to the full path of the script to run.<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\Script<br>
<br>
5. The following register key values are required to complete the creation of a toolbar button that
<br>
&nbsp;runs an executable file.<br>
&nbsp;<br>
&nbsp;CLSID - set the value equal to {1FBA04EE-3024-11d2-8F1F-0000F87ABD16}. This value indicates
<br>
&nbsp;that the extension is of the CLSID_Shell_ToolbarExtExec class. <br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\CLSID<br>
&nbsp;<br>
&nbsp;Exec - Set the value of Exec to the full path of the .exe file to run.<br>
&nbsp;HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Extensions\{GUID}\Exec<br>
<br>
<br>
-----------------------------------------------------------------------------<br>
<br>
D. Deploying the Toolbar Button with a setup project.<br>
<br>
&nbsp;(1) In IEToolbarButton, add an Installer class (named IEToolbarButtonInstaller in this
<br>
&nbsp; code sample) to define the custom actions in the setup. The class derives from<br>
&nbsp; System.Configuration.Install.Installer. We use the custom actions to <br>
&nbsp; register/unregister the COM-visible classes in the current managed assembly<br>
&nbsp; when user installs/uninstalls the component. <br>
<br>
&nbsp; &nbsp;[RunInstaller(true), ComVisible(false)]<br>
&nbsp; &nbsp;public partial class IEToolbarButtonInstaller : Installer<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp;public IEToolbarButtonInstaller()<br>
&nbsp; &nbsp; &nbsp; &nbsp;{ &nbsp; &nbsp; &nbsp; &nbsp; <br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;InitializeComponent(); &nbsp; &nbsp; &nbsp; &nbsp;
<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;<br>
&nbsp; &nbsp; &nbsp; &nbsp;public override void Install(System.Collections.IDictionary stateSaver)<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;base.Install(stateSaver);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;RegistrationServices regsrv = new RegistrationServices();<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;if (!regsrv.RegisterAssembly(this.GetType().Assembly,<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;AssemblyRegistrationFlags.SetCodeBase))<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;throw new InstallException(&quot;Failed To Register for COM&quot;);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp; <br>
&nbsp; &nbsp; &nbsp; &nbsp;public override void Uninstall(System.Collections.IDictionary savedState)<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;base.Uninstall(savedState);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;RegistrationServices regsrv = new RegistrationServices();<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;if (!regsrv.UnregisterAssembly(this.GetType().Assembly))<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;throw new InstallException(&quot;Failed To Unregister for COM&quot;);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;} &nbsp; <br>
&nbsp; &nbsp;}<br>
<br>
&nbsp;In the overriden Install method, we use RegistrationServices.RegisterAssembly
<br>
&nbsp;to register the classes in the current managed assembly to enable creation <br>
&nbsp;from COM. The method also invokes the static method marked with <br>
&nbsp;ComRegisterFunctionAttribute to perform the custom COM registration steps. <br>
&nbsp;The call is equivalent to running the command: <br>
&nbsp;<br>
&nbsp; &nbsp;&quot;Regasm.exe CSIEToolbarButton.dll /codebase&quot;<br>
<br>
&nbsp;in the development environment. <br>
<br>
&nbsp;(2) To add a deployment project, on the File menu, point to Add, and then <br>
&nbsp;click New Project. In the Add New Project dialog box, expand the Other <br>
&nbsp;Project Types node, expand the Setup and Deployment Projects, click Visual <br>
&nbsp;Studio Installer, and then click Setup Project. In the Name box, type <br>
&nbsp;CSIEToolbarButtonSetup(x86). Click OK to create the project. <br>
&nbsp;In the Properties dialog of the setup project, make sure that the <br>
&nbsp;TargetPlatform property is set to x86. This setup project is to be deployed
<br>
&nbsp;for 32bit IE on x86 or x64 Windows operating systems. <br>
<br>
&nbsp;Right-click the setup project, and choose Add / Project Output ... <br>
&nbsp;In the Add Project Output Group dialog box, CSIEToolbarButton will &nbsp;<br>
&nbsp;be displayed in the Project list. Select Primary Output and click OK. VS<br>
&nbsp;will detect the dependencies of the CSIEToolbarButton, including .NET<br>
&nbsp;Framework 4.0 (Client Profile).<br>
<br>
&nbsp;Right-click the setup project again, and choose View / Custom Actions. <br>
&nbsp;In the Custom Actions Editor, right-click the root Custom Actions node. On <br>
&nbsp;the Action menu, click Add Custom Action. In the Select Item in Project <br>
&nbsp;dialog box, double-click the Application Folder. Select Primary output from
<br>
&nbsp;CSIEToolbarButton. This adds the custom actions that we defined <br>
&nbsp;in BHOInstaller of CSIEToolbarButton. <br>
<br>
&nbsp;Build the setup project. If the build succeeds, you will get a .msi file <br>
&nbsp;and a Setup.exe file. You can distribute them to your users to install or <br>
&nbsp;uninstall this BHO. <br>
<br>
&nbsp;(3) To deploy the Toolbar Button for 64bit IE on a x64 operating system, you
<br>
&nbsp;must create a new setup project (e.g. CSIEToolbarButtonSetup(x64) <br>
&nbsp;in this code sample), and set its TargetPlatform property to x64. <br>
<br>
&nbsp;Although the TargetPlatform property is set to x64, the native shim <br>
&nbsp;packaged with the .msi file is still a 32-bit executable. The Visual Studio
<br>
&nbsp;embeds the 32-bit version of InstallUtilLib.dll into the Binary table as <br>
&nbsp;InstallUtil. So the custom actions will be run in the 32-bit, which is <br>
&nbsp;unexpected in this code sample. To workaround this issue and ensure that <br>
&nbsp;the custom actions run in the 64-bit mode, you either need to import the <br>
&nbsp;appropriate bitness of InstallUtilLib.dll into the Binary table for the <br>
&nbsp;InstallUtil record or - if you do have or will have 32-bit managed custom <br>
&nbsp;actions add it as a new record in the Binary table and adjust the <br>
&nbsp;CustomAction table to use the 64-bit Binary table record for 64-bit managed
<br>
&nbsp;custom actions. This blog article introduces how to do it manually with <br>
&nbsp;Orca http://blogs.msdn.com/b/heaths/archive/2006/02/01/64-bit-managed-custom-actions-with-visual-studio.aspx<br>
<br>
&nbsp;In this code sample, we automate the modification of InstallUtil by using a
<br>
&nbsp;post-build javascript: Fix64bitInstallUtilLib.js. You can find the script <br>
&nbsp;file in the CSIEToolbarButtonSetup(x64) project folder. To <br>
&nbsp;configure the script to run in the post-build event, you select the <br>
&nbsp;CSIEToolbarButtonSetup(x64) project in Solution Explorer, and <br>
&nbsp;find the PostBuildEvent property in the Properties window. Specify its <br>
&nbsp;value to be <br>
&nbsp;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&quot;$(ProjectDir)Fix64bitInstallUtilLib.js&quot; &quot;$(BuiltOuputPath)&quot; &quot;$(ProjectDir)&quot;<br>
<br>
&nbsp;Repeat the rest steps in (2) to add the project output, set the custom <br>
&nbsp;actions, configure the prerequisites, and build the setup project.<br>
<br>
<br>
/////////////////////////////////////////////////////////////////////////////<br>
Diagnostic:<br>
<br>
To debug Toolbar Button, you can attach to iexplorer.exe. <br>
<br>
<br>
<br>
///////////////////////////////////////////////////////////////////////////// <br>
<br>
References:<br>
<br>
Adding Toolbar Buttons<br>
http://msdn.microsoft.com/en-us/library/aa753588(VS.85).aspx<br>
<br>
Creating Add-ons for Internet Explorer: Toolbar Buttons<br>
http://msdn.microsoft.com/en-us/library/bb735854(VS.85).aspx<br>
<br>
IOleCommandTarget Interface<br>
http://msdn.microsoft.com/en-us/library/ms683797(VS.85).aspx<br>
<br>
Mouse event handling problem in BHO<br>
http://social.msdn.microsoft.com/Forums/en/ieextensiondevelopment/thread/1ea154a5-5802-460c-9941-30f14b36d0a4<br>
<br>
/////////////////////////////////////////////////////////////////////////////<br>
<br>
