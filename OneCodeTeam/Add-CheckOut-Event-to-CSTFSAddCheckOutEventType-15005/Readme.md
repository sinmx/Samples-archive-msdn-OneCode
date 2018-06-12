# Add CheckOut Event to TFS (CSTFSAddCheckOutEventType)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* TFS
## Topics
* PendChangesNotification
## IsPublished
* True
## ModifiedDate
* 2012-03-22 03:10:17
## Description

<div class="WordSection1">
<h1>Add CheckOut Event to TFS (CSTFSAddCheckOutEventType)</h1>
<h2>Introduction</h2>
<div class="MsoNormal">The sample demonstrates how to enable checkout notification in TFS2010.<span>&nbsp;
</span></div>
<div class="MsoNormal">In TFS2010, when a user sends a Check out (PendChanges) request to server, the server will send a PendChangesNotification before the items are checked out. If we subscribe this notification, we can do following things:</div>
<div class="MsoListParagraphCxSpFirst" style="text-indent:-.25in"><span><span>1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Deny the request.</div>
<div class="MsoListParagraphCxSpLast" style="text-indent:-.25in"><span><span>2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Fire the custom CheckOut event.<br>
NOTE: As this notification is sent before the items are checked out, we can only know someone is trying to checkout some items.</div>
<h2>Building the Sample</h2>
<div class="MsoNormal">This sample should be complied on the Application Tier of TFS, as it uses TFS Server Object Model.</div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; You also need to install
<a href="http://www.microsoft.com/download/en/details.aspx?id=8279">Windows SDK</a>, because we need xsd.exe to generate&nbsp;the schema.</div>
<h2>Running the Sample</h2>
<div class="MsoNormal">1. Copy <strong>CSCheckOutNotification.dll</strong> to <strong>
X:\Program Files\Microsoft Team Foundation Server 2010\Application Tier\Web Services\bin\Plugins</strong>.<br>
<strong><em>X: </em></strong><em>means the driver in which TFS is installed.</em></div>
<div class="MsoNormal">2. Copy <strong>CheckOutEvent.plaintextXsl</strong> and <strong>
CheckOutEvent.xsl</strong> to <strong>X:\Program Files\Microsoft Team Foundation Server 2010\Application Tier\TFSJobAgent\Transforms</strong>.</div>
<div class="MsoNormal">3. Copy <strong>CSAddEventType.exe</strong> and <strong>
CSAddEventType.exe.config</strong> to <strong>X:\Program Files\Microsoft Team Foundation Server 2010\Tools</strong>.<span>&nbsp;
</span>Open <strong>CSAddEventType.exe.config</strong>, and modify <strong>&lt;server&gt;</strong> and driver label in following keys:</div>
<div class="MsoNormal">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>
<pre class="hidden">&lt;add key=&quot;applicationDatabase&quot; value=&quot;Data Source=&lt;server&gt;;Initial Catalog=Tfs_Configuration;Integrated Security=True;&quot; /&gt;
&lt;add key=&quot;ToolsPath&quot; value=&quot;X:\Program Files\Microsoft Team Foundation Server 2010\Tools\&quot;/&gt;
&lt;add key=&quot;xsdPath&quot; value=&quot;C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\NETFX 4.0 Tools\xsd.exe&quot;/&gt;
</pre>
<div class="preview">
<pre class="xml"><span class="xml__tag_start">&lt;add</span>&nbsp;<span class="xml__attr_name">key</span>=<span class="xml__attr_value">&quot;applicationDatabase&quot;</span>&nbsp;value=&quot;Data&nbsp;Source=&lt;server<span class="xml__tag_start">&gt;;</span>Initial&nbsp;Catalog=Tfs_Configuration;Integrated&nbsp;Security=True;&quot;&nbsp;<span class="xml__tag_end">/&gt;</span>&nbsp;
<span class="xml__tag_start">&lt;add</span>&nbsp;<span class="xml__attr_name">key</span>=<span class="xml__attr_value">&quot;ToolsPath&quot;</span>&nbsp;<span class="xml__attr_name">value</span>=<span class="xml__attr_value">&quot;X:\Program&nbsp;Files\Microsoft&nbsp;Team&nbsp;Foundation&nbsp;Server&nbsp;2010\Tools\&quot;</span><span class="xml__tag_start">/&gt;</span>&nbsp;
<span class="xml__tag_start">&lt;add</span>&nbsp;<span class="xml__attr_name">key</span>=<span class="xml__attr_value">&quot;xsdPath&quot;</span>&nbsp;<span class="xml__attr_name">value</span>=<span class="xml__attr_value">&quot;C:\Program&nbsp;Files&nbsp;(x86)\Microsoft&nbsp;SDKs\Windows\v7.0A\Bin\NETFX&nbsp;4.0&nbsp;Tools\xsd.exe&quot;</span><span class="xml__tag_start">/&gt;</span>&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">4. Launch CSAddEventType.exe and type following command.</div>
<div class="endscriptcode"></div>
</div>
<div class="MsoNormal"><strong>X:\Program Files\Microsoft Team Foundation Server 2010\Application Tier\Web Services\bin\Plugins\CSCheckOutNotification.dll&quot; CSCheckOutNotification.CheckOutEvent TFSLab CheckOutEvent VersionControl</strong></div>
<div class="MsoNormal"><span><img src="/site/view/file/49049/1/image001.png" alt="" width="968" height="199"></span></div>
<div class="MsoNormal">5. Use BisSubscribe.exe to subscribe the CheckOut event.</div>
<div class="MsoNormal">Run following command:</div>
<div class="MsoNormal">X:\Program Files\Microsoft Team Foundation Server 2010\Tools\BisSubscribe.exe /eventType CheckOutEvent /address &lt;your mail address&gt; /collection http://&lt;server&gt;:8080/tfs/&lt;collection&gt; /deliveryType EmailHtml</div>
<div class="MsoNormal"><span><img src="/site/view/file/49050/1/image002.png" alt="" width="964" height="108"></span></div>
<div class="MsoNormal">6. In TFS Admin Console, enable TFS Alert, and make sure that your mail settings are correct.</div>
<div class="MsoNormal">7. Check out items in source control explorer, and then you will get the notification mails.</div>
<div class="MsoNormal"><span><img src="/site/view/file/49051/1/image003.png" alt="" width="697" height="121"></span></div>
<h2>Using the Code</h2>
<div class="MsoNormal">In TFS2010, when a user sends a Check out (PendChanges) request to server, the server will send a
<strong>PendChangesNotification</strong> before the items are checked out.<span>&nbsp;
</span>If there is any subscriber (a class implements the <strong>Microsoft.TeamFoundation.Framework.Server.ISubscriber</strong> interface) subscribes this notification, the
<strong>ProcessEvent</strong> method will be called. In this method, we can fire the custom
<strong>CheckOutEvent</strong>, and then <strong>TFSJobAgent</strong> will send the alert.</div>
<div class="MsoNormal"><strong>1. Create CheckOut Event Type.</strong></div>
<div class="MsoNormal"><strong>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">public class CheckOutEvent
{
    public string OwnerName { get; set; }
    public string UserName { get; set; }
    public string WorkspaceName { get; set; }
    public string[] Items { get; set; }
}</pre>
<div class="preview">
<pre class="csharp"><span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">class</span>&nbsp;CheckOutEvent&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;OwnerName&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;UserName&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;WorkspaceName&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>[]&nbsp;Items&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
}</pre>
</div>
</div>
</div>
</strong></div>
<div class="MsoNormal"><strong>2. Create xslt files for the event.</strong></div>
<div class="MsoNormal">Before the alert the send, TFSJobAgent will serialize the CheckOutEvent to XML, and then use these files are to transform the<span>&nbsp;
</span>XML to Plaintext or HTML.</div>
<div class="MsoNormal">The XML is like&nbsp;</div>
<div class="MsoNormal">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>
<pre class="hidden">&lt;CheckOutEvent xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot;&gt;
    &lt;OwnerName&gt;domain\user&lt;/OwnerName&gt;
    &lt;UserName&gt;domain\user&lt;/UserName&gt;
    &lt;WorkspaceName&gt;workspaename&lt;/WorkspaceName&gt;
    &lt;Items&gt;
        &lt;string&gt;Local Path:*** EditType:Edit&lt;/string&gt;
        &lt;string&gt;Local Path:*** EditType:Add&lt;/string&gt;
    &lt;/Items&gt;
&lt;/CheckOutEvent&gt;
</pre>
<div class="preview">
<pre class="xml"><span class="xml__tag_start">&lt;CheckOutEvent</span>&nbsp;<span class="xml__keyword">xmlns</span>:<span class="xml__attr_name">xsd</span>=<span class="xml__attr_value">&quot;http://www.w3.org/2001/XMLSchema&quot;</span>&nbsp;<span class="xml__keyword">xmlns</span>:<span class="xml__attr_name">xsi</span>=<span class="xml__attr_value">&quot;http://www.w3.org/2001/XMLSchema-instance&quot;</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;OwnerName</span><span class="xml__tag_start">&gt;</span>domain\user<span class="xml__tag_end">&lt;/OwnerName&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;UserName</span><span class="xml__tag_start">&gt;</span>domain\user<span class="xml__tag_end">&lt;/UserName&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;WorkspaceName</span><span class="xml__tag_start">&gt;</span>workspaename<span class="xml__tag_end">&lt;/WorkspaceName&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;Items</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;string</span><span class="xml__tag_start">&gt;</span>Local&nbsp;Path:***&nbsp;EditType:Edit<span class="xml__tag_end">&lt;/string&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;string</span><span class="xml__tag_start">&gt;</span>Local&nbsp;Path:***&nbsp;EditType:Add<span class="xml__tag_end">&lt;/string&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_end">&lt;/Items&gt;</span>&nbsp;
<span class="xml__tag_end">&lt;/CheckOutEvent&gt;</span>&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
</div>
<div class="MsoNormal">The Xslt file for HTML is&nbsp;</div>
<div class="MsoNormal">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>
<pre class="hidden">&lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
&lt;xsl:stylesheet xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; version=&quot;1.0&quot;&gt;
    &lt;xsl:import href=&quot;TeamFoundation.xsl&quot;/&gt;
    &lt;!-- Common TeamSystem elements --&gt;
    &lt;xsl:template match=&quot;CheckOutEvent&quot;&gt;
        &lt;head&gt;
            &lt;!-- Pull in the command style settings --&gt;
            &lt;xsl:call-template name=&quot;style&quot;&gt;
            &lt;/xsl:call-template&gt;
        &lt;/head&gt;
        &lt;body&gt;
            &lt;div class=&quot;Title&quot;&gt;
                CheckOut Event
            &lt;/div&gt;
            &lt;div&gt;
                &lt;xsl:value-of select=&quot;UserName&quot;/&gt;
                &lt;xsl:text&gt; is trying to check out following items:&lt;/xsl:text&gt;
            &lt;/div&gt;
            &lt;div&gt;
                &lt;xsl:apply-templates select=&quot;Items&quot;/&gt;
            &lt;/div&gt;
        &lt;/body&gt;
    &lt;/xsl:template&gt;
    &lt;xsl:template match=&quot;CheckOutEvent/Items&quot;&gt;
        &lt;xsl:apply-templates select=&quot;string&quot;/&gt;
    &lt;/xsl:template&gt;
    &lt;xsl:template match=&quot;CheckOutEvent/Items/string&quot;&gt;
        &lt;xsl:value-of select=&quot;node()&quot; /&gt;
        &lt;br/&gt;
    &lt;/xsl:template&gt;
&lt;/xsl:stylesheet&gt;
</pre>
<div class="preview">
<pre class="js">&lt;?xml&nbsp;version=<span class="js__string">&quot;1.0&quot;</span>&nbsp;encoding=<span class="js__string">&quot;utf-8&quot;</span>?&gt;&nbsp;
&lt;xsl:stylesheet&nbsp;xmlns:xsl=<span class="js__string">&quot;http://www.w3.org/1999/XSL/Transform&quot;</span>&nbsp;version=<span class="js__string">&quot;1.0&quot;</span>&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:import&nbsp;href=<span class="js__string">&quot;TeamFoundation.xsl&quot;</span>/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;!--&nbsp;Common&nbsp;TeamSystem&nbsp;elements&nbsp;--&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:template&nbsp;match=<span class="js__string">&quot;CheckOutEvent&quot;</span>&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;head&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;!--&nbsp;Pull&nbsp;<span class="js__operator">in</span>&nbsp;the&nbsp;command&nbsp;style&nbsp;settings&nbsp;--&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:call-template&nbsp;name=<span class="js__string">&quot;style&quot;</span>&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/xsl:call-template&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/head&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;body&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;div&nbsp;class=<span class="js__string">&quot;Title&quot;</span>&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;CheckOut&nbsp;Event&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:value-of&nbsp;select=<span class="js__string">&quot;UserName&quot;</span>/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:text&gt;&nbsp;is&nbsp;trying&nbsp;to&nbsp;check&nbsp;out&nbsp;following&nbsp;items:&lt;/xsl:text&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:apply-templates&nbsp;select=<span class="js__string">&quot;Items&quot;</span>/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/body&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;/xsl:template&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:template&nbsp;match=<span class="js__string">&quot;CheckOutEvent/Items&quot;</span>&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:apply-templates&nbsp;select=<span class="js__string">&quot;string&quot;</span>/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;/xsl:template&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:template&nbsp;match=<span class="js__string">&quot;CheckOutEvent/Items/string&quot;</span>&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;xsl:value-of&nbsp;select=<span class="js__string">&quot;node()&quot;</span>&nbsp;/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;br/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;/xsl:template&gt;&nbsp;
&lt;/xsl:stylesheet&gt;&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">And the output is</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>
<pre class="hidden">&lt;head&gt;
&lt;/head&gt;
&lt;body&gt;
    &lt;div class=&quot;Title&quot;&gt;
        CheckOut Event
    &lt;/div&gt;
    &lt;div&gt;domain\user is trying to check out following items:&lt;/div&gt;
    &lt;div&gt;
        Local Path:***  EditType:Edit&lt;br/&gt;
        Local Path:***  EditType:Add&lt;br/&gt;
    &lt;/div&gt;
&lt;/body&gt;
</pre>
<div class="preview">
<pre class="js">&lt;head&gt;&nbsp;
&lt;/head&gt;&nbsp;
&lt;body&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;div&nbsp;class=<span class="js__string">&quot;Title&quot;</span>&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;CheckOut&nbsp;Event&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;/div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;div&gt;domain\user&nbsp;is&nbsp;trying&nbsp;to&nbsp;check&nbsp;out&nbsp;following&nbsp;items:&lt;/div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;div&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Local&nbsp;Path:***&nbsp;&nbsp;EditType:Edit&lt;br/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Local&nbsp;Path:***&nbsp;&nbsp;EditType:Add&lt;br/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;/div&gt;&nbsp;
&lt;/body&gt;&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode"><strong>3. Subscribe PendChangesNotification and fire CheckOut Event.</strong></div>
</div>
</div>
<div class="MsoNormal"><strong>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">public class CheckOutNotificationSubscriber : ISubscriber
{
 
    public string Name
    {
        get
        {
            return &quot;Team Foundation Source Control: CheckOut Alert Provider&quot;;
        }
    }
 
    public SubscriberPriority Priority
    {
        get
        {
            return SubscriberPriority.Normal;
        }
    }
 
    /// &lt;summary&gt;
    /// Return the types that it subscribes.
    /// &lt;/summary&gt;
    /// &lt;returns&gt;&lt;/returns&gt;
    public Type[] SubscribedTypes()
    {
        return new Type[] { typeof(PendChangesNotification) };
    }
 
    /// &lt;summary&gt;
    /// The ProcessEvent method will be called when the server receives the pend
    /// change request, and in this method, we can fire the custom CheckOutEvent,
    /// then TFSJobAgent will send out the alert.
    /// &lt;/summary&gt;
    /// &lt;param name=&quot;requestContext&quot;&gt;
    /// From the request, we can get the parameters that contains the detailed 
    /// information.
    /// &lt;/param&gt;
    /// &lt;param name=&quot;notificationType&quot;&gt;
    /// DecisionPoint: before the request is processed.
    /// Notification: after the request is processed.
    /// 
    /// In this sample, this parameter is DecisionPoint.
    /// &lt;/param&gt;
    /// &lt;param name=&quot;notificationEventArgs&quot;&gt;
    /// An instance of PendChangesNotification.
    /// &lt;/param&gt;
    /// &lt;param name=&quot;statusCode&quot;&gt;&lt;/param&gt;
    /// &lt;param name=&quot;statusMessage&quot;&gt;&lt;/param&gt;
    /// &lt;param name=&quot;properties&quot;&gt;&lt;/param&gt;
    /// &lt;returns&gt;
    /// Return EventNotificationStatus.ActionPermitted.
    /// &lt;/returns&gt;
    public EventNotificationStatus ProcessEvent(
        TeamFoundationRequestContext requestContext,
        NotificationType notificationType,
        object notificationEventArgs,
        out int statusCode,
        out string statusMessage,
        out ExceptionPropertyCollection properties)
    {
        statusCode = 0;
        properties = null;
        statusMessage = string.Empty;
 
        try
        {
            if (notificationEventArgs is PendChangesNotification)
            {
 
                // Initialize a CheckOutEvent instance.
                PendChangesNotification notification =
                    notificationEventArgs as PendChangesNotification;
                CheckOutEvent checkoutEvent = new CheckOutEvent();
                checkoutEvent.WorkspaceName = notification.WorkspaceName;
                checkoutEvent.UserName = notification.UserName;
                checkoutEvent.OwnerName = notification.OwnerName;
 
                // Get the detailed information from the request context.
 
                // Get the count of pend changes.
                string changes = requestContext.Method.Parameters[&quot;changes&quot;];
                int count = 0;
                if (int.TryParse(changes.Replace(&quot;Count = &quot;, string.Empty), out count))
                {
                    if (count &gt; 0)
                    {
                        checkoutEvent.Items = new string[count];
 
                        for (int i = 0; i &lt; count; i&#43;&#43;)
                        {
                            checkoutEvent.Items[i] = string.Format(&quot;Path:{0} EditType:{1}&quot;,
                                requestContext.Method.Parameters[string.Format(&quot;changes[{0}].ItemSpec&quot;, i)],
                                requestContext.Method.Parameters[string.Format(&quot;changes[{0}].RequestType&quot;, i)]);
                        }
                    }
                }
 
                // Fire the CheckOutEvent.
                this.FireSystemEvent(requestContext, checkoutEvent);
            }
        }
        catch (Exception exception)
        {
            TeamFoundationApplication.LogException(&quot;Sending Event Failed&quot;, exception);
        }
        return EventNotificationStatus.ActionPermitted;
    }
 
    /// &lt;summary&gt;
    ///  Fire the CheckOutEvent.
    /// &lt;/summary&gt;
    private void FireSystemEvent(TeamFoundationRequestContext requestContext, object eventObject)
    {
        try
        {
            requestContext.GetService&lt;TeamFoundationNotificationService&gt;().FireSystemEvent(requestContext, eventObject);
        }
        catch (Exception exception)
        {
            TeamFoundationApplication.LogException(&quot;Sending Event Failed&quot;, exception);
        }
    }
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">class</span>&nbsp;CheckOutNotificationSubscriber&nbsp;:&nbsp;ISubscriber&nbsp;
{&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;Name&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">get</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;<span class="cs__string">&quot;Team&nbsp;Foundation&nbsp;Source&nbsp;Control:&nbsp;CheckOut&nbsp;Alert&nbsp;Provider&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;SubscriberPriority&nbsp;Priority&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">get</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;SubscriberPriority.Normal;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;summary&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;Return&nbsp;the&nbsp;types&nbsp;that&nbsp;it&nbsp;subscribes.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;/summary&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;returns&gt;&lt;/returns&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;Type[]&nbsp;SubscribedTypes()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;<span class="cs__keyword">new</span>&nbsp;Type[]&nbsp;{&nbsp;<span class="cs__keyword">typeof</span>(PendChangesNotification)&nbsp;};&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;summary&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;The&nbsp;ProcessEvent&nbsp;method&nbsp;will&nbsp;be&nbsp;called&nbsp;when&nbsp;the&nbsp;server&nbsp;receives&nbsp;the&nbsp;pend</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;change&nbsp;request,&nbsp;and&nbsp;in&nbsp;this&nbsp;method,&nbsp;we&nbsp;can&nbsp;fire&nbsp;the&nbsp;custom&nbsp;CheckOutEvent,</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;then&nbsp;TFSJobAgent&nbsp;will&nbsp;send&nbsp;out&nbsp;the&nbsp;alert.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;/summary&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;param&nbsp;name=&quot;requestContext&quot;&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;From&nbsp;the&nbsp;request,&nbsp;we&nbsp;can&nbsp;get&nbsp;the&nbsp;parameters&nbsp;that&nbsp;contains&nbsp;the&nbsp;detailed&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;information.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;/param&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;param&nbsp;name=&quot;notificationType&quot;&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;DecisionPoint:&nbsp;before&nbsp;the&nbsp;request&nbsp;is&nbsp;processed.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;Notification:&nbsp;after&nbsp;the&nbsp;request&nbsp;is&nbsp;processed.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;In&nbsp;this&nbsp;sample,&nbsp;this&nbsp;parameter&nbsp;is&nbsp;DecisionPoint.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;/param&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;param&nbsp;name=&quot;notificationEventArgs&quot;&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;An&nbsp;instance&nbsp;of&nbsp;PendChangesNotification.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;/param&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;param&nbsp;name=&quot;statusCode&quot;&gt;&lt;/param&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;param&nbsp;name=&quot;statusMessage&quot;&gt;&lt;/param&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;param&nbsp;name=&quot;properties&quot;&gt;&lt;/param&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;returns&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;Return&nbsp;EventNotificationStatus.ActionPermitted.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;/returns&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;EventNotificationStatus&nbsp;ProcessEvent(&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;TeamFoundationRequestContext&nbsp;requestContext,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NotificationType&nbsp;notificationType,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">object</span>&nbsp;notificationEventArgs,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">out</span>&nbsp;<span class="cs__keyword">int</span>&nbsp;statusCode,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">out</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;statusMessage,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">out</span>&nbsp;ExceptionPropertyCollection&nbsp;properties)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;statusCode&nbsp;=&nbsp;<span class="cs__number">0</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;properties&nbsp;=&nbsp;<span class="cs__keyword">null</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;statusMessage&nbsp;=&nbsp;<span class="cs__keyword">string</span>.Empty;&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(notificationEventArgs&nbsp;<span class="cs__keyword">is</span>&nbsp;PendChangesNotification)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Initialize&nbsp;a&nbsp;CheckOutEvent&nbsp;instance.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PendChangesNotification&nbsp;notification&nbsp;=&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;notificationEventArgs&nbsp;<span class="cs__keyword">as</span>&nbsp;PendChangesNotification;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;CheckOutEvent&nbsp;checkoutEvent&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;CheckOutEvent();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;checkoutEvent.WorkspaceName&nbsp;=&nbsp;notification.WorkspaceName;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;checkoutEvent.UserName&nbsp;=&nbsp;notification.UserName;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;checkoutEvent.OwnerName&nbsp;=&nbsp;notification.OwnerName;&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Get&nbsp;the&nbsp;detailed&nbsp;information&nbsp;from&nbsp;the&nbsp;request&nbsp;context.</span>&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Get&nbsp;the&nbsp;count&nbsp;of&nbsp;pend&nbsp;changes.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">string</span>&nbsp;changes&nbsp;=&nbsp;requestContext.Method.Parameters[<span class="cs__string">&quot;changes&quot;</span>];&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">int</span>&nbsp;count&nbsp;=&nbsp;<span class="cs__number">0</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(<span class="cs__keyword">int</span>.TryParse(changes.Replace(<span class="cs__string">&quot;Count&nbsp;=&nbsp;&quot;</span>,&nbsp;<span class="cs__keyword">string</span>.Empty),&nbsp;<span class="cs__keyword">out</span>&nbsp;count))&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(count&nbsp;&gt;&nbsp;<span class="cs__number">0</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;checkoutEvent.Items&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;<span class="cs__keyword">string</span>[count];&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">for</span>&nbsp;(<span class="cs__keyword">int</span>&nbsp;i&nbsp;=&nbsp;<span class="cs__number">0</span>;&nbsp;i&nbsp;&lt;&nbsp;count;&nbsp;i&#43;&#43;)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;checkoutEvent.Items[i]&nbsp;=&nbsp;<span class="cs__keyword">string</span>.Format(<span class="cs__string">&quot;Path:{0}&nbsp;EditType:{1}&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;requestContext.Method.Parameters[<span class="cs__keyword">string</span>.Format(<span class="cs__string">&quot;changes[{0}].ItemSpec&quot;</span>,&nbsp;i)],&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;requestContext.Method.Parameters[<span class="cs__keyword">string</span>.Format(<span class="cs__string">&quot;changes[{0}].RequestType&quot;</span>,&nbsp;i)]);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Fire&nbsp;the&nbsp;CheckOutEvent.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">this</span>.FireSystemEvent(requestContext,&nbsp;checkoutEvent);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">catch</span>&nbsp;(Exception&nbsp;exception)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;TeamFoundationApplication.LogException(<span class="cs__string">&quot;Sending&nbsp;Event&nbsp;Failed&quot;</span>,&nbsp;exception);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;EventNotificationStatus.ActionPermitted;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;summary&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&nbsp;Fire&nbsp;the&nbsp;CheckOutEvent.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">///&nbsp;&lt;/summary&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;FireSystemEvent(TeamFoundationRequestContext&nbsp;requestContext,&nbsp;<span class="cs__keyword">object</span>&nbsp;eventObject)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;requestContext.GetService&lt;TeamFoundationNotificationService&gt;().FireSystemEvent(requestContext,&nbsp;eventObject);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">catch</span>&nbsp;(Exception&nbsp;exception)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;TeamFoundationApplication.LogException(<span class="cs__string">&quot;Sending&nbsp;Event&nbsp;Failed&quot;</span>,&nbsp;exception);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
</strong></div>
<div class="MsoNormal"><strong>4. Add event type to TFS.</strong></div>
<div class="MsoNormal">We can use TFS Server Object Model to add the event type to TFS.</div>
<div class="MsoNormal">&nbsp;&nbsp; a.<span><span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;</span></span>Initialize the
<strong>ApplicationServiceHost</strong></div>
<div class="MsoListParagraph" style="text-indent:-.25in"><span><span>&nbsp;</span></span>&nbsp;</div>
<div class="MsoListParagraph" style="text-indent:-.25in"><span><span>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">/// &lt;summary&gt;
/// Initialize AppHost using its constructor.
/// &lt;/summary&gt;
private void InitializeAppHost(string applicationDatabaseConnectionString,
    string toolPath)
{
    if (string.IsNullOrEmpty(applicationDatabaseConnectionString)
        || string.IsNullOrEmpty(toolPath))
    {
        throw new ArgumentException(&quot;applicationDatabase or toolPah should not be null.&quot;);
    }
 
    this.applicationHost = new ApplicationServiceHost(
        Guid.Empty,
        applicationDatabaseConnectionString,
        &quot;unused&quot;,
        Path.Combine(toolPath, &quot;Plugins&quot;),
        &quot;/tfs&quot;,
        true);
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__com">///&nbsp;&lt;summary&gt;</span>&nbsp;
<span class="cs__com">///&nbsp;Initialize&nbsp;AppHost&nbsp;using&nbsp;its&nbsp;constructor.</span>&nbsp;
<span class="cs__com">///&nbsp;&lt;/summary&gt;</span>&nbsp;
<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;InitializeAppHost(<span class="cs__keyword">string</span>&nbsp;applicationDatabaseConnectionString,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">string</span>&nbsp;toolPath)&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(<span class="cs__keyword">string</span>.IsNullOrEmpty(applicationDatabaseConnectionString)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||&nbsp;<span class="cs__keyword">string</span>.IsNullOrEmpty(toolPath))&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">throw</span>&nbsp;<span class="cs__keyword">new</span>&nbsp;ArgumentException(<span class="cs__string">&quot;applicationDatabase&nbsp;or&nbsp;toolPah&nbsp;should&nbsp;not&nbsp;be&nbsp;null.&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">this</span>.applicationHost&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;ApplicationServiceHost(&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Guid.Empty,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;applicationDatabaseConnectionString,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__string">&quot;unused&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Path.Combine(toolPath,&nbsp;<span class="cs__string">&quot;Plugins&quot;</span>),&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__string">&quot;/tfs&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">true</span>);&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;&nbsp;</div>
</span></span>b. Initialize the <strong>CollectionServiceHost</strong>
<div class="MsoNormal">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">/// &lt;summary&gt;
/// Get CollectionHost using TeamProjectCollectionService.
/// &lt;/summary&gt;
private void InitializeCollectionHost(string collectionName)
{
    if (this.applicationHost == null)
    {
        throw new ApplicationException(&quot;AppHost is null.&quot;);
    }
 
    // Generate a SystemContext.
    TeamFoundationRequestContext systemRequest = applicationHost.CreateSystemContext();
 
    Guid collectionId = Guid.Empty;
 
    // Get TeamProjectCollectionService using the SystemContext.
    TeamProjectCollectionService tpcService = systemRequest.GetService&lt;TeamProjectCollectionService&gt;();
    
    // Query the properties to find the GUID of the specified collection.
    List&lt;TeamProjectCollectionProperties&gt; collectionProperties =
        tpcService.GetCollectionProperties(systemRequest, ServiceHostFilterFlags.None);
 
    foreach (TeamProjectCollectionProperties properties in collectionProperties)
    {
        if (string.Equals(properties.Name, collectionName, StringComparison.OrdinalIgnoreCase)
            &amp;&amp; properties.State == TeamFoundationServiceHostStatus.Started)
        {
            collectionId = properties.Id;
        }
    }
 
    if (collectionId == Guid.Empty)
    {
        throw new ApplicationException(&quot;Cannot find the collection :&quot; &#43; collectionName);
    }
 
    this.collectionHost = applicationHost.GetServiceHost(collectionId) as CollectionServiceHost;
    
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__com">///&nbsp;&lt;summary&gt;</span>&nbsp;
<span class="cs__com">///&nbsp;Get&nbsp;CollectionHost&nbsp;using&nbsp;TeamProjectCollectionService.</span>&nbsp;
<span class="cs__com">///&nbsp;&lt;/summary&gt;</span>&nbsp;
<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;InitializeCollectionHost(<span class="cs__keyword">string</span>&nbsp;collectionName)&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(<span class="cs__keyword">this</span>.applicationHost&nbsp;==&nbsp;<span class="cs__keyword">null</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">throw</span>&nbsp;<span class="cs__keyword">new</span>&nbsp;ApplicationException(<span class="cs__string">&quot;AppHost&nbsp;is&nbsp;null.&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Generate&nbsp;a&nbsp;SystemContext.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;TeamFoundationRequestContext&nbsp;systemRequest&nbsp;=&nbsp;applicationHost.CreateSystemContext();&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;Guid&nbsp;collectionId&nbsp;=&nbsp;Guid.Empty;&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Get&nbsp;TeamProjectCollectionService&nbsp;using&nbsp;the&nbsp;SystemContext.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;TeamProjectCollectionService&nbsp;tpcService&nbsp;=&nbsp;systemRequest.GetService&lt;TeamProjectCollectionService&gt;();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Query&nbsp;the&nbsp;properties&nbsp;to&nbsp;find&nbsp;the&nbsp;GUID&nbsp;of&nbsp;the&nbsp;specified&nbsp;collection.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;List&lt;TeamProjectCollectionProperties&gt;&nbsp;collectionProperties&nbsp;=&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;tpcService.GetCollectionProperties(systemRequest,&nbsp;ServiceHostFilterFlags.None);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">foreach</span>&nbsp;(TeamProjectCollectionProperties&nbsp;properties&nbsp;<span class="cs__keyword">in</span>&nbsp;collectionProperties)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(<span class="cs__keyword">string</span>.Equals(properties.Name,&nbsp;collectionName,&nbsp;StringComparison.OrdinalIgnoreCase)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&amp;&amp;&nbsp;properties.State&nbsp;==&nbsp;TeamFoundationServiceHostStatus.Started)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;collectionId&nbsp;=&nbsp;properties.Id;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(collectionId&nbsp;==&nbsp;Guid.Empty)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">throw</span>&nbsp;<span class="cs__keyword">new</span>&nbsp;ApplicationException(<span class="cs__string">&quot;Cannot&nbsp;find&nbsp;the&nbsp;collection&nbsp;:&quot;</span>&nbsp;&#43;&nbsp;collectionName);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">this</span>.collectionHost&nbsp;=&nbsp;applicationHost.GetServiceHost(collectionId)&nbsp;<span class="cs__keyword">as</span>&nbsp;CollectionServiceHost;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode"><span><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; c.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;
</span></span></span>Add event type to TFS.</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">/// &lt;summary&gt;
/// Add an EventTYpe using TeamFoundationNotificationService.
/// &lt;/summary&gt;
/// &lt;param name=&quot;schema&quot;&gt;&lt;/param&gt;
public void AddEventType(string name, string toolType, string schema)
{
    // Generate a SystemContext.
    TeamFoundationRequestContext systemRequest =  this.collectionHost.CreateSystemContext();
 
    // Get TeamFoundationNotificationService using the SystemContext.
    TeamFoundationNotificationService notificationService = 
        systemRequest.GetService&lt;TeamFoundationNotificationService&gt;();
 
    RegistrationEventType eventType = new RegistrationEventType(name, schema);
 
    notificationService.AddEventTypes(systemRequest, toolType,
        new RegistrationEventType[] { eventType });
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__com">///&nbsp;&lt;summary&gt;</span>&nbsp;
<span class="cs__com">///&nbsp;Add&nbsp;an&nbsp;EventTYpe&nbsp;using&nbsp;TeamFoundationNotificationService.</span>&nbsp;
<span class="cs__com">///&nbsp;&lt;/summary&gt;</span>&nbsp;
<span class="cs__com">///&nbsp;&lt;param&nbsp;name=&quot;schema&quot;&gt;&lt;/param&gt;</span>&nbsp;
<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;AddEventType(<span class="cs__keyword">string</span>&nbsp;name,&nbsp;<span class="cs__keyword">string</span>&nbsp;toolType,&nbsp;<span class="cs__keyword">string</span>&nbsp;schema)&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Generate&nbsp;a&nbsp;SystemContext.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;TeamFoundationRequestContext&nbsp;systemRequest&nbsp;=&nbsp;&nbsp;<span class="cs__keyword">this</span>.collectionHost.CreateSystemContext();&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Get&nbsp;TeamFoundationNotificationService&nbsp;using&nbsp;the&nbsp;SystemContext.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;TeamFoundationNotificationService&nbsp;notificationService&nbsp;=&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;systemRequest.GetService&lt;TeamFoundationNotificationService&gt;();&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;RegistrationEventType&nbsp;eventType&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;RegistrationEventType(name,&nbsp;schema);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;notificationService.AddEventTypes(systemRequest,&nbsp;toolType,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">new</span>&nbsp;RegistrationEventType[]&nbsp;{&nbsp;eventType&nbsp;});&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
</div>
</div>
<div class="MsoNormal">&nbsp;</div>
<h2>&nbsp;&nbsp;&nbsp;&nbsp; More Information</h2>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.versioncontrol.server.pendchangesnotification.aspx"><span class="SpellE">PendChangesNotification</span></a></div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.framework.server.applicationservicehost.aspx">
<span class="SpellE">ApplicationServiceHost</span> Class</a></div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.framework.server.collectionservicehost.aspx">
<span class="SpellE">CollectionServiceHost</span> Class</a></div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.framework.server.teamfoundationrequestcontext.aspx">
<span class="SpellE">TeamFoundationRequestContext</span> Class</a></div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.framework.server.teamprojectcollectionservice.aspx">
<span class="SpellE">TeamProjectCollectionService</span> Class</a></div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.framework.server.teamfoundationnotificationservice.aspx">
<span class="SpellE">TeamFoundationNotificationService</span> Class</a></div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.framework.server.isubscriber.aspx">
<span class="SpellE">ISubscriber</span> Interface</a></div>
<div class="MsoNormal">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://msdn.microsoft.com/en-us/library/x6c1kb0s.aspx">
XML Schema Definition Tool (Xsd.exe)</a></div>
<div class="MsoNormal">&nbsp;</div>
<div class="MsoNormal">&nbsp;</div>
<div class="MsoNormal"></div>
<div class="MsoNormal"></div>
<div class="MsoNormal">
<hr>
<div>&nbsp;&nbsp; <a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px">
<img src="http://bit.ly/onecodelogo" alt=""> </a></div>
</div>
</div>
<strong>&nbsp;</strong></div>