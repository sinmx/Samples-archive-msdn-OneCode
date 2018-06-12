# Show data with multiple value field (VBSharePointshowDataWithMultipleValueField)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* SharePoint
## Topics
* SharePoint
## IsPublished
* True
## ModifiedDate
* 2012-12-07 12:57:34
## Description

<h1><span style="">How to get data with multiple value field in a site collection(VBSharePointshowDataWithMultipleValueField)</span></h1>
<h2>Introduction</h2>
<p class="MsoNormal"><span style="">The sample </span>will show<span style=""> you</span> how to get data with multiple<span style="">
</span>values <span style="">F</span>ield in a site collection.<span style=""> </span>
<span style="">Ma</span>ny <span style="">users want</span> to get data with multiple value fields (user-multi field, taxonomy field<span style=""> and so on</span>) in site collection. In general,
<span style="">we </span>can achieve<span style=""> it</span> by using SPSiteDataQuery; however, the value of the multiple value fields will be empty.
<span style="">F</span>or this requirement, <span style="">w</span>e can consider SQL syntax search query, like FullTextSqlQuery<span style="">.</span></p>
<h2>Building the Sample</h2>
<p class="MsoNormal"><span style="">In order to make use of this web part, we need to have Enterprise Search service application provisioned and should have indexed our content.</span></p>
<h2>Running the Sample</h2>
<p class="MsoNormalCxSpFirst" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; text-indent:-.25in; line-height:normal">
<span style=""><span style="">Step 1:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;
</span></span></span><span style="">Open the VBSharePointshowDataWithMultipleValueField.sln file.
</span><span style=""></span></p>
<p class="MsoNormalCxSpMiddle" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; text-indent:-.25in; line-height:normal">
<span style=""><span style="">Step 2:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;
</span></span></span><span style="">After that, right-click the &quot;VBSharePointshowDataWithMultipleValueField&quot; project and click &quot;Deploy&quot;.</span></p>
<p class="MsoNormalCxSpMiddle" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; text-indent:-.25in; line-height:normal">
<span style=""><span style="">Step 3:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;
</span></span></span><span style="">Open the SharePoint site in the browser and then select &quot;Page&quot;.<br>
</span><span style="font-size:9.5pt"><img src="/site/view/file/72167/1/image.png" alt="" width="1042" height="351" align="middle">
</span><span style=""></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal">
<span style="font-size:9.5pt"></span></p>
<p class="MsoNormalCxSpMiddle" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; text-indent:-.25in; line-height:normal">
<span style=""><span style="">Step 4:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;
</span></span></span><span style="">Select Edit.<br>
</span><span style=""><img src="/site/view/file/72168/1/image.png" alt="" width="895" height="222" align="middle">
</span><span style=""><br style="">
<br style="">
</span></p>
<p class="MsoNormalCxSpMiddle" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; text-indent:-.25in; line-height:normal">
<span style="color:black"><span style="">Step 5:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;
</span></span></span><span style="">Select &quot;Insert&quot; Tab and click &quot;Web Part&quot;.<span style="color:black"><br>
In &quot;Categories&quot;, select &quot;Custom&quot; and in &quot;Web Parts&quot; column select this project's Web Part. Click on &quot;Add&quot; button, then click &quot;OK&quot;, you will see our Web Part appears in the SharePoint site as follows:</span></span><span style="color:black">
</span></p>
<p class="MsoNormalCxSpMiddle" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; line-height:normal">
<span style=""><img src="/site/view/file/72169/1/image.png" alt="" width="575" height="264" align="middle">
</span><span style="color:black"></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal">
<span style="">The </span><span style="">multiple value field's value will be shown as below:</span><span style="font-size:9.5pt; font-family:Consolas; color:green">
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal">
<span style=""><img src="/site/view/file/72170/1/image.png" alt="" width="576" height="159" align="middle">
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal">
<span style="">The following is a corresponding list of the data source.<br>
<img src="/site/view/file/72171/1/image.png" alt="" width="576" height="229" align="middle">
</span></p>
<p class="MsoNormalCxSpMiddle" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; line-height:normal">
<span style="color:black"></span></p>
<p class="MsoNormalCxSpLast" style="margin-top:0in; margin-right:0in; margin-bottom:0in; margin-left:.25in; margin-bottom:.0001pt; text-indent:-.25in; line-height:normal">
<span style=""><span style="">Step 6:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;
</span></span></span><span style="">Validation is completed</span>.</p>
<h2>Using the Code</h2>
<p class="MsoNormal">Step 1:<span style=""> Create a </span><span style="">VB </span>
<span style="">&quot;Empty SharePoint Project&quot; in Visual Studio 2010 and named it as &quot;VBSharePointshowDataWithMultipleValueField&quot;.<br>
Step 2: Add the following assembly reference:</span><span style="font-size:9.5pt; line-height:115%; font-family:Consolas; color:green">
<br>
</span><span style="color:black">Project-&gt; References -&gt;…</span> <span style="">
Microsoft.Office.Server.Search.dll</span><span style=""><br>
This DLL is located in &quot;C: \ Program Files \ Common Files \ Microsoft Shared \ Web Server Extensions \ 14 \ ISAPI&quot; file folder.<br>
</span><span style="">Step 3: Add a Visual Web Part to project.</span><span style="font-size:9.5pt; line-height:115%; font-family:Consolas; color:green">
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">html</span>
<pre class="hidden">
&lt;%@ Assembly Name=&quot;$SharePoint.Project.AssemblyFullName$&quot; %&gt;
&lt;%@ Assembly Name=&quot;Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;SharePoint&quot; Namespace=&quot;Microsoft.SharePoint.WebControls&quot;
&nbsp;&nbsp;&nbsp; Assembly=&quot;Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;Utilities&quot; Namespace=&quot;Microsoft.SharePoint.Utilities&quot; Assembly=&quot;Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;asp&quot; Namespace=&quot;System.Web.UI&quot; Assembly=&quot;System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35&quot; %&gt;
&lt;%@ Import Namespace=&quot;Microsoft.SharePoint&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;WebPartPages&quot; Namespace=&quot;Microsoft.SharePoint.WebPartPages&quot;
&nbsp;&nbsp;&nbsp; Assembly=&quot;Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Control Language=&quot;VB&quot; AutoEventWireup=&quot;true&quot; CodeBehind=&quot;MultipleValueWebPartUserControl.ascx.vb&quot;
&nbsp;&nbsp;&nbsp; Inherits=&quot;VBSharePointshowDataWithMultipleValueField.MultipleValueWebPartUserControl&quot; %&gt;
&lt;SharePoint:SPGridView runat=&quot;server&quot; ID=&quot;MyGridView&quot; Width=&quot;100%&quot; EnableViewState=&quot;false&quot;
&nbsp;&nbsp;&nbsp; AutoGenerateColumns=&quot;false&quot; OnRowDataBound=&quot;SPGridView1_RowDataBound&quot;&gt;
&nbsp;&nbsp;&nbsp; &lt;Columns&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:BoundField DataField=&quot;Title&quot; HeaderText=&quot;Title&quot; HeaderStyle-Width=&quot;70%&quot; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:TemplateField HeaderText=&quot;AssignedTo&quot; HeaderStyle-Width=&quot;70%&quot; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;ItemTemplate&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;SharePoint:SPGridView runat=&quot;server&quot; ID=&quot;gdvPeople&quot; AutoGenerateColumns=&quot;false&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Columns&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:BoundField DataField=&quot;Uname&quot; HeaderText=&quot;&quot; HeaderStyle-Width=&quot;70%&quot; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Columns&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/SharePoint:SPGridView&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/ItemTemplate&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/asp:TemplateField&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:BoundField DataField=&quot;LastModifiedTime&quot; HeaderText=&quot;LastModifiedTime&quot; HeaderStyle-Width=&quot;70%&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot; /&gt;
&nbsp;&nbsp;&nbsp; &lt;/Columns&gt;
&lt;/SharePoint:SPGridView&gt;

</pre>
<pre id="codePreview" class="html">
&lt;%@ Assembly Name=&quot;$SharePoint.Project.AssemblyFullName$&quot; %&gt;
&lt;%@ Assembly Name=&quot;Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;SharePoint&quot; Namespace=&quot;Microsoft.SharePoint.WebControls&quot;
&nbsp;&nbsp;&nbsp; Assembly=&quot;Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;Utilities&quot; Namespace=&quot;Microsoft.SharePoint.Utilities&quot; Assembly=&quot;Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;asp&quot; Namespace=&quot;System.Web.UI&quot; Assembly=&quot;System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35&quot; %&gt;
&lt;%@ Import Namespace=&quot;Microsoft.SharePoint&quot; %&gt;
&lt;%@ Register TagPrefix=&quot;WebPartPages&quot; Namespace=&quot;Microsoft.SharePoint.WebPartPages&quot;
&nbsp;&nbsp;&nbsp; Assembly=&quot;Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c&quot; %&gt;
&lt;%@ Control Language=&quot;VB&quot; AutoEventWireup=&quot;true&quot; CodeBehind=&quot;MultipleValueWebPartUserControl.ascx.vb&quot;
&nbsp;&nbsp;&nbsp; Inherits=&quot;VBSharePointshowDataWithMultipleValueField.MultipleValueWebPartUserControl&quot; %&gt;
&lt;SharePoint:SPGridView runat=&quot;server&quot; ID=&quot;MyGridView&quot; Width=&quot;100%&quot; EnableViewState=&quot;false&quot;
&nbsp;&nbsp;&nbsp; AutoGenerateColumns=&quot;false&quot; OnRowDataBound=&quot;SPGridView1_RowDataBound&quot;&gt;
&nbsp;&nbsp;&nbsp; &lt;Columns&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:BoundField DataField=&quot;Title&quot; HeaderText=&quot;Title&quot; HeaderStyle-Width=&quot;70%&quot; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:TemplateField HeaderText=&quot;AssignedTo&quot; HeaderStyle-Width=&quot;70%&quot; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;ItemTemplate&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;SharePoint:SPGridView runat=&quot;server&quot; ID=&quot;gdvPeople&quot; AutoGenerateColumns=&quot;false&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Columns&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:BoundField DataField=&quot;Uname&quot; HeaderText=&quot;&quot; HeaderStyle-Width=&quot;70%&quot; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Columns&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/SharePoint:SPGridView&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/ItemTemplate&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/asp:TemplateField&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:BoundField DataField=&quot;LastModifiedTime&quot; HeaderText=&quot;LastModifiedTime&quot; HeaderStyle-Width=&quot;70%&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HeaderStyle-CssClass=&quot;ms-vh2-nofilter&quot; /&gt;
&nbsp;&nbsp;&nbsp; &lt;/Columns&gt;
&lt;/SharePoint:SPGridView&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style="font-size:9.5pt; line-height:115%; font-family:Consolas; color:green"><br>
</span><span style="">Step 4: </span><span style="">Using FullTextSqlQuery to get Items. First, create a new DataTable for storing data. Then create a new FullTextSqlQuery class - use property intializers to set query. Finally, execute the query and load the
 results into the datatable</span><span style="">. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
''' &lt;summary&gt;
&nbsp;&nbsp; ''' Using FullTextSqlQuery to get Items
&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp; ''' &lt;returns&gt;&lt;/returns&gt;
&nbsp;&nbsp; ''' &lt;remarks&gt;&lt;/remarks&gt;
&nbsp;&nbsp; Public Shared Function GetFTSQueryItems() As DataTable
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create a DataTable to store data
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Dim results As New DataTable()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The web site's URL
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim url As String = SPContext.Current.Web.Url


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Query text
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim queryText As String = &quot;SELECT Title,AssignedTo,LastModifiedTime FROM SCOPE()&quot;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Open the site
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using site As New SPSite(url)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create a new FullTextSqlQuery class - use property initializers to set query
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim fts As New FullTextSqlQuery(site)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fts.QueryText = queryText
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fts.ResultTypes = ResultType.RelevantResults
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fts.RowLimit = 300


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Execute the query and load the results into the datatable
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim rtc As ResultTableCollection = fts.Execute()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If rtc.Count &gt; 0 Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using relevantResults As ResultTable = rtc(ResultType.RelevantResults)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; results.Load(relevantResults, LoadOption.OverwriteChanges)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return results
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp; End Function

</pre>
<pre id="codePreview" class="vb">
''' &lt;summary&gt;
&nbsp;&nbsp; ''' Using FullTextSqlQuery to get Items
&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp; ''' &lt;returns&gt;&lt;/returns&gt;
&nbsp;&nbsp; ''' &lt;remarks&gt;&lt;/remarks&gt;
&nbsp;&nbsp; Public Shared Function GetFTSQueryItems() As DataTable
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create a DataTable to store data
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Dim results As New DataTable()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The web site's URL
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim url As String = SPContext.Current.Web.Url


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Query text
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim queryText As String = &quot;SELECT Title,AssignedTo,LastModifiedTime FROM SCOPE()&quot;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Open the site
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using site As New SPSite(url)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create a new FullTextSqlQuery class - use property initializers to set query
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim fts As New FullTextSqlQuery(site)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fts.QueryText = queryText
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fts.ResultTypes = ResultType.RelevantResults
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fts.RowLimit = 300


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Execute the query and load the results into the datatable
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim rtc As ResultTableCollection = fts.Execute()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If rtc.Count &gt; 0 Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using relevantResults As ResultTable = rtc(ResultType.RelevantResults)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; results.Load(relevantResults, LoadOption.OverwriteChanges)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return results
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp; End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style=""><br>
Step 5: </span><span style="">Bind data to GridView</span><span style=""> at </span>
<span style="">Page_Load event </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Bind data to GridView
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyGridView.DataSource = GetFTSQueryItems()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyGridView.DataBind()
&nbsp; End Sub

</pre>
<pre id="codePreview" class="vb">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Bind data to GridView
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyGridView.DataSource = GetFTSQueryItems()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyGridView.DataBind()
&nbsp; End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style="">To bind</span><span style=""> multiple value field' value, we need to use SPGridView's RowDataBound</span><span style=""> Event. The code will be shown as below:
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
''' &lt;summary&gt;
&nbsp;&nbsp; ''' Bind the value of multiple value field (user-multi field in this sample) to SPGridView
&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp; Protected Sub SPGridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If e.Row.RowType = DataControlRowType.DataRow Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The control will be used to show the multiple value field's value
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim gdvPeople As SPGridView = TryCast(e.Row.Cells(1).FindControl(&quot;gdvPeople&quot;), SPGridView)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' A string array to store the multiple value field
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim userName As String() = Nothing


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Handle while the multiple value field's value is not null. 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;If Not (TypeOf (DataBinder.Eval(e.Row.DataItem, &quot;AssignedTo&quot;)) Is DBNull) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; userName = DirectCast(DataBinder.Eval(e.Row.DataItem, &quot;AssignedTo&quot;), String())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create a table to store the multiple value field's value 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Dim tblUserName As New DataTable()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tblUserName.Columns.Add(&quot;Uname&quot;)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If userName IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim url As String = SPContext.Current.Web.Url


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using site As New SPSite(url)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;' Deal with the multiple value field's value
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For Each item As String In userName
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If item.Contains(&quot;#&quot;) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim arrayUser As String() = item.Split(&quot;;&quot;c)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim i As Integer = 0
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; While i &lt; arrayUser.Length
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tblUserName.Rows.Add(arrayUser(i).Replace(&quot;#&quot;c, &quot; &quot;c).Trim())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; i = i &#43; 2
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End While
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' add username to datatable
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tblUserName.Rows.Add(item)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Next
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If tblUserName.Rows.Count &gt; 0 Then
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;gdvPeople.DataSource = tblUserName
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SetVisible(gdvPeople)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SetVisible(gdvPeople)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gdvPeople.DataBind()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub

</pre>
<pre id="codePreview" class="vb">
''' &lt;summary&gt;
&nbsp;&nbsp; ''' Bind the value of multiple value field (user-multi field in this sample) to SPGridView
&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp; Protected Sub SPGridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If e.Row.RowType = DataControlRowType.DataRow Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The control will be used to show the multiple value field's value
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim gdvPeople As SPGridView = TryCast(e.Row.Cells(1).FindControl(&quot;gdvPeople&quot;), SPGridView)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' A string array to store the multiple value field
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim userName As String() = Nothing


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Handle while the multiple value field's value is not null. 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;If Not (TypeOf (DataBinder.Eval(e.Row.DataItem, &quot;AssignedTo&quot;)) Is DBNull) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; userName = DirectCast(DataBinder.Eval(e.Row.DataItem, &quot;AssignedTo&quot;), String())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create a table to store the multiple value field's value 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Dim tblUserName As New DataTable()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tblUserName.Columns.Add(&quot;Uname&quot;)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If userName IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim url As String = SPContext.Current.Web.Url


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using site As New SPSite(url)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;' Deal with the multiple value field's value
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For Each item As String In userName
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If item.Contains(&quot;#&quot;) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim arrayUser As String() = item.Split(&quot;;&quot;c)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim i As Integer = 0
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; While i &lt; arrayUser.Length
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tblUserName.Rows.Add(arrayUser(i).Replace(&quot;#&quot;c, &quot; &quot;c).Trim())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; i = i &#43; 2
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End While
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' add username to datatable
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tblUserName.Rows.Add(item)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Next
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If tblUserName.Rows.Count &gt; 0 Then
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;gdvPeople.DataSource = tblUserName
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SetVisible(gdvPeople)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SetVisible(gdvPeople)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gdvPeople.DataBind()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style="">Step 6: You can debug and test it.</span></p>
<h2>More Information</h2>
<p class="MsoNormal"><span style="">FullTextSqlQuery Class<br>
</span><a href="http://msdn.microsoft.com/en-us/library/microsoft.office.server.search.query.fulltextsqlquery.aspx">http://msdn.microsoft.com/en-us/library/microsoft.office.server.search.query.fulltextsqlquery.aspx</a>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>