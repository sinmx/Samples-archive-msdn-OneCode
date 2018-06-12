# How to horizontally partition data in Windows Azure SQL Database
## Requires
* Visual Studio 2010
## License
* Apache License, Version 2.0
## Technologies
* Microsoft Azure
* Windows Azure SQL Database
## Topics
* Partitioning
## IsPublished
* True
## ModifiedDate
* 2013-10-23 08:15:38
## Description

<h1>How to partition your data in SQL Azure (CSSqlAzurePartitioning)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">This sample demonstrates how to partition your data in SQL Azure. It shows two ways: one is vertical partitioning while the other is horizontal partitioning.</p>
<h2>Building the Sample</h2>
<p class="MsoNormal">Prerequisites: <br>
If you would like to test this sample project locally, you need to install: </p>
<p class="MsoNormal">Microsoft SQL Server 2008 R2 Express </p>
<p class="MsoNormal">Microsoft SQL Server 2008 R2 Management Studio Express </p>
<p class="MsoNormal">You can get them from: </p>
<p class="MsoNormal"><a href="http://blogs.msdn.com/b/petersad/archive/2009/11/13/how-to-install-sql-server-2008-r2-express-edition-november-ctp.aspx">http://blogs.msdn.com/b/petersad/archive/2009/11/13/how-to-install-sql-server-2008-r2-express-edition-november-ctp.aspx</a></p>
<h2>Running the Sample</h2>
<p class="MsoNormal">Step 1. You can run this sample by logging into SQL Azure or local SQL Server.</p>
<p class="MsoNormal">[NOTE: Since the SQL Azure only supports the SQL Server Authentication Mode, if you run this sample against your local server you should configure SQL Server to accept SQL Authentication mode.]
</p>
<p class="MsoNormal">Step 2. Create two databases (either on SQL Azure or local Server): &quot;Courses&quot; and &quot;Students&quot;, then execute the scripts in Course.sql and Student.sql respectively.
</p>
<p class="MsoNormal">Step 3. Execute the scripts in StudentSQLQuery.sql on database &quot;Students&quot; and execute CourseSQLQuery.sql on database &quot;Courses&quot; to generate some trivial data for testing purpose.
</p>
<p class="MsoNormal">Step 4. Create another two databases, and name them &quot;Database001&quot;, &quot;Database002&quot;.
</p>
<p class="MsoNormal">Step 5. Execute the scripts in Accounts.sql on both databases &quot;Database001&quot; and &quot;Database002&quot;. Then Database001 and Database002 will both have a same schema table &quot;Accounts&quot;.
</p>
<p class="MsoNormal">Step 6. You have to modify the connectionString in Web.config to make them point to your SQL Azure server or local SQL server.
</p>
<p class="MsoNormal">Step 7. Build the solution and make sure the Default.aspx is the Startup Page, then run it.</p>
<h2>Using the Code</h2>
<p class="MsoNormal">Step 1. Please refer to Demo section to create databases/tables.
</p>
<p class="MsoNormal">Step 2. Create a Windows Azure project and add an ASP.NET Web Role with the default name.
</p>
<p class="MsoNormal">Step 3. Add two WebForms, name them &quot;Vertical Partitioning.aspx&quot;, &quot;Horizontal Partitioning.aspx&quot;.
</p>
<p class="MsoNormal">Step 4. In Default.aspx, add two HyperLink controls and set the
</p>
<p class="MsoNormal" style="text-indent:.5in">NavigateUrl=&quot;~/Vertical Partitioning.aspx&quot; and
</p>
<p class="MsoNormal" style="text-indent:.5in">NavigateUrl=&quot;~/Horizontal Partitioning.aspx&quot; respectively.
</p>
<p class="MsoNormal">Step 5. In Vertical Partitioning.aspx, add three GridViews, use GridView Tasks Wizard to set data source for GridView1 and GridView2.<span style="">&nbsp;
</span>GridView1's DataSource should be Students.Student table. GridView2's DataSource should be Courses.Course table. For more detail, you can look into Vertical Partitioning.aspx.
</p>
<p class="MsoNormal">Step 6. In Vertical Partitioning.aspx.cs, set the data source for GridView3 as follows.
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>
<pre class="hidden">
// Load data.
var studentDataReader = SQLAzureHelper.ExecuteReader(
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ConfigurationManager.ConnectionStrings[&quot;StudentsConnectionString&quot;].ConnectionString,
&nbsp;&nbsp;&nbsp; sqlConnection =&gt;
&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SqlCommand sqlCommand =
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; new SqlCommand(&quot;SELECT StudentId, StudentName FROM Student&quot;,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sqlConnection);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return (sqlCommand.ExecuteReader());
&nbsp;&nbsp;&nbsp; });


var courseDataReader = SQLAzureHelper.ExecuteReader(
&nbsp;&nbsp;&nbsp; ConfigurationManager.ConnectionStrings[&quot;CoursesConnectionString&quot;].ConnectionString,
&nbsp;&nbsp;&nbsp; sqlConnection =&gt;
&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SqlCommand sqlCommand =
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; new SqlCommand(&quot;SELECT CourseName, StudentId FROM Course&quot;,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sqlConnection);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return (sqlCommand.ExecuteReader());
&nbsp;&nbsp;&nbsp; });


// Join two tables on different SQL Azure databases using LINQ. 
var query =
&nbsp;&nbsp;&nbsp; from student in studentDataReader
&nbsp;&nbsp;&nbsp; join course in courseDataReader on
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (Int32)student[&quot;StudentId&quot;] equals (Int32)course[&quot;StudentId&quot;]
&nbsp;&nbsp;&nbsp; select new
&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CourseName = (string)course[&quot;CourseName&quot;],
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StudentName = (string)student[&quot;StudentName&quot;]
&nbsp;&nbsp;&nbsp; };


this.GridView3.DataSource = query;
this.GridView3.DataBind();

</pre>
<pre id="codePreview" class="csharp">
// Load data.
var studentDataReader = SQLAzureHelper.ExecuteReader(
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ConfigurationManager.ConnectionStrings[&quot;StudentsConnectionString&quot;].ConnectionString,
&nbsp;&nbsp;&nbsp; sqlConnection =&gt;
&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SqlCommand sqlCommand =
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; new SqlCommand(&quot;SELECT StudentId, StudentName FROM Student&quot;,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sqlConnection);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return (sqlCommand.ExecuteReader());
&nbsp;&nbsp;&nbsp; });


var courseDataReader = SQLAzureHelper.ExecuteReader(
&nbsp;&nbsp;&nbsp; ConfigurationManager.ConnectionStrings[&quot;CoursesConnectionString&quot;].ConnectionString,
&nbsp;&nbsp;&nbsp; sqlConnection =&gt;
&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SqlCommand sqlCommand =
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; new SqlCommand(&quot;SELECT CourseName, StudentId FROM Course&quot;,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sqlConnection);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return (sqlCommand.ExecuteReader());
&nbsp;&nbsp;&nbsp; });


// Join two tables on different SQL Azure databases using LINQ. 
var query =
&nbsp;&nbsp;&nbsp; from student in studentDataReader
&nbsp;&nbsp;&nbsp; join course in courseDataReader on
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (Int32)student[&quot;StudentId&quot;] equals (Int32)course[&quot;StudentId&quot;]
&nbsp;&nbsp;&nbsp; select new
&nbsp;&nbsp;&nbsp; {
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CourseName = (string)course[&quot;CourseName&quot;],
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StudentName = (string)student[&quot;StudentName&quot;]
&nbsp;&nbsp;&nbsp; };


this.GridView3.DataSource = query;
this.GridView3.DataBind();

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"></p>
<p class="MsoNormal">Step 7. In Horizontal Partioning.aspx, add two <span class="SpellE">
GridViews</span>, use <span class="SpellE">GridView</span> Tasks Wizard to set data source for GridView1 and GridView2.<span style="">&nbsp;
</span>GridView1's <span class="SpellE">DataSource</span> should be Database001.Accounts table. GridView2's
<span class="SpellE">DataSource</span> should be Database002.Accounts table. For more detail, you can look into Horizontal Partioning.aspx.</p>
<h2>More Information</h2>
<p class="MsoNormal">Development Considerations in SQL Azure </p>
<p class="MsoNormal"><a href="http://msdn.microsoft.com/en-us/library/ee730903.aspx">http://msdn.microsoft.com/en-us/library/ee730903.aspx</a>
</p>
<p class="MsoNormal">How to: Connect to SQL Azure through ASP.NET </p>
<p class="MsoNormal"><a href="http://msdn.microsoft.com/en-us/library/ee621781.aspx">http://msdn.microsoft.com/en-us/library/ee621781.aspx</a>
</p>
<p class="MsoNormal">Unique identifier and Clustered Indexes </p>
<p class="MsoNormal"><a href="http://blogs.msdn.com/b/sqlazure/archive/2010/05/05/10007304.aspx">http://blogs.msdn.com/b/sqlazure/archive/2010/05/05/10007304.aspx</a>
</p>
<p class="MsoNormal">Vertical Partitioning in SQL Azure: Part 1 </p>
<p class="MsoNormal"><a href="http://blogs.msdn.com/b/sqlazure/archive/2010/05/17/10014011.aspx">http://blogs.msdn.com/b/sqlazure/archive/2010/05/17/10014011.aspx</a>
</p>
<p class="MsoNormal">SQL Azure Horizontal Partitioning: Part 2 </p>
<p class="MsoNormal"><a href="http://blogs.msdn.com/b/sqlazure/archive/2010/06/24/10029719.aspx">http://blogs.msdn.com/b/sqlazure/archive/2010/06/24/10029719.aspx</a><br>
<br style="">
<br style="">
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>