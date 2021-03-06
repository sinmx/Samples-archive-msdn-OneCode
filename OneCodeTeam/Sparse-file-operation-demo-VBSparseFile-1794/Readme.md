# Sparse file operation demo (VBSparseFile)
## Requires
* Visual Studio 2008
## License
* Apache License, Version 2.0
## Technologies
* File System
## Topics
* Sparse File
## IsPublished
* True
## ModifiedDate
* 2011-05-05 08:21:09
## Description

<p style="font-family:Courier New"></p>
<h2>CONSOLE APPLICATION : VBSparseFile Project Overview</h2>
<p style="font-family:Courier New"></p>
<h3>Use:</h3>
<p style="font-family:Courier New"><br>
VBSparseFile demonstrates the common operations on sparse files. A sparse <br>
file is a type of computer file that attempts to use file system space more <br>
efficiently when blocks allocated to the file are mostly empty. This is <br>
achieved by writing brief information (metadata) representing the empty <br>
blocks to disk instead of the actual &quot;empty&quot; space which makes up the block,
<br>
using less disk space. You can find in this example the creation of sparse <br>
file, the detection of sparse attribute, the retrieval of sparse file size, <br>
and the query of sparse file layout.<br>
<br>
</p>
<h3>Code Logic:</h3>
<p style="font-family:Courier New"><br>
A. Determine if the volume support sparse streams.<br>
<br>
The Win32 API function GetVolumeInformation returns a set of file system <br>
flags that you can analyze to determine if the drive supports sparse streams. <br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Get volume information<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim fileSystemFlags As FileSystemFeature<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim volumeSerialNumber As UInt32<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim maxComponentLength As UInt32<br>
&nbsp;&nbsp;&nbsp;&nbsp;NativeMethod.GetVolumeInformation(rootPathName, Nothing, _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NativeMethod.MAX_PATH, volumeSerialNumber, maxComponentLength, _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;fileSystemFlags, Nothing, NativeMethod.MAX_PATH)<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;Return ((fileSystemFlags And FileSystemFeature.SupportsSparseFiles) _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;= FileSystemFeature.SupportsSparseFiles)<br>
<br>
B. Create a sparse file.<br>
<br>
After creating a normal file, you must use the DeviceIoControl function with <br>
the FSCTL_SET_SPARSE control code to mark the file as sparse. Then you write <br>
blocks of data to the file and specify the region of data as sparse using <br>
the DeviceIoControl function with the FSCTL_SET_ZERO_DATA control code. The <br>
function also requires the starting and the ending address (not the size) of <br>
the sparse zero block. Note, however, that this operation does not perform <br>
actual file I/O, and unlike the WriteFile function, it does not move the <br>
current file I/O pointer or sets the end-of-file pointer. That is, if you <br>
want to place a sparse zero block in the end of the file, you must move the <br>
file pointer accordingly using the SetFilePointer function and call the <br>
SetEndOfFile function, otherwise DeviceIoControl will have no effect. <br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Create a normal file<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim fs As New FileStream(fileName, FileMode.Create, FileAccess.Write)<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Use the DeviceIoControl function with the FSCTL_SET_SPARSE control
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' code to mark the file as sparse. If you don't mark the file as
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' sparse, the FSCTL_SET_ZERO_DATA control code will actually write
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' zero bytes to the file instead of marking the region as sparse
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' zero area.<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim bytesReturned As Integer = 0<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim lpOverlapped As New NativeOverlapped<br>
&nbsp;&nbsp;&nbsp;&nbsp;NativeMethod.DeviceIoControl(fs.SafeFileHandle, _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;EIoControlCode.FsctlSetSparse, IntPtr.Zero, 0, IntPtr.Zero, 0, _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;bytesReturned, lpOverlapped)<br>
<br>
C. Determine if a file is sparse.<br>
<br>
In order to check if a file is sparse, use FileInfo.FileAttributes to check <br>
for FileAttributes.SparseFile.<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Get file information<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim fileInfo As New FileInfo(fileName)<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Check for sparse file<br>
&nbsp;&nbsp;&nbsp;&nbsp;Return ((fileInfo.Attributes And FileAttributes.SparseFile) = _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;FileAttributes.SparseFile)<br>
<br>
D. Get file size.<br>
<br>
Use the GetCompressedFileSize function to obtain the actual size allocated on <br>
disk for a sparse file. This total does not include the size of the regions <br>
which were deallocated because they were filled with zeroes. Use the <br>
FileInfo.Length property to determine the total size of a file, including the <br>
size of the sparse regions that were deallocated.<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Retrieves the size of the specified file, in bytes. The size
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' includes both allocated ranges and sparse ranges.<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim fileInfo As New FileInfo(fileName)<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim sparseFileSize As Long = fileInfo.Length<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Retrieves the file's actual size on disk, in bytes. The size
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' does not include the sparse ranges.<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim high As UInt32<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim low As UInt32 = NativeMethod.GetCompressedFileSize(fileName, high)<br>
&nbsp;&nbsp;&nbsp;&nbsp;Dim sparseFileCompressedSize As UInt64 = ((high &lt;&lt; &H20) &#43; low)<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;' Print the result<br>
&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(ChrW(10) & &quot;File total size: {0}KB&quot;, _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(sparseFileSize / &H400))<br>
&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(&quot;Actual size on disk: {0}KB&quot;, _<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(sparseFileCompressedSize / CULng(&H400)))<br>
<br>
E. Query the sparse file layout.<br>
<br>
You can specify the range to query in DeviceIoControl with the <br>
FSCTL_QUERY_ALLOCATED_RANGES control code, and provide a sufficient buffer <br>
for output info. The output contains the allocated (not sparse) regions in <br>
the sparse file.<br>
<br>
</p>
<h3>References:</h3>
<p style="font-family:Courier New"><br>
MSDN: Sparse Files<br>
<a target="_blank" href="http://msdn.microsoft.com/en-us/library/aa365564.aspx">http://msdn.microsoft.com/en-us/library/aa365564.aspx</a><br>
<br>
NTFS Sparse Files with C#<br>
<a target="_blank" href="http://blogs.msdn.com/codedebate/archive/2007/12/18/6797175.aspx">http://blogs.msdn.com/codedebate/archive/2007/12/18/6797175.aspx</a><br>
<br>
Technet: Fsutil sparse<br>
<a target="_blank" href="http://technet.microsoft.com/en-us/library/cc788025.aspx">http://technet.microsoft.com/en-us/library/cc788025.aspx</a><br>
<br>
Sparse files<br>
<a target="_blank" href="http://bartdesmet.net/blogs/bart/archive/2004/05/16/274.aspx">http://bartdesmet.net/blogs/bart/archive/2004/05/16/274.aspx</a><br>
<br>
<br>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo">
</a></div>
