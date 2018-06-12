# Retry Azure Cache Operations (CSAzureRetryCache)
## Requires
* Visual Studio 2010
## License
* Apache License, Version 2.0
## Technologies
* Microsoft Azure
## Topics
* transient errors
* Transient Fault Handling Application Block
## IsPublished
* True
## ModifiedDate
* 2013-04-16 10:26:53
## Description

<p style="font-family:Courier New">&nbsp;<a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420" target="_blank"><img id="79969" src="http://i1.code.msdn.s-msft.com/csazurebingmaps-bab92df1/image/file/79969/1/120x90_azure_web_en_us.jpg" alt="" width="360" height="90"></a></p>
<h1>Retry Azure Cache Operations (CSAzureRetryCache)</h1>
<h2>Introduction</h2>
<div>When using cloud based services, it is very common to receive exceptions similar to below while performing cache operations such as get, put. These are called transient errors.&nbsp;</div>
<div>&nbsp;</div>
<div>Developer is required to implement retry logic to successfully complete their cache operations.</div>
<div>&nbsp;</div>
<div><em>ErrorCode&lt;ERRCA0017&gt;:SubStatus&lt;ES0006&gt;:There is a temporary failure. Please retry later. (One or more specified cache servers are unavailable, which could be caused by busy network or servers. For on-premises cache clusters, also verify
 the following conditions. Ensure that security permission has been granted for this client account, and check that the AppFabric Caching Service is allowed through the firewall on all cache hosts. Also the MaxBufferSize on the server must be greater than or
 equal to the serialized object size sent from the client.)</em></div>
<div>&nbsp;</div>
<div>This sample implements retry&nbsp;logic to protect the application from crashing in the event of transient errors. This sample uses Transient Fault Handling Application Block to implement retry mechanism</div>
<div>
<div align="right">
<p><a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420"><span style="color:windowtext; text-decoration:none"><span><img src="http://code.msdn.microsoft.com/site/view/file/67654/1/image.png" alt="" width="120" height="90" align="middle">
</span></span></a><br>
<a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420">Try Windows Azure for free for 90 Days!</a></p>
</div>
</div>
<div>&nbsp;</div>
<h2>Building the Sample</h2>
<div>1) Ensure Windows Azure SDK 1.6 is installed on the machine. Download Link</div>
<div>&nbsp;</div>
<div>2)&nbsp;Modify the highlighted cachenamespace, autherizataionInfo attributes under DataCacheClient section of web.config and provide values of your own cache namespace and Authentication Token. Steps to obtain the value of authentication token, cache namespace
 value can be found here</div>
<div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>
<pre class="hidden">&lt;dataCacheClients&gt;
 
  &lt;dataCacheClient name=&quot;default&quot;&gt;
    &lt;hosts&gt;
      &lt;host name=&quot;skyappcache.cache.windows.net&quot; cachePort=&quot;22233&quot; /&gt;
    &lt;/hosts&gt;
 
    &lt;securityProperties mode=&quot;Message&quot;&gt;
      &lt;messageSecurity
        authorizationInfo=&quot;YWNzOmh0dHBzOi8vbXZwY2FjaGUtY2FjaGUuYWNjZXNzY29udHJvbC53aW5kb3dzLm5ldC9XUkFQdjAuOS8mb3duZXImOWRINnZQeWhhaFMrYXp1VnF0Y1RDY1NGNzgxdGpheEpNdzg0d1ZXN2FhWT0maHR0cDovL212cGNhY2hlLmNhY2hlLndpbmRvd3MubmV0&quot;&gt;
      &lt;/messageSecurity&gt;
    &lt;/securityProperties&gt;
  &lt;/dataCacheClient&gt;
</pre>
<div class="preview">
<pre class="xml"><span class="xml__tag_start">&lt;dataCacheClients</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;
&nbsp;&nbsp;<span class="xml__tag_start">&lt;dataCacheClient</span>&nbsp;<span class="xml__attr_name">name</span>=<span class="xml__attr_value">&quot;default&quot;</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;hosts</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;host</span>&nbsp;<span class="xml__attr_name">name</span>=<span class="xml__attr_value">&quot;skyappcache.cache.windows.net&quot;</span>&nbsp;<span class="xml__attr_name">cachePort</span>=<span class="xml__attr_value">&quot;22233&quot;</span>&nbsp;<span class="xml__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_end">&lt;/hosts&gt;</span>&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;securityProperties</span>&nbsp;<span class="xml__attr_name">mode</span>=<span class="xml__attr_value">&quot;Message&quot;</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;messageSecurity</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__attr_name">authorizationInfo</span>=<span class="xml__attr_value">&quot;YWNzOmh0dHBzOi8vbXZwY2FjaGUtY2FjaGUuYWNjZXNzY29udHJvbC53aW5kb3dzLm5ldC9XUkFQdjAuOS8mb3duZXImOWRINnZQeWhhaFMrYXp1VnF0Y1RDY1NGNzgxdGpheEpNdzg0d1ZXN2FhWT0maHR0cDovL212cGNhY2hlLmNhY2hlLndpbmRvd3MubmV0&quot;</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_end">&lt;/messageSecurity&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_end">&lt;/securityProperties&gt;</span>&nbsp;
&nbsp;&nbsp;<span class="xml__tag_end">&lt;/dataCacheClient&gt;</span>&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
</div>
<h2>Running the Sample</h2>
<ul>
<li>Open the Project in VS 2010 and run it in debug or release mode </li><li>Click on &ldquo;Add To Cache&rdquo; button to add a string object to Azure cache. Up on successful operation, &ldquo;String object added to cache!&rdquo; message will be printed on the webpage
</li><li>Click on &ldquo;Read From Cache&rdquo; button to read the string object from Azure Cache. Up on successful operation, value of the string object stored in Azure cache will be printed on the webpage. By default it will be &ldquo;My Cache&rdquo; (if no changes
 are made to code) </li></ul>
<div>&nbsp;</div>
<h2>Using the Code</h2>
<div>1. Define required objects globally, so that they are available for all code paths with in the module.</div>
<div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">// Define DataCache object
DataCache cache;
 
// Global variable for retry strategy
FixedInterval retryStrategy;
 
// Global variable for retry policy
RetryPolicy retryPolicy;</pre>
<div class="preview">
<pre class="csharp"><span class="cs__com">//&nbsp;Define&nbsp;DataCache&nbsp;object</span>&nbsp;
DataCache&nbsp;cache;&nbsp;
&nbsp;&nbsp;
<span class="cs__com">//&nbsp;Global&nbsp;variable&nbsp;for&nbsp;retry&nbsp;strategy</span>&nbsp;
FixedInterval&nbsp;retryStrategy;&nbsp;
&nbsp;&nbsp;
<span class="cs__com">//&nbsp;Global&nbsp;variable&nbsp;for&nbsp;retry&nbsp;policy</span>&nbsp;
RetryPolicy&nbsp;retryPolicy;</pre>
</div>
</div>
</div>
<div class="endscriptcode">2. This method configures strategies, policies, actions required for performing retries.</div>
<div class="endscriptcode"></div>
</div>
<div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">/// &lt;summary&gt;
/// This method configures strategies, policies, actions required for performing retries.
/// &lt;/summary&gt; 
protected void SetupRetryPolicy()
{
    // Define your retry strategy: in this sample, I'm retrying operation 3 times with 1 second interval
    retryStrategy = new FixedInterval(3, TimeSpan.FromSeconds(1));
 
    // Define your retry policy here. This sample uses CacheTransientErrorDetectionStrategy 
    retryPolicy = new RetryPolicy&lt;CacheTransientErrorDetectionStrategy&gt;(retryStrategy);
 
    // Get notifications from retries from  Transient Fault Handling Application Block code
    retryPolicy.Retrying &#43;= (sender1, args) =&gt;
    {
        // Log details of the retry.
        var msg = String.Format(&quot;Retry - Count:{0}, Delay:{1}, Exception:{2}&quot;,
            args.CurrentRetryCount, args.Delay, args.LastException);
 
        // Logging the notification details to the application trace. 
        Trace.Write(msg);
    };
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__com">///&nbsp;&lt;summary&gt;</span>&nbsp;
<span class="cs__com">///&nbsp;This&nbsp;method&nbsp;configures&nbsp;strategies,&nbsp;policies,&nbsp;actions&nbsp;required&nbsp;for&nbsp;performing&nbsp;retries.</span>&nbsp;
<span class="cs__com">///&nbsp;&lt;/summary&gt;&nbsp;</span>&nbsp;
<span class="cs__keyword">protected</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;SetupRetryPolicy()&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Define&nbsp;your&nbsp;retry&nbsp;strategy:&nbsp;in&nbsp;this&nbsp;sample,&nbsp;I'm&nbsp;retrying&nbsp;operation&nbsp;3&nbsp;times&nbsp;with&nbsp;1&nbsp;second&nbsp;interval</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;retryStrategy&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;FixedInterval(<span class="cs__number">3</span>,&nbsp;TimeSpan.FromSeconds(<span class="cs__number">1</span>));&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Define&nbsp;your&nbsp;retry&nbsp;policy&nbsp;here.&nbsp;This&nbsp;sample&nbsp;uses&nbsp;CacheTransientErrorDetectionStrategy&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;retryPolicy&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;RetryPolicy&lt;CacheTransientErrorDetectionStrategy&gt;(retryStrategy);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Get&nbsp;notifications&nbsp;from&nbsp;retries&nbsp;from&nbsp;&nbsp;Transient&nbsp;Fault&nbsp;Handling&nbsp;Application&nbsp;Block&nbsp;code</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;retryPolicy.Retrying&nbsp;&#43;=&nbsp;(sender1,&nbsp;args)&nbsp;=&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Log&nbsp;details&nbsp;of&nbsp;the&nbsp;retry.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;msg&nbsp;=&nbsp;String.Format(<span class="cs__string">&quot;Retry&nbsp;-&nbsp;Count:{0},&nbsp;Delay:{1},&nbsp;Exception:{2}&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;args.CurrentRetryCount,&nbsp;args.Delay,&nbsp;args.LastException);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Logging&nbsp;the&nbsp;notification&nbsp;details&nbsp;to&nbsp;the&nbsp;application&nbsp;trace.&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trace.Write(msg);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;};&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">3. Create the Cache Object using the DataCacheClient configuration specified in web.config and perform initial setup required for Azure cache retries</div>
<div class="endscriptcode"></div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">protected void Page_Load(object sender, EventArgs e)
{
   // Configure retry policies, strategies, actions
    SetupRetryPolicy();
 
   // Create cache object using the cache settings specified web.config 
   cache = CacheUtil.GetCacheConfig();
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__keyword">protected</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;Page_Load(<span class="cs__keyword">object</span>&nbsp;sender,&nbsp;EventArgs&nbsp;e)&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Configure&nbsp;retry&nbsp;policies,&nbsp;strategies,&nbsp;actions</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;SetupRetryPolicy();&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Create&nbsp;cache&nbsp;object&nbsp;using&nbsp;the&nbsp;cache&nbsp;settings&nbsp;specified&nbsp;web.config&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;cache&nbsp;=&nbsp;CacheUtil.GetCacheConfig();&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
</div>
<div class="endscriptcode">4. Add string object to Cache on a button click event and perform retries in case of transient failures</div>
<div class="endscriptcode"></div>
</div>
<div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">protected void btnAddToCache_Click(object sender, EventArgs e)
{
    try
    {
        // In order to use the retry policies, strategies defined in Transient Fault Handling
        // Application Block , user calls to cache must be wrapped with in ExecuteAction delegate
        retryPolicy.ExecuteAction(
            () =&gt;
            {
                // I'm just storing simple string object here .. Assuming this call fails, 
                // this sample retries the same call 3 times with 1 second interval before it gives up.
                cache.Put(&quot;MyDataSet&quot;, &quot;My Cache&quot;);
                Response.Write(&quot;String object added to cache!&quot;);
            });
                                        
    }
    catch (DataCacheException dc)
    {
        // Exception occurred after implementing the Retry logic.
        // Ideally you should log the exception to your application logs and show user friendly 
        // error message on the webpage.
        Trace.Write(dc.GetType().ToString() &#43; dc.Message.ToString() &#43; dc.StackTrace.ToString());
    }
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__keyword">protected</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;btnAddToCache_Click(<span class="cs__keyword">object</span>&nbsp;sender,&nbsp;EventArgs&nbsp;e)&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;In&nbsp;order&nbsp;to&nbsp;use&nbsp;the&nbsp;retry&nbsp;policies,&nbsp;strategies&nbsp;defined&nbsp;in&nbsp;Transient&nbsp;Fault&nbsp;Handling</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Application&nbsp;Block&nbsp;,&nbsp;user&nbsp;calls&nbsp;to&nbsp;cache&nbsp;must&nbsp;be&nbsp;wrapped&nbsp;with&nbsp;in&nbsp;ExecuteAction&nbsp;delegate</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;retryPolicy.ExecuteAction(&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;()&nbsp;=&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;I'm&nbsp;just&nbsp;storing&nbsp;simple&nbsp;string&nbsp;object&nbsp;here&nbsp;..&nbsp;Assuming&nbsp;this&nbsp;call&nbsp;fails,&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;this&nbsp;sample&nbsp;retries&nbsp;the&nbsp;same&nbsp;call&nbsp;3&nbsp;times&nbsp;with&nbsp;1&nbsp;second&nbsp;interval&nbsp;before&nbsp;it&nbsp;gives&nbsp;up.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;cache.Put(<span class="cs__string">&quot;MyDataSet&quot;</span>,&nbsp;<span class="cs__string">&quot;My&nbsp;Cache&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Response.Write(<span class="cs__string">&quot;String&nbsp;object&nbsp;added&nbsp;to&nbsp;cache!&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">catch</span>&nbsp;(DataCacheException&nbsp;dc)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Exception&nbsp;occurred&nbsp;after&nbsp;implementing&nbsp;the&nbsp;Retry&nbsp;logic.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Ideally&nbsp;you&nbsp;should&nbsp;log&nbsp;the&nbsp;exception&nbsp;to&nbsp;your&nbsp;application&nbsp;logs&nbsp;and&nbsp;show&nbsp;user&nbsp;friendly&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;error&nbsp;message&nbsp;on&nbsp;the&nbsp;webpage.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trace.Write(dc.GetType().ToString()&nbsp;&#43;&nbsp;dc.Message.ToString()&nbsp;&#43;&nbsp;dc.StackTrace.ToString());&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
&nbsp;5. Read the value of string object stored in Azure Cache on a button click event and perform retries in case of transient failures</div>
<div></div>
<div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">protected void btnReadFromCache_Click(object sender, EventArgs e)
{
    try
    {
        // In order to use the retry policies, strategies defined in Transient Fault 
        // Handling Application Block , user calls to cache must be wrapped with in 
        // ExecuteAction delegate.
        retryPolicy.ExecuteAction(
            () =&gt;
            {
                
                // Getting the object from azure cache and printing it on the page. 
                Response.Write(cache.Get(&quot;MyDataSet&quot;));
            });
    }
    catch (DataCacheException dc)
    {
        // Exception occurred after implementing the Retry logic.
        // Ideally you should log the exception to your application logs and show user 
        // friendly error message on the webpage.
        Trace.Write(dc.GetType().ToString() &#43; dc.Message.ToString() &#43; dc.StackTrace.ToString());
    }
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__keyword">protected</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;btnReadFromCache_Click(<span class="cs__keyword">object</span>&nbsp;sender,&nbsp;EventArgs&nbsp;e)&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;In&nbsp;order&nbsp;to&nbsp;use&nbsp;the&nbsp;retry&nbsp;policies,&nbsp;strategies&nbsp;defined&nbsp;in&nbsp;Transient&nbsp;Fault&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Handling&nbsp;Application&nbsp;Block&nbsp;,&nbsp;user&nbsp;calls&nbsp;to&nbsp;cache&nbsp;must&nbsp;be&nbsp;wrapped&nbsp;with&nbsp;in&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;ExecuteAction&nbsp;delegate.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;retryPolicy.ExecuteAction(&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;()&nbsp;=&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Getting&nbsp;the&nbsp;object&nbsp;from&nbsp;azure&nbsp;cache&nbsp;and&nbsp;printing&nbsp;it&nbsp;on&nbsp;the&nbsp;page.&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Response.Write(cache.Get(<span class="cs__string">&quot;MyDataSet&quot;</span>));&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">catch</span>&nbsp;(DataCacheException&nbsp;dc)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Exception&nbsp;occurred&nbsp;after&nbsp;implementing&nbsp;the&nbsp;Retry&nbsp;logic.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Ideally&nbsp;you&nbsp;should&nbsp;log&nbsp;the&nbsp;exception&nbsp;to&nbsp;your&nbsp;application&nbsp;logs&nbsp;and&nbsp;show&nbsp;user&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;friendly&nbsp;error&nbsp;message&nbsp;on&nbsp;the&nbsp;webpage.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trace.Write(dc.GetType().ToString()&nbsp;&#43;&nbsp;dc.Message.ToString()&nbsp;&#43;&nbsp;dc.StackTrace.ToString());&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode"></div>
</div>
<div>&nbsp;
<h2>More Information</h2>
<p>Refer to below blog entry for more information <a href="http://blogs.msdn.com/b/narahari/archive/2011/12/29/implementing-retry-logic-for-azure-caching-applications-made-easy.aspx">
http://blogs.msdn.com/b/narahari/archive/2011/12/29/implementing-retry-logic-for-azure-caching-applications-made-easy.aspx</a></p>
</div>
<div>&nbsp;</div>
<div><br>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt=""></a></div>
<div></div>
<div>&nbsp;</div>
</div>