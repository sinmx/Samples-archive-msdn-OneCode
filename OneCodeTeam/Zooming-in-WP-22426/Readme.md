# Zooming in WP
## Requires
* Visual Studio 2012
## License
* Apache License, Version 2.0
## Technologies
* Windows Phone
* Windows Phone 8
* Windows Phone Development
## Topics
* Windows Phone 8
* Zoom
## IsPublished
* True
## ModifiedDate
* 2013-06-05 12:17:44
## Description

<h1>How to zoom in and zoom out (VBWP8Zooming)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">This sample demonstrates how to zoom in and zoom out in Windows Phone, for both still images and video.</p>
<h2>Building the Sample</h2>
<p class="MsoNormal">Prerequisite: Visual Studio 2012 with Windows Phone SDK 8.0.<br>
You can download Visual Studio 2012 from here:<br>
<a href="http://www.microsoft.com/visualstudio/eng/downloads">http://www.microsoft.com/visualstudio/eng/downloads</a><br>
You can download Windows Phone SDK 8.0 from here:<br>
<a href="https://dev.windowsphone.com/en-us/downloadsdk">https://dev.windowsphone.com/en-us/downloadsdk</a><br>
<span style="">&nbsp;</span>You can get started by checking this link: <br>
<a href="http://create.msdn.com/en-us/home/getting_started">http://create.msdn.com/en-us/home/getting_started</a></p>
<h2>Running the Sample</h2>
<p class="MsoListParagraphCxSpFirst" style="text-indent:-.25in"><span style=""><span style="">Step 1:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Open &quot;VBWP8Zooming&quot;in Visual Studio 2012 or Visual Studio Express 2012 for Windows Phone.</p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:-.25in"><span style=""><span style="">Step 2:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Press Ctrl &#43; F5. The emulator looks as follows:</p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><img src="/site/view/file/83499/1/image.png" alt="" width="282" height="134" align="middle">
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:-.25in"><span style=""><span style="">Step 3:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Click the &quot;Image Zoom&quot; button. The emulator looks as follows:</p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><img src="/site/view/file/83500/1/image.png" alt="" width="275" height="421" align="middle">
</span></p>
<p class="MsoListParagraphCxSpMiddle">And then you can click the buttons to zoom the image.</p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:-.25in"><span style=""><span style="">Step 4:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Click the back arrow key to return to the previous page.</p>
<p class="MsoListParagraphCxSpMiddle">Then Click the &quot;Video Zoom&quot; button. The emulator looks as follows:</p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><img src="/site/view/file/83501/1/image.png" alt="" width="272" height="352" align="middle">
</span></p>
<p class="MsoListParagraphCxSpMiddle">And then you can click the buttons to zoom the video.
</p>
<p class="MsoListParagraphCxSpLast" style="text-indent:-.25in"><span style=""><span style="">Step 5:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>The validation is complete.</p>
<h2>Using the Code</h2>
<p class="MsoListParagraphCxSpFirst" style="text-indent:-.25in"><span style=""><span style="">Step 1:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Create a new &quot;Windows Phone&quot; project in in Visual Studio 2012 or Visual Studio Express 2012 for Windows Phone.
</p>
<p class="MsoListParagraphCxSpLast" style="text-indent:-.25in"><span style=""><span style="">Step 2:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Open WMAppManifest.xml and confirm that the following capability elements are present:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Capability Name=&quot;ID_CAP_ISV_CAMERA&quot;/&gt;
&lt;Capability Name=&quot;ID_CAP_MICROPHONE&quot;/&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;Capability Name=&quot;ID_CAP_ISV_CAMERA&quot;/&gt;
&lt;Capability Name=&quot;ID_CAP_MICROPHONE&quot;/&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="text-indent:-.25in"><span style=""><span style="">Step 3:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>To add icons used by the application. In the <b style="">Add Existing Item</b> window, navigate to one of the following paths to select the icons.</p>
<p class="MsoListParagraphCxSpMiddle"><b style="">64-bit Operating Systems</b>: C:\Program Files (x86)\Microsoft SDKs\Windows Phone\ v8.0 \Icons\dark</p>
<p class="MsoListParagraphCxSpMiddle"><b style="">32-bit Operating Systems</b>: C:\Program Files\Microsoft SDKs\Windows Phone\ v8.0 \Icons\dark</p>
<p class="MsoListParagraphCxSpMiddle">From the folder, select the following icons:</p>
<p class="MsoListParagraphCxSpMiddle"><b style="">add.png </b></p>
<p class="MsoListParagraphCxSpMiddle"><b style="">minus.png </b></p>
<p class="MsoListParagraphCxSpMiddle" style="text-indent:-.25in"><span style=""><span style="">Step 4:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Follow these steps to add two pages to the root directory of the project:
</p>
<p class="MsoListParagraphCxSpMiddle">In <b style="">Solution Explorer</b>, right-click and then click
<b style="">New Item</b>. In the list of file types, click &quot;<b style="">Windows Phone Portrait Page</b>&quot; or &quot;<b style="">Windows Phone Landscape Page</b>&quot;.</p>
<p class="MsoListParagraphCxSpMiddle">Type &quot;ImageZoom&quot; and &quot;VideoZoom&quot; as the name of each page.List these two Navigation links in the MainPage page.</p>
<p class="MsoListParagraphCxSpLast" style="text-indent:-.25in"><span style=""><span style="">Step 5:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>The XAML code in ImageZoom.xaml resembles the following:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XAML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xaml</span>
<pre class="hidden">
&lt;Grid x:Name=&quot;LayoutRoot&quot; Background=&quot;Transparent&quot; RenderTransformOrigin=&quot;0.475,0.673&quot; Margin=&quot;0,-9,0,9&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Grid.RowDefinitions&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;500&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;*&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Grid.RowDefinitions&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Image x:Name=&quot;img&quot; Margin=&quot;10,10,-10,10&quot;/&gt;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Canvas Grid.Row=&quot;1&quot; Margin=&quot;-10,529,10,83&quot; &gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Button x:Name=&quot;btnZoomOut&quot; Background=&quot;Red&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click=&quot;btnZoomOut_Click&quot; Content=&quot;-&quot; Width=&quot;140&quot; Height=&quot;66&quot; Canvas.Left=&quot;234&quot; Canvas.Top=&quot;-384&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Button x:Name=&quot;btnZoomIn&quot; Background=&quot;Red&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click=&quot;btnZoomIn_Click&quot; Content=&quot;&#43;&quot; Width=&quot;140&quot; Height=&quot;66&quot; Canvas.Left=&quot;94&quot; Canvas.Top=&quot;-384&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Canvas&gt;
&nbsp;&nbsp; &lt;/Grid&gt;

</pre>
<pre id="codePreview" class="xaml">
&lt;Grid x:Name=&quot;LayoutRoot&quot; Background=&quot;Transparent&quot; RenderTransformOrigin=&quot;0.475,0.673&quot; Margin=&quot;0,-9,0,9&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Grid.RowDefinitions&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;500&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;*&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Grid.RowDefinitions&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Image x:Name=&quot;img&quot; Margin=&quot;10,10,-10,10&quot;/&gt;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Canvas Grid.Row=&quot;1&quot; Margin=&quot;-10,529,10,83&quot; &gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Button x:Name=&quot;btnZoomOut&quot; Background=&quot;Red&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click=&quot;btnZoomOut_Click&quot; Content=&quot;-&quot; Width=&quot;140&quot; Height=&quot;66&quot; Canvas.Left=&quot;234&quot; Canvas.Top=&quot;-384&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Button x:Name=&quot;btnZoomIn&quot; Background=&quot;Red&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click=&quot;btnZoomIn_Click&quot; Content=&quot;&#43;&quot; Width=&quot;140&quot; Height=&quot;66&quot; Canvas.Left=&quot;94&quot; Canvas.Top=&quot;-384&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Canvas&gt;
&nbsp;&nbsp; &lt;/Grid&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style=""><span style="">Step 6:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>In <span class="SpellE">ImageZoom.xaml.vb</span>, add the following code to the ImageZoom class:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Partial Public Class ImageZoom
&nbsp;&nbsp;&nbsp; Inherits PhoneApplicationPage
&nbsp;&nbsp;&nbsp; Private initHight As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initial high.
&nbsp;&nbsp;&nbsp; Private initWidth As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initial width.
&nbsp;&nbsp;&nbsp; Private maxHight As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max hight.
&nbsp;&nbsp;&nbsp; Private myMaxWidth As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max width.
&nbsp;&nbsp;&nbsp; Private changeHight As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;' The amount of the increase or decrease of the high.
&nbsp;&nbsp;&nbsp; Private changeWidth As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The amount of the increase or decrease of the width.
&nbsp;&nbsp;&nbsp; Private strPath As String = &quot;1code.jpg&quot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Image path.
&nbsp;&nbsp;&nbsp; Private strImageName As String = &quot;test.jpg&quot;&nbsp;&nbsp; ' Image name.
&nbsp;&nbsp;&nbsp; Private isLoad As Boolean = False&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Flag for initialization. 


&nbsp;&nbsp;&nbsp; ' Constructor
&nbsp;&nbsp;&nbsp; Public Sub New()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; InitializeComponent()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Save image to isolated storage. You can capture a image from camera instead of local image.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SaveImageToIsolatedStorage(initWidth, initHight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Load image and rendering.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoadImageFromIsolatedStorage(0, 0)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Prevent repeat initialized.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Not isLoad Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; myMaxWidth = img.Width
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; maxHight = img.Height
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; changeHight = Convert.ToInt32(((maxHight - initHight) / 20))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; changeWidth = Convert.ToInt32((myMaxWidth - initWidth) / 20)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isLoad = True
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedTo(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedFrom(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedFrom(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Save image to IsolatedStorage.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;Private Sub SaveImageToIsolatedStorage(intPixelWidth As Integer, intPixelHeight As Integer)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Use Uri to get local images.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim sri As StreamResourceInfo = Nothing
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim uri As New Uri(strPath, UriKind.Relative)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sri = Application.GetResourceStream(uri)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using iso As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If iso.FileExists(strImageName) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; iso.DeleteFile(strImageName)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using isostream As IsolatedStorageFileStream = iso.CreateFile(strImageName)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim bitmap As New BitmapImage()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; bitmap.SetSource(sri.Stream)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim wb As New WriteableBitmap(bitmap)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If intPixelHeight &gt; 0 Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Encode WriteableBitmap object to a JPEG stream.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Extensions.SaveJpeg(wb, isostream, intPixelWidth, intPixelHeight, 0, 85)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;' Encode WriteableBitmap object to a JPEG stream.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Extensions.SaveJpeg(wb, isostream, wb.PixelWidth, wb.PixelHeight, 0, 85)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isostream.Close()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Sample code for loading image from IsolatedStorage
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt; 
&nbsp;&nbsp;&nbsp;&nbsp;Private Sub LoadImageFromIsolatedStorage(intPixelWidth As Integer, intPixelHeight As Integer)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The image will be read from isolated storage into the following byte array
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim data As Byte()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Read the entire image in one go into a byte array
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Try
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using isf As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using isfs As IsolatedStorageFileStream = isf.OpenFile(strImageName, FileMode.Open, FileAccess.Read)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Allocate an array large enough for the entire file
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; data = New Byte(isfs.Length - 1) {}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Read the entire file and then close it
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isfs.Read(data, 0, data.Length)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isfs.Close()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create memory stream and bitmap
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim ms As New MemoryStream(data)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim bi As New BitmapImage()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Set bitmap source to memory stream
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; bi.SetSource(ms)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Note: You must remove previous picture.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LayoutRoot.Children.Remove(img)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img = New Image()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Set size of image to bitmap size for this demonstration
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If intPixelHeight &gt; 0 Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Height = intPixelHeight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Width = intPixelWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Height = bi.PixelHeight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Width = bi.PixelWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Source = bi
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LayoutRoot.Children.Add(img)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Catch e As Exception
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' handle the exception
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Debug.WriteLine(e.Message)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Try
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom in.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomIn_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If img.Width &lt;= myMaxWidth AndAlso img.Height &lt;= maxHight Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim width As Integer = GetInt(img.Width)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current width.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim hight As Integer = GetInt(img.Height)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current hight.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; width = width &#43; changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; hight = hight &#43; changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SaveImageToIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoadImageFromIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom out.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomOut_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If img.Width &gt; changeWidth AndAlso img.Height &gt; changeHight Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim width As Integer = GetInt(img.Width)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current width.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim hight As Integer = GetInt(img.Height)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current hight.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; width = width - changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; hight = hight - changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SaveImageToIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoadImageFromIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Convert method
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;p&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;returns&gt;&lt;/returns&gt;
&nbsp;&nbsp;&nbsp; Private Function GetInt(p As Double) As Integer
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return Convert.ToInt32(p)
&nbsp;&nbsp;&nbsp; End Function
End Class

</pre>
<pre id="codePreview" class="vb">
Partial Public Class ImageZoom
&nbsp;&nbsp;&nbsp; Inherits PhoneApplicationPage
&nbsp;&nbsp;&nbsp; Private initHight As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initial high.
&nbsp;&nbsp;&nbsp; Private initWidth As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Initial width.
&nbsp;&nbsp;&nbsp; Private maxHight As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max hight.
&nbsp;&nbsp;&nbsp; Private myMaxWidth As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max width.
&nbsp;&nbsp;&nbsp; Private changeHight As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;' The amount of the increase or decrease of the high.
&nbsp;&nbsp;&nbsp; Private changeWidth As Integer = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The amount of the increase or decrease of the width.
&nbsp;&nbsp;&nbsp; Private strPath As String = &quot;1code.jpg&quot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Image path.
&nbsp;&nbsp;&nbsp; Private strImageName As String = &quot;test.jpg&quot;&nbsp;&nbsp; ' Image name.
&nbsp;&nbsp;&nbsp; Private isLoad As Boolean = False&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Flag for initialization. 


&nbsp;&nbsp;&nbsp; ' Constructor
&nbsp;&nbsp;&nbsp; Public Sub New()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; InitializeComponent()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Save image to isolated storage. You can capture a image from camera instead of local image.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SaveImageToIsolatedStorage(initWidth, initHight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Load image and rendering.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoadImageFromIsolatedStorage(0, 0)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Prevent repeat initialized.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If Not isLoad Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; myMaxWidth = img.Width
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; maxHight = img.Height
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; changeHight = Convert.ToInt32(((maxHight - initHight) / 20))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; changeWidth = Convert.ToInt32((myMaxWidth - initWidth) / 20)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isLoad = True
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedTo(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedFrom(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedFrom(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Save image to IsolatedStorage.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;Private Sub SaveImageToIsolatedStorage(intPixelWidth As Integer, intPixelHeight As Integer)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Use Uri to get local images.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim sri As StreamResourceInfo = Nothing
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim uri As New Uri(strPath, UriKind.Relative)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; sri = Application.GetResourceStream(uri)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using iso As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If iso.FileExists(strImageName) Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; iso.DeleteFile(strImageName)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using isostream As IsolatedStorageFileStream = iso.CreateFile(strImageName)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim bitmap As New BitmapImage()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; bitmap.SetSource(sri.Stream)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim wb As New WriteableBitmap(bitmap)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If intPixelHeight &gt; 0 Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Encode WriteableBitmap object to a JPEG stream.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Extensions.SaveJpeg(wb, isostream, intPixelWidth, intPixelHeight, 0, 85)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;' Encode WriteableBitmap object to a JPEG stream.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Extensions.SaveJpeg(wb, isostream, wb.PixelWidth, wb.PixelHeight, 0, 85)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isostream.Close()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Sample code for loading image from IsolatedStorage
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt; 
&nbsp;&nbsp;&nbsp;&nbsp;Private Sub LoadImageFromIsolatedStorage(intPixelWidth As Integer, intPixelHeight As Integer)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The image will be read from isolated storage into the following byte array
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim data As Byte()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Read the entire image in one go into a byte array
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Try
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using isf As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using isfs As IsolatedStorageFileStream = isf.OpenFile(strImageName, FileMode.Open, FileAccess.Read)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Allocate an array large enough for the entire file
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; data = New Byte(isfs.Length - 1) {}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Read the entire file and then close it
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isfs.Read(data, 0, data.Length)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; isfs.Close()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Using


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Create memory stream and bitmap
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim ms As New MemoryStream(data)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim bi As New BitmapImage()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Set bitmap source to memory stream
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; bi.SetSource(ms)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Note: You must remove previous picture.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LayoutRoot.Children.Remove(img)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img = New Image()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Set size of image to bitmap size for this demonstration
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If intPixelHeight &gt; 0 Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Height = intPixelHeight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Width = intPixelWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Else
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Height = bi.PixelHeight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Width = bi.PixelWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; img.Source = bi
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LayoutRoot.Children.Add(img)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Catch e As Exception
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' handle the exception
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Debug.WriteLine(e.Message)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Try
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom in.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomIn_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If img.Width &lt;= myMaxWidth AndAlso img.Height &lt;= maxHight Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim width As Integer = GetInt(img.Width)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current width.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim hight As Integer = GetInt(img.Height)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current hight.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; width = width &#43; changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; hight = hight &#43; changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SaveImageToIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoadImageFromIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom out.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomOut_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If img.Width &gt; changeWidth AndAlso img.Height &gt; changeHight Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim width As Integer = GetInt(img.Width)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current width.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim hight As Integer = GetInt(img.Height)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Current hight.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; width = width - changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; hight = hight - changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SaveImageToIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoadImageFromIsolatedStorage(width, hight)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Convert method
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;p&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;returns&gt;&lt;/returns&gt;
&nbsp;&nbsp;&nbsp; Private Function GetInt(p As Double) As Integer
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return Convert.ToInt32(p)
&nbsp;&nbsp;&nbsp; End Function
End Class

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style=""><span style="">Step 7:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>The XAML code in VideoZoom.xaml resembles the following:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XAML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xaml</span>
<pre class="hidden">
&lt;Grid x:Name=&quot;LayoutRoot&quot; Background=&quot;Transparent&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Grid.RowDefinitions&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;Auto&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;*&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Grid.RowDefinitions&gt;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Canvas x:Name=&quot;LayoutRootIn&quot; Background=&quot;Transparent&quot;&nbsp; Grid.Row=&quot;0&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Height=&quot;400&quot; Width=&quot;400&quot; Grid.RowSpan=&quot;2&quot; &gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Canvas x:Name=&quot;LayoutRootOut&quot; Background=&quot;Transparent&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Height=&quot;373&quot; Margin=&quot;0,0,67,0&quot; &gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;MediaElement 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;x:Name=&quot;VideoPlayer&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Width=&quot;440&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Height=&quot;350&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AutoPlay=&quot;True&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RenderTransformOrigin=&quot;0.5, 0.5&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;VerticalAlignment=&quot;Center&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;HorizontalAlignment=&quot;Center&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Stretch=&quot;Fill&quot; Canvas.Top=&quot;14&quot; Canvas.Left=&quot;-18&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Canvas&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Canvas&gt;
&nbsp;&nbsp; &lt;/Grid&gt;


&nbsp;&nbsp; &lt;phone:PhoneApplicationPage.ApplicationBar&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;shell:ApplicationBar IsVisible=&quot;True&quot; IsMenuEnabled=&quot;True&quot; x:Name=&quot;PhoneAppBar&quot; Opacity=&quot;0.0&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;shell:ApplicationBarIconButton IconUri=&quot;/Icons/add.png&quot; Text=&quot;zoomin&quot;&nbsp; x:Name=&quot;StartZoomIn&quot; Click=&quot;btnZoomIn_Click&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;shell:ApplicationBarIconButton IconUri=&quot;/Icons/minus.png&quot; Text=&quot;zoomout&quot; x:Name=&quot;StartZoomOut&quot; Click=&quot;btnZoomOut_Click&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/shell:ApplicationBar&gt;
&nbsp;&nbsp; &lt;/phone:PhoneApplicationPage.ApplicationBar&gt;

</pre>
<pre id="codePreview" class="xaml">
&lt;Grid x:Name=&quot;LayoutRoot&quot; Background=&quot;Transparent&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Grid.RowDefinitions&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;Auto&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;RowDefinition Height=&quot;*&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Grid.RowDefinitions&gt;


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Canvas x:Name=&quot;LayoutRootIn&quot; Background=&quot;Transparent&quot;&nbsp; Grid.Row=&quot;0&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Height=&quot;400&quot; Width=&quot;400&quot; Grid.RowSpan=&quot;2&quot; &gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Canvas x:Name=&quot;LayoutRootOut&quot; Background=&quot;Transparent&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Height=&quot;373&quot; Margin=&quot;0,0,67,0&quot; &gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;MediaElement 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;x:Name=&quot;VideoPlayer&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Width=&quot;440&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Height=&quot;350&quot;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AutoPlay=&quot;True&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RenderTransformOrigin=&quot;0.5, 0.5&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;VerticalAlignment=&quot;Center&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;HorizontalAlignment=&quot;Center&quot; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Stretch=&quot;Fill&quot; Canvas.Top=&quot;14&quot; Canvas.Left=&quot;-18&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Canvas&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Canvas&gt;
&nbsp;&nbsp; &lt;/Grid&gt;


&nbsp;&nbsp; &lt;phone:PhoneApplicationPage.ApplicationBar&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;shell:ApplicationBar IsVisible=&quot;True&quot; IsMenuEnabled=&quot;True&quot; x:Name=&quot;PhoneAppBar&quot; Opacity=&quot;0.0&quot;&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;shell:ApplicationBarIconButton IconUri=&quot;/Icons/add.png&quot; Text=&quot;zoomin&quot;&nbsp; x:Name=&quot;StartZoomIn&quot; Click=&quot;btnZoomIn_Click&quot; /&gt;
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;shell:ApplicationBarIconButton IconUri=&quot;/Icons/minus.png&quot; Text=&quot;zoomout&quot; x:Name=&quot;StartZoomOut&quot; Click=&quot;btnZoomOut_Click&quot;/&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/shell:ApplicationBar&gt;
&nbsp;&nbsp; &lt;/phone:PhoneApplicationPage.ApplicationBar&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style=""><span style="">Step 8:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>In VideoZoom.xaml.vb, add the following code to the VideoZoom class:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Partial Public Class VideoZoom
&nbsp;&nbsp;&nbsp; Inherits PhoneApplicationPage
&nbsp;&nbsp;&nbsp; Private strLocalName As String = &quot;howto.wmv&quot;&nbsp;&nbsp;&nbsp; ' Local video.
&nbsp;&nbsp;&nbsp; Private maxHight As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max hight.
&nbsp;&nbsp;&nbsp; Private myMaxWidth As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max width.
&nbsp;&nbsp;&nbsp; Private changeHight As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The amount of the increase or decrease of the high.
&nbsp;&nbsp;&nbsp; Private changeWidth As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The amount of the increase or decrease of the width.&nbsp;&nbsp; 


&nbsp;&nbsp;&nbsp; ' Constructor
&nbsp;&nbsp;&nbsp; Public Sub New()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; InitializeComponent()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; maxHight = VideoPlayer.ActualHeight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; myMaxWidth = VideoPlayer.ActualWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; changeHight = maxHight / 20
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;changeWidth = myMaxWidth / 20


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Source = New Uri(strLocalName, UriKind.Relative)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AddHandler VideoPlayer.MediaEnded, AddressOf VideoPlayer_MediaEnded


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Prepare ApplicationBar and buttons.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PhoneAppBar = DirectCast(ApplicationBar, ApplicationBar)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PhoneAppBar.IsVisible = True
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StartZoomIn = DirectCast(ApplicationBar.Buttons(0), ApplicationBarIconButton)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StartZoomOut = DirectCast(ApplicationBar.Buttons(1), ApplicationBarIconButton)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedTo(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedFrom(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedFrom(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp; &nbsp;''' Display the viewfinder when playback ends.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Public Sub VideoPlayer_MediaEnded(sender As Object, e As RoutedEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If VideoPlayer.CurrentState &lt;&gt; MediaElementState.Playing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.[Stop]()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Play()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom in.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomIn_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If VideoPlayer.Height &lt;= maxHight AndAlso VideoPlayer.Width &lt;= myMaxWidth Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Pause()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Height &#43;= changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Width &#43;= changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Play()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom out.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomOut_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If VideoPlayer.Height &gt; changeHight AndAlso VideoPlayer.Width &gt; changeWidth Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.[Stop]()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Height -= changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Width -= changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Play()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub
End Class

</pre>
<pre id="codePreview" class="vb">
Partial Public Class VideoZoom
&nbsp;&nbsp;&nbsp; Inherits PhoneApplicationPage
&nbsp;&nbsp;&nbsp; Private strLocalName As String = &quot;howto.wmv&quot;&nbsp;&nbsp;&nbsp; ' Local video.
&nbsp;&nbsp;&nbsp; Private maxHight As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max hight.
&nbsp;&nbsp;&nbsp; Private myMaxWidth As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Max width.
&nbsp;&nbsp;&nbsp; Private changeHight As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The amount of the increase or decrease of the high.
&nbsp;&nbsp;&nbsp; Private changeWidth As Double = 0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The amount of the increase or decrease of the width.&nbsp;&nbsp; 


&nbsp;&nbsp;&nbsp; ' Constructor
&nbsp;&nbsp;&nbsp; Public Sub New()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; InitializeComponent()


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; maxHight = VideoPlayer.ActualHeight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; myMaxWidth = VideoPlayer.ActualWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; changeHight = maxHight / 20
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;changeWidth = myMaxWidth / 20


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Source = New Uri(strLocalName, UriKind.Relative)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AddHandler VideoPlayer.MediaEnded, AddressOf VideoPlayer_MediaEnded


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Prepare ApplicationBar and buttons.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PhoneAppBar = DirectCast(ApplicationBar, ApplicationBar)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PhoneAppBar.IsVisible = True
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StartZoomIn = DirectCast(ApplicationBar.Buttons(0), ApplicationBarIconButton)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StartZoomOut = DirectCast(ApplicationBar.Buttons(1), ApplicationBarIconButton)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedTo(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; Protected Overrides Sub OnNavigatedFrom(e As NavigationEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MyBase.OnNavigatedFrom(e)
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp; &nbsp;''' Display the viewfinder when playback ends.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Public Sub VideoPlayer_MediaEnded(sender As Object, e As RoutedEventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If VideoPlayer.CurrentState &lt;&gt; MediaElementState.Playing Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.[Stop]()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Play()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom in.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomIn_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If VideoPlayer.Height &lt;= maxHight AndAlso VideoPlayer.Width &lt;= myMaxWidth Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Pause()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Height &#43;= changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Width &#43;= changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Play()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub


&nbsp;&nbsp;&nbsp; ''' &lt;summary&gt;
&nbsp;&nbsp;&nbsp; ''' Zoom out.
&nbsp;&nbsp;&nbsp; ''' &lt;/summary&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
&nbsp;&nbsp;&nbsp; Private Sub btnZoomOut_Click(sender As Object, e As EventArgs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If VideoPlayer.Height &gt; changeHight AndAlso VideoPlayer.Width &gt; changeWidth Then
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.[Stop]()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Height -= changeHight
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Width -= changeWidth
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VideoPlayer.Play()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End If
&nbsp;&nbsp;&nbsp; End Sub
End Class

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style=""><span style="">Step 9:<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Build the application, and then you can debug it. </p>
<h2>More Information</h2>
<p class="MsoNormal">For more info about IsolatedStorageFile class, please see this link:
<br>
<a href="http://msdn.microsoft.com/en-us/library/system.io.isolatedstorage.isolatedstoragefile(v=VS.95).aspx">http://msdn.microsoft.com/en-us/library/system.io.isolatedstorage.isolatedstoragefile(v=VS.95).aspx</a><br>
<br style="">
<br style="">
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>
