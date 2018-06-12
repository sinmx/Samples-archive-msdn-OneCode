# How to disable specified items selection in Listview/Gridview
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows 8
## Topics
* Data Binding
* Windows 8
## IsPublished
* True
## ModifiedDate
* 2013-04-16 10:05:41
## Description

<h1><span><a href="http://www.microsoft.com/click/services/Redirect2.ashx?CR_CC=200144425" target="_blank"><img id="79968" src="http://i1.code.msdn.s-msft.com/cswindowsstoreappadditem-a5d7fbcc/image/file/79968/1/dpe_w8_728x90_1022_v2.jpg" alt="" width="728" height="90" style="width:100%"></a></span></h1>
<h1>How to disable specific item selection in GridView (<span>VB</span>WindowsStoreAppDisableItem)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">This sample demonstrates how to disable specific items selection in GridView. You can add item to the GridView and specify whether it could be selected, and see the effect of it.</p>
<h2>Build the Sample</h2>
<p class="MsoListParagraphCxSpFirst"><span><span>1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Start Visual Studio 2012 and select File &gt; Open &gt; Project/Solution.</p>
<p class="MsoListParagraphCxSpMiddle"><span><span>2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Go to the directory in which you download the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution(.sln) file.</p>
<p class="MsoListParagraphCxSpLast"><span><span>3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Press F7 or use Build &gt; Build Solution to build the sample.</p>
<h2>Running the Sample</h2>
<p class="MsoListParagraphCxSpFirst"><span><span>1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Press F5 to run it.</p>
<p class="MsoListParagraphCxSpMiddle"><span><span>2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>After the sample is launched, you will see this screen.</p>
<p class="MsoListParagraphCxSpMiddle"><span><img src="/site/view/file/73732/1/image.png" alt="" width="866" height="493" align="middle">
</span></p>
<p class="MsoListParagraphCxSpMiddle"><span><span>3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>You can complete the information input and click &quot;Add&quot; button to add an item to the GridView. If &quot;Available&quot; is false, this item couldn't be selected in the GridView, and its color is gray.</p>
<p class="MsoListParagraphCxSpMiddle"><span><img src="/site/view/file/73733/1/image.png" alt="" width="867" height="489" align="middle">
</span></p>
<p class="MsoListParagraphCxSpMiddle"><span><span>4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Click any items to see the effect.</p>
<p class="MsoListParagraphCxSpLast"><span><img src="/site/view/file/73734/1/image.png" alt="" width="869" height="497" align="middle">
</span></p>
<h2>Using the Code</h2>
<p class="MsoNormal">The code below shows how to get the index of tapped item in the GridView by the tapped position.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">vb</span>
<pre class="hidden">' The y coordinate of the tapped position
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim y As Double = e.GetPosition(DirectCast(sender, UIElement)).Y


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The x coordinate of the tapped position
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim x As Double = e.GetPosition(DirectCast(sender, UIElement)).X


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim gvBooksContainer As GridView = TryCast(sender, GridView)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvBooksContainer.Measure(New Size(235, 80))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim size As Size = gvBooksContainer.DesiredSize


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The tapped item's x index
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim itemX As Integer = CInt(Math.Truncate(x / size.Width))


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The tapped item's y index
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim itemY As Integer = CInt(Math.Truncate(y / size.Height))


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Get the index of tapped item
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim index As Integer = CInt(itemY * CInt(gvBooks.ActualWidth / size.Width)) &#43; itemX

</pre>
<pre id="codePreview" class="vb">' The y coordinate of the tapped position
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim y As Double = e.GetPosition(DirectCast(sender, UIElement)).Y


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The x coordinate of the tapped position
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim x As Double = e.GetPosition(DirectCast(sender, UIElement)).X


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim gvBooksContainer As GridView = TryCast(sender, GridView)


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvBooksContainer.Measure(New Size(235, 80))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim size As Size = gvBooksContainer.DesiredSize


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The tapped item's x index
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim itemX As Integer = CInt(Math.Truncate(x / size.Width))


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' The tapped item's y index
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim itemY As Integer = CInt(Math.Truncate(y / size.Height))


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ' Get the index of tapped item
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dim index As Integer = CInt(itemY * CInt(gvBooks.ActualWidth / size.Width)) &#43; itemX

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoNormal">The code below shows how to get the instance of tapped item's item source.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">vb</span>
<pre class="hidden">Dim book As Book = TryCast(gvBooks.Items(index), Book)

</pre>
<pre id="codePreview" class="vb">Dim book As Book = TryCast(gvBooks.Items(index), Book)

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoNormal">The code below shows how to get the tapped item in the GridView by ItemContainerGenerator.ContainerFromIndex method and select it.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">vb</span>
<pre class="hidden">Dim tappedItem As GridViewItem = TryCast(gvBooksContainer.ItemContainerGenerator.ContainerFromIndex(index), GridViewItem)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvBooksContainer.SelectionMode = ListViewSelectionMode.[Single]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tappedItem.IsSelected = True

</pre>
<pre id="codePreview" class="vb">Dim tappedItem As GridViewItem = TryCast(gvBooksContainer.ItemContainerGenerator.ContainerFromIndex(index), GridViewItem)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; gvBooksContainer.SelectionMode = ListViewSelectionMode.[Single]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tappedItem.IsSelected = True

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">&nbsp;</p>
<p class="MsoNormal">&nbsp;</p>
<h2>More Information</h2>
<p class="MsoNormal"><a href="http://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.uielement.tapped">UIElement.Tapped event</a></p>
<p class="MsoNormal"><a href="http://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.input.tappedroutedeventargs.getposition.aspx">TappedRoutedEventArgs.GetPosition method</a></p>
<p class="MsoNormal"><a href="http://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.itemcontainergenerator.containerfromindex.aspx">ItemContainerGenerator.ContainerFromIndex method</a></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt="">
</a></div>