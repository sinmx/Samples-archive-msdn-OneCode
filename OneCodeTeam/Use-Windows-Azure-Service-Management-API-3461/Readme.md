# Use Windows Azure Service Management API (VBAzureManagementAPI)
## Requires
* Visual Studio 2010
## License
* Apache License, Version 2.0
## Technologies
* Microsoft Azure
## Topics
* Windows Azure Service Management REST API
## IsPublished
* True
## ModifiedDate
* 2013-04-16 10:48:23
## Description

<p style="font-family:Courier New">&nbsp;<a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420" target="_blank"><img id="79969" src="http://i1.code.msdn.s-msft.com/csazurebingmaps-bab92df1/image/file/79969/1/120x90_azure_web_en_us.jpg" alt="" width="360" height="90"></a></p>
<h2>APPLICATION : VBAzureManagementAPI Project Overview</h2>
<p style="font-family:Courier New">&nbsp;</p>
<h3>Summary:</h3>
<p style="font-family:Courier New"><br>
This project shows how to create a new hosted service on Azure via Management API.</p>
<div align="right">
<p><a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420"><span style="color:windowtext; text-decoration:none"><span><img src="http://code.msdn.microsoft.com/site/view/file/67654/1/image.png" alt="" width="120" height="90" align="middle">
</span></span></a><br>
<a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420">Try Windows Azure for free for 90 Days!</a></p>
</div>
<p style="font-family:Courier New"><br>
<br>
</p>
<h3>Demo:</h3>
<p style="font-family:Courier New"><br>
1.&nbsp;&nbsp;&nbsp;&nbsp;Fill in your subscription ID to below:<br>
&nbsp; &nbsp; &nbsp; Dim subscriptionId As String = &quot;&quot;<br>
<br>
2.&nbsp;&nbsp;&nbsp;&nbsp;Fill in the management certificate thumbprint to below:<br>
&nbsp; &nbsp; &nbsp; &nbsp;<br>
&nbsp; &nbsp; &nbsp; &nbsp;' This is the thumbprint of the management certificate<br>
&nbsp; &nbsp; &nbsp; &nbsp;' make sure the certificate exists in your personal/Certificates. Please verify it by certmgr.msc<br>
&nbsp; &nbsp; &nbsp; &nbsp;' this certificate must be uploaded to Azure Management Portal, in Management Certificates
<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;' <a href="&lt;a target=" target="_blank">
http://msdn.microsoft.com/en-us/library/gg551726.aspx</a>'&gt;<a href="http://msdn.microsoft.com/en-us/library/gg551726.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/gg551726.aspx</a><br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim certThumbprint As String = &quot;&quot;<br>
&nbsp;<br>
3.&nbsp;&nbsp;&nbsp;&nbsp;Fill in the ServiceName and the labelName:<br>
&nbsp; &nbsp; &nbsp; &nbsp;<br>
&nbsp; &nbsp; &nbsp; &nbsp;' This will be use as the DNS prefix, so if it exists(someone else might took it) then you will
<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;' receive 409 conflict error<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim hostServiceName As String = &quot;&quot;<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;' The Name of the hosted service<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim labelName As String = &quot;&quot;<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;' The Name of the hosted service<br>
&nbsp; &nbsp; &nbsp; &nbsp;string labelName = &quot;&quot;;<br>
<br>
4.&nbsp;&nbsp;&nbsp;&nbsp;Run the program.<br>
<br>
5. &nbsp;You will see a service with name you defined in &nbsp; &nbsp;<br>
&nbsp; &nbsp; &nbsp; &nbsp;' The Name of the hosted service<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim labelName As String = &quot;&quot;;<br>
&nbsp; &nbsp;created on your Azure account.<br>
<br>
</p>
<h3>Code Logic:</h3>
<p style="font-family:Courier New"><br>
1. Sending the request xml string asynchronously.<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim formData As Byte() = UTF8Encoding.UTF8.GetBytes(sbRequestXml.ToString())<br>
&nbsp; &nbsp; &nbsp; &nbsp;request.ContentLength = formData.Length<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Using post As Stream = request.GetRequestStream()<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;post.Write(formData, 0, formData.Length)<br>
&nbsp; &nbsp; &nbsp; &nbsp;End Using<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Console.WriteLine(&quot;Creating Hosted Service: &quot; &amp; hostServiceName)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Try<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim state As New RequestState()<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;state.Request = request<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim result As IAsyncResult = request.BeginGetResponse(New AsyncCallback(AddressOf RespCallback), state)<br>
&nbsp; &nbsp; &nbsp; &nbsp;Catch ex As Exception<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Console.WriteLine(&quot;Error: &quot; &amp; ex.Message)<br>
&nbsp; &nbsp; &nbsp; &nbsp;End Try<br>
<br>
2. &nbsp;Response callback.<br>
<br>
&nbsp; &nbsp;Private Sub RespCallback(ByVal result As IAsyncResult)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim state As RequestState = DirectCast(result.AsyncState, RequestState) &nbsp; &nbsp; &nbsp; &nbsp; ' Grab the custom state object<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim request As WebRequest = DirectCast(state.Request, WebRequest)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim response As HttpWebResponse = DirectCast(request.EndGetResponse(result), HttpWebResponse) ' Get the Response<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim statusCode As String = response.StatusCode.ToString()<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;' A value that uniquely identifies a request made against the Management service.<br>
&nbsp; &nbsp; &nbsp; &nbsp;' For an asynchronous operation, <br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim reqId As String = response.GetResponseHeader(&quot;x-ms-request-id&quot;)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;' You can call get operation status with the value of the header to determine whether the operation is complete,
<br>
&nbsp; &nbsp; &nbsp; &nbsp;' has failed, or is still in progress. <br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Console.WriteLine(&quot;Creation Return Value: &quot; &amp; statusCode)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Console.WriteLine(&quot;RequestId: &quot; &amp; reqId)<br>
&nbsp; &nbsp;End Sub<br>
<br>
</p>
<h3>References:</h3>
<p style="font-family:Courier New"><br>
Windows Azure Service Management REST API Reference<br>
<a href="http://msdn.microsoft.com/en-us/library/ee460799.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/ee460799.aspx</a><br>
<br>
How to Add a Management Certificate to a Windows Azure Subscription<br>
<a href="&lt;a target=" target="_blank">http://msdn.microsoft.com/en-us/library/gg551726.aspx</a>'&gt;<a href="http://msdn.microsoft.com/en-us/library/gg551726.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/gg551726.aspx</a><br>
<br>
<br>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt="">
</a></div>