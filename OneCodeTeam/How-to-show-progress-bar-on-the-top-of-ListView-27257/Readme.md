# How to show progress bar on the top of ListView when it is loading large data
## Requires
* Visual Studio 2012
## License
* Apache License, Version 2.0
## Technologies
* Windows
* Windows 8
* Windows Store app Development
## Topics
* ListView
* Progress Bar
* load data
## IsPublished
* True
## ModifiedDate
* 2014-02-16 07:28:26
## Description

<hr>
<div><a href="http://blogs.msdn.com/b/onecode" style="margin-top:3px"><img src="http://bit.ly/onecodesampletopbanner" alt="">
</a></div>
<h1>How to get<span> the </span>progress<span> ring to display in the period when</span>
<span class="SpellE">ListView</span> is loading large data<span> (<span class="SpellE">JSWindowsStoreAppProgressOverListView</span></span>)</h1>
<h2>Introduction</h2>
<h2><span style="font-size:11.0pt; line-height:115%; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-weight:normal">The sample demonstrates how to get the progress ring to display in the period when
<span class="SpellE">WinJS.UI.ListView</span> control is loading large data. After launching the app, click &quot;load&quot; button to load sample data into
<span class="SpellE">ListView</span> control. </span></h2>
<h2>Build the Sample</h2>
<p class="MsoListParagraphCxSpFirst" style="text-indent:-.25in"><span><span>1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Start Visual Studio 2012 and select File &gt; Open &gt; Project/Solution.</p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:-.25in"><span><span>2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Go to the directory in which you download the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio
<span class="GramE">Solution(</span>.<span class="SpellE">sln</span>) file.</p>
<p class="MsoListParagraphCxSpLast" style="text-indent:-.25in"><span><span>3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Press F7 or use Build &gt; Build Solution to build the sample.</p>
<h2>Running the Sample</h2>
<p class="MsoListParagraphCxSpFirst" style="text-indent:-.25in"><span><span>1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Press Ctrl&#43;F5 or F5 to run the project.</p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:-.25in"><span><span>2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>After the sample is launched, <span>the screen as shown below will display.</span></p>
<p class="MsoListParagraphCxSpMiddle"><span><img src="/site/view/file/108760/1/image.png" alt="" width="576" height="326" align="middle">
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:-.25in"><span><span>3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span>Please click &quot;Load&quot; button to load sample data into <span class="SpellE">
ListView</span>, the following screen will display: </span></p>
<p class="MsoListParagraphCxSpMiddle"><span><img src="/site/view/file/108761/1/image.png" alt="" width="576" height="326" align="middle">
</span><span>&nbsp;</span></p>
<p class="MsoListParagraphCxSpLast" style="text-indent:-.25in"><span><span>4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span>When the data loading is finished, the progress ring will be invisible and the data will be shown in
<span class="SpellE">WinJS.UI.ListView</span> control. </span></p>
<h2>Using the Code</h2>
<p class="MsoNormal">The code<span> snippet</span> below <span>shows the HTML UI.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">html</span>
<pre class="hidden">&lt;body&gt;
    &lt;div id=&quot;rootGrid&quot;&gt;
    &lt;div id=&quot;title&quot;&gt;
    &lt;p class=&quot;AppLogo&quot;&gt;Windows Store Code Samples by All-In-One Code Framework&lt;/p&gt;
    &lt;p class=&quot;AppName&quot;&gt;Show a ProgressRing over ListView&lt;/p&gt;
    &lt;p class=&quot;AppDescription&quot;&gt;This sample demonstrates how to show progressring on the top of ListView when WinJS.UI.ListView is loading large data&lt;/p&gt;
    &lt;/div&gt;
    &lt;div id=&quot;content&quot;&gt; 
        &lt;div&gt;
            &lt;button id=&quot;loadButton&quot; class=&quot;action&quot;&gt;Load&lt;/button&gt;
        &lt;/div&gt;
        &lt;div id=&quot;urlerror&quot;&gt;
            &lt;label &gt;This Url is not valid.&lt;/label&gt;
        &lt;/div&gt;
        &lt;div class=&quot;output&quot;&gt;
            &lt;!-- Template --&gt;
            &lt;div id=&quot;myItemTemplate&quot; data-win-control=&quot;WinJS.Binding.Template&quot;&gt;
                &lt;div class=&quot;smallListIconTextItem&quot;&gt;
                    &lt;img src=&quot;#&quot; class=&quot;smallListIconTextItem-Image&quot; data-win-bind=&quot;src: picture&quot; /&gt;
                    &lt;div class=&quot;smallListIconTextItem-Detail&quot;&gt;
                        &lt;h4 data-win-bind=&quot;innerText: title&quot;&gt;&lt;/h4&gt;
                        &lt;h6 data-win-bind=&quot;innerText: text&quot;&gt;&lt;/h6&gt;
                    &lt;/div&gt;
                &lt;/div&gt;
            &lt;/div&gt;
         
            &lt;!-- Note the 'loadingBehavior', 'pagesToLoad', 'automaticallyLoadPages', and 'pagesToLoadThreshold' properties--&gt;
            &lt;div id=&quot;listView&quot; 
                class=&quot;win-selectionstylefilled&quot;
                data-win-control=&quot;WinJS.UI.ListView&quot;&gt;
            &lt;/div&gt;  
            
         &lt;div id=&quot;progressContain&quot;&gt;
             &lt;progress id=&quot;loadprogressring&quot; class=&quot;win-ring&quot; /&gt;
        &lt;/div&gt;
        &lt;/div&gt;
        
    &lt;/div&gt;

    &lt;div id=&quot;footer&quot;&gt;
        &lt;div&gt;
            &lt;img src=&quot;/images/microsoft.png&quot;/&gt;&lt;br/&gt;
        &lt;/div&gt;        
        &lt;div id=&quot;company&quot;&gt;&Acirc;&copy; 2013 Microsoft Corporation. All rights reserved.
        &lt;a href=&quot;http://blogs.msdn.com/b/onecode&quot;&gt;All-In-One Code Framework&lt;/a&gt;
        &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
&lt;/body&gt;
</pre>
<div class="preview">
<pre class="html"><span class="html__tag_start">&lt;body</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;rootGrid&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;title&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;p</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;AppLogo&quot;</span><span class="html__tag_start">&gt;</span>Windows&nbsp;Store&nbsp;Code&nbsp;Samples&nbsp;by&nbsp;All-In-One&nbsp;Code&nbsp;Framework<span class="html__tag_end">&lt;/p&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;p</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;AppName&quot;</span><span class="html__tag_start">&gt;</span>Show&nbsp;a&nbsp;ProgressRing&nbsp;over&nbsp;ListView<span class="html__tag_end">&lt;/p&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;p</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;AppDescription&quot;</span><span class="html__tag_start">&gt;</span>This&nbsp;sample&nbsp;demonstrates&nbsp;how&nbsp;to&nbsp;show&nbsp;progressring&nbsp;on&nbsp;the&nbsp;top&nbsp;of&nbsp;ListView&nbsp;when&nbsp;WinJS.UI.ListView&nbsp;is&nbsp;loading&nbsp;large&nbsp;data<span class="html__tag_end">&lt;/p&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;content&quot;</span><span class="html__tag_start">&gt;&nbsp;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;button</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;loadButton&quot;</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;action&quot;</span><span class="html__tag_start">&gt;</span>Load<span class="html__tag_end">&lt;/button&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;urlerror&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;label</span>&nbsp;<span class="html__tag_start">&gt;</span>This&nbsp;Url&nbsp;is&nbsp;not&nbsp;valid.<span class="html__tag_end">&lt;/label&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;output&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__comment">&lt;!--&nbsp;Template&nbsp;--&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;myItemTemplate&quot;</span>&nbsp;<span class="html__attr_name">data-win-control</span>=<span class="html__attr_value">&quot;WinJS.Binding.Template&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;smallListIconTextItem&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;img</span>&nbsp;<span class="html__attr_name">src</span>=<span class="html__attr_value">&quot;#&quot;</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;smallListIconTextItem-Image&quot;</span>&nbsp;<span class="html__attr_name">data-win-bind</span>=<span class="html__attr_value">&quot;src:&nbsp;picture&quot;</span>&nbsp;<span class="html__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;smallListIconTextItem-Detail&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;h4</span>&nbsp;<span class="html__attr_name">data-win-bind</span>=<span class="html__attr_value">&quot;innerText:&nbsp;title&quot;</span><span class="html__tag_start">&gt;</span><span class="html__tag_end">&lt;/h4&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;h6</span>&nbsp;<span class="html__attr_name">data-win-bind</span>=<span class="html__attr_value">&quot;innerText:&nbsp;text&quot;</span><span class="html__tag_start">&gt;</span><span class="html__tag_end">&lt;/h6&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__comment">&lt;!--&nbsp;Note&nbsp;the&nbsp;'loadingBehavior',&nbsp;'pagesToLoad',&nbsp;'automaticallyLoadPages',&nbsp;and&nbsp;'pagesToLoadThreshold'&nbsp;properties--&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;listView&quot;</span>&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;win-selectionstylefilled&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__attr_name">data-win-control</span>=<span class="html__attr_value">&quot;WinJS.UI.ListView&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;progressContain&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;progress</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;loadprogressring&quot;</span>&nbsp;<span class="html__attr_name">class</span>=<span class="html__attr_value">&quot;win-ring&quot;</span>&nbsp;<span class="html__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;footer&quot;</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span><span class="html__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;img</span>&nbsp;<span class="html__attr_name">src</span>=<span class="html__attr_value">&quot;/images/microsoft.png&quot;</span><span class="html__tag_start">/&gt;</span><span class="html__tag_start">&lt;br</span><span class="html__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;div</span>&nbsp;<span class="html__attr_name">id</span>=<span class="html__attr_value">&quot;company&quot;</span><span class="html__tag_start">&gt;&Acirc;</span>&copy;&nbsp;2013&nbsp;Microsoft&nbsp;Corporation.&nbsp;All&nbsp;rights&nbsp;reserved.&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_start">&lt;a</span>&nbsp;<span class="html__attr_name">href</span>=<span class="html__attr_value">&quot;http://blogs.msdn.com/b/onecode&quot;</span><span class="html__tag_start">&gt;</span>All-In-One&nbsp;Code&nbsp;Framework<span class="html__tag_end">&lt;/a&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
<span class="html__tag_end">&lt;/div&gt;</span>&nbsp;
<span class="html__tag_end">&lt;/body&gt;</span>&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><a name="OLE_LINK2"></a><a name="OLE_LINK1"><span>The </span>
</a><span><span><span>following</span> cod</span></span><span>&nbsp;</span><span>e</span> snippet
<span>shows how to get the progress ring to display during the period when <span class="SpellE">
ListView</span> is loading large data, and then set the progress ring to be invisible after the data loading is finished.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>JavaScript</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">js</span>
<pre class="hidden">app.onactivated = function (args) {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; if (args.detail.kind === activation.ActivationKind.launch) {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // TODO: This application has been newly launched. Initialize
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // your application here.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; } else {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // TODO: This application has been reactivated from suspension.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Restore application state here.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; args.setPromise(WinJS.UI.processAll().then(function complete() {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // retrieve button
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; loadBtn = document.getElementById(&quot;loadButton&quot;);&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // register Click Event for load button
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; loadBtn.addEventListener(&quot;click&quot;, loadButtonClick, false);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
&nbsp;&nbsp; };


&nbsp;&nbsp; // load data into listview control
&nbsp;&nbsp; function loadButtonClick() {&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// clear the datasource
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; document.getElementById(&quot;listView&quot;).winControl.itemDataSource = null;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// set load button disabled 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;loadBtn.disabled = true;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // set progress be visible
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; document.getElementById(&quot;loadprogressring&quot;).style.visibility = &quot;visible&quot;;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// simulate listview to load large data. because the listview load data synchronously 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;setTimeout(loaddata, 2000);
&nbsp;&nbsp; }


&nbsp;&nbsp; function loaddata()
&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // get listview element
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var listviewElement = document.getElementById(&quot;listView&quot;);


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // get WinJS.UI.ListView control object
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var listViewControl = listviewElement.winControl;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // binding data to ListView control
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.itemDataSource = myData.dataSource;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.itemTemplate = document.getElementById(&quot;myItemTemplate&quot;);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.layout = new WinJS.UI.GridLayout();


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // force update the layout of listview control to display the binding data
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.forceLayout();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// set load button enable and set progress be invisible
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; loadBtn.disabled = false;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; document.getElementById(&quot;loadprogressring&quot;).style.visibility = &quot;collapse&quot;;
&nbsp;&nbsp; }

</pre>
<pre class="js" id="codePreview">app.onactivated = function (args) {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; if (args.detail.kind === activation.ActivationKind.launch) {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // TODO: This application has been newly launched. Initialize
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // your application here.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; } else {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // TODO: This application has been reactivated from suspension.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Restore application state here.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; args.setPromise(WinJS.UI.processAll().then(function complete() {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // retrieve button
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; loadBtn = document.getElementById(&quot;loadButton&quot;);&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // register Click Event for load button
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; loadBtn.addEventListener(&quot;click&quot;, loadButtonClick, false);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
&nbsp;&nbsp; };


&nbsp;&nbsp; // load data into listview control
&nbsp;&nbsp; function loadButtonClick() {&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// clear the datasource
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; document.getElementById(&quot;listView&quot;).winControl.itemDataSource = null;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// set load button disabled 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;loadBtn.disabled = true;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // set progress be visible
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; document.getElementById(&quot;loadprogressring&quot;).style.visibility = &quot;visible&quot;;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// simulate listview to load large data. because the listview load data synchronously 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;setTimeout(loaddata, 2000);
&nbsp;&nbsp; }


&nbsp;&nbsp; function loaddata()
&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // get listview element
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var listviewElement = document.getElementById(&quot;listView&quot;);


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // get WinJS.UI.ListView control object
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var listViewControl = listviewElement.winControl;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // binding data to ListView control
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.itemDataSource = myData.dataSource;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.itemTemplate = document.getElementById(&quot;myItemTemplate&quot;);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.layout = new WinJS.UI.GridLayout();


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // force update the layout of listview control to display the binding data
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; listViewControl.forceLayout();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// set load button enable and set progress be invisible
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; loadBtn.disabled = false;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; document.getElementById(&quot;loadprogressring&quot;).style.visibility = &quot;collapse&quot;;
&nbsp;&nbsp; }

</pre>
</div>
</div>
<h2>More Information<span> </span></h2>
<p class="MsoNormal"><span>Data binding (Windows Store apps using JavaScript and HTML)
</span></p>
<p class="MsoNormal"><span><a href="http://msdn.microsoft.com/en-us/library/windows/apps/hh758311.aspx">http://msdn.microsoft.com/en-us/library/windows/apps/hh758311.aspx</a>
</span></p>
<p class="MsoNormal"><span class="SpellE"><span>WinJS.UI.ListView</span></span><span> object
</span></p>
<p class="MsoNormal"><span><a href="http://msdn.microsoft.com/en-us/library/windows/apps/br211837.aspx">http://msdn.microsoft.com/en-us/library/windows/apps/br211837.aspx</a>
</span></p>
<p class="MsoNormal"><span>Adding progress controls (Windows Store apps using JavaScript and HTML)
</span></p>
<p class="MsoNormal"><span><a href="http://msdn.microsoft.com/en-us/library/windows/apps/hh465428.aspx">http://msdn.microsoft.com/en-us/library/windows/apps/hh465428.aspx</a>
</span></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt="">
</a></div>