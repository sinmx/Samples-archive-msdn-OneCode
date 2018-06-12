# Custom DataGrid Control for WebAccess (VBTFSWebAccessWorkItemDataGridControl)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* TFS
## Topics
* Work Item
* TFS Web Access
## IsPublished
* True
## ModifiedDate
* 2012-04-20 12:20:49
## Description

<h1>Custom Data Grid work item control of <span style="">TFS2010 <span class="SpellE">
WebAccess</span></span> (<span class="SpellE"><span style="">VBTFSWebAccessWorkItemDataGridControl</span></span>)<span style="">
</span></h1>
<h2>Introduction</h2>
<p class="MsoNormal"><span style="">The VBTFSWebAccessWorkItemDataGridControl</span><span style=""> sample</span><span style=""> demonstrates how to create a Custom Data Grid work item control of
</span><span style="">TFS2010 WebAccess. </span></p>
<p class="MsoListParagraphCxSpFirst" style=""><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Display a Field value in DataGrid </span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Save the data in DataGrid to a WorkItem Field
</span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Support customize the Columns' Name </span></p>
<p class="MsoListParagraphCxSpLast" style=""><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Avoid<span style="">&nbsp; </span>Illegal characters
</span></p>
<p class="MsoNormal"><span style="">NOTE: The client javsscript uses Microsoft.XMLDOM to parse the xml, and it only works for IE.
</span></p>
<h2><span style="">Building</span> the Sample<span style=""> </span></h2>
<p class="MsoNormal"><span style="">This sample should be built on TFS2010 AppTier. Because following assemblise are only available in the App Tier.
</span></p>
<p class="MsoListParagraphCxSpFirst" style=""><span style="font-family:Wingdings"><span style="">��<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;
</span></span></span><span style="">Microsoft.TeamFoundation.WorkItemTracking.Client
</span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style="font-family:Wingdings"><span style="">��<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;
</span></span></span><span style="">Microsoft.TeamFoundation.WebAccess.Controls </span>
</p>
<p class="MsoListParagraphCxSpLast" style=""><span style="font-family:Wingdings"><span style="">��<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;
</span></span></span><span style="">Microsoft.TeamFoundation.WebAccess.WorkItemTracking
</span></p>
<h2>Running the Sample<span style=""> </span></h2>
<p class="MsoListParagraphCxSpFirst" style=""><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Copy following items to <u>C:\Program Files\Microsoft Team Foundation Server 2010\Application Tier\Web Access\Web\<span class="SpellE">App_Data</span>\<span class="SpellE">CustomControls</span></u>.
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:72.0pt"><span style="font-family:Wingdings"><span style="">��<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;
</span></span></span><span class="SpellE"><span style="">DataGridControl.wicc</span></span><span style="">
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:72.0pt"><span style="font-family:Wingdings"><span style="">��<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;
</span></span></span><span style="">VBTFSWebAccessWorkItemDataGridControl.dll </span>
</p>
<p class="MsoListParagraphCxSpMiddle"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Use <span class="SpellE"><b style="">WitAdmin</b></span>
<span class="SpellE"><b style="">importwitd</b></span> command line to import the
<a name="OLE_LINK1"></a><a name="OLE_LINK2"><span style=""><b style="">WIT Controls</b>
</span></a>(WIT Controls.xml) WorkItem Type. </span></p>
<p class="MsoListParagraphCxSpMiddle"><span style="">See <a href="http://msdn.microsoft.com/en-us/library/dd312129.aspx">
http://msdn.microsoft.com/en-us/library/dd312129.aspx</a>. TFS Power Tools also supplies a more convenient approach.
</span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Open Team <span class="SpellE">WebAccess</span> in IE, and connect to the Team Project to which you import the
<b style="">WIT Controls.</b> </span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Create a new <b style="">WIT Controls </b>work item, and you will see
</span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><img src="/site/view/file/56194/1/image.png" alt="" width="576" height="187" align="middle">
</span><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">5.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Type the title and data in the <span class="SpellE">
DataGrid</span>, then save the work item. </span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><img src="/site/view/file/56195/1/image.png" alt="" width="576" height="478" align="middle">
</span><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">6.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">If you add READONLY rule to <b style="">Demo.</b></span><b style="">
</b><span class="SpellE"><b style=""><span style="">GridField</span></b></span><span style="">, or set the control as readonly, you will see
</span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><img src="/site/view/file/56196/1/image.png" alt="" width="435" height="399" align="middle">
</span><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style="">7.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Visual Studio, you can also get the same result if you have used the
<span class="SpellE"><b style="">VBTFSWorkItemDataGridControl</b></span><b style="">.</b>
</span></p>
<p class="MsoListParagraphCxSpLast"><span style=""><img src="/site/view/file/56197/1/image.png" alt="" width="562" height="417" align="middle">
</span><span style=""></span></p>
<h2>Using the Code<span style=""> </span></h2>
<p class="MsoListParagraph" style="margin-left:54.0pt"><b style=""><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b><b style=""><span style="">This control inherits <span class="SpellE">
BaseWorkItemWebControl</span> which implements most methods of the <span class="SpellE">
IWorkItemWebControl</span> interface. </span></b></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Public Class DataGridControl
    Inherits BaseWorkItemWebControl

</pre>
<pre id="codePreview" class="vb">
Public Class DataGridControl
    Inherits BaseWorkItemWebControl

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><b style=""><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b><b style=""><span style="">The server side code is used to initialize the controls and flush the value to data source.<span style="">
</span></span></b></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">a.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Use the control attribute to customize the columns definition.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
' The pattern to identify the columns from the attribute.
' The attribute should like 
' Column A(FieldA);Column B(FieldB);
Private Const columnDefinitionPattern As String = &quot;(?&lt;display&gt;.&#43;?)\((?&lt;field&gt;.&#43;?)\);&quot;

</pre>
<pre id="codePreview" class="vb">
' The pattern to identify the columns from the attribute.
' The attribute should like 
' Column A(FieldA);Column B(FieldB);
Private Const columnDefinitionPattern As String = &quot;(?&lt;display&gt;.&#43;?)\((?&lt;field&gt;.&#43;?)\);&quot;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">b.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">The value of the field is stored as<span style="">&nbsp;
</span>XML format. This control will use DataTable to read data from the XML, and write XML to the field when the workitem is saved.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
''' &lt;summary&gt;
''' Control is requested to flush any data to workitem object. 
''' The field value is stored in the hidden field. GetValidateXml method will 
''' generate a valid xml from the hfValue.Value, and then set the value of current 
''' field to the XML.
''' &lt;/summary&gt;
Public Overrides Sub FlushToDatasource()
    Me.EnsureChildControls()
    Dim valiadXml As String = GetValidateXml(hfValue.Value)
    Me.SetFieldValue(valiadXml)
End Sub


'''&lt;summary&gt;
''' Asks control to invalidate the contents and redraw.
''' Read the value (XML) of current field, and set hfValue.Value
''' to the xml.
''' &lt;/summary&gt;
Public Overrides Sub InvalidateDatasource()
    Me.EnsureChildControls()
    Me.Clear()


    If Me.HasValidField Then
        Dim valiadXml As String = GetValidateXml(TryCast(Me.Field.Value, String))
        Me.hfValue.Value = valiadXml
    End If
End Sub


''' &lt;summary&gt;
''' Generate a valid XML from the given data. 
''' &lt;/summary&gt;
''' &lt;param name=&quot;data&quot;&gt;&lt;/param&gt;
''' &lt;returns&gt;&lt;/returns&gt;
Private Function GetValidateXml(ByVal data As String) As String
    Using table As New DataTable(&quot;DataTable&quot;)
        Try
            ' Determine whether the data is a valiad xml. 
            Using reader As New StringReader(data)
                table.ReadXml(reader)
            End Using
        Catch
        End Try


        ' Add columns to the DataTable if the column definition changes. 
        Dim columnsAttribute As String = MyBase.Properties(&quot;columns&quot;)
        Dim matches As MatchCollection = Regex.Matches(columnsAttribute,
                                                       columnDefinitionPattern)


        For Each match As Match In matches
            If Not table.Columns.Contains(match.Groups(&quot;field&quot;).Value) Then
                table.Columns.Add(match.Groups(&quot;field&quot;).Value)
            End If
        Next match


        ' Return the xml generated by the DataTable.
        Using writer As New StringWriter()
            table.WriteXml(writer, XmlWriteMode.WriteSchema)
            Return writer.ToString()
        End Using
    End Using
End Function

</pre>
<pre id="codePreview" class="vb">
''' &lt;summary&gt;
''' Control is requested to flush any data to workitem object. 
''' The field value is stored in the hidden field. GetValidateXml method will 
''' generate a valid xml from the hfValue.Value, and then set the value of current 
''' field to the XML.
''' &lt;/summary&gt;
Public Overrides Sub FlushToDatasource()
    Me.EnsureChildControls()
    Dim valiadXml As String = GetValidateXml(hfValue.Value)
    Me.SetFieldValue(valiadXml)
End Sub


'''&lt;summary&gt;
''' Asks control to invalidate the contents and redraw.
''' Read the value (XML) of current field, and set hfValue.Value
''' to the xml.
''' &lt;/summary&gt;
Public Overrides Sub InvalidateDatasource()
    Me.EnsureChildControls()
    Me.Clear()


    If Me.HasValidField Then
        Dim valiadXml As String = GetValidateXml(TryCast(Me.Field.Value, String))
        Me.hfValue.Value = valiadXml
    End If
End Sub


''' &lt;summary&gt;
''' Generate a valid XML from the given data. 
''' &lt;/summary&gt;
''' &lt;param name=&quot;data&quot;&gt;&lt;/param&gt;
''' &lt;returns&gt;&lt;/returns&gt;
Private Function GetValidateXml(ByVal data As String) As String
    Using table As New DataTable(&quot;DataTable&quot;)
        Try
            ' Determine whether the data is a valiad xml. 
            Using reader As New StringReader(data)
                table.ReadXml(reader)
            End Using
        Catch
        End Try


        ' Add columns to the DataTable if the column definition changes. 
        Dim columnsAttribute As String = MyBase.Properties(&quot;columns&quot;)
        Dim matches As MatchCollection = Regex.Matches(columnsAttribute,
                                                       columnDefinitionPattern)


        For Each match As Match In matches
            If Not table.Columns.Contains(match.Groups(&quot;field&quot;).Value) Then
                table.Columns.Add(match.Groups(&quot;field&quot;).Value)
            End If
        Next match


        ' Return the xml generated by the DataTable.
        Using writer As New StringWriter()
            table.WriteXml(writer, XmlWriteMode.WriteSchema)
            Return writer.ToString()
        End Using
    End Using
End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">c.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Register the client side script. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
' Defines the metadata attribute that enables an embedded resource in an assembly.
&lt;Assembly: WebResource(&quot;VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js&quot;,
 &quot;application/x-javascript&quot;)&gt; 

</pre>
<pre id="codePreview" class="vb">
' Defines the metadata attribute that enables an embedded resource in an assembly.
&lt;Assembly: WebResource(&quot;VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js&quot;,
 &quot;application/x-javascript&quot;)&gt; 

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraph" style="margin-left:90.0pt"><span style=""></span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
''' &lt;summary&gt;
''' Register the client script.
''' 1. VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js
''' 2. Use dataGridControl method in VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js
'''    to generate a client object.
''' &lt;/summary&gt;
''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
    MyBase.OnPreRender(e)


    ScriptManager.RegisterClientScriptResource(
        Me,
        GetType(DataGridControl),
        &quot;VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js&quot;)


    Dim columnsAttribute As String = MyBase.Properties(&quot;columns&quot;)
    ScriptHelper.RegisterObjectScript(
        Me,
        &quot;dataGridControl&quot;,
        New Object() {MyBase.ClientEditorObjectId,
                      MyBase.WorkItemFieldName,
                      MyBase.ControlId,
                      Me.pnlContainer.ClientID,
                      Me.hfValue.ClientID,
                      columnsAttribute,
                      MyBase.ReadOnly})
End Sub

</pre>
<pre id="codePreview" class="vb">
''' &lt;summary&gt;
''' Register the client script.
''' 1. VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js
''' 2. Use dataGridControl method in VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js
'''    to generate a client object.
''' &lt;/summary&gt;
''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
    MyBase.OnPreRender(e)


    ScriptManager.RegisterClientScriptResource(
        Me,
        GetType(DataGridControl),
        &quot;VBTFSWebAccessWorkItemDataGridControl.DataGridControl.js&quot;)


    Dim columnsAttribute As String = MyBase.Properties(&quot;columns&quot;)
    ScriptHelper.RegisterObjectScript(
        Me,
        &quot;dataGridControl&quot;,
        New Object() {MyBase.ClientEditorObjectId,
                      MyBase.WorkItemFieldName,
                      MyBase.ControlId,
                      Me.pnlContainer.ClientID,
                      Me.hfValue.ClientID,
                      columnsAttribute,
                      MyBase.ReadOnly})
End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">The client side Javascript is used to display the data in browser and handle the client event.
</span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">a.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Define the contrstructor of the client object.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>JavaScript</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">js</span>
<pre class="hidden">
// The constructor of the dataGridControl.
function dataGridControl(id,
                      workItemEditorObjectId,
                      fieldName,
                      controlId,
                      innerControlId,
                      hiddenFieldControlId,
                      columns,
                      readOnly) {


    // The m_workItemEditor represents the workItemEditor object in client side.
    // It supply methods to 
    //     1. Get field value.
    //     2. Update field value.
    //     3. Refresh all field.
    //     4. Other services. 
    // We can use $getObject(m_workItemEditorObjectId) to get it later.
    this.m_workItemEditorObjectId = workItemEditorObjectId;
    this.m_workItemEditor = null;


    // The field name.
    this.m_fieldName = fieldName;


    // The ID of this control.
    // We can use $getObject(controlId) to get this object.
    this.m_controlId = controlId;


    // The id of the pnlContainer.
    this.m_innerControlId = innerControlId;


    // The client html element of pnlContainer.
    this.m_control = null;


    // The id of hfValue.
    this.m_hiddenFieldControlId = hiddenFieldControlId;


    // The client html element of hfValue.
    this.m_hiddenFieldControl = null;


    // Use RegExp to parse to columns.
    // The attribute should like Column A(FieldA);Column B(FieldB);
    this.m_columns = new Array();


    var re = new RegExp(&quot;(.&#43;?)\\((.&#43;?)\\);&quot;, &quot;g&quot;);
    var arr;
    while ((arr = re.exec(columns)) != null) {
        var col = { display: arr[1], field: arr[2] };
        this.m_columns.push(col);
    }


    this.m_readOnly = readOnly;


    // The table to display the data.
    this.m_table = null;
    this.m_tbody = null;


    // A button to add a new record.
    this.m_btnAdd = null;


    // Use Microsoft.XMLDOM to parse the field value.
    this.m_xmlDoc = null;
}

</pre>
<pre id="codePreview" class="js">
// The constructor of the dataGridControl.
function dataGridControl(id,
                      workItemEditorObjectId,
                      fieldName,
                      controlId,
                      innerControlId,
                      hiddenFieldControlId,
                      columns,
                      readOnly) {


    // The m_workItemEditor represents the workItemEditor object in client side.
    // It supply methods to 
    //     1. Get field value.
    //     2. Update field value.
    //     3. Refresh all field.
    //     4. Other services. 
    // We can use $getObject(m_workItemEditorObjectId) to get it later.
    this.m_workItemEditorObjectId = workItemEditorObjectId;
    this.m_workItemEditor = null;


    // The field name.
    this.m_fieldName = fieldName;


    // The ID of this control.
    // We can use $getObject(controlId) to get this object.
    this.m_controlId = controlId;


    // The id of the pnlContainer.
    this.m_innerControlId = innerControlId;


    // The client html element of pnlContainer.
    this.m_control = null;


    // The id of hfValue.
    this.m_hiddenFieldControlId = hiddenFieldControlId;


    // The client html element of hfValue.
    this.m_hiddenFieldControl = null;


    // Use RegExp to parse to columns.
    // The attribute should like Column A(FieldA);Column B(FieldB);
    this.m_columns = new Array();


    var re = new RegExp(&quot;(.&#43;?)\\((.&#43;?)\\);&quot;, &quot;g&quot;);
    var arr;
    while ((arr = re.exec(columns)) != null) {
        var col = { display: arr[1], field: arr[2] };
        this.m_columns.push(col);
    }


    this.m_readOnly = readOnly;


    // The table to display the data.
    this.m_table = null;
    this.m_tbody = null;


    // A button to add a new record.
    this.m_btnAdd = null;


    // Use Microsoft.XMLDOM to parse the field value.
    this.m_xmlDoc = null;
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">b.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Initialize or reinitialize the client controls.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>JavaScript</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">js</span>
<pre class="hidden">
// This method will be called by m_workItemEditor.
dataGridControl.prototype.init = function dataGridControl$init() {
    this.m_workItemEditor = $getObject(this.m_workItemEditorObjectId);


    // Attach a event handler to the editorReady event of the workItemEditor.
    // The workItemEditor has other event like 
    //     1. synchronize.
    //     2. serverRoundtripStart.
    //     3. fieldChange.
    //     4. updateField-complete.
    //     5. beforeSave.
    //     6. serverRoundtripEnd.
    //     7. add-link.
    // You can find all the definition in EditWorkItem.js
    this.m_workItemEditor.attachEvent(&quot;editorReady&quot;, Function.createDelegate(this, this.onEditorReady));
    this.m_control = $getObject(this.m_innerControlId);
    this.m_hiddenFieldControl = $get(this.m_hiddenFieldControlId);
}


// Initialize the control.
dataGridControl.prototype.onEditorReady = function accountControl$onEditorReady() {
    this.reinitdataGridControl();
}


// Initialize the control.
dataGridControl.prototype.reinitdataGridControl = function dataGridControl$reinitdataGridControl() {


    // Get the field object.
    var field = this.m_workItemEditor.getField(this.m_fieldName);


    if (field) {


        // Determine whether the field is readonly/enabled.
        var fieldReadOnly = !field.IsEditable || field.IsComputed;
        var controlReadOnly = this.m_readOnly || fieldReadOnly;
        var enabled = !(this.m_workItemEditor.ReadOnly || controlReadOnly);
        var required = enabled ? field.IsRequired : false;


        // Delete the existing table.
        if (this.m_table) {
            this.m_control.removeChild(this.m_table);
        }


        // Generate the table. 
        this.drawTable(enabled);


        // Delete the existing button.
        if (this.m_btnAdd) {
            this.m_control.removeChild(this.m_btnAdd);
        }


        if (enabled) {
            this.drawAddButton();
        }
        this.m_xmlDoc = this.parseXml(this.m_hiddenFieldControl.value);


        // Draw the rows using the xmldoc.
        // If enabled == true, then generate the delete buttons.
        this.drawDataRows(enabled);
    }


}


// Draw the table with header row.
dataGridControl.prototype.drawTable = function accountControl$drawTable(enabled) {


    this.m_table = document.createElement(&quot;table&quot;);
    this.m_tbody = document.createElement(&quot;tbody&quot;);


    // Create Header Row
    var headerRow = document.createElement(&quot;tr&quot;);
    for (var i = 0; i &lt; this.m_columns.length; i&#43;&#43;) {
        var cell = document.createElement(&quot;th&quot;);
        cell.innerHTML = this.m_columns[i].display;
        headerRow.appendChild(cell);
    }
    if (enabled == true) {
        var deletecell = document.createElement(&quot;th&quot;);
        deletecell.innerHTML = &quot;Delete&quot;;
        headerRow.appendChild(deletecell);
    }


    this.m_tbody.appendChild(headerRow);
    this.m_table.appendChild(this.m_tbody);


    // Set the style of the table.
    this.m_table.rules = &quot;all&quot;;
    this.m_table.style.borderWidth = &quot;1&quot;;
    this.m_table.style.borderCollapse = &quot;collapse&quot;;


    // Add table to the container.
    this.m_control.appendChild(this.m_table);
}


// Draw datarows in the table.
dataGridControl.prototype.drawDataRows = function accountControl$drawDataRows(enabled) {


    // Get data from the xmldoc.
    var datarows = this.m_xmlDoc.getElementsByTagName(&quot;DataTable&quot;);


    for (var i = 0; i &lt; datarows.length; i&#43;&#43;) {


        // Generate new row.
        var newRow = document.createElement(&quot;tr&quot;);
        for (var j = 0; j &lt; this.m_columns.length; j&#43;&#43;) {
            
            // Get cell value from the datarow.
            var cellNodes = datarows[i].getElementsByTagName(this.m_columns[j].field);
            var cellValue = &quot;&quot;;
            if (cellNodes.length &gt; 0) {
                cellValue = cellNodes[0].text;
            }


            // Generate new cell.
            var cell = document.createElement(&quot;td&quot;);


            // If this control is disabled, then use cell.innerHTML to display the data.
            if (enabled == false) {
                cell.innerHTML = cellValue;
            }


            // Use TextBox to display the data.
            else {
                var textbox = document.createElement(&quot;input&quot;);
                textbox.type = &quot;text&quot;;
                textbox.value = cellValue;
                textbox.dataRow = datarows[i];
                textbox.attributes[&quot;title&quot;].value = this.m_columns[j].field;


                // Attach event handler to the change event.
                JsUtility.attachEvent(textbox, &quot;change&quot;, Function.createDelegate(this, this.onCellChange));


                cell.appendChild(textbox);
            }
            newRow.appendChild(cell);
        }


        // Draw the delete button.
        if (enabled == true) {
            var deleteCell = document.createElement(&quot;td&quot;);
            var btnDelete = document.createElement(&quot;input&quot;);
            btnDelete.type = &quot;button&quot;;
            btnDelete.value = &quot;Delete&quot;;
            btnDelete.dataRow = datarows[i];
            btnDelete.tableRow = newRow;
            JsUtility.attachEvent(btnDelete, &quot;click&quot;, Function.createDelegate(this, this.onbtnDeleteClick));
            deleteCell.appendChild(btnDelete);
            newRow.appendChild(deleteCell);
        }
        this.m_tbody.appendChild(newRow);
    }
}


// Draw the add button.
dataGridControl.prototype.drawAddButton = function accountControl$drawAddButton() {
    this.m_btnAdd = document.createElement(&quot;input&quot;);
    this.m_btnAdd.type = &quot;button&quot;;
    this.m_btnAdd.value = &quot;Add new record&quot;;
    JsUtility.attachEvent(this.m_btnAdd, &quot;click&quot;, Function.createDelegate(this, this.onbtnAddClick));
    this.m_control.appendChild(this.m_btnAdd);
}

</pre>
<pre id="codePreview" class="js">
// This method will be called by m_workItemEditor.
dataGridControl.prototype.init = function dataGridControl$init() {
    this.m_workItemEditor = $getObject(this.m_workItemEditorObjectId);


    // Attach a event handler to the editorReady event of the workItemEditor.
    // The workItemEditor has other event like 
    //     1. synchronize.
    //     2. serverRoundtripStart.
    //     3. fieldChange.
    //     4. updateField-complete.
    //     5. beforeSave.
    //     6. serverRoundtripEnd.
    //     7. add-link.
    // You can find all the definition in EditWorkItem.js
    this.m_workItemEditor.attachEvent(&quot;editorReady&quot;, Function.createDelegate(this, this.onEditorReady));
    this.m_control = $getObject(this.m_innerControlId);
    this.m_hiddenFieldControl = $get(this.m_hiddenFieldControlId);
}


// Initialize the control.
dataGridControl.prototype.onEditorReady = function accountControl$onEditorReady() {
    this.reinitdataGridControl();
}


// Initialize the control.
dataGridControl.prototype.reinitdataGridControl = function dataGridControl$reinitdataGridControl() {


    // Get the field object.
    var field = this.m_workItemEditor.getField(this.m_fieldName);


    if (field) {


        // Determine whether the field is readonly/enabled.
        var fieldReadOnly = !field.IsEditable || field.IsComputed;
        var controlReadOnly = this.m_readOnly || fieldReadOnly;
        var enabled = !(this.m_workItemEditor.ReadOnly || controlReadOnly);
        var required = enabled ? field.IsRequired : false;


        // Delete the existing table.
        if (this.m_table) {
            this.m_control.removeChild(this.m_table);
        }


        // Generate the table. 
        this.drawTable(enabled);


        // Delete the existing button.
        if (this.m_btnAdd) {
            this.m_control.removeChild(this.m_btnAdd);
        }


        if (enabled) {
            this.drawAddButton();
        }
        this.m_xmlDoc = this.parseXml(this.m_hiddenFieldControl.value);


        // Draw the rows using the xmldoc.
        // If enabled == true, then generate the delete buttons.
        this.drawDataRows(enabled);
    }


}


// Draw the table with header row.
dataGridControl.prototype.drawTable = function accountControl$drawTable(enabled) {


    this.m_table = document.createElement(&quot;table&quot;);
    this.m_tbody = document.createElement(&quot;tbody&quot;);


    // Create Header Row
    var headerRow = document.createElement(&quot;tr&quot;);
    for (var i = 0; i &lt; this.m_columns.length; i&#43;&#43;) {
        var cell = document.createElement(&quot;th&quot;);
        cell.innerHTML = this.m_columns[i].display;
        headerRow.appendChild(cell);
    }
    if (enabled == true) {
        var deletecell = document.createElement(&quot;th&quot;);
        deletecell.innerHTML = &quot;Delete&quot;;
        headerRow.appendChild(deletecell);
    }


    this.m_tbody.appendChild(headerRow);
    this.m_table.appendChild(this.m_tbody);


    // Set the style of the table.
    this.m_table.rules = &quot;all&quot;;
    this.m_table.style.borderWidth = &quot;1&quot;;
    this.m_table.style.borderCollapse = &quot;collapse&quot;;


    // Add table to the container.
    this.m_control.appendChild(this.m_table);
}


// Draw datarows in the table.
dataGridControl.prototype.drawDataRows = function accountControl$drawDataRows(enabled) {


    // Get data from the xmldoc.
    var datarows = this.m_xmlDoc.getElementsByTagName(&quot;DataTable&quot;);


    for (var i = 0; i &lt; datarows.length; i&#43;&#43;) {


        // Generate new row.
        var newRow = document.createElement(&quot;tr&quot;);
        for (var j = 0; j &lt; this.m_columns.length; j&#43;&#43;) {
            
            // Get cell value from the datarow.
            var cellNodes = datarows[i].getElementsByTagName(this.m_columns[j].field);
            var cellValue = &quot;&quot;;
            if (cellNodes.length &gt; 0) {
                cellValue = cellNodes[0].text;
            }


            // Generate new cell.
            var cell = document.createElement(&quot;td&quot;);


            // If this control is disabled, then use cell.innerHTML to display the data.
            if (enabled == false) {
                cell.innerHTML = cellValue;
            }


            // Use TextBox to display the data.
            else {
                var textbox = document.createElement(&quot;input&quot;);
                textbox.type = &quot;text&quot;;
                textbox.value = cellValue;
                textbox.dataRow = datarows[i];
                textbox.attributes[&quot;title&quot;].value = this.m_columns[j].field;


                // Attach event handler to the change event.
                JsUtility.attachEvent(textbox, &quot;change&quot;, Function.createDelegate(this, this.onCellChange));


                cell.appendChild(textbox);
            }
            newRow.appendChild(cell);
        }


        // Draw the delete button.
        if (enabled == true) {
            var deleteCell = document.createElement(&quot;td&quot;);
            var btnDelete = document.createElement(&quot;input&quot;);
            btnDelete.type = &quot;button&quot;;
            btnDelete.value = &quot;Delete&quot;;
            btnDelete.dataRow = datarows[i];
            btnDelete.tableRow = newRow;
            JsUtility.attachEvent(btnDelete, &quot;click&quot;, Function.createDelegate(this, this.onbtnDeleteClick));
            deleteCell.appendChild(btnDelete);
            newRow.appendChild(deleteCell);
        }
        this.m_tbody.appendChild(newRow);
    }
}


// Draw the add button.
dataGridControl.prototype.drawAddButton = function accountControl$drawAddButton() {
    this.m_btnAdd = document.createElement(&quot;input&quot;);
    this.m_btnAdd.type = &quot;button&quot;;
    this.m_btnAdd.value = &quot;Add new record&quot;;
    JsUtility.attachEvent(this.m_btnAdd, &quot;click&quot;, Function.createDelegate(this, this.onbtnAddClick));
    this.m_control.appendChild(this.m_btnAdd);
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">c.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Handle the client side event. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>JavaScript</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">js</span>
<pre class="hidden">
// Create new row if btnAdd is clicked. 
// This method will draw a new row in the table, and update the xmldoc and field.
// The control should be enabled because btnAdd is enabled.
dataGridControl.prototype.onbtnAddClick = function dataGridControl$onbtnAddClick() {
  var dataRow = this.m_xmlDoc.createElement(&quot;DataTable&quot;);
  var newRow = document.createElement(&quot;tr&quot;);


  // Draw textboxes to represent the data.
  for (var i = 0; i &lt; this.m_columns.length; i&#43;&#43;) {
      var cell = document.createElement(&quot;th&quot;);
      
      var textbox = document.createElement(&quot;input&quot;);
      textbox.type = &quot;text&quot;;
      textbox.dataRow = dataRow;
      textbox.attributes[&quot;title&quot;].value = this.m_columns[i].field;
      JsUtility.attachEvent(textbox, &quot;change&quot;, Function.createDelegate(this, this.onCellChange));


      cell.appendChild(textbox);
      newRow.appendChild(cell);


      var dataCell = this.m_xmlDoc.createElement(this.m_columns[i].field);
      dataRow.appendChild(dataCell);
  }


  // Draw delete button.
  var deleteCell = document.createElement(&quot;td&quot;);
  var btnDelete = document.createElement(&quot;input&quot;);
  btnDelete.type = &quot;button&quot;;
  btnDelete.value = &quot;Delete&quot;;
  btnDelete.dataRow = dataRow;
  btnDelete.tableRow = newRow;
  JsUtility.attachEvent(btnDelete, &quot;click&quot;, Function.createDelegate(this, this.onbtnDeleteClick));


  deleteCell.appendChild(btnDelete);
  newRow.appendChild(deleteCell);


  // Update xmldoc, table and field.
  this.m_xmlDoc.firstChild.appendChild(dataRow);
  this.m_tbody.appendChild(newRow);
  this.UpdateField();
}


// Delete a row in the table, and then update the xmldoc and field.
dataGridControl.prototype.onbtnDeleteClick = function dataGridControl$onbtnDeleteClick() {
  var btnDelete = event.srcElement;
  var dataRow = btnDelete.dataRow;
  var tableRow = btnDelete.tableRow;


  this.m_xmlDoc.firstChild.removeChild(dataRow);
  this.m_tbody.removeChild(tableRow);


  this.UpdateField();
}


// update the xmldoc and field.
dataGridControl.prototype.onCellChange = function accountControl$onCellChange() {
  var textbox = event.srcElement;
  
  // A node in the xmldoc which is displayed in the current table row.
  var datarow = textbox.dataRow;


  var field = textbox.attributes[&quot;title&quot;].value;
  var datacells = datarow.getElementsByTagName(field);


  if (datacells.length &gt; 0) {


      var datacell = datacells[0];


      // Update the node in xmldoc.
      datacell.text = textbox.value;


      // Update the field.
      this.UpdateField();
  }


}

</pre>
<pre id="codePreview" class="js">
// Create new row if btnAdd is clicked. 
// This method will draw a new row in the table, and update the xmldoc and field.
// The control should be enabled because btnAdd is enabled.
dataGridControl.prototype.onbtnAddClick = function dataGridControl$onbtnAddClick() {
  var dataRow = this.m_xmlDoc.createElement(&quot;DataTable&quot;);
  var newRow = document.createElement(&quot;tr&quot;);


  // Draw textboxes to represent the data.
  for (var i = 0; i &lt; this.m_columns.length; i&#43;&#43;) {
      var cell = document.createElement(&quot;th&quot;);
      
      var textbox = document.createElement(&quot;input&quot;);
      textbox.type = &quot;text&quot;;
      textbox.dataRow = dataRow;
      textbox.attributes[&quot;title&quot;].value = this.m_columns[i].field;
      JsUtility.attachEvent(textbox, &quot;change&quot;, Function.createDelegate(this, this.onCellChange));


      cell.appendChild(textbox);
      newRow.appendChild(cell);


      var dataCell = this.m_xmlDoc.createElement(this.m_columns[i].field);
      dataRow.appendChild(dataCell);
  }


  // Draw delete button.
  var deleteCell = document.createElement(&quot;td&quot;);
  var btnDelete = document.createElement(&quot;input&quot;);
  btnDelete.type = &quot;button&quot;;
  btnDelete.value = &quot;Delete&quot;;
  btnDelete.dataRow = dataRow;
  btnDelete.tableRow = newRow;
  JsUtility.attachEvent(btnDelete, &quot;click&quot;, Function.createDelegate(this, this.onbtnDeleteClick));


  deleteCell.appendChild(btnDelete);
  newRow.appendChild(deleteCell);


  // Update xmldoc, table and field.
  this.m_xmlDoc.firstChild.appendChild(dataRow);
  this.m_tbody.appendChild(newRow);
  this.UpdateField();
}


// Delete a row in the table, and then update the xmldoc and field.
dataGridControl.prototype.onbtnDeleteClick = function dataGridControl$onbtnDeleteClick() {
  var btnDelete = event.srcElement;
  var dataRow = btnDelete.dataRow;
  var tableRow = btnDelete.tableRow;


  this.m_xmlDoc.firstChild.removeChild(dataRow);
  this.m_tbody.removeChild(tableRow);


  this.UpdateField();
}


// update the xmldoc and field.
dataGridControl.prototype.onCellChange = function accountControl$onCellChange() {
  var textbox = event.srcElement;
  
  // A node in the xmldoc which is displayed in the current table row.
  var datarow = textbox.dataRow;


  var field = textbox.attributes[&quot;title&quot;].value;
  var datacells = datarow.getElementsByTagName(field);


  if (datacells.length &gt; 0) {


      var datacell = datacells[0];


      // Update the node in xmldoc.
      datacell.text = textbox.value;


      // Update the field.
      this.UpdateField();
  }


}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">d.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Update the field. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>JavaScript</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">js</span>
<pre class="hidden">
// Update the value of the hfValue, and then update the value of current field.
dataGridControl.prototype.UpdateField = function accountControl$UpdateField() {
    this.m_hiddenFieldControl.value = this.m_xmlDoc.xml;
    this.m_workItemEditor.updateField(this, this.m_fieldName, this.m_xmlDoc.xml, true, &quot;&quot;, this.m_controlId);
}

</pre>
<pre id="codePreview" class="js">
// Update the value of the hfValue, and then update the value of current field.
dataGridControl.prototype.UpdateField = function accountControl$UpdateField() {
    this.m_hiddenFieldControl.value = this.m_xmlDoc.xml;
    this.m_workItemEditor.updateField(this, this.m_fieldName, this.m_xmlDoc.xml, true, &quot;&quot;, this.m_controlId);
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:90.0pt"><span style=""><span style="">e.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Parse XMLDoc from input data. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>JavaScript</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">js</span>
<pre class="hidden">
// Parse xmldoc from the input data.
// NOTE: this control uses Microsoft.XMLDOM to parse the xml, and it only works for IE.
dataGridControl.prototype.parseXml = function accountControl$parseXml(data) {
    var xml, tmp;
    try {
        xml = new ActiveXObject(&quot;Microsoft.XMLDOM&quot;);
        xml.async = &quot;false&quot;;
        xml.loadXML(data);
    } catch (e) {
        xml = null;
    }


    if (!xml || !xml.documentElement || xml.getElementsByTagName(&quot;parsererror&quot;).length) {
        return null;
    }
    return xml;
}

</pre>
<pre id="codePreview" class="js">
// Parse xmldoc from the input data.
// NOTE: this control uses Microsoft.XMLDOM to parse the xml, and it only works for IE.
dataGridControl.prototype.parseXml = function accountControl$parseXml(data) {
    var xml, tmp;
    try {
        xml = new ActiveXObject(&quot;Microsoft.XMLDOM&quot;);
        xml.async = &quot;false&quot;;
        xml.loadXML(data);
    } catch (e) {
        xml = null;
    }


    if (!xml || !xml.documentElement || xml.getElementsByTagName(&quot;parsererror&quot;).length) {
        return null;
    }
    return xml;
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:90.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><b style=""><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b><b style=""><span style="">Define a new WorkItem Type to use this control</span></b><b style=""><span style="">
</span></b></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
&lt;witd:WITD application=&quot;Work item type editor&quot; version=&quot;1.0&quot; xmlns:witd=&quot;http://schemas.microsoft.com/VisualStudio/2008/workitemtracking/typedef&quot;&gt;
  &lt;WORKITEMTYPE name=&quot;WIT Controls&quot;&gt;
    &lt;DESCRIPTION&gt;&lt;/DESCRIPTION&gt;
    &lt;FIELDS&gt;
      ...
      &lt;FIELD name=&quot;GridField&quot; refname=&quot;Demo.GridField&quot; type=&quot;PlainText&quot; /&gt;
      ...
    &lt;/FIELDS&gt;
    &lt;WORKFLOW&gt;
      ...
    &lt;/WORKFLOW&gt;
    &lt;FORM&gt;
      ...
            &lt;Control FieldName=&quot;Demo.GridField&quot; Type=&quot;DataGridControl&quot; Label=&quot;&quot; LabelPosition=&quot;Top&quot; Dock=&quot;Fill&quot; columns=&quot;Column A(Name);Column B(Age);Column C(Score);&quot;&gt;
              &lt;CustomControlOptions /&gt;
            &lt;/Control&gt;
     ...
    &lt;/FORM&gt;
  &lt;/WORKITEMTYPE&gt;
&lt;/witd:WITD&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
&lt;witd:WITD application=&quot;Work item type editor&quot; version=&quot;1.0&quot; xmlns:witd=&quot;http://schemas.microsoft.com/VisualStudio/2008/workitemtracking/typedef&quot;&gt;
  &lt;WORKITEMTYPE name=&quot;WIT Controls&quot;&gt;
    &lt;DESCRIPTION&gt;&lt;/DESCRIPTION&gt;
    &lt;FIELDS&gt;
      ...
      &lt;FIELD name=&quot;GridField&quot; refname=&quot;Demo.GridField&quot; type=&quot;PlainText&quot; /&gt;
      ...
    &lt;/FIELDS&gt;
    &lt;WORKFLOW&gt;
      ...
    &lt;/WORKFLOW&gt;
    &lt;FORM&gt;
      ...
            &lt;Control FieldName=&quot;Demo.GridField&quot; Type=&quot;DataGridControl&quot; Label=&quot;&quot; LabelPosition=&quot;Top&quot; Dock=&quot;Fill&quot; columns=&quot;Column A(Name);Column B(Age);Column C(Score);&quot;&gt;
              &lt;CustomControlOptions /&gt;
            &lt;/Control&gt;
     ...
    &lt;/FORM&gt;
  &lt;/WORKITEMTYPE&gt;
&lt;/witd:WITD&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<h2>More Information<span style=""> </span></h2>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb286959(VS.90).aspx">Work Item Tracking Custom Controls</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/microsoft.teamfoundation.workitemtracking.controls.iworkitemcontrol(VS.90).aspx"><span class="SpellE">IWorkItemControl</span> Interface</a>
</span></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>