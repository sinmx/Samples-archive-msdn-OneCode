# Get online users in ASP.NET (VBASPNETCurrentOnlineUserList)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* ASP.NET
## Topics
* Session
## IsPublished
* True
## ModifiedDate
* 2012-12-03 08:02:18
## Description

<h1>Get online users in ASP.NET<span style=""> </span>without using membership provider (<span class="SpellE"><span class="GramE">VBASPNETCurrentOnlineUserList</span></span><span class="GramE"> )</span></h1>
<h2>Introduction</h2>
<p class="MsoNormal">The Membership.GetNumberOfUsersOnline Method can get the number of online users,however many asp.net projects are not using membership.This project shows how to display a list of current online users' information without using membership
 provider.<span style=""> </span></p>
<h2>Running the Sample</h2>
<p class="MsoNormal">Step1: Browse the Login.aspx page from the sample and you will find two textboxes which used to let user input &quot;UserName&quot; and &quot;TrueName&quot; and a<span style="">
</span>button which used to sign in.<span style=""> </span></p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/71731/1/image.png" alt="" width="295" height="122" align="middle">
</span><span style=""><br>
</span>Step2: Enter &quot;UserName&quot; and &quot;TrueName&quot; in textboxes and click the sign in button.<span style="">
</span>If user do not enter all the textboxes before clicking the sign in<span style="">
</span>button,<span style=""> </span>page will shows the error message under the button.<span style=""><br>
</span>Step3: After user sign in,<span style=""> </span>the page will redirect to CurrentOnlineUserList.aspx<span style="">
</span>page.<span style=""> </span>There is a gridview control which used to show the information of current on line users and under the gridview contorl,<span style="">
</span>there is a hyper<span style=""> </span>link which used to redirect user to sign out page.<span style=""><br>
<span style=""><img src="/site/view/file/71732/1/image.png" alt="" width="1357" height="119" align="middle">
</span><br>
</span>Step4: Browse the Login.aspx page again (It is best to browse the page on another<span style="">
</span>computer), sign in another user. The gridview will show two pieces information of<span style="">
</span>current online users in CurrentOnlineUserList.aspx page.<span style=""><br>
</span>Step5: If you browse the Login.aspx page at the same computer.You can refresh the<span style="">
</span>CurrentOnlineUserList.aspx page after one minute.The remaining number of the<span style="">
</span>current online users will become one.The gridview will just show the information<span style="">
</span>of user who is login later.<span style=""><br>
</span>Step6: If you browse the login.aspx page and sign in at the different computer,<span style="">
</span>please close the page at one of the computers,and at the other computer please<span style="">
</span>refresh the CurrentOnlineUserList.aspx page after one minute.You will see there is<span style="">
</span>only one record in gridview control.<span style=""><br>
</span>Step6: You can also try to close the page in any other ways after sign in.<span style="">
</span>Then refresh the remain page after one minute,for my experience ,you can also get the list of current on line users.<span style="">
</span></p>
<h2>Using the Code</h2>
<p class="MsoNormal">Step1: Create a <span style="">VB.NET</span> ASP.NET Empty Web Application in Visual Studio 2012.<span style=""><br>
</span>Step2: Add a class file and name it '<span class="SpellE">UserEntity</span>'.<span style="">
</span>You can find the complete code in <span class="SpellE">UserEntity.<span style="">vb</span></span> file.<span style=""><br>
</span>Step3: Add a class file and name it '<span class="SpellE">DataTableForCurrentOnlineUser</span>'. It is used to initialize the
<span class="SpellE">datatable</span> which store the information of current online user.<span style=""> You can find the complete code in
<span class="SpellE">DataTableForCurrentOnlineUser.vb</span> file.<br>
</span>Step4: Add a class file and name it '<span class="SpellE">CheckUserOnline</span>'. It is used to add JavaScript code to the page.<span style="">
</span>The JavaScript function can check the user's<span style=""> </span>active time and post a request to the CheckUserOnlinePage.aspx page.<span style="">
</span>The project will automatically delete the offline users'<span style=""> </span>
record from user table by checking the last active time.<span style=""> You can find the complete code in
<span class="SpellE">CheckUserOnline.vb</span> file.<br>
</span>Step5: Add a Login page into the Web Application.<span style=""><br>
</span>Step6: Add two textboxes,<span style=""> </span>three labels and a button into the page as the following HTML code.<span style="">
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">html</span>
<pre class="hidden">
&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
&lt;head id=&quot;Head1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; &lt;title&gt;&lt;/title&gt;
&lt;/head&gt;
&lt;body&gt;
&nbsp;&nbsp;&nbsp; &lt;form id=&quot;form1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; <div style="text-align:center">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <table style="width:50%">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tbody><tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 &lt;asp:Label ID=&quot;lbUserName&quot; runat=&quot;server&quot; Text=&quot;UserName:&quot;&gt;&lt;/asp:Label&gt;&lt;asp:TextBox &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID=&quot;tbUserName&quot; runat=&quot;server&quot;&gt;&lt;/asp:TextBox&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:Label
 ID=&quot;lbTrueName&quot; runat=&quot;server&quot; Text=&quot;TrueName:&quot;&gt;&lt;/asp:Label&gt;&lt;asp:TextBox &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID=&quot;tbTrueName&quot; runat=&quot;server&quot;&gt;&lt;/asp:TextBox&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 &lt;asp:Button ID=&quot;btnLogin&quot; runat=&quot;server&quot; Text=&quot;Sign in&quot; OnClick=&quot;btnLogin_Click&quot; /&gt;<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:Label ID=&quot;lbMessage&quot; runat=&quot;server&quot; Text=&quot;Label&quot; Visible=&quot;False&quot; ForeColor=&quot;Red&quot;&gt;&lt;/asp:Label&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tbody></table>
&nbsp;&nbsp;&nbsp; </div>
&nbsp;&nbsp;&nbsp; &lt;/form&gt;
&lt;/body&gt;
&lt;/html&gt;

</pre>
<pre id="codePreview" class="html">
&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
&lt;head id=&quot;Head1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; &lt;title&gt;&lt;/title&gt;
&lt;/head&gt;
&lt;body&gt;
&nbsp;&nbsp;&nbsp; &lt;form id=&quot;form1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; <div style="text-align:center">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <table style="width:50%">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tbody><tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 &lt;asp:Label ID=&quot;lbUserName&quot; runat=&quot;server&quot; Text=&quot;UserName:&quot;&gt;&lt;/asp:Label&gt;&lt;asp:TextBox &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID=&quot;tbUserName&quot; runat=&quot;server&quot;&gt;&lt;/asp:TextBox&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:Label
 ID=&quot;lbTrueName&quot; runat=&quot;server&quot; Text=&quot;TrueName:&quot;&gt;&lt;/asp:Label&gt;&lt;asp:TextBox &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID=&quot;tbTrueName&quot; runat=&quot;server&quot;&gt;&lt;/asp:TextBox&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 &lt;asp:Button ID=&quot;btnLogin&quot; runat=&quot;server&quot; Text=&quot;Sign in&quot; OnClick=&quot;btnLogin_Click&quot; /&gt;<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:Label ID=&quot;lbMessage&quot; runat=&quot;server&quot; Text=&quot;Label&quot; Visible=&quot;False&quot; ForeColor=&quot;Red&quot;&gt;&lt;/asp:Label&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tbody></table>
&nbsp;&nbsp;&nbsp; </div>
&nbsp;&nbsp;&nbsp; &lt;/form&gt;
&lt;/body&gt;
&lt;/html&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step7: Open the <span class="SpellE">Login.aspx.<span style="">vb</span></span> file<span style=""> to finish the Login function as follows</span>.<span style="">
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _error As String = &quot;&quot;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Check the value of user's input data.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If check_text(_error) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' information of current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onLineTable As New DataTableForCurrentOnlineUser()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' An instance of user's entity.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _user As New UserEntity()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.Ticket = DateTime.Now.ToString(&quot;yyyyMMddHHmmss&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.UserName = tbUserName.Text.Trim()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.TrueName = tbTrueName.Text.Trim()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.ClientIP = Me.Request.UserHostAddress
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;_user.RoleID = &quot;MingXuGroup&quot;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Use session variable to store the ticket.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.Session(&quot;Ticket&quot;) = _user.Ticket


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Log in.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _onLineTable.Login(_user, True)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Redirect(&quot;CurrentOnlineUserList.aspx&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.lbMessage.Visible = True
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.lbMessage.Text = _error
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub
&nbsp;&nbsp; Public Function check_text(ByRef errormessage As String) As Boolean
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; errormessage = &quot;&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Me.tbUserName.Text.Trim() = &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; errormessage = &quot;Please enter the username&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return False
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Me.tbTrueName.Text.Trim() = &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; errormessage = &quot;Please enter the truename&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return False
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return True
&nbsp;&nbsp; End Function

</pre>
<pre id="codePreview" class="vb">
Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _error As String = &quot;&quot;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Check the value of user's input data.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If check_text(_error) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' information of current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onLineTable As New DataTableForCurrentOnlineUser()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' An instance of user's entity.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _user As New UserEntity()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.Ticket = DateTime.Now.ToString(&quot;yyyyMMddHHmmss&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.UserName = tbUserName.Text.Trim()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.TrueName = tbTrueName.Text.Trim()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _user.ClientIP = Me.Request.UserHostAddress
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;_user.RoleID = &quot;MingXuGroup&quot;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Use session variable to store the ticket.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.Session(&quot;Ticket&quot;) = _user.Ticket


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Log in.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _onLineTable.Login(_user, True)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Redirect(&quot;CurrentOnlineUserList.aspx&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.lbMessage.Visible = True
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.lbMessage.Text = _error
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub
&nbsp;&nbsp; Public Function check_text(ByRef errormessage As String) As Boolean
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; errormessage = &quot;&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Me.tbUserName.Text.Trim() = &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; errormessage = &quot;Please enter the username&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return False
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Me.tbTrueName.Text.Trim() = &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; errormessage = &quot;Please enter the truename&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return False
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return True
&nbsp;&nbsp; End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step8: Add a <span class="SpellE">CurrentOnlineUserList</span> web page into the Web Application.<span style=""> T</span>his page is used to show the current online user list.<span style=""><br>
</span>Step9: Add a <span class="SpellE"><span style="">G</span>rid<span style="">V</span>iew</span> control and a hyperlink into the page as the following HTML code.<span style="">
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">html</span>
<pre class="hidden">
&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
&lt;head id=&quot;Head1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; &lt;title&gt;&lt;/title&gt;
&lt;/head&gt;
&lt;body&gt;
&nbsp;&nbsp;&nbsp; &lt;form id=&quot;form1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; <div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;cc1:CheckUserOnline ID=&quot;CheckUserOnline1&quot; runat=&quot;server&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <table border="1" style="width:98%; height:100%">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tbody><tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 Current Online User List &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:GridView ID=&quot;gvUserList&quot; runat=&quot;server&quot; Width=&quot;98%&quot;&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/asp:GridView&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;asp:HyperLink ID=&quot;hlk&quot; runat=&quot;server&quot; NavigateUrl=&quot;~/LogOut.aspx&quot;&gt;sign out&lt;/asp:HyperLink&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tbody></table>
&nbsp;&nbsp;&nbsp; </div>
&nbsp;&nbsp;&nbsp; &lt;/form&gt;
&lt;/body&gt;
&lt;/html&gt;

</pre>
<pre id="codePreview" class="html">
&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
&lt;head id=&quot;Head1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; &lt;title&gt;&lt;/title&gt;
&lt;/head&gt;
&lt;body&gt;
&nbsp;&nbsp;&nbsp; &lt;form id=&quot;form1&quot; runat=&quot;server&quot;&gt;
&nbsp;&nbsp;&nbsp; <div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;cc1:CheckUserOnline ID=&quot;CheckUserOnline1&quot; runat=&quot;server&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <table border="1" style="width:98%; height:100%">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tbody><tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 Current Online User List &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;asp:GridView ID=&quot;gvUserList&quot; runat=&quot;server&quot; Width=&quot;98%&quot;&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/asp:GridView&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <td style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;asp:HyperLink ID=&quot;hlk&quot; runat=&quot;server&quot; NavigateUrl=&quot;~/LogOut.aspx&quot;&gt;sign out&lt;/asp:HyperLink&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tr>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </tbody></table>
&nbsp;&nbsp;&nbsp; </div>
&nbsp;&nbsp;&nbsp; &lt;/form&gt;
&lt;/body&gt;
&lt;/html&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step10: Open the code <span style="">file</span> to write <span class="SpellE">
CheckLogin</span> function.You can find the complete version in the <span class="SpellE">
CurrentOnlineUserList.aspx.<span style="">vb</span></span> file.<span style=""> </span>
</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Public Sub CheckLogin()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _userticket As String = &quot;&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Session(&quot;Ticket&quot;) IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _userticket = Session(&quot;Ticket&quot;).ToString()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If _userticket &lt;&gt; &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the information
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' of current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onlinetable As New DataTableForCurrentOnlineUser()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Check whether the user is online by using ticket.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If _onlinetable.IsOnline_byTicket(Me.Session(&quot;Ticket&quot;).ToString()) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Update the last active time.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _onlinetable.ActiveTime(Session(&quot;Ticket&quot;).ToString())


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Bind the datatable which used to store the information of 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;' current online user to gridview control.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvUserList.DataSource = _onlinetable.ActiveUsers
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvUserList.DataBind()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' If the current User is not exist in the table,then redirect
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' the page to LogoOut.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Redirect(&quot;LogOut.aspx&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Redirect(&quot;Login.aspx&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp; End Sub

</pre>
<pre id="codePreview" class="vb">
Public Sub CheckLogin()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _userticket As String = &quot;&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Session(&quot;Ticket&quot;) IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _userticket = Session(&quot;Ticket&quot;).ToString()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If _userticket &lt;&gt; &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the information
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' of current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onlinetable As New DataTableForCurrentOnlineUser()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Check whether the user is online by using ticket.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If _onlinetable.IsOnline_byTicket(Me.Session(&quot;Ticket&quot;).ToString()) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Update the last active time.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _onlinetable.ActiveTime(Session(&quot;Ticket&quot;).ToString())


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Bind the datatable which used to store the information of 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;' current online user to gridview control.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvUserList.DataSource = _onlinetable.ActiveUsers
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvUserList.DataBind()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' If the current User is not exist in the table,then redirect
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' the page to LogoOut.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Redirect(&quot;LogOut.aspx&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Redirect(&quot;Login.aspx&quot;)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp; End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step11: Add a Logout web page into the Web Application.<span style=""><br>
</span>Step12: Add a hyperlink into the page as the following HTML code.<span style="">
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">html</span>
<pre class="hidden">
&lt;asp:HyperLink ID=&quot;HyperLink1&quot; runat=&quot;server&quot; NavigateUrl=&quot;~/Login.aspx&quot;&gt;
Sign in again&lt;/asp:HyperLink&gt;

</pre>
<pre id="codePreview" class="html">
&lt;asp:HyperLink ID=&quot;HyperLink1&quot; runat=&quot;server&quot; NavigateUrl=&quot;~/Login.aspx&quot;&gt;
Sign in again&lt;/asp:HyperLink&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step13: Open the code <span style="">file</span> to write logout function.You can find the complete version in the
<span class="SpellE">Logout.aspx.<span style="">vb</span></span> file. <span style="">
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the information
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' of current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onlinetable As New DataTableForCurrentOnlineUser()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Me.Session(&quot;Ticket&quot;) IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Log out.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _onlinetable.Logout(Me.Session(&quot;Ticket&quot;).ToString())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.Session.Clear()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub

</pre>
<pre id="codePreview" class="vb">
Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the information
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' of current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onlinetable As New DataTableForCurrentOnlineUser()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Me.Session(&quot;Ticket&quot;) IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Log out.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _onlinetable.Logout(Me.Session(&quot;Ticket&quot;).ToString())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Me.Session.Clear()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step14: Add a <span class="SpellE">CheckUserOnlinePage</span> web page into the Web Application. This page is used<span style="">
</span>to check whether the user is online or not.<span style=""><br>
</span>Step15: Open the code file to write Check function.<span style=""> </span>
You can find the complete version in the <span class="SpellE">CheckUserOnlinePage.aspx.<span style="">vb</span></span> file.<span style="">
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Protected Sub Check()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _myTicket As String = &quot;&quot;
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;If System.Web.HttpContext.Current.Session(Me.SessionName) IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _myTicket = System.Web.HttpContext.Current.Session(Me.SessionName).ToString()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If _myTicket &lt;&gt; &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the information of
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onlinetable As New DataTableForCurrentOnlineUser()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Update the time when the page refresh or the page get a request.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;_onlinetable.RefreshTime(_myTicket)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Write(&quot;OKï¼š&quot; & DateTime.Now.ToString())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Write(&quot;Sorryï¼š&quot; & DateTime.Now.ToString())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub

</pre>
<pre id="codePreview" class="vb">
Protected Sub Check()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _myTicket As String = &quot;&quot;
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;If System.Web.HttpContext.Current.Session(Me.SessionName) IsNot Nothing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; _myTicket = System.Web.HttpContext.Current.Session(Me.SessionName).ToString()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If _myTicket &lt;&gt; &quot;&quot; Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initialize the datatable which used to store the information of
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' current online user.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim _onlinetable As New DataTableForCurrentOnlineUser()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Update the time when the page refresh or the page get a request.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;_onlinetable.RefreshTime(_myTicket)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Write(&quot;OKï¼š&quot; & DateTime.Now.ToString())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Response.Write(&quot;Sorryï¼š&quot; & DateTime.Now.ToString())
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp; End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></p>
<h2>More Information</h2>
<p class="MsoNormal">ASP.NET Session State<span style=""><br>
</span><a href="http://msdn.microsoft.com/en-us/library/ms178581(VS.100).aspx">http://msdn.microsoft.com/en-us/library/ms178581(VS.100).aspx</a><br>
DataTable Class<span style=""><br>
</span><a href="http://msdn.microsoft.com/en-us/library/system.data.datatable.aspx">http://msdn.microsoft.com/en-us/library/system.data.datatable.aspx</a><span style="">
</span></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>