# A Private Messages Module in ASP.NET Site (CSASPNETPrivateMessagesModule)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* ASP.NET
## Topics
* Module
## IsPublished
* True
## ModifiedDate
* 2012-12-12 10:04:19
## Description

<h1>A Private Messaging Module in ASP.NET Site (VBASPNETPrivateMessagesModule)</h1>
<h2>Introduction </h2>
<p class="MsoNormal">This sample shows how to create a private messaging module in an ASP.NET site. This module can
<a name="OLE_LINK3"></a><a name="OLE_LINK2"><span style="">base on </span></a>the ASP.NET Membership or other member systems. And it can be easily added to an existing ASP.NET Site.</p>
<h2>Running the Sample</h2>
<p class="MsoNormal">Please follow these demonstration steps below.</p>
<p class="MsoNormal">Step 1:&nbsp;Open the <span style="">VBASPNETPrivateMessagesModule</span>.sln. Expand the
<a name="OLE_LINK1"><span style="">VBASPNETPrivateMessagesModule</span> </a>web application.<span style=""> Right click CreateUser.aspx and choose &quot;View in Browser&quot; to create some test accounts.</span><span style="font-size:9.5pt; line-height:115%; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style=""></span></p>
<p class="MsoNormal">Step 2:<span style="">&nbsp; </span>Press Ctrl &#43; F5 to show the Default.aspx then login.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/72467/1/image.png" alt="" width="751" height="498" align="middle">
</span></p>
<p class="MsoNormal">Select message recipient then click the button &quot;Add to list&quot;.
</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/72468/1/image.png" alt="" width="512" height="328" align="middle">
</span></p>
<p class="MsoNormal">After typing the content and title, you can click the &quot;Send/Save Draft&quot; button to send/save the message.</p>
<p class="MsoNormal">Step 3:<span style="">&nbsp;&nbsp; </span>Click the link of &quot;Draft&quot;, &quot;Inbox&quot; or &quot;OutBox&quot;.<br>
<span style=""><img src="/site/view/file/72469/1/image.png" alt="" width="548" height="380" align="middle">
</span></p>
<p class="MsoNormal">Click the detail link.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/72470/1/image.png" alt="" width="445" height="192" align="middle">
</span></p>
<p class="MsoNormal">Click reply or reply all.</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/72471/1/image.png" alt="" width="535" height="339" align="middle">
</span></p>
<p class="MsoNormal">Reply or save draft.<br>
Step 4:<span style="">&nbsp;&nbsp; </span>Login with other account to receive the message.</p>
<p class="MsoNormal">Step 5:<span style="">&nbsp;&nbsp; </span>Validation finished.</p>
<h2>Using the Code</h2>
<p class="MsoNormal" style="">Code Logical: </p>
<p class="MsoNormal">Step 1. Create a new database in SQL Server. Name it as &quot;<span style="">MembershipProviderTest</span>&quot;.
<span style="">&nbsp;&nbsp; </span></p>
<p class="MsoNormal">Step 2. Use the command-line tool aspnet_regsql.exe (located in the Framework folder) to create the tables and procedures used by the
<span style="">Membership Provider</span>.</p>
<p class="MsoNormal" style="">Create a table for message, in this sample it is MessageTable. The definition of the message table as shown below:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>SQL</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">mysql</span>
<pre class="hidden">
CREATE TABLE [dbo].[MessageTable](
    [MessageID] [int] IDENTITY(1,1) NOT NULL,
    [FromUserId] [uniqueidentifier] NULL,
    [ToUserId] [uniqueidentifier] NULL,
    [Message] [nvarchar](200),
    [MessageTitle] [nvarchar](50),
    [CreateDate] [datetime] NOT NULL,
    [State] [tinyint] NULL
)

</pre>
<pre id="codePreview" class="mysql">
CREATE TABLE [dbo].[MessageTable](
    [MessageID] [int] IDENTITY(1,1) NOT NULL,
    [FromUserId] [uniqueidentifier] NULL,
    [ToUserId] [uniqueidentifier] NULL,
    [Message] [nvarchar](200),
    [MessageTitle] [nvarchar](50),
    [CreateDate] [datetime] NOT NULL,
    [State] [tinyint] NULL
)

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step 3. Create a Visual Basic &quot;ASP.NET Web Application&quot; in Visual Studio 20<span style="">12</span>. Name it as &quot;<span style="">VBASPNETPrivateMessagesModule</span>&quot;.
</p>
<p class="MsoNormal">Step 4. Add a master page. It is used to uniform page style and navigation. Use the master to create six Pages then rename them to &quot;CreateUser.aspx&quot;,&quot; Login.aspx&quot;,<br>
&quot;MessageList.aspx&quot;,&quot;<span style=""> <span style="color:black">itemdetail.aspx</span></span>&quot;,&quot;newitem.aspx&quot; and &quot;Default.aspx&quot;.<span style="">&nbsp;
</span>Add a CreateUserWizard Control to the CreateUser page, the code as shown below:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">html</span>
<pre class="hidden">
&lt;asp:CreateUserWizard ID=&quot;CreateUserWizard1&quot; runat=&quot;server&quot; ActiveStepIndex=&quot;0&quot; ContinueDestinationPageUrl=&quot;~/Default.aspx&quot;&gt;
       &lt;WizardSteps&gt;
         &lt;asp:CreateUserWizardStep ID=&quot;CreateUserWizardStep1&quot; runat=&quot;server&quot;&gt;
         &lt;/asp:CreateUserWizardStep&gt;
         &lt;asp:CompleteWizardStep ID=&quot;CompleteWizardStep1&quot; runat=&quot;server&quot;&gt;
         &lt;/asp:CompleteWizardStep&gt;
       &lt;/WizardSteps&gt;
     &lt;/asp:CreateUserWizard&gt;

</pre>
<pre id="codePreview" class="html">
&lt;asp:CreateUserWizard ID=&quot;CreateUserWizard1&quot; runat=&quot;server&quot; ActiveStepIndex=&quot;0&quot; ContinueDestinationPageUrl=&quot;~/Default.aspx&quot;&gt;
       &lt;WizardSteps&gt;
         &lt;asp:CreateUserWizardStep ID=&quot;CreateUserWizardStep1&quot; runat=&quot;server&quot;&gt;
         &lt;/asp:CreateUserWizardStep&gt;
         &lt;asp:CompleteWizardStep ID=&quot;CompleteWizardStep1&quot; runat=&quot;server&quot;&gt;
         &lt;/asp:CompleteWizardStep&gt;
       &lt;/WizardSteps&gt;
     &lt;/asp:CreateUserWizard&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Add a <span style="">Login Control to the Login page, the code as shown below:
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">html</span>
<pre class="hidden">
&lt;asp:Login ID=&quot;Login1&quot; runat=&quot;server&quot;&gt;
  &lt;/asp:Login&gt;

</pre>
<pre id="codePreview" class="html">
&lt;asp:Login ID=&quot;Login1&quot; runat=&quot;server&quot;&gt;
  &lt;/asp:Login&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step 5.<span style="">&nbsp; </span>Now, begin to edit the web.config.</p>
<p class="MsoNormal">First, configure the Connection Strings as follows; <span style="">
you can try the </span>connectionString1 <span style="">or </span>connectionString<span style="">2.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;connectionStrings&gt;
   &lt;!-- Clear the default connection. --&gt;
   &lt;clear/&gt;
   &lt;!-- Connect to the database in the App_Data folder --&gt;
   &lt;add name=&quot;LocalSqlServer&quot; connectionString=&quot;Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MembershipProviderTest.mdf;Integrated Security=True&quot; /&gt;
   &lt;!-- Connect to the database which has been attached to the database manager. --&gt;
   &lt;!--&lt;add name=&quot;LocalSqlServer&quot; connectionString=&quot;Data Source=.;Initial Catalog=D:\PROJECTDIR\NET\VBASPNETPrivateMessagesModule\VBASPNETMEMBERSHIPPROVIDER\APP_DATA\MEMBERSHIPPROVIDERTEST.MDF;Integrated Security=True&quot;/&gt;--&gt;
 &lt;/connectionStrings&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;connectionStrings&gt;
   &lt;!-- Clear the default connection. --&gt;
   &lt;clear/&gt;
   &lt;!-- Connect to the database in the App_Data folder --&gt;
   &lt;add name=&quot;LocalSqlServer&quot; connectionString=&quot;Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MembershipProviderTest.mdf;Integrated Security=True&quot; /&gt;
   &lt;!-- Connect to the database which has been attached to the database manager. --&gt;
   &lt;!--&lt;add name=&quot;LocalSqlServer&quot; connectionString=&quot;Data Source=.;Initial Catalog=D:\PROJECTDIR\NET\VBASPNETPrivateMessagesModule\VBASPNETMEMBERSHIPPROVIDER\APP_DATA\MEMBERSHIPPROVIDERTEST.MDF;Integrated Security=True&quot;/&gt;--&gt;
 &lt;/connectionStrings&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><br>
Second, configure the CreateUser pa<span style="">ge and </span><span style="">the
</span><span style="">security authentication mode:</span><span style=""> </span>
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;location path=&quot;CreateUser.aspx&quot;&gt;
   &lt;system.web&gt;
     &lt;authorization&gt;
       &lt;allow users=&quot;?&quot;/&gt;
     &lt;/authorization&gt;
   &lt;/system.web&gt;
 &lt;/location&gt;
&lt;authentication mode=&quot;Forms&quot;&gt;
       &lt;forms loginUrl=&quot;login.aspx&quot; name=&quot;.ASPXFORMSAUTH&quot;/&gt;
     &lt;/authentication&gt;
     &lt;authorization&gt;
       &lt;deny users=&quot;?&quot;/&gt;
     &lt;/authorization&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;location path=&quot;CreateUser.aspx&quot;&gt;
   &lt;system.web&gt;
     &lt;authorization&gt;
       &lt;allow users=&quot;?&quot;/&gt;
     &lt;/authorization&gt;
   &lt;/system.web&gt;
 &lt;/location&gt;
&lt;authentication mode=&quot;Forms&quot;&gt;
       &lt;forms loginUrl=&quot;login.aspx&quot; name=&quot;.ASPXFORMSAUTH&quot;/&gt;
     &lt;/authentication&gt;
     &lt;authorization&gt;
       &lt;deny users=&quot;?&quot;/&gt;
     &lt;/authorization&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style="">&nbsp;</span>Finally, configure the membership<span style=""> to
</span>AspNetSqlMembershipProvider<span style="">:</span><span style=""> </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;!--Build-in Provider Configuration--&gt;
     &lt;membership defaultProvider=&quot;AspNetSqlMembershipProvider&quot; userIsOnlineTimeWindow=&quot;15&quot;&gt;
       &lt;providers&gt;
       &lt;/providers&gt;
     &lt;/membership&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;!--Build-in Provider Configuration--&gt;
     &lt;membership defaultProvider=&quot;AspNetSqlMembershipProvider&quot; userIsOnlineTimeWindow=&quot;15&quot;&gt;
       &lt;providers&gt;
       &lt;/providers&gt;
     &lt;/membership&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step <span style="">6</span>. Create the helper class.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
'Sql connection.
   Public Shared connetionString As String = ConfigurationManager.ConnectionStrings(&quot;LocalSqlServer&quot;).ConnectionString


   ''' &lt;summary&gt;
   ''' Get UserName By ProviderUserKey
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;id&quot;&gt;ProviderUserKey&lt;/param&gt;
   ''' &lt;returns&gt;UserName&lt;/returns&gt;
   Public Shared Function getUserNameByProviderUserKey(id As String) As String
       ' UserName
       Dim strName As String = String.Empty


       ' Query string
       Dim queryString As String = &quot;SELECT UserName FROM [aspnet_Users] where UserID=@id&quot;


       '#Region &quot;database Operation&quot;
       Using connection As New SqlConnection(connetionString)
           Dim command As New SqlCommand(queryString, connection)
           Dim para2 As New SqlParameter(&quot;id&quot;, id)
           command.Parameters.Add(para2)
           connection.Open()
           Dim reader As SqlDataReader = command.ExecuteReader()
           If reader.HasRows Then
               reader.Read()
               strName = reader(0).ToString()
           End If
           reader.Close()
           connection.Close()
       End Using
       '#End Region


       Return strName
   End Function


   ''' &lt;summary&gt;
   ''' Get ProviderUserKey By UserName
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;strName&quot;&gt;UserName&lt;/param&gt;
   ''' &lt;returns&gt;ProviderUserKey&lt;/returns&gt;
   Public Shared Function getUserKeyByUserName(strName As String) As String
       ' ProviderUserKey
       Dim strUserKey As String = String.Empty


       ' Query string
       Dim queryString As String = &quot;SELECT UserID FROM [aspnet_Users] where UserName=@Name&quot;


       '#Region &quot;database Operation&quot;
       Using connection As New SqlConnection(connetionString)
           Dim command As New SqlCommand(queryString, connection)
           Dim para2 As New SqlParameter(&quot;Name&quot;, strName)
           command.Parameters.Add(para2)
           connection.Open()
           Dim reader As SqlDataReader = command.ExecuteReader()
           If reader.HasRows Then
               reader.Read()
               strUserKey = reader(0).ToString()
           End If
           reader.Close()
           connection.Close()
       End Using
       '#End Region


       Return strUserKey
   End Function

</pre>
<pre id="codePreview" class="vb">
'Sql connection.
   Public Shared connetionString As String = ConfigurationManager.ConnectionStrings(&quot;LocalSqlServer&quot;).ConnectionString


   ''' &lt;summary&gt;
   ''' Get UserName By ProviderUserKey
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;id&quot;&gt;ProviderUserKey&lt;/param&gt;
   ''' &lt;returns&gt;UserName&lt;/returns&gt;
   Public Shared Function getUserNameByProviderUserKey(id As String) As String
       ' UserName
       Dim strName As String = String.Empty


       ' Query string
       Dim queryString As String = &quot;SELECT UserName FROM [aspnet_Users] where UserID=@id&quot;


       '#Region &quot;database Operation&quot;
       Using connection As New SqlConnection(connetionString)
           Dim command As New SqlCommand(queryString, connection)
           Dim para2 As New SqlParameter(&quot;id&quot;, id)
           command.Parameters.Add(para2)
           connection.Open()
           Dim reader As SqlDataReader = command.ExecuteReader()
           If reader.HasRows Then
               reader.Read()
               strName = reader(0).ToString()
           End If
           reader.Close()
           connection.Close()
       End Using
       '#End Region


       Return strName
   End Function


   ''' &lt;summary&gt;
   ''' Get ProviderUserKey By UserName
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;strName&quot;&gt;UserName&lt;/param&gt;
   ''' &lt;returns&gt;ProviderUserKey&lt;/returns&gt;
   Public Shared Function getUserKeyByUserName(strName As String) As String
       ' ProviderUserKey
       Dim strUserKey As String = String.Empty


       ' Query string
       Dim queryString As String = &quot;SELECT UserID FROM [aspnet_Users] where UserName=@Name&quot;


       '#Region &quot;database Operation&quot;
       Using connection As New SqlConnection(connetionString)
           Dim command As New SqlCommand(queryString, connection)
           Dim para2 As New SqlParameter(&quot;Name&quot;, strName)
           command.Parameters.Add(para2)
           connection.Open()
           Dim reader As SqlDataReader = command.ExecuteReader()
           If reader.HasRows Then
               reader.Read()
               strUserKey = reader(0).ToString()
           End If
           reader.Close()
           connection.Close()
       End Using
       '#End Region


       Return strUserKey
   End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step <span style="">7</span>. The code of list page as shown below:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
      Dim currentUser As MembershipUser = Membership.GetUser()     ' Current User


      Dim strFlag As String = Request.QueryString(&quot;flag&quot;)
      If Not IsPostBack Then
          ' Query string
          Dim queryString As String = &quot;SELECT [MessageID], [FromUserId], [ToUserId], [Message], &quot; _
          & &quot;[CreateDate], [MessageTitle], [State] FROM [MessageTable]&quot;


          ' The status field has two values, the normal message is 1 while a draft is 0.
          Select Case strFlag
              Case &quot;0&quot;
                  ' Draft
                  queryString &#43;= &quot; where state=0 and FromUserId=@UserId&quot;
                  Exit Select
              Case &quot;1&quot;
                  ' Inbox
                  queryString &#43;= &quot; where state=1 and ToUserId=@UserId&quot;
                  Exit Select
              Case &quot;2&quot;
                  ' Outbox
                  queryString &#43;= &quot; where state=1 and FromUserId=@UserId&quot;
                  Exit Select
              Case Else
                  Exit Select
          End Select


          If Not String.IsNullOrEmpty(strFlag) Then
              Dim adapter As New SqlDataAdapter()
              Dim sqlData As New DataSet()


              Using connection As New SqlConnection(Common.connetionString)
                  ' Set query string
                  adapter.SelectCommand = New SqlCommand(queryString, connection)
                  Dim para As New SqlParameter(&quot;UserId&quot;, currentUser.ProviderUserKey)
                  adapter.SelectCommand.Parameters.Add(para)


                  ' Open connection
                  connection.Open()


                  ' Sql data is stored DataSet.
                  adapter.Fill(sqlData, &quot;MessageTable&quot;)


                  ' Close connection
                  connection.Close()
              End Using


              ' Bind datatable to GridView
              gdvView.DataSource = sqlData.Tables(0)
              gdvView.DataBind()


          End If
      End If
  End Sub

</pre>
<pre id="codePreview" class="vb">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
      Dim currentUser As MembershipUser = Membership.GetUser()     ' Current User


      Dim strFlag As String = Request.QueryString(&quot;flag&quot;)
      If Not IsPostBack Then
          ' Query string
          Dim queryString As String = &quot;SELECT [MessageID], [FromUserId], [ToUserId], [Message], &quot; _
          & &quot;[CreateDate], [MessageTitle], [State] FROM [MessageTable]&quot;


          ' The status field has two values, the normal message is 1 while a draft is 0.
          Select Case strFlag
              Case &quot;0&quot;
                  ' Draft
                  queryString &#43;= &quot; where state=0 and FromUserId=@UserId&quot;
                  Exit Select
              Case &quot;1&quot;
                  ' Inbox
                  queryString &#43;= &quot; where state=1 and ToUserId=@UserId&quot;
                  Exit Select
              Case &quot;2&quot;
                  ' Outbox
                  queryString &#43;= &quot; where state=1 and FromUserId=@UserId&quot;
                  Exit Select
              Case Else
                  Exit Select
          End Select


          If Not String.IsNullOrEmpty(strFlag) Then
              Dim adapter As New SqlDataAdapter()
              Dim sqlData As New DataSet()


              Using connection As New SqlConnection(Common.connetionString)
                  ' Set query string
                  adapter.SelectCommand = New SqlCommand(queryString, connection)
                  Dim para As New SqlParameter(&quot;UserId&quot;, currentUser.ProviderUserKey)
                  adapter.SelectCommand.Parameters.Add(para)


                  ' Open connection
                  connection.Open()


                  ' Sql data is stored DataSet.
                  adapter.Fill(sqlData, &quot;MessageTable&quot;)


                  ' Close connection
                  connection.Close()
              End Using


              ' Bind datatable to GridView
              gdvView.DataSource = sqlData.Tables(0)
              gdvView.DataBind()


          End If
      End If
  End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step <span style="">8</span>. The code of detail page as shown below:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim currentUser As MembershipUser
        ' Current User
        currentUser = Membership.GetUser()


        If Not String.IsNullOrEmpty(Request.QueryString(&quot;ID&quot;)) Then
            intId = CInt(Request.QueryString(&quot;ID&quot;))
            ' Query string
            Dim queryString As String = &quot;SELECT [MessageID], [FromUserId], [ToUserId], [Message], &quot; _
            & &quot;[CreateDate], [MessageTitle], [State] FROM [MessageTable] &quot; _
            & &quot; where MessageID=@id and (ToUserId=@userid or FromUserId=@userid)&quot;


            Using connection As New SqlConnection(Common.connetionString)
                ' sql command
                Dim command As New SqlCommand(queryString, connection)


                Dim para1 As New SqlParameter(&quot;id&quot;, intId)
                Dim para2 As New SqlParameter(&quot;userId&quot;, currentUser.ProviderUserKey)
                command.Parameters.Add(para1)
                command.Parameters.Add(para2)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    strFrom = reader(&quot;FromUserId&quot;).ToString()
                    strTitle = reader(&quot;MessageTitle&quot;).ToString()
                    strContent = reader(&quot;Message&quot;).ToString()


                    strTime = reader(&quot;CreateDate&quot;).ToString()
                End If
                reader.Close()




                queryString = &quot;SELECT ToUserId FROM MessageTable where CreateDate = @CreateDate&quot; _
                & &quot; AND FromUserId = @FromUserId&quot;
                para1 = New SqlParameter(&quot;CreateDate&quot;, Convert.ToDateTime(strTime))
                para2 = New SqlParameter(&quot;FromUserId&quot;, DirectCast(strFrom, Object))
                command.Parameters.Clear()
                command.CommandText = queryString
                command.Parameters.Add(para1)
                command.Parameters.Add(para2)
                reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        strTo &#43;= &quot;;&quot; & Common.getUserNameByProviderUserKey(reader(0).ToString())
                    End While
                End If
                If strTo.Length &gt; 0 Then
                    strTo = strTo.Substring(1)
                End If
                reader.Close()


                connection.Close()
            End Using
        End If


        ltrContent.Text = strContent
        ltrFrom.Text = Common.getUserNameByProviderUserKey(strFrom)
        ltrTo.Text = strTo
        ltrTime.Text = strTime
        ltrTitle.Text = strTitle
    End Sub


    Protected Sub btnReply_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect(&quot;NewItem.aspx?flag=1&rid=&quot; & intId)
    End Sub


    Protected Sub btnReplyAll_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect(&quot;NewItem.aspx?flag=2&rid=&quot; & intId)
    End Sub

</pre>
<pre id="codePreview" class="vb">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim currentUser As MembershipUser
        ' Current User
        currentUser = Membership.GetUser()


        If Not String.IsNullOrEmpty(Request.QueryString(&quot;ID&quot;)) Then
            intId = CInt(Request.QueryString(&quot;ID&quot;))
            ' Query string
            Dim queryString As String = &quot;SELECT [MessageID], [FromUserId], [ToUserId], [Message], &quot; _
            & &quot;[CreateDate], [MessageTitle], [State] FROM [MessageTable] &quot; _
            & &quot; where MessageID=@id and (ToUserId=@userid or FromUserId=@userid)&quot;


            Using connection As New SqlConnection(Common.connetionString)
                ' sql command
                Dim command As New SqlCommand(queryString, connection)


                Dim para1 As New SqlParameter(&quot;id&quot;, intId)
                Dim para2 As New SqlParameter(&quot;userId&quot;, currentUser.ProviderUserKey)
                command.Parameters.Add(para1)
                command.Parameters.Add(para2)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    strFrom = reader(&quot;FromUserId&quot;).ToString()
                    strTitle = reader(&quot;MessageTitle&quot;).ToString()
                    strContent = reader(&quot;Message&quot;).ToString()


                    strTime = reader(&quot;CreateDate&quot;).ToString()
                End If
                reader.Close()




                queryString = &quot;SELECT ToUserId FROM MessageTable where CreateDate = @CreateDate&quot; _
                & &quot; AND FromUserId = @FromUserId&quot;
                para1 = New SqlParameter(&quot;CreateDate&quot;, Convert.ToDateTime(strTime))
                para2 = New SqlParameter(&quot;FromUserId&quot;, DirectCast(strFrom, Object))
                command.Parameters.Clear()
                command.CommandText = queryString
                command.Parameters.Add(para1)
                command.Parameters.Add(para2)
                reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        strTo &#43;= &quot;;&quot; & Common.getUserNameByProviderUserKey(reader(0).ToString())
                    End While
                End If
                If strTo.Length &gt; 0 Then
                    strTo = strTo.Substring(1)
                End If
                reader.Close()


                connection.Close()
            End Using
        End If


        ltrContent.Text = strContent
        ltrFrom.Text = Common.getUserNameByProviderUserKey(strFrom)
        ltrTo.Text = strTo
        ltrTime.Text = strTime
        ltrTitle.Text = strTitle
    End Sub


    Protected Sub btnReply_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect(&quot;NewItem.aspx?flag=1&rid=&quot; & intId)
    End Sub


    Protected Sub btnReplyAll_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect(&quot;NewItem.aspx?flag=2&rid=&quot; & intId)
    End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step <span style="">9.</span> The code of new item page as shown below:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


       If Not String.IsNullOrEmpty(Request.QueryString(&quot;rid&quot;)) Then
           rid = CInt(Request.QueryString(&quot;rid&quot;))


           ' The flag of reply and reply all.
           Dim flag As String = Request.QueryString(&quot;flag&quot;)


           ' According to the flag, get the recipient list
           Select Case flag
               Case &quot;1&quot;
                   ' reply
                   GetBasicInfo()
                   strTo = Common.getUserNameByProviderUserKey(strFrom)
                   Exit Select
               Case &quot;2&quot;
                   ' replyall
                   GetBasicInfo()
                   GetReplyAllTo()
                   Exit Select
               Case Else
                   Exit Select
           End Select


           strContent = &quot;From: &quot; & Common.getUserNameByProviderUserKey(strFrom) & vbLf & &quot;Sent: &quot; _
           & strTime & vbLf & &quot;To: &quot; & strTo & vbLf & &quot;Title: &quot; & strTitle & vbLf & &quot;Content: &quot; & strContent


           strTitle = &quot;Re:&quot; & strTitle
       End If


       If Not IsPostBack Then
           BindUser()


           txtContent.Text = strContent
           txtTo.Text = strTo
           txtTitle.Text = strTitle
       End If
   End Sub


   ''' &lt;summary&gt;
   ''' Get recipient list of reply all
   ''' &lt;/summary&gt;
   Private Sub GetReplyAllTo()
       Using connection As New SqlConnection(Common.connetionString)
           queryString = &quot;SELECT ToUserId from MessageTable where CreateDate=@create and FromUserId=@FromUserId&quot;
           command = New SqlCommand(queryString, connection)
           para1 = New SqlParameter(&quot;create&quot;, strTime)
           para2 = New SqlParameter(&quot;FromUserId&quot;, strFrom)
           command.Parameters.Clear()
           command.CommandText = queryString
           command.Parameters.Add(para1)
           command.Parameters.Add(para2)


           connection.Open()
           reader = command.ExecuteReader()
           If reader.HasRows Then
               While reader.Read()
                     strTo &#43;= &quot;;&quot; & Common.getUserNameByProviderUserKey(reader(0).ToString())
               End While
           End If
           If strTo.Length &gt; 0 Then
               strTo = strTo.Substring(1)
           End If
           reader.Close()
           connection.Close()
       End Using
   End Sub


   ''' &lt;summary&gt;
   ''' Get the basic infomation of the message
   ''' &lt;/summary&gt;
   Private Sub GetBasicInfo()
       Dim currentUser As MembershipUser
       ' Current User
       currentUser = Membership.GetUser()


       ' Query string
       queryString = &quot;SELECT [MessageID], [FromUserId], [ToUserId], [Message], [CreateDate],&quot; _
           & &quot; [MessageTitle], [State] FROM [MessageTable] &quot; _
           & &quot;where MessageID=@id and (ToUserId=@userid or FromUserId=@userid)&quot;
       Using connection As New SqlConnection(Common.connetionString)
           command = New SqlCommand(queryString, connection)
           para1 = New SqlParameter(&quot;id&quot;, rid)
           para2 = New SqlParameter(&quot;userId&quot;, currentUser.ProviderUserKey)
           command.Parameters.Add(para1)
           command.Parameters.Add(para2)
           connection.Open()
           reader = command.ExecuteReader()
           If reader.HasRows Then
               reader.Read()
               strFrom = reader(&quot;FromUserId&quot;).ToString()
               strTitle = reader(&quot;MessageTitle&quot;).ToString()
               strContent = reader(&quot;Message&quot;).ToString()
               strTime = reader(&quot;CreateDate&quot;).ToString()
           End If
           reader.Close()
           connection.Close()
       End Using
   End Sub




   ''' &lt;summary&gt;
   ''' Get all MembershipUser
   ''' &lt;/summary&gt;
   Private Sub BindUser()
       Dim muc As MembershipUserCollection = Membership.GetAllUsers()
       chlUser.DataSource = muc
       chlUser.DataBind()
   End Sub


   Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
       Dim strTo As String = String.Empty


       ' Loop the users and add the selected user to recipient list
       For Each item As ListItem In Me.chlUser.Items
           If item.Selected Then
              strTo &#43;= &quot;;&quot; & item.Text
           End If
       Next


       If strTo.Length &gt; 0 Then
           txtTo.Text = strTo.Substring(1)
       End If
   End Sub


   ' Send message
   Protected Sub btnEnter_Click(ByVal sender As Object, ByVal e As EventArgs)
       If IsValid Then
           SaveToDB()
       End If
   End Sub


   ''' &lt;summary&gt;
   ''' Save the message to Database 
   ''' &lt;/summary&gt;
   Private Sub SaveToDB()
       Dim strSql As String = &quot;&quot;
       ' Get recipient list
       Dim tos As String() = txtTo.Text.Split(&quot;;&quot;c)


       ' Save message for everyone in the recipient list
       For i As Integer = 0 To tos.Length - 1
           strSql &#43;= &quot;insert into MessageTable(FromUserId,ToUserId,Message,MessageTitle,CreateDate,state)&quot; _
         & &quot; values('&quot; & Membership.GetUser().ProviderUserKey.ToString() _
         & &quot;','&quot; & Common.getUserKeyByUserName(tos(i)) & &quot;','&quot; & txtContent.Text.Trim() _
         & &quot;','&quot; & txtTitle.Text.Trim() & &quot;','&quot; & DateTime.Now.ToString() & &quot;',&quot; & state & &quot;);&quot;
       Next


       Using connection As New SqlConnection(Common.connetionString)
           connection.Open()
           Dim tran As SqlTransaction = connection.BeginTransaction()
           Try


               Dim cmd As New SqlCommand(strSql, connection, tran)
               cmd.ExecuteNonQuery()
               tran.Commit()
           Catch e As Exception
               tran.Rollback()
           Finally
               connection.Close()
               Response.Redirect(&quot;messagelist.aspx?flag=2&quot;)
           End Try
       End Using
   End Sub




   ''' &lt;summary&gt;
   ''' save draft
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
   ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
   Protected Sub btnDraft_Click(ByVal sender As Object, ByVal e As EventArgs)
       state = 0
       ' This is the value of draft
       SaveToDB()
   End Sub

</pre>
<pre id="codePreview" class="vb">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


       If Not String.IsNullOrEmpty(Request.QueryString(&quot;rid&quot;)) Then
           rid = CInt(Request.QueryString(&quot;rid&quot;))


           ' The flag of reply and reply all.
           Dim flag As String = Request.QueryString(&quot;flag&quot;)


           ' According to the flag, get the recipient list
           Select Case flag
               Case &quot;1&quot;
                   ' reply
                   GetBasicInfo()
                   strTo = Common.getUserNameByProviderUserKey(strFrom)
                   Exit Select
               Case &quot;2&quot;
                   ' replyall
                   GetBasicInfo()
                   GetReplyAllTo()
                   Exit Select
               Case Else
                   Exit Select
           End Select


           strContent = &quot;From: &quot; & Common.getUserNameByProviderUserKey(strFrom) & vbLf & &quot;Sent: &quot; _
           & strTime & vbLf & &quot;To: &quot; & strTo & vbLf & &quot;Title: &quot; & strTitle & vbLf & &quot;Content: &quot; & strContent


           strTitle = &quot;Re:&quot; & strTitle
       End If


       If Not IsPostBack Then
           BindUser()


           txtContent.Text = strContent
           txtTo.Text = strTo
           txtTitle.Text = strTitle
       End If
   End Sub


   ''' &lt;summary&gt;
   ''' Get recipient list of reply all
   ''' &lt;/summary&gt;
   Private Sub GetReplyAllTo()
       Using connection As New SqlConnection(Common.connetionString)
           queryString = &quot;SELECT ToUserId from MessageTable where CreateDate=@create and FromUserId=@FromUserId&quot;
           command = New SqlCommand(queryString, connection)
           para1 = New SqlParameter(&quot;create&quot;, strTime)
           para2 = New SqlParameter(&quot;FromUserId&quot;, strFrom)
           command.Parameters.Clear()
           command.CommandText = queryString
           command.Parameters.Add(para1)
           command.Parameters.Add(para2)


           connection.Open()
           reader = command.ExecuteReader()
           If reader.HasRows Then
               While reader.Read()
                     strTo &#43;= &quot;;&quot; & Common.getUserNameByProviderUserKey(reader(0).ToString())
               End While
           End If
           If strTo.Length &gt; 0 Then
               strTo = strTo.Substring(1)
           End If
           reader.Close()
           connection.Close()
       End Using
   End Sub


   ''' &lt;summary&gt;
   ''' Get the basic infomation of the message
   ''' &lt;/summary&gt;
   Private Sub GetBasicInfo()
       Dim currentUser As MembershipUser
       ' Current User
       currentUser = Membership.GetUser()


       ' Query string
       queryString = &quot;SELECT [MessageID], [FromUserId], [ToUserId], [Message], [CreateDate],&quot; _
           & &quot; [MessageTitle], [State] FROM [MessageTable] &quot; _
           & &quot;where MessageID=@id and (ToUserId=@userid or FromUserId=@userid)&quot;
       Using connection As New SqlConnection(Common.connetionString)
           command = New SqlCommand(queryString, connection)
           para1 = New SqlParameter(&quot;id&quot;, rid)
           para2 = New SqlParameter(&quot;userId&quot;, currentUser.ProviderUserKey)
           command.Parameters.Add(para1)
           command.Parameters.Add(para2)
           connection.Open()
           reader = command.ExecuteReader()
           If reader.HasRows Then
               reader.Read()
               strFrom = reader(&quot;FromUserId&quot;).ToString()
               strTitle = reader(&quot;MessageTitle&quot;).ToString()
               strContent = reader(&quot;Message&quot;).ToString()
               strTime = reader(&quot;CreateDate&quot;).ToString()
           End If
           reader.Close()
           connection.Close()
       End Using
   End Sub




   ''' &lt;summary&gt;
   ''' Get all MembershipUser
   ''' &lt;/summary&gt;
   Private Sub BindUser()
       Dim muc As MembershipUserCollection = Membership.GetAllUsers()
       chlUser.DataSource = muc
       chlUser.DataBind()
   End Sub


   Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
       Dim strTo As String = String.Empty


       ' Loop the users and add the selected user to recipient list
       For Each item As ListItem In Me.chlUser.Items
           If item.Selected Then
              strTo &#43;= &quot;;&quot; & item.Text
           End If
       Next


       If strTo.Length &gt; 0 Then
           txtTo.Text = strTo.Substring(1)
       End If
   End Sub


   ' Send message
   Protected Sub btnEnter_Click(ByVal sender As Object, ByVal e As EventArgs)
       If IsValid Then
           SaveToDB()
       End If
   End Sub


   ''' &lt;summary&gt;
   ''' Save the message to Database 
   ''' &lt;/summary&gt;
   Private Sub SaveToDB()
       Dim strSql As String = &quot;&quot;
       ' Get recipient list
       Dim tos As String() = txtTo.Text.Split(&quot;;&quot;c)


       ' Save message for everyone in the recipient list
       For i As Integer = 0 To tos.Length - 1
           strSql &#43;= &quot;insert into MessageTable(FromUserId,ToUserId,Message,MessageTitle,CreateDate,state)&quot; _
         & &quot; values('&quot; & Membership.GetUser().ProviderUserKey.ToString() _
         & &quot;','&quot; & Common.getUserKeyByUserName(tos(i)) & &quot;','&quot; & txtContent.Text.Trim() _
         & &quot;','&quot; & txtTitle.Text.Trim() & &quot;','&quot; & DateTime.Now.ToString() & &quot;',&quot; & state & &quot;);&quot;
       Next


       Using connection As New SqlConnection(Common.connetionString)
           connection.Open()
           Dim tran As SqlTransaction = connection.BeginTransaction()
           Try


               Dim cmd As New SqlCommand(strSql, connection, tran)
               cmd.ExecuteNonQuery()
               tran.Commit()
           Catch e As Exception
               tran.Rollback()
           Finally
               connection.Close()
               Response.Redirect(&quot;messagelist.aspx?flag=2&quot;)
           End Try
       End Using
   End Sub




   ''' &lt;summary&gt;
   ''' save draft
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
   ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
   Protected Sub btnDraft_Click(ByVal sender As Object, ByVal e As EventArgs)
       state = 0
       ' This is the value of draft
       SaveToDB()
   End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step <span style="">10</span>. When targeting .NET 4.5 we enable Unobtrusive Validation by default. You need to have jQuery in your project and have something like this in Global.asax to register jQuery properly:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Dim myScriptResDef As New ScriptResourceDefinition()
       myScriptResDef.Path = &quot;~/JS/jquery-1.4.1.js&quot;
       myScriptResDef.DebugPath = &quot;~/JS/jquery-1.4.1.js&quot;
       myScriptResDef.CdnPath = &quot;http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.min.js&quot;
       myScriptResDef.CdnDebugPath = &quot;http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.js&quot;
       ScriptManager.ScriptResourceMapping.AddDefinition(&quot;jquery&quot;, Nothing, myScriptResDef) 

</pre>
<pre id="codePreview" class="vb">
Dim myScriptResDef As New ScriptResourceDefinition()
       myScriptResDef.Path = &quot;~/JS/jquery-1.4.1.js&quot;
       myScriptResDef.DebugPath = &quot;~/JS/jquery-1.4.1.js&quot;
       myScriptResDef.CdnPath = &quot;http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.min.js&quot;
       myScriptResDef.CdnDebugPath = &quot;http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.js&quot;
       ScriptManager.ScriptResourceMapping.AddDefinition(&quot;jquery&quot;, Nothing, myScriptResDef) 

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Add global.asax item in your project and add above code to Application_Start. Replacing the version of jQuery with the version you are using.<br>
Step <span style="">11</span>. Build the application<span style="">,</span> and then it can be debugged.</p>
<h2>More Information</h2>
<p class="MsoNormal">SqlMembershipProvider Class<br>
<a href="http://msdn.microsoft.com/en-us/library/system.web.security.sqlmembershipprovider.aspx">http://msdn.microsoft.com/en-us/library/system.web.security.sqlmembershipprovider.aspx</a><br>
Membership Class<br>
<a href="http://msdn.microsoft.com/en-us/library/system.web.security.membership.aspx">http://msdn.microsoft.com/en-us/library/system.web.security.membership.aspx</a></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>
