# Configure SSL for specific pages in Windows Azure (CSAzureSSLForPage)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Microsoft Azure
## Topics
* Security
* ssl
## IsPublished
* True
## ModifiedDate
* 2013-04-16 10:52:47
## Description

<p style="font-family:Courier New">&nbsp;<a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420" target="_blank"><img id="79969" src="http://i1.code.msdn.s-msft.com/csazurebingmaps-bab92df1/image/file/79969/1/120x90_azure_web_en_us.jpg" alt="" width="360" height="90"></a></p>
<h1>Configure SSL for specific page(s) while hosting the application in Azure (CSAzureSSLForPage)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">While hosting the applications in Azure, developers are required to modify IIS settings to suit their application requirements. Many of these IIS settings can be modified only programmatically and developers are required to write code,
 startup tasks to achieve what they are looking for. One common thing customer does while hosting the applications on-premise is to mix the SSL content with non-SSL content. In Azure, by default you can enable SSL for entire site. There is no provision to enable
 SSL only for few pages. Hence, i have written sample that customers can use it without investing more time to achieve the task.<span>
</span></p>
<p class="MsoNormal" style="text-align:right"><a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420"><span style="color:windowtext; text-decoration:none"><span><img src="/site/view/file/67645/1/image.png" alt="" width="120" height="90" align="middle">
</span></span></a><br>
<a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420">Try Windows Azure for free for 90 Days!</a></p>
<h2>Building the Sample</h2>
<p class="MsoNormal">This sample needs to be configured with sitename before running it.</p>
<p class="MsoNormal">1. Under OnStart() Method, Locate following line, read and make changes to this line of code as per comments below.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">// Since we are looking to enable SSL for only specific page, get the section 
// of configuration which needs to be changed for specific location
// Website name can be obtained using  RoleEnvironment.CurrentRoleInstance.Id 
// and then append &quot;_&quot; along with actual site name specified in ServiceDefinition.csdef
// Default name of the website is Web. If you have specified different sitename, 
// please replace &quot;Web&quot; with the specified name in below line of code.
ConfigurationSection section = config.GetSection(&quot;system.webServer/security/access&quot;,
    RoleEnvironment.CurrentRoleInstance.Id &#43; &quot;_Web&quot; &#43; &quot;/sslpage.aspx&quot;);

</pre>
<pre id="codePreview" class="csharp">// Since we are looking to enable SSL for only specific page, get the section 
// of configuration which needs to be changed for specific location
// Website name can be obtained using  RoleEnvironment.CurrentRoleInstance.Id 
// and then append &quot;_&quot; along with actual site name specified in ServiceDefinition.csdef
// Default name of the website is Web. If you have specified different sitename, 
// please replace &quot;Web&quot; with the specified name in below line of code.
ConfigurationSection section = config.GetSection(&quot;system.webServer/security/access&quot;,
    RoleEnvironment.CurrentRoleInstance.Id &#43; &quot;_Web&quot; &#43; &quot;/sslpage.aspx&quot;);

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoNormal">2. If you need to enable SSL for multiple pages, below lines should be repeated in the code. Highlighted portion is where you need to replace with page name you are trying to configure SSL for.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">ConfigurationSection section = config.GetSection(&quot;system.webServer/security/access&quot;,
    RoleEnvironment.CurrentRoleInstance.Id &#43; &quot;_Web&quot; &#43; &quot;/sslpage.aspx&quot;);


// Get the sslFlags attribute which is used for configuring SSL settings
ConfigurationAttribute enabled = section.GetAttribute(&quot;sslFlags&quot;);


// Configure sslFlags value as &quot;ssl&quot;. This will enable &quot;Require SSL&quot; flag
enabled.Value = &quot;Ssl&quot;;

</pre>
<pre id="codePreview" class="csharp">ConfigurationSection section = config.GetSection(&quot;system.webServer/security/access&quot;,
    RoleEnvironment.CurrentRoleInstance.Id &#43; &quot;_Web&quot; &#43; &quot;/sslpage.aspx&quot;);


// Get the sslFlags attribute which is used for configuring SSL settings
ConfigurationAttribute enabled = section.GetAttribute(&quot;sslFlags&quot;);


// Configure sslFlags value as &quot;ssl&quot;. This will enable &quot;Require SSL&quot; flag
enabled.Value = &quot;Ssl&quot;;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoNormal">3. In the sample, I have configured https endpoint, RDP access using the certificates I have on my machine. You would need to re-configure certificates using the ones you have on your machine or create new certificates for these purposes.
 To change the certificates, Open the project, go to the properties of the sslRole as shown below and modify the highlighted certificates.</p>
<p class="MsoNormal"><span><img src="/site/view/file/67646/1/image.png" alt="" width="915" height="225" align="middle">
</span></p>
<h2>Running the Sample</h2>
<p class="MsoNormal">Configure the variables as mentioned in the &quot;Building the sample&quot; section and then run the sample by clicking F5 in VS or build the sample and run the exe. Once you confirm that the sample is working, take the code from OnStart() method
 and incorporate with actual application.</p>
<h2>Using the Code</h2>
<p class="MsoNormal">Add references to Microsoft.Web.Administration (location: &lt;systemdrive&gt;\system32\inetsrv) assembly and add below using statement to your project</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">using Microsoft.Web.Administration;

</pre>
<pre id="codePreview" class="csharp">using Microsoft.Web.Administration;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoNormal">Code to configure SSL is below:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">// Create new ServerManager object to modify IIS7 configuration
ServerManager serverManager = new ServerManager();


// Retrieve Current Application Host Configuration of IIS
Configuration config = serverManager.GetApplicationHostConfiguration();


// Since we are looking to enable SSL for only specific page, get the section 
// of configuration which needs to be changed for specific location
// Website name can be obtained using  RoleEnvironment.CurrentRoleInstance.Id 
// and then append &quot;_&quot; along with actual site name specified in ServiceDefinition.csdef
// Default name of the website is Web. If you have specified different sitename, 
// please replace &quot;Web&quot; with the specified name in below line of code.
ConfigurationSection section = config.GetSection(&quot;system.webServer/security/access&quot;,
    RoleEnvironment.CurrentRoleInstance.Id &#43; &quot;_Web&quot; &#43; &quot;/sslpage.aspx&quot;);


// Get the sslFlags attribute which is used for configuring SSL settings
ConfigurationAttribute enabled = section.GetAttribute(&quot;sslFlags&quot;);


// Configure sslFlags value as &quot;ssl&quot;. This will enable &quot;Require SSL&quot; flag
enabled.Value = &quot;Ssl&quot;;


// Save the changes. If role is not running under elevated executionContext, 
// this line will result in exception.
serverManager.CommitChanges();

</pre>
<pre id="codePreview" class="csharp">// Create new ServerManager object to modify IIS7 configuration
ServerManager serverManager = new ServerManager();


// Retrieve Current Application Host Configuration of IIS
Configuration config = serverManager.GetApplicationHostConfiguration();


// Since we are looking to enable SSL for only specific page, get the section 
// of configuration which needs to be changed for specific location
// Website name can be obtained using  RoleEnvironment.CurrentRoleInstance.Id 
// and then append &quot;_&quot; along with actual site name specified in ServiceDefinition.csdef
// Default name of the website is Web. If you have specified different sitename, 
// please replace &quot;Web&quot; with the specified name in below line of code.
ConfigurationSection section = config.GetSection(&quot;system.webServer/security/access&quot;,
    RoleEnvironment.CurrentRoleInstance.Id &#43; &quot;_Web&quot; &#43; &quot;/sslpage.aspx&quot;);


// Get the sslFlags attribute which is used for configuring SSL settings
ConfigurationAttribute enabled = section.GetAttribute(&quot;sslFlags&quot;);


// Configure sslFlags value as &quot;ssl&quot;. This will enable &quot;Require SSL&quot; flag
enabled.Value = &quot;Ssl&quot;;


// Save the changes. If role is not running under elevated executionContext, 
// this line will result in exception.
serverManager.CommitChanges();

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<h2>More Information</h2>
<p class="MsoNormal">Exercise 4: Securing Windows Azure with SSL<br>
<a href="http://msdn.microsoft.com/en-us/gg271302">http://msdn.microsoft.com/en-us/gg271302</a></p>
<p class="MsoNormal">&nbsp;</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt="">
</a></div>