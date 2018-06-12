# Image slideshow in full screen mode (VBImageFullScreenSlideShow)
## Requires
* Visual Studio 2010
## License
* Apache License, Version 2.0
## Technologies
* Windows Forms
* Windows General
## Topics
* Full Screen
## IsPublished
* True
## ModifiedDate
* 2011-07-14 12:47:19
## Description

<p style="font-family:Courier New"></p>
<h2>Windows APPLICATION: VBImageFullScreenSlideShow Overview</h2>
<p style="font-family:Courier New"></p>
<h3>Summary:</h3>
<p style="font-family:Courier New"><br>
The sample demonstrates how to display image slideshow in a Windows Forms <br>
application. &nbsp;It also shows how to enter the full screen mode to slide-show <br>
images. <br>
<br>
</p>
<h3>Demo:</h3>
<p style="font-family:Courier New"><br>
Step1. Build and run the sample project in Visual Studio 2010. <br>
<br>
Step2. Prepare some image files. &nbsp;Click the &quot;Open Folder...&quot; button and
<br>
&nbsp; &nbsp; &nbsp; select the path which includes image files. <br>
<br>
Step3. Click &quot;Previous&quot; button and &quot;Next&quot; button to make image files
<br>
&nbsp; &nbsp; &nbsp; displayed in order.<br>
<br>
Step4. Left-click the &quot;Settings&quot; button and select the internal between the
<br>
&nbsp; &nbsp; &nbsp; displayed image files for Timer control in order to display them
<br>
&nbsp; &nbsp; &nbsp; with a fixed interval time. Finally, left-click the &quot;Start Slideshow&quot;<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; button to make the image files displayed one by one.<br>
<br>
Step5. Left-click the &quot;Full Screen&quot; button to display images in the full
<br>
&nbsp; &nbsp; &nbsp; screen mode. &nbsp;Press the &quot;ESC&quot; key to leave the full screen mode.<br>
<br>
</p>
<h3>Implementation:</h3>
<p style="font-family:Courier New"><br>
1. When user selects the root folder of image files, the sample enumerates <br>
&nbsp; the image files in the folder using the stack-based iteration method <br>
&nbsp; demonstrated in this MSDN article: <br>
&nbsp; <a target="_blank" href="&lt;a target=" href="&lt;a target=" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">
http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="&lt;a target=" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a><br>
&nbsp; The sample does not use <br>
&nbsp; &nbsp; &nbsp; &nbsp;Directory.GetFiles(path, &quot;*.*&quot;, SearchOption.AllDirectories)<br>
&nbsp; to enumerate the files because it will abort when the user does not have <br>
&nbsp; access permissions for certain directories or files in the root folder.<br>
<br>
&nbsp; &nbsp; &nbsp; Public Shared Function GetFiles(ByVal path As String, ByVal searchPattern As String) As String()<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim patterns() As String = searchPattern.Split(&quot;;&quot;c)<br>
&nbsp; &nbsp; &nbsp; &nbsp;Dim files As New List(Of String)()<br>
&nbsp; &nbsp; &nbsp; &nbsp;For Each filter As String In patterns<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' Iterate through the directory tree and ignore the
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' DirectoryNotFoundException or UnauthorizedAccessException
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' exceptions. <br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' <a target="_blank" href="&lt;a target=" href="&lt;a target=" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">
http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="&lt;a target=" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a><br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' Data structure to hold names of subfolders to be<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' examined for files.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim dirs As New Stack(Of String)(20)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;If Not Directory.Exists(path) Then<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Throw New ArgumentException()<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;End If<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;dirs.Push(path)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Do While dirs.Count &gt; 0<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim currentDir As String = dirs.Pop()<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim subDirs() As String<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Try<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;subDirs = Directory.GetDirectories(currentDir)<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' An UnauthorizedAccessException exception will be thrown
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' if we do not have discovery permission on a folder or
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' file. It may or may not be acceptable to ignore the
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' exception and continue enumerating the remaining files
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' and folders. It is also possible (but unlikely) that a
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' DirectoryNotFound exception will be raised. This will
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' happen if currentDir has been deleted by another
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' application or thread after our call to Directory.Exists.
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' The choice of which exceptions to catch depends entirely
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' on the specific task you are intending to perform and
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' also on how much you know with certainty about the
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' systems on which this code will run.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Catch e As UnauthorizedAccessException<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Continue Do<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Catch e As DirectoryNotFoundException<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Continue Do<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;End Try<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Try<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;files.AddRange(Directory.GetFiles(currentDir, filter))<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Catch e As UnauthorizedAccessException<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Continue Do<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Catch e As DirectoryNotFoundException<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Continue Do<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;End Try<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' Push the subdirectories onto the stack for traversal.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' This could also be done before handing the files.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;For Each str As String In subDirs<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;dirs.Push(str)<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Next str<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Loop<br>
&nbsp; &nbsp; &nbsp; &nbsp;Next filter<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;Return files.ToArray()<br>
&nbsp; &nbsp;End Function<br>
<br>
2. The sample displays the images in a PictureBox. <br>
<br>
&nbsp; &nbsp;''' &lt;summary&gt;<br>
&nbsp; &nbsp;''' Show the image in the PictureBox.<br>
&nbsp; &nbsp;''' &lt;/summary&gt;<br>
&nbsp; &nbsp;Public Shared Sub ShowImage(ByVal path As String, ByVal pct As PictureBox)<br>
&nbsp; &nbsp; &nbsp; &nbsp;pct.ImageLocation = path<br>
&nbsp; &nbsp;End Sub<br>
<br>
&nbsp; &nbsp;''' &lt;summary&gt;<br>
&nbsp; &nbsp;''' Show the previous image.<br>
&nbsp; &nbsp;''' &lt;/summary&gt;<br>
&nbsp; &nbsp;Private Sub ShowPrevImage()<br>
&nbsp; &nbsp; &nbsp; &nbsp;Me.selected -= 1<br>
&nbsp; &nbsp; &nbsp; &nbsp;ShowImage(Me.imageFiles((Me.selected) Mod Me.imageFiles.Length), Me.pictureBox)<br>
&nbsp; &nbsp;End Sub<br>
<br>
&nbsp; &nbsp;''' &lt;summary&gt;<br>
&nbsp; &nbsp;''' Show the next image.<br>
&nbsp; &nbsp;''' &lt;/summary&gt;<br>
&nbsp; &nbsp;Private Sub ShowNextImage()<br>
&nbsp; &nbsp; &nbsp; &nbsp;Me.selected &#43;= 1<br>
&nbsp; &nbsp; &nbsp; &nbsp;ShowImage(Me.imageFiles((Me.selected) Mod Me.imageFiles.Length), Me.pictureBox)<br>
&nbsp; &nbsp;End Sub<br>
<br>
&nbsp; A timer is used to automatically slideshow the images.<br>
<br>
&nbsp; &nbsp;''' &lt;summary&gt;<br>
&nbsp; &nbsp;''' Show the next image at every regular intervals.<br>
&nbsp; &nbsp;''' &lt;/summary&gt;<br>
&nbsp; &nbsp;Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick<br>
&nbsp; &nbsp; &nbsp; &nbsp;ShowNextImage()<br>
&nbsp; &nbsp;End Sub<br>
<br>
2. To slide-show images in the full-screen mode, the sample provides a helper <br>
&nbsp; class 'FullScreen'. &nbsp;FullScreen.cs contains two public methods: <br>
&nbsp; <br>
&nbsp; &nbsp; &nbsp; &nbsp;EnterFullScreen - used to make a Windows Form display in the full screen.<br>
&nbsp; &nbsp; &nbsp; &nbsp;LeaveFullScreen - used to restore a Windows Form to its original state.<br>
<br>
&nbsp; &nbsp;''' &lt;summary&gt;<br>
&nbsp; &nbsp;''' Maximize the window to the full screen.<br>
&nbsp; &nbsp;''' &lt;/summary&gt;<br>
&nbsp; &nbsp;Public Sub EnterFullScreen(ByVal targetForm As Form)<br>
&nbsp; &nbsp; &nbsp; &nbsp;If Not IsFullScreen Then<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Save(targetForm) ' Save the original form state.<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.WindowState = FormWindowState.Maximized<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.FormBorderStyle = FormBorderStyle.None<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.TopMost = True<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.Bounds = Screen.GetBounds(targetForm)<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;IsFullScreen = True<br>
&nbsp; &nbsp; &nbsp; &nbsp;End If<br>
&nbsp; &nbsp;End Sub<br>
&nbsp;&nbsp;&nbsp;&nbsp;<br>
&nbsp; &nbsp;''' &lt;summary&gt;<br>
&nbsp; &nbsp;''' Leave the full screen mode and restore the original window state.<br>
&nbsp; &nbsp;''' &lt;/summary&gt;<br>
&nbsp; &nbsp;Public Sub LeaveFullScreen(ByVal targetForm As Form)<br>
&nbsp; &nbsp; &nbsp; &nbsp;If IsFullScreen Then<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;' Restore the original Window state.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.WindowState = winState<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.FormBorderStyle = brdStyle<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.TopMost = topMost<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;targetForm.Bounds = bounds<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;IsFullScreen = False<br>
&nbsp; &nbsp; &nbsp; &nbsp;End If<br>
&nbsp; &nbsp;End Sub<br>
<br>
</p>
<h3>References:</h3>
<p style="font-family:Courier New"><br>
How to: Iterate Through a Directory Tree (C# Programming Guide)<br>
<a target="_blank" href="&lt;a target=" href="&lt;a target=" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="&lt;a target=" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a>'&gt;<a target="_blank" href="http://msdn.microsoft.com/en-us/library/bb513869.aspx">http://msdn.microsoft.com/en-us/library/bb513869.aspx</a><br>
<br>
Screen.GetBounds Method <br>
<a target="_blank" href="http://msdn.microsoft.com/en-us/library/system.windows.forms.screen.getbounds.aspx">http://msdn.microsoft.com/en-us/library/system.windows.forms.screen.getbounds.aspx</a><br>
<br>
<br>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo">
</a></div>