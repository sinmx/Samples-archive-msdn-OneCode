# Use a web role to serve files from blob storage
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Microsoft Azure
## Topics
* BLOB
* Web Role
## IsPublished
* True
## ModifiedDate
* 2013-04-16 10:37:12
## Description

<p style="font-family:Courier New">&nbsp;<a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144420" target="_blank"><img id="79969" src="http://i1.code.msdn.s-msft.com/csazurebingmaps-bab92df1/image/file/79969/1/120x90_azure_web_en_us.jpg" alt="" width="360" height="90"></a></p>
<p class="MsoNormal">The sample code demonstrates a way to serve files from storage via a web role.<span>
</span>A file from blob storage (such as http://xxx.cloudapp.net/files/File1) can be<span>
</span>reached as the normal files in your application by relative path (&quot;files/File1&quot;).<span>
</span>And this http module can also filter some specify types files.<span> There is a HttpModule runs before every http request to check the types of requested files and get it from blob storage, and it can also check if the file exists.
</span></p>
<p class="MsoNormal"><span>Before running this sample, please install Windows Azure SDK 1.6 and Windows Azure Toolkit for Visual Studio
</span></p>
<p class="MsoNormal"><span><a href="http://www.windowsazure.com/en-us/develop/downloads/">http://www.windowsazure.com/en-us/develop/downloads/</a>
</span></p>
<p class="MsoNormal"><span>SQL Server 2008 R2 Express: </span></p>
<p class="MsoNormal"><span><a href="http://www.microsoft.com/download/en/details.aspx?id=23650">http://www.microsoft.com/download/en/details.aspx?id=23650</a>
</span></p>
<p class="MsoNormal">Please follow these demonstration steps below.</p>
<p class="MsoNormal">Step 1:&nbsp;Open the VBAzureServeFilesFromBlobStorage.sln<span> as Administrator</span>. Expand the VBAzureServeFilesFromBlobStorage
<span>application</span> and <span>set VBAzureServeFilesFromBlobStorage azure application as the startup project, press F5 for show Default.aspx page</span>.</p>
<p class="MsoNormal">Step 2: <span>If please add your Windows Azure <strong>Storage Account and Key</strong> in the Windows Azure settings, &quot;StorageConnections&quot;. If you do not have one, please use Windows Azure Storage Emulator.<span>&nbsp;
</span>We will see a web page with two unavailable links on the page</span>. <span>
Please click the link &quot;Add default resources page&quot; button to redirect to default resources adding page.</span></p>
<p class="MsoNormal"><span><img src="/site/view/file/73976/1/image.png" alt="" width="576" height="396" align="middle">
</span></p>
<p class="MsoNormal">Step 3:<span>&nbsp; </span><span>Click the &quot;Click to upload the default resources&quot; button to upload your resources in Windows Azure Blob Storage and Table Storage</span>.<span> You can find them upon the &quot;Files&quot; folder, Microsoft.jpg,
 MSDN.jpg and Site.css. The file itself will be uploaded on the blob and file's information will be stored in table.</span></p>
<p class="MsoNormal"><span><img src="/site/view/file/73977/1/image.png" alt="" width="576" height="394" align="middle">
</span><span>&nbsp;</span></p>
<p class="MsoNormal"><span>Step 4: The files has been uploaded now, you can go to
<a href="http://windows.azure.com/">Microsoft Windows Azure Management Portal</a> for view your resources or use Azure Storage Explore tool to view them, the default blob container's name is &quot;container&quot; and default table name is &quot;files&quot;.
</span></p>
<p class="MsoNormal"><span><img src="/site/view/file/73978/1/image.png" alt="" width="576" height="393" align="middle">
</span><span>&nbsp;</span></p>
<p class="MsoNormal"><span><img src="/site/view/file/73979/1/image.png" alt="" width="576" height="139" align="middle">
</span><span>&nbsp;</span></p>
<p class="MsoNormal"><span>Step 5: Go back to the Default.aspx page and your will find the uploaded resources displays, please try to click the link to view them.
</span></p>
<p class="MsoNormal"><span><img src="/site/view/file/73980/1/image.png" alt="" width="576" height="393" align="middle">
</span></p>
<p class="MsoNormal"><span>Step 6: In this sample, you can access jpg and css files (also include .aspx file), other types of file cannot be reached, such as .htm file.
</span></p>
<p class="MsoNormal"><span><img src="/site/view/file/73981/1/image.png" alt="" width="576" height="393" align="middle">
</span><span><span>&nbsp;</span> </span></p>
<p class="MsoNormal">Step <span>7</span>: Validation finished.</p>
<p class="MsoNormal">Code Logical: <span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></p>
<p class="MsoNormal">Step 1. Create a VB &quot;<span>Windows Azure Project</span>&quot; in Visual Studio 201<span>0</span>. Name it as &quot;<span>VBAzureServeFilesFromBlobStorage</span>&quot;.
<span>Add a Web Role and named it as &quot;ServeFilesFromBlobStorageWebRole&quot;, a class library &quot;TableStorageManager&quot;, and make sure the class library's target framework is .NET Framework 4 (Not .NET Framework 4 Client Profile).
</span></p>
<p class="MsoNormal">Step 2. <span>Add 3 class files in TableStorageManager class library, this library is used to package the bottom table storage methods. Try to add Windows Azure references and Data Service client reference.
</span></p>
<p class="MsoListParagraphCxSpFirst" style="text-indent:5.0pt"><span style="font-family:Symbol"><span>&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span>Microsoft.WindowsAzure.Diagonostics </span></strong></p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:5.0pt"><span style="font-family:Symbol"><span>&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span>Microsoft.WindowsAzure.ServiceRuntime </span></strong></p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:5.0pt"><span style="font-family:Symbol"><span>&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span>Microsoft.WindowsAzure.StorageClient </span></strong></p>
<p class="MsoListParagraphCxSpLast" style="text-indent:5.0pt"><span style="font-family:Symbol"><span>&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span>System.Data.Service.Client </span></strong></p>
<p class="MsoNormal"><span>The FileEntity class is a table storage entity class, it includes some basic properties. The FileContext class is used to create queries for table services. You can also add paging method for table storage. The FileDataSource package
 the bottom layer methods (about cloud account, TableServiceContext, credentials, etc)
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">vb</span>
<pre class="hidden">Public Class FileDataSource
    Private Shared account As CloudStorageAccount
    Private context As FileContext


    Public Sub New()
        '' Create table storage client via cloud account.
        account = CloudStorageAccount.FromConfigurationSetting(&quot;StorageConnections&quot;)
        Dim client As CloudTableClient = account.CreateCloudTableClient()
        client.CreateTableIfNotExist(&quot;files&quot;)


        '' Table context properties.
        context = New FileContext(account.TableEndpoint.AbsoluteUri, account.Credentials)
        context.RetryPolicy = RetryPolicies.Retry(3, TimeSpan.FromSeconds(1))
        context.IgnoreResourceNotFoundException = True


        context.IgnoreMissingProperties = True
    End Sub


    ''' &lt;summary&gt;
    ''' Get all entities method.
    ''' &lt;/summary&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function GetAllEntities() As IEnumerable(Of FileEntity)
        Dim list = From m In Me.context.GetEntities
                   Select m
        Return list
    End Function


    ''' &lt;summary&gt;
    ''' Get table rows by partitionKey.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;partitionKey&quot;&gt;&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function GetEntities(partitionKey As String) As IEnumerable(Of FileEntity)
        Dim list = From m In Me.context.GetEntities Where m.PartitionKey = partitionKey
                   Select m
        Return list
    End Function


    ''' &lt;summary&gt;
    ''' Get specify entity.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;partitionKey&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;fileName&quot;&gt;&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function GetEntitiesByName(partitionKey As String, fileName As String) As FileEntity
        Dim list = From m In Me.context.GetEntities
                   Where m.PartitionKey = partitionKey AndAlso m.FileName = fileName
                   Select m
        If list.Count() &gt; 0 Then
            Return list.First()
        Else
            Return Nothing
        End If
    End Function


    ''' &lt;summary&gt;
    ''' Add an entity.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;entity&quot;&gt;&lt;/param&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Sub AddFile(entity As FileEntity)
        Me.context.AddObject(&quot;files&quot;, entity)
        Me.context.SaveChanges()
    End Sub


    ''' &lt;summary&gt;
    ''' Make a judgment to check if file is exists.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;filename&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;partitionKey&quot;&gt;&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function FileExists(filename As String, partitionKey As String) As Boolean
        Dim list As IEnumerable(Of FileEntity) = From m In Me.context.GetEntities
                                                 Where m.FileName = filename AndAlso m.PartitionKey = partitionKey
                                                 Select m
        If list.Count() &gt; 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

</pre>
<pre id="codePreview" class="vb">Public Class FileDataSource
    Private Shared account As CloudStorageAccount
    Private context As FileContext


    Public Sub New()
        '' Create table storage client via cloud account.
        account = CloudStorageAccount.FromConfigurationSetting(&quot;StorageConnections&quot;)
        Dim client As CloudTableClient = account.CreateCloudTableClient()
        client.CreateTableIfNotExist(&quot;files&quot;)


        '' Table context properties.
        context = New FileContext(account.TableEndpoint.AbsoluteUri, account.Credentials)
        context.RetryPolicy = RetryPolicies.Retry(3, TimeSpan.FromSeconds(1))
        context.IgnoreResourceNotFoundException = True


        context.IgnoreMissingProperties = True
    End Sub


    ''' &lt;summary&gt;
    ''' Get all entities method.
    ''' &lt;/summary&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function GetAllEntities() As IEnumerable(Of FileEntity)
        Dim list = From m In Me.context.GetEntities
                   Select m
        Return list
    End Function


    ''' &lt;summary&gt;
    ''' Get table rows by partitionKey.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;partitionKey&quot;&gt;&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function GetEntities(partitionKey As String) As IEnumerable(Of FileEntity)
        Dim list = From m In Me.context.GetEntities Where m.PartitionKey = partitionKey
                   Select m
        Return list
    End Function


    ''' &lt;summary&gt;
    ''' Get specify entity.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;partitionKey&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;fileName&quot;&gt;&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function GetEntitiesByName(partitionKey As String, fileName As String) As FileEntity
        Dim list = From m In Me.context.GetEntities
                   Where m.PartitionKey = partitionKey AndAlso m.FileName = fileName
                   Select m
        If list.Count() &gt; 0 Then
            Return list.First()
        Else
            Return Nothing
        End If
    End Function


    ''' &lt;summary&gt;
    ''' Add an entity.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;entity&quot;&gt;&lt;/param&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Sub AddFile(entity As FileEntity)
        Me.context.AddObject(&quot;files&quot;, entity)
        Me.context.SaveChanges()
    End Sub


    ''' &lt;summary&gt;
    ''' Make a judgment to check if file is exists.
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;filename&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;partitionKey&quot;&gt;&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    ''' &lt;remarks&gt;&lt;/remarks&gt;
    Public Function FileExists(filename As String, partitionKey As String) As Boolean
        Dim list As IEnumerable(Of FileEntity) = From m In Me.context.GetEntities
                                                 Where m.FileName = filename AndAlso m.PartitionKey = partitionKey
                                                 Select m
        If list.Count() &gt; 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step 3. <span>Then we need add a class in ServeFilesFromBlobStorageWebRole project as a HttpModuler to check the requested file types and access the file in Blob Storage.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">vb</span>
<pre class="hidden">Public Sub Init(context As HttpApplication) Implements IHttpModule.Init
    AddHandler context.BeginRequest, AddressOf Me.Application_BeginRequest
End Sub


''' &lt;summary&gt;
''' Check file types and request it by cloud blob API.
''' &lt;/summary&gt;
''' &lt;param name=&quot;source&quot;&gt;&lt;/param&gt;
''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
Private Sub Application_BeginRequest(source As [Object], e As EventArgs)
    Dim url As String = HttpContext.Current.Request.Url.ToString()
    Dim fileName As String = url.Substring(url.LastIndexOf(&quot;/&quot;c) &#43; 1).ToString()
    Dim extensionName As String = String.Empty
    If fileName.Substring(fileName.LastIndexOf(&quot;.&quot;c) &#43; 1).ToString().Equals(&quot;aspx&quot;) Then
        Return
    End If


    If Not fileName.Equals(String.Empty) Then
        extensionName = fileName.Substring(fileName.LastIndexOf(&quot;.&quot;c) &#43; 1).ToString()
        If Not extensionName.Equals(String.Empty) Then
            Dim contentType As String = Me.GetContentType(fileName)
            If contentType.Equals(String.Empty) Then
                HttpContext.Current.Server.Transfer(&quot;NoHandler.aspx&quot;)
            End If




            If True Then
                Dim dataSource As New FileDataSource()
                Dim paritionKey As String = Me.GetPartitionName(extensionName)
                If [String].IsNullOrEmpty(paritionKey) Then
                    HttpContext.Current.Server.Transfer(&quot;NoHandler.aspx&quot;)
                End If
                Dim entity As FileEntity = dataSource.GetEntitiesByName(paritionKey, &quot;Files/&quot; &amp; fileName)
                If entity IsNot Nothing Then
                    HttpContext.Current.Response.Redirect(entity.FileUrl)
                Else
                    HttpContext.Current.Server.Transfer(&quot;NoResources.aspx&quot;)
                End If
            End If
        End If
    End If
End Sub


''' &lt;summary&gt;
''' Get file's Content-Type.
''' &lt;/summary&gt;
''' &lt;param name=&quot;filename&quot;&gt;&lt;/param&gt;
''' &lt;returns&gt;&lt;/returns&gt;
Public Function GetContentType(filename As String) As String
    Dim res As String = String.Empty


    Select Case filename.Substring(filename.LastIndexOf(&quot;.&quot;c) &#43; 1).ToString().ToLower()
        Case &quot;jpg&quot;
            res = &quot;image/jpg&quot;
            Exit Select
        Case &quot;css&quot;
            res = &quot;text/css&quot;
            Exit Select
    End Select


    Return res
End Function


''' &lt;summary&gt;
''' Get file's partitionKey.
''' &lt;/summary&gt;
''' &lt;param name=&quot;extensionName&quot;&gt;&lt;/param&gt;
''' &lt;returns&gt;&lt;/returns&gt;
Public Function GetPartitionName(extensionName As String) As String
    Dim partitionName As String = String.Empty
    Select Case extensionName
        Case &quot;jpg&quot;
            partitionName = &quot;image&quot;
            Exit Select
        Case &quot;css&quot;
            partitionName = &quot;css&quot;
            Exit Select
    End Select
    Return partitionName
End Function

</pre>
<pre id="codePreview" class="vb">Public Sub Init(context As HttpApplication) Implements IHttpModule.Init
    AddHandler context.BeginRequest, AddressOf Me.Application_BeginRequest
End Sub


''' &lt;summary&gt;
''' Check file types and request it by cloud blob API.
''' &lt;/summary&gt;
''' &lt;param name=&quot;source&quot;&gt;&lt;/param&gt;
''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
Private Sub Application_BeginRequest(source As [Object], e As EventArgs)
    Dim url As String = HttpContext.Current.Request.Url.ToString()
    Dim fileName As String = url.Substring(url.LastIndexOf(&quot;/&quot;c) &#43; 1).ToString()
    Dim extensionName As String = String.Empty
    If fileName.Substring(fileName.LastIndexOf(&quot;.&quot;c) &#43; 1).ToString().Equals(&quot;aspx&quot;) Then
        Return
    End If


    If Not fileName.Equals(String.Empty) Then
        extensionName = fileName.Substring(fileName.LastIndexOf(&quot;.&quot;c) &#43; 1).ToString()
        If Not extensionName.Equals(String.Empty) Then
            Dim contentType As String = Me.GetContentType(fileName)
            If contentType.Equals(String.Empty) Then
                HttpContext.Current.Server.Transfer(&quot;NoHandler.aspx&quot;)
            End If




            If True Then
                Dim dataSource As New FileDataSource()
                Dim paritionKey As String = Me.GetPartitionName(extensionName)
                If [String].IsNullOrEmpty(paritionKey) Then
                    HttpContext.Current.Server.Transfer(&quot;NoHandler.aspx&quot;)
                End If
                Dim entity As FileEntity = dataSource.GetEntitiesByName(paritionKey, &quot;Files/&quot; &amp; fileName)
                If entity IsNot Nothing Then
                    HttpContext.Current.Response.Redirect(entity.FileUrl)
                Else
                    HttpContext.Current.Server.Transfer(&quot;NoResources.aspx&quot;)
                End If
            End If
        End If
    End If
End Sub


''' &lt;summary&gt;
''' Get file's Content-Type.
''' &lt;/summary&gt;
''' &lt;param name=&quot;filename&quot;&gt;&lt;/param&gt;
''' &lt;returns&gt;&lt;/returns&gt;
Public Function GetContentType(filename As String) As String
    Dim res As String = String.Empty


    Select Case filename.Substring(filename.LastIndexOf(&quot;.&quot;c) &#43; 1).ToString().ToLower()
        Case &quot;jpg&quot;
            res = &quot;image/jpg&quot;
            Exit Select
        Case &quot;css&quot;
            res = &quot;text/css&quot;
            Exit Select
    End Select


    Return res
End Function


''' &lt;summary&gt;
''' Get file's partitionKey.
''' &lt;/summary&gt;
''' &lt;param name=&quot;extensionName&quot;&gt;&lt;/param&gt;
''' &lt;returns&gt;&lt;/returns&gt;
Public Function GetPartitionName(extensionName As String) As String
    Dim partitionName As String = String.Empty
    Select Case extensionName
        Case &quot;jpg&quot;
            partitionName = &quot;image&quot;
            Exit Select
        Case &quot;css&quot;
            partitionName = &quot;css&quot;
            Exit Select
    End Select
    Return partitionName
End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoNormal">Step <span>4. Try to add a Default web page to shows the some example links, and FileUploadPage for upload some default resources to Storage for testing.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">vb</span>
<pre class="hidden">Private Shared account As CloudStorageAccount
Public files As New List(Of FileEntity)()
Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    account = CloudStorageAccount.FromConfigurationSetting(&quot;StorageConnections&quot;)
End Sub


''' &lt;summary&gt;
''' Upload existing resources. (&quot;Files&quot; folder)
''' &lt;/summary&gt;
''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
''' &lt;remarks&gt;&lt;/remarks&gt;
Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
    Dim source As New FileDataSource()
    Dim nameList As New List(Of String)() From { _
     &quot;Files/Microsoft.jpg&quot;, _
     &quot;Files/MSDN.jpg&quot;, _
     &quot;Files/Site.css&quot; _
    }
    Dim client As CloudBlobClient = account.CreateCloudBlobClient()
    Dim container As CloudBlobContainer = client.GetContainerReference(&quot;container&quot;)
    container.CreateIfNotExist()
    Dim permission = container.GetPermissions()
    permission.PublicAccess = BlobContainerPublicAccessType.Container
    container.SetPermissions(permission)


    For Each name As String In nameList
        If name.Substring(name.LastIndexOf(&quot;.&quot;c) &#43; 1).Equals(&quot;jpg&quot;) AndAlso File.Exists(Server.MapPath(name)) Then
            If Not source.FileExists(name, &quot;image&quot;) Then
                Dim blob As CloudBlob = container.GetBlobReference(name)
                blob.UploadFile(Server.MapPath(name))


                Dim entity As New FileEntity(&quot;image&quot;)
                entity.FileName = name
                entity.FileUrl = blob.Uri.ToString()
                source.AddFile(entity)
                lbContent.Text &#43;= [String].Format(&quot;The image file {0} is uploaded successes. <br>&quot;, name)
            End If
        ElseIf name.Substring(name.LastIndexOf(&quot;.&quot;c) &#43; 1).Equals(&quot;css&quot;) AndAlso File.Exists(Server.MapPath(name)) Then
            If Not source.FileExists(name, &quot;css&quot;) Then
                Dim blob As CloudBlob = container.GetBlobReference(name)
                blob.UploadFile(Server.MapPath(name))


                Dim entity As New FileEntity(&quot;css&quot;)
                entity.FileName = name
                entity.FileUrl = blob.Uri.ToString()
                source.AddFile(entity)
                lbContent.Text &#43;= [String].Format(&quot;The css file {0} is uploaded successes. <br>&quot;, name)
            End If
        End If
    Next


    If nameList.Count &lt;= 0 Then
        lbContent.Text = &quot;You had uploaded these resources&quot;
    End If


End Sub


Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
    Response.Redirect(&quot;Default.aspx&quot;)
End Sub

</pre>
<pre id="codePreview" class="vb">Private Shared account As CloudStorageAccount
Public files As New List(Of FileEntity)()
Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    account = CloudStorageAccount.FromConfigurationSetting(&quot;StorageConnections&quot;)
End Sub


''' &lt;summary&gt;
''' Upload existing resources. (&quot;Files&quot; folder)
''' &lt;/summary&gt;
''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
''' &lt;remarks&gt;&lt;/remarks&gt;
Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
    Dim source As New FileDataSource()
    Dim nameList As New List(Of String)() From { _
     &quot;Files/Microsoft.jpg&quot;, _
     &quot;Files/MSDN.jpg&quot;, _
     &quot;Files/Site.css&quot; _
    }
    Dim client As CloudBlobClient = account.CreateCloudBlobClient()
    Dim container As CloudBlobContainer = client.GetContainerReference(&quot;container&quot;)
    container.CreateIfNotExist()
    Dim permission = container.GetPermissions()
    permission.PublicAccess = BlobContainerPublicAccessType.Container
    container.SetPermissions(permission)


    For Each name As String In nameList
        If name.Substring(name.LastIndexOf(&quot;.&quot;c) &#43; 1).Equals(&quot;jpg&quot;) AndAlso File.Exists(Server.MapPath(name)) Then
            If Not source.FileExists(name, &quot;image&quot;) Then
                Dim blob As CloudBlob = container.GetBlobReference(name)
                blob.UploadFile(Server.MapPath(name))


                Dim entity As New FileEntity(&quot;image&quot;)
                entity.FileName = name
                entity.FileUrl = blob.Uri.ToString()
                source.AddFile(entity)
                lbContent.Text &#43;= [String].Format(&quot;The image file {0} is uploaded successes. <br>&quot;, name)
            End If
        ElseIf name.Substring(name.LastIndexOf(&quot;.&quot;c) &#43; 1).Equals(&quot;css&quot;) AndAlso File.Exists(Server.MapPath(name)) Then
            If Not source.FileExists(name, &quot;css&quot;) Then
                Dim blob As CloudBlob = container.GetBlobReference(name)
                blob.UploadFile(Server.MapPath(name))


                Dim entity As New FileEntity(&quot;css&quot;)
                entity.FileName = name
                entity.FileUrl = blob.Uri.ToString()
                source.AddFile(entity)
                lbContent.Text &#43;= [String].Format(&quot;The css file {0} is uploaded successes. <br>&quot;, name)
            End If
        End If
    Next


    If nameList.Count &lt;= 0 Then
        lbContent.Text = &quot;You had uploaded these resources&quot;
    End If


End Sub


Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
    Response.Redirect(&quot;Default.aspx&quot;)
End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span>Step 5. Please add your Windows Azure Storage account name and key in the Azure project. If you do not have one, use Windows Azure Storage Emulator for testing.
</span></p>
<p class="MsoNormal">Step <span>6</span>. Build the application and you can debug it.</p>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoListParagraphCxSpFirst" style="text-indent:5.0pt"><span style="font-family:Symbol"><span>&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><a href="http://msdn.microsoft.com/en-us/library/windowsazure/dd135733.aspx">Blob Service REST API</a></p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:5.0pt"><span style="font-family:Symbol"><span>&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><a href="http://msdn.microsoft.com/en-us/library/windowsazure/dd179423.aspx">Table Service REST API</a></p>
<p class="MsoListParagraphCxSpLast" style="text-indent:5.0pt"><span style="font-family:Symbol"><span>&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><a href="http://msdn.microsoft.com/en-us/library/aa719858(v=VS.71).aspx">HttpModule</a>r</p>
<p class="MsoNormal">&nbsp;</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt="">
</a></div>