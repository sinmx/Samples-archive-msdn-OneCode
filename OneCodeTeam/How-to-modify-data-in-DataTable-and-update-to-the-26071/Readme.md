# How to modify data in DataTable and update to the data source
## Requires
* Visual Studio 2012
## License
* Apache License, Version 2.0
## Technologies
* ADO.NET
* Data Access
* .NET Development
## Topics
* DataTable Edit
* constraints
* deletion
## IsPublished
* True
## ModifiedDate
* 2013-11-25 11:33:21
## Description

<hr>
<div><a href="http://blogs.msdn.com/b/onecode" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodesampletopbanner">
</a></div>
<h1>How to Modify data in DataTable and Update(CSDataTableModify)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">We have several ways to modify the data in DataTable. In this application, we will demonstrate how to use different ways to modify data in DataTable and update to the source.</p>
<p class="MsoNormal">1. We use SqlDataAdapter to fill the DataTables.</p>
<p class="MsoNormal">2. We set<span style="">&nbsp; </span>DataTable Constraints in DataTables.</p>
<p class="MsoNormal">4. We use DataTable Edits to modify data.</p>
<p class="MsoNormal">3. We use DataRow.Delete Method and DataRowCollection.Remove Method to delete the rows, and then compare them.</p>
<p class="MsoNormal">5. We use SqlDataAdapter to update the datasource.</p>
<h2>Building the Sample</h2>
<p class="MsoNormal">Before you run the sample, you need to finish the following steps:</p>
<p class="MsoNormal">Step1. Please choose one of the following ways to build the database:</p>
<p class="MsoListParagraphCxSpFirst" style="margin-left:63.15pt; text-indent:-.25in">
<span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Attach the database file MySchool.mdf under the folder _External_Dependecies to your SQL Server 2008 database instance.</p>
<p class="MsoListParagraphCxSpLast" style="margin-left:63.15pt; text-indent:-.25in">
<span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Run the MySchool.sql script under the folder _External_Dependecies in your SQL Server 2008 database instance.</p>
<p class="MsoNormal">Step2. Modify the connection string in the Project Properties-&gt;Settings according-&gt; MySchoolConnectionString to your SQL Server 2008 database instance name.</p>
<h2>Running the Sample</h2>
<p class="MsoNormal">Press F5 to run the sample, the following is the result.</p>
<p class="MsoNormal">First, we get the data from database.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/102826/1/image.png" alt="" width="642" height="288" align="middle">
</span></p>
<p class="MsoNormal">Second, we use DataTable Edits to edit the data.</p>
<p class="MsoNormal">a. We change two values in Credits column, and one will cause the following display and cancel the Edit.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/102827/1/image.png" alt="" width="392" height="44" align="middle">
</span></p>
<p class="MsoNormal">b. We change the first two values of Credits, but only the second value is changed.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/102828/1/image.png" alt="" width="640" height="135" align="middle">
</span></p>
<p class="MsoNormal">Third, we delete and remove the rows in Datatable.</p>
<p class="MsoNormal">a. Because we set the foreign key constraint, the related rows in child table will be deleted when the rows in parent table are deleted.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/102829/1/image.png" alt="" width="640" height="304" align="middle">
</span></p>
<p class="MsoNormal">Then we can update the delete operations. Now the deleted row is removed from the DataTable and the database.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/102830/1/image.png" alt="" width="642" height="136" align="middle">
</span></p>
<p class="MsoNormal">b. We can also remove the rows from DataTable, and the row isn't exist in the table.
</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/102831/1/image.png" alt="" width="641" height="93" align="middle">
</span></p>
<p class="MsoNormal">After update the delete operations, however, we can also find the row in database. The Remove operation only remove the rows from DataTable, and doesn't change the value in Database.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/102832/1/image.png" alt="" width="345" height="99" align="middle">
</span></p>
<h2>Using the Code</h2>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
1. Use SqlDataAdapter to get data.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>
<pre class="hidden">
private static void GetDataTables(String connectionString,String selectString,
&nbsp;&nbsp;&nbsp; DataSet dataSet,params DataTable[] tables)
{
&nbsp;&nbsp;&nbsp; using (SqlDataAdapter adapter = new SqlDataAdapter())
&nbsp;&nbsp;&nbsp; {&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;adapter.SelectCommand = new SqlCommand(selectString);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; adapter.SelectCommand.Connection = new SqlConnection(connectionString);


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; adapter.Fill(0, 0,tables);


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; foreach (DataTable table in dataSet.Tables)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(&quot;Data in {0}:&quot;,table.TableName);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ShowDataTable(table);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
&nbsp;&nbsp;&nbsp; }
}

</pre>
<pre id="codePreview" class="csharp">
private static void GetDataTables(String connectionString,String selectString,
&nbsp;&nbsp;&nbsp; DataSet dataSet,params DataTable[] tables)
{
&nbsp;&nbsp;&nbsp; using (SqlDataAdapter adapter = new SqlDataAdapter())
&nbsp;&nbsp;&nbsp; {&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;adapter.SelectCommand = new SqlCommand(selectString);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; adapter.SelectCommand.Connection = new SqlConnection(connectionString);


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; adapter.Fill(0, 0,tables);


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; foreach (DataTable table in dataSet.Tables)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(&quot;Data in {0}:&quot;,table.TableName);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ShowDataTable(table);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
&nbsp;&nbsp;&nbsp; }
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
2. Use DataTable Edits to modify the data.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>
<pre class="hidden">
row.BeginEdit();
row[&quot;Credits&quot;] = credits;
row.EndEdit();

</pre>
<pre id="codePreview" class="csharp">
row.BeginEdit();
row[&quot;Credits&quot;] = credits;
row.EndEdit();

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
The following method will be invoked when the value in table is changed. If the new value of Credits is negative, we'll reject the modify.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>
<pre class="hidden">
private static void OnColumnChanged(Object sender, DataColumnChangeEventArgs args)
{
&nbsp;&nbsp;&nbsp; Int32 credits = 0;
&nbsp;&nbsp;&nbsp; // If Credits is changed and the value is negative, we'll cancel the edit.
&nbsp;&nbsp;&nbsp; if ((args.Column.ColumnName == &quot;Credits&quot;)&&
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (!Int32.TryParse(args.ProposedValue.ToString(),out credits)||credits&lt;0))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(&quot;The value of Credits is invalid. Edit canceled.&quot;);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; args.Row.CancelEdit();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
}

</pre>
<pre id="codePreview" class="csharp">
private static void OnColumnChanged(Object sender, DataColumnChangeEventArgs args)
{
&nbsp;&nbsp;&nbsp; Int32 credits = 0;
&nbsp;&nbsp;&nbsp; // If Credits is changed and the value is negative, we'll cancel the edit.
&nbsp;&nbsp;&nbsp; if ((args.Column.ColumnName == &quot;Credits&quot;)&&
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (!Int32.TryParse(args.ProposedValue.ToString(),out credits)||credits&lt;0))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(&quot;The value of Credits is invalid. Edit canceled.&quot;);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; args.Row.CancelEdit();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
3. Delete and remove rows from DataTable.</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
a. Delete rows</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
Create the foreign key constraint, and set the DeleteRule with Cascade.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>
<pre class="hidden">
ForeignKeyConstraint courseDepartFK = 
&nbsp;&nbsp;&nbsp;&nbsp;new ForeignKeyConstraint(&quot;CourseDepartFK&quot;, 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;department.Columns[&quot;DepartmentID&quot;], 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;course.Columns[&quot;DepartmentID&quot;]);
courseDepartFK.DeleteRule = Rule.Cascade;
courseDepartFK.UpdateRule = Rule.Cascade;
courseDepartFK.AcceptRejectRule = AcceptRejectRule.None;
course.Constraints.Add(courseDepartFK);

</pre>
<pre id="codePreview" class="csharp">
ForeignKeyConstraint courseDepartFK = 
&nbsp;&nbsp;&nbsp;&nbsp;new ForeignKeyConstraint(&quot;CourseDepartFK&quot;, 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;department.Columns[&quot;DepartmentID&quot;], 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;course.Columns[&quot;DepartmentID&quot;]);
courseDepartFK.DeleteRule = Rule.Cascade;
courseDepartFK.UpdateRule = Rule.Cascade;
courseDepartFK.AcceptRejectRule = AcceptRejectRule.None;
course.Constraints.Add(courseDepartFK);

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
We delete one row in department, and the related rows in Course table will also be deleted. And then we update Course table with the deleted operation, the row in database is also be deleted.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>
<pre class="hidden">
department.Rows[0].Delete();

</pre>
<pre id="codePreview" class="csharp">
department.Rows[0].Delete();

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
b. Remove rows</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
We remove one row from course table. And then we update Course table with the deleted operation, we can still find the row in database. The Remove operation only remove the rows from DataTable, and doesn't change the value in Database.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>
<pre class="hidden">
course.Rows.RemoveAt(0);

</pre>
<pre id="codePreview" class="csharp">
course.Rows.RemoveAt(0);

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span class="MsoHyperlink"><a href="http://msdn.microsoft.com/en-us/library/ch2aw0w6(VS.110).aspx">DataTable Edits</a>
</span></p>
<p class="MsoNormal" style=""><span class="MsoHyperlink"><a href="http://msdn.microsoft.com/en-us/library/st1t2c35(VS.110).aspx">DataTable Constraints</a>
</span></p>
<p class="MsoNormal" style=""><span class="MsoHyperlink"><a href="http://msdn.microsoft.com/en-us/library/03c7a3zb(VS.110).aspx">DataRow Deletion</a>
</span></p>
<p class="MsoNormal" style=""><span class="MsoHyperlink"><a href="http://msdn.microsoft.com/en-us/library/system.data.datarowcollection.remove(VS.110).aspx">DataRowCollection.Remove Method</a>
</span></p>
<p class="MsoNormal" style=""><span class="MsoHyperlink"><a href="http://msdn.microsoft.com/en-us/library/system.data.datarowcollection.indexof.aspx">DataRowCollection.IndexOf Method</a>
</span></p>
<p class="MsoNormal" style=""><span class="MsoHyperlink"><a href="http://msdn.microsoft.com/en-us/library/at8a576f(VS.100).aspx">DbDataAdapter.Update Method (DataSet)</a>
</span></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>