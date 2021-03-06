# How to create Chart in Word document using OpenXML
## Requires
* Visual Studio 2012
## License
* Apache License, Version 2.0
## Technologies
* Office
* Office Development
## Topics
* OpenXml
* Create Chart
## IsPublished
* True
## ModifiedDate
* 2014-02-25 02:06:29
## Description

<hr>
<div><a href="http://blogs.msdn.com/b/onecode" style="margin-top:3px"><img src="http://bit.ly/onecodesampletopbanner" alt="">
</a></div>
<h1 class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>This sample demonstrates how to <span id="ms-rterangepaste-start">&nbsp;</span>create chart in word document using Open XML API.
</span></h1>
<h2 class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>&nbsp;Introduction</span></h2>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>Before building the sample, please make sure you have installed <a href="http://www.microsoft.com/en-us/download/details.aspx?id=30425">
Open XML SDK 2.5 for Microsoft Office</a>. </span></p>
<h2 class="MsoNormal" style="margin-bottom:7.5pt; line-height:normal"><span style="font-size:12.0pt; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; color:black">&nbsp;Buiding the Samlple</span></h2>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>The following steps walk through a demonstration of the Creating Chart in Word.
</span></p>
<h2 class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>&nbsp;Running the Sample</span></h2>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>Step1. Open span&gt;CSOpenXmlCreateChartInWord<span>.s.sln and then press Ctrl &#43; F5 to run this project. You will see the following form:
</span></span></p>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span><img src="/site/view/file/109347/1/image.png" alt="" width="460" height="301" align="middle">
</span><span>&nbsp;</span></p>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>&nbsp;</span></p>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>Step2. Click &quot;Save&quot; button to choose the location of the document will be saved.
</span></p>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>Step3. Click &quot;Create Chart&quot; button to create chart in Word document. You will see a pop-up message box prompting whether the operation is successful.
</span></p>
<h2 class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>&nbsp;Use the Code</span></h2>
<p class="MsoNormal"><span>Step1. Create Windows Form project. On the File Menu, choose New, Project, in the templates pane, select Windows Forms Application and enter the name of the project.
</span></p>
<p class="MsoNormal"><span>Step2. Add the Open xml reference to the project. To reference the Open XML, right click the project file and click the &quot;Add Reference&hellip;&quot; button. In the Add Reference dialog, navigate to the .Net tab, find DocumentFormat.OpenXml
 and WindowBase, then click OK button. </span></p>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>Step3. Create <strong>CreateWordChart </strong>clclass. Import the Open XML namespace in this class.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">pan
style='font-size:10.0pt;line-height:115%'&gt;


using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using d = DocumentFormat.OpenXml.Drawing;
using dc = DocumentFormat.OpenXml.Drawing.Charts;
using dw = DocumentFormat.OpenXml.Drawing.Wordprocessing;

</pre>
<pre id="codePreview" class="csharp">pan
style='font-size:10.0pt;line-height:115%'&gt;


using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using d = DocumentFormat.OpenXml.Drawing;
using dc = DocumentFormat.OpenXml.Drawing.Charts;
using dw = DocumentFormat.OpenXml.Drawing.Wordprocessing;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span>Step4. Create <strong>CreateChart</strong> method which implements the function of creating chart in the word document
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">pan
style='font-size:10.0pt;line-height:115%'&gt;


// Create Chart in Word document
      public void CreateChart(List&lt;ChartSubArea&gt; chartList)
      {
          // Get MainDocumentPart of Document
          MainDocumentPart mainPart = document.AddMainDocumentPart();
          mainPart.Document = new Document(new Body());


          // Create ChartPart object in Word Document
          ChartPart chartPart = mainPart.AddNewPart&lt;ChartPart&gt;(&quot;rId110&quot;);


          // the root element of chartPart 
          dc.ChartSpace chartSpace = new dc.ChartSpace();
          chartSpace.Append(new dc.EditingLanguage() { Val = &quot;en-us&quot; });
          
          // Create Chart 
          dc.Chart chart = new dc.Chart();
          chart.Append(new dc.AutoTitleDeleted() { Val=true });


          // Define the 3D view
          dc.View3D view3D = new dc.View3D();
          view3D.Append(new dc.RotateX() { Val = 30 });
          view3D.Append(new dc.RotateY() { Val = 0 });
          
          // Intiliazes a new instance of the PlotArea class
          dc.PlotArea plotArea = new dc.PlotArea();
          plotArea.Append(new dc.Layout());


          // the type of Chart 
          dc.Pie3DChart pie3DChart = new dc.Pie3DChart();
          pie3DChart.Append(new dc.VaryColors() { Val = true });
          dc.PieChartSeries pieChartSers = new dc.PieChartSeries();
          pieChartSers.Append(new dc.Index() { Val=0U});
          pieChartSers.Append(new dc.Order() { Val = 0U });
          dc.SeriesText seriesText = new dc.SeriesText();
          seriesText.Append(new dc.NumericValue() { Text = &quot;Series&quot; });


          uint rowcount = 0;
          uint count = UInt32.Parse(chartList.Count.ToString());
          string endCell = (count &#43; 1).ToString();
          dc.ChartShapeProperties chartShapePros = new dc.ChartShapeProperties();
         
          // Define cell for lable information
          dc.CategoryAxisData cateAxisData = new dc.CategoryAxisData();
          dc.StringReference stringRef = new dc.StringReference();
          stringRef.Append(new dc.Formula() { Text = &quot;Main!$A$2:$A$&quot; &#43; endCell });
          dc.StringCache stringCache = new dc.StringCache();
          stringCache.Append(new dc.PointCount() { Val = count });


          // Define cells for value information
          dc.Values values = new dc.Values();
          dc.NumberReference numRef = new dc.NumberReference();
          numRef.Append(new dc.Formula() { Text = &quot;Main!$B$2:$B$&quot; &#43; endCell });


          dc.NumberingCache numCache = new dc.NumberingCache();
          numCache.Append(new dc.FormatCode() { Text = &quot;General&quot; });
          numCache.Append(new dc.PointCount() { Val = count });


          // Fill data for chart
          foreach (var item in chartList)
          {
              if (count == 0)
              {
                  chartShapePros.Append(new d.SolidFill(new d.SchemeColor() { Val = item.Color }));
                  pieChartSers.Append(chartShapePros);
              }
              else
              {         
                  dc.DataPoint dataPoint = new dc.DataPoint();
                  dataPoint.Append(new dc.Index() { Val = rowcount });
                  chartShapePros = new dc.ChartShapeProperties();
                  chartShapePros.Append(new d.SolidFill(new d.SchemeColor() { Val = item.Color }));
                  dataPoint.Append(chartShapePros);
                  pieChartSers.Append(dataPoint);
              }


              dc.StringPoint stringPoint = new dc.StringPoint() { Index = rowcount };
              stringPoint.Append(new dc.NumericValue() { Text = item.Label });
              stringCache.Append(stringPoint);


              dc.NumericPoint numericPoint = new dc.NumericPoint() { Index = rowcount };
              numericPoint.Append(new dc.NumericValue() { Text = item.Value });
              numCache.Append(numericPoint);
              rowcount&#43;&#43;;
          }


          // Create c:cat and c:val element 
          stringRef.Append(stringCache);
          cateAxisData.Append(stringRef);
          numRef.Append(numCache);
          values.Append(numRef);


          // Append c:cat and c:val to the end of c:ser element
          pieChartSers.Append(cateAxisData);
          pieChartSers.Append(values);


          // Append c:ser to the end of c:pie3DChart element
          pie3DChart.Append(pieChartSers);


          // Append c:pie3DChart to the end of s:plotArea element
          plotArea.Append(pie3DChart);


          // create child elements of the c:legend element
          dc.Legend legend = new dc.Legend();
          legend.Append(new dc.LegendPosition() { Val = LegendPositionValues.Right });
          dc.Overlay overlay = new dc.Overlay() { Val = false };
          legend.Append(overlay);


          dc.TextProperties textPros = new TextProperties();
          textPros.Append(new d.BodyProperties());
          textPros.Append(new d.ListStyle());


          d.Paragraph paragraph = new d.Paragraph();
          d.ParagraphProperties paraPros = new d.ParagraphProperties();
          d.DefaultParagraphProperties defaultParaPros = new d.DefaultParagraphProperties();
          defaultParaPros.Append(new d.LatinFont() { Typeface = &quot;Arial&quot;, PitchFamily = 34, CharacterSet = 0 });
          defaultParaPros.Append(new d.ComplexScriptFont() { Typeface = &quot;Arial&quot;, PitchFamily = 34, CharacterSet = 0 });
          paraPros.Append(defaultParaPros);
          paragraph.Append(paraPros);
          paragraph.Append(new d.EndParagraphRunProperties() { Language=&quot;en-Us&quot;});


          textPros.Append(paragraph);
          legend.Append(textPros);


          // Append c:view3D, c:plotArea and c:legend elements to the end of c:chart element
          chart.Append(view3D);
          chart.Append(plotArea);
          chart.Append(legend);


          // Append the c:chart element to the end of c:chartSpace element
          chartSpace.Append(chart);


          // Create c:spPr Elements and fill the child elements of it
          chartShapePros = new dc.ChartShapeProperties();
          d.Outline outline = new d.Outline();
          outline.Append(new d.NoFill());
          chartShapePros.Append(outline);


          // Append c:spPr element to the end of c:chartSpace element
          chartSpace.Append(chartShapePros);


          chartPart.ChartSpace = chartSpace;
          
          // Generate content of the MainDocumentPart
          GeneratePartContent(mainPart);
      }

</pre>
<pre id="codePreview" class="csharp">pan
style='font-size:10.0pt;line-height:115%'&gt;


// Create Chart in Word document
      public void CreateChart(List&lt;ChartSubArea&gt; chartList)
      {
          // Get MainDocumentPart of Document
          MainDocumentPart mainPart = document.AddMainDocumentPart();
          mainPart.Document = new Document(new Body());


          // Create ChartPart object in Word Document
          ChartPart chartPart = mainPart.AddNewPart&lt;ChartPart&gt;(&quot;rId110&quot;);


          // the root element of chartPart 
          dc.ChartSpace chartSpace = new dc.ChartSpace();
          chartSpace.Append(new dc.EditingLanguage() { Val = &quot;en-us&quot; });
          
          // Create Chart 
          dc.Chart chart = new dc.Chart();
          chart.Append(new dc.AutoTitleDeleted() { Val=true });


          // Define the 3D view
          dc.View3D view3D = new dc.View3D();
          view3D.Append(new dc.RotateX() { Val = 30 });
          view3D.Append(new dc.RotateY() { Val = 0 });
          
          // Intiliazes a new instance of the PlotArea class
          dc.PlotArea plotArea = new dc.PlotArea();
          plotArea.Append(new dc.Layout());


          // the type of Chart 
          dc.Pie3DChart pie3DChart = new dc.Pie3DChart();
          pie3DChart.Append(new dc.VaryColors() { Val = true });
          dc.PieChartSeries pieChartSers = new dc.PieChartSeries();
          pieChartSers.Append(new dc.Index() { Val=0U});
          pieChartSers.Append(new dc.Order() { Val = 0U });
          dc.SeriesText seriesText = new dc.SeriesText();
          seriesText.Append(new dc.NumericValue() { Text = &quot;Series&quot; });


          uint rowcount = 0;
          uint count = UInt32.Parse(chartList.Count.ToString());
          string endCell = (count &#43; 1).ToString();
          dc.ChartShapeProperties chartShapePros = new dc.ChartShapeProperties();
         
          // Define cell for lable information
          dc.CategoryAxisData cateAxisData = new dc.CategoryAxisData();
          dc.StringReference stringRef = new dc.StringReference();
          stringRef.Append(new dc.Formula() { Text = &quot;Main!$A$2:$A$&quot; &#43; endCell });
          dc.StringCache stringCache = new dc.StringCache();
          stringCache.Append(new dc.PointCount() { Val = count });


          // Define cells for value information
          dc.Values values = new dc.Values();
          dc.NumberReference numRef = new dc.NumberReference();
          numRef.Append(new dc.Formula() { Text = &quot;Main!$B$2:$B$&quot; &#43; endCell });


          dc.NumberingCache numCache = new dc.NumberingCache();
          numCache.Append(new dc.FormatCode() { Text = &quot;General&quot; });
          numCache.Append(new dc.PointCount() { Val = count });


          // Fill data for chart
          foreach (var item in chartList)
          {
              if (count == 0)
              {
                  chartShapePros.Append(new d.SolidFill(new d.SchemeColor() { Val = item.Color }));
                  pieChartSers.Append(chartShapePros);
              }
              else
              {         
                  dc.DataPoint dataPoint = new dc.DataPoint();
                  dataPoint.Append(new dc.Index() { Val = rowcount });
                  chartShapePros = new dc.ChartShapeProperties();
                  chartShapePros.Append(new d.SolidFill(new d.SchemeColor() { Val = item.Color }));
                  dataPoint.Append(chartShapePros);
                  pieChartSers.Append(dataPoint);
              }


              dc.StringPoint stringPoint = new dc.StringPoint() { Index = rowcount };
              stringPoint.Append(new dc.NumericValue() { Text = item.Label });
              stringCache.Append(stringPoint);


              dc.NumericPoint numericPoint = new dc.NumericPoint() { Index = rowcount };
              numericPoint.Append(new dc.NumericValue() { Text = item.Value });
              numCache.Append(numericPoint);
              rowcount&#43;&#43;;
          }


          // Create c:cat and c:val element 
          stringRef.Append(stringCache);
          cateAxisData.Append(stringRef);
          numRef.Append(numCache);
          values.Append(numRef);


          // Append c:cat and c:val to the end of c:ser element
          pieChartSers.Append(cateAxisData);
          pieChartSers.Append(values);


          // Append c:ser to the end of c:pie3DChart element
          pie3DChart.Append(pieChartSers);


          // Append c:pie3DChart to the end of s:plotArea element
          plotArea.Append(pie3DChart);


          // create child elements of the c:legend element
          dc.Legend legend = new dc.Legend();
          legend.Append(new dc.LegendPosition() { Val = LegendPositionValues.Right });
          dc.Overlay overlay = new dc.Overlay() { Val = false };
          legend.Append(overlay);


          dc.TextProperties textPros = new TextProperties();
          textPros.Append(new d.BodyProperties());
          textPros.Append(new d.ListStyle());


          d.Paragraph paragraph = new d.Paragraph();
          d.ParagraphProperties paraPros = new d.ParagraphProperties();
          d.DefaultParagraphProperties defaultParaPros = new d.DefaultParagraphProperties();
          defaultParaPros.Append(new d.LatinFont() { Typeface = &quot;Arial&quot;, PitchFamily = 34, CharacterSet = 0 });
          defaultParaPros.Append(new d.ComplexScriptFont() { Typeface = &quot;Arial&quot;, PitchFamily = 34, CharacterSet = 0 });
          paraPros.Append(defaultParaPros);
          paragraph.Append(paraPros);
          paragraph.Append(new d.EndParagraphRunProperties() { Language=&quot;en-Us&quot;});


          textPros.Append(paragraph);
          legend.Append(textPros);


          // Append c:view3D, c:plotArea and c:legend elements to the end of c:chart element
          chart.Append(view3D);
          chart.Append(plotArea);
          chart.Append(legend);


          // Append the c:chart element to the end of c:chartSpace element
          chartSpace.Append(chart);


          // Create c:spPr Elements and fill the child elements of it
          chartShapePros = new dc.ChartShapeProperties();
          d.Outline outline = new d.Outline();
          outline.Append(new d.NoFill());
          chartShapePros.Append(outline);


          // Append c:spPr element to the end of c:chartSpace element
          chartSpace.Append(chartShapePros);


          chartPart.ChartSpace = chartSpace;
          
          // Generate content of the MainDocumentPart
          GeneratePartContent(mainPart);
      }

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span>Step5. Click &quot;Save&quot; button to choose the location of the word document will be saved.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">n
style='font-size:10.0pt;line-height:115%'&gt;


private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = &quot;Word document (*.docx)|*.docx&quot;;
                saveDialog.InitialDirectory = Environment.CurrentDirectory;
                saveDialog.RestoreDirectory = true;
                saveDialog.DefaultExt = &quot;docx&quot;;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs= File.Create(saveDialog.FileName);
                    tbxFile.Text = saveDialog.FileName;
                    this.btnCreateChart.Enabled = true;
                    fs.Close();
                }
            }
        }     
    }

</pre>
<pre id="codePreview" class="csharp">n
style='font-size:10.0pt;line-height:115%'&gt;


private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = &quot;Word document (*.docx)|*.docx&quot;;
                saveDialog.InitialDirectory = Environment.CurrentDirectory;
                saveDialog.RestoreDirectory = true;
                saveDialog.DefaultExt = &quot;docx&quot;;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs= File.Create(saveDialog.FileName);
                    tbxFile.Text = saveDialog.FileName;
                    this.btnCreateChart.Enabled = true;
                    fs.Close();
                }
            }
        }     
    }

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span>Step6. Click &quot;Create Chart&quot; button to create chart in word document.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">style='font-size:10.0pt;line-height:115%'&gt;


private void btnCreateChart_Click(object sender, EventArgs e)
      {
          CreateWordChart createWordChart=null;
          try
          {
              createWordChart = new CreateWordChart(this.tbxFile.Text);
              List&lt;ChartSubArea&gt; chartAreas = new List&lt;ChartSubArea&gt;();
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent1, Label = &quot;1st Qtr&quot;, Value = &quot;8.2&quot; });
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent2, Label = &quot;2st Qtr&quot;, Value = &quot;3.2&quot; });
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent3, Label = &quot;3st Qtr&quot;, Value = &quot;1.4&quot; });
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent4, Label = &quot;4st Qtr&quot;, Value = &quot;1.2&quot; });
              createWordChart.CreateChart(chartAreas);
              MessageBox.Show(&quot;Create Chart successfully, you can check your document!&quot;);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, &quot;Error&quot;, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          finally
          {
              if (createWordChart != null)
              {
                  createWordChart.Dispose();
              }
          }
      }

</pre>
<pre id="codePreview" class="csharp">style='font-size:10.0pt;line-height:115%'&gt;


private void btnCreateChart_Click(object sender, EventArgs e)
      {
          CreateWordChart createWordChart=null;
          try
          {
              createWordChart = new CreateWordChart(this.tbxFile.Text);
              List&lt;ChartSubArea&gt; chartAreas = new List&lt;ChartSubArea&gt;();
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent1, Label = &quot;1st Qtr&quot;, Value = &quot;8.2&quot; });
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent2, Label = &quot;2st Qtr&quot;, Value = &quot;3.2&quot; });
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent3, Label = &quot;3st Qtr&quot;, Value = &quot;1.4&quot; });
              chartAreas.Add(new ChartSubArea() { Color = SchemeColorValues.Accent4, Label = &quot;4st Qtr&quot;, Value = &quot;1.2&quot; });
              createWordChart.CreateChart(chartAreas);
              MessageBox.Show(&quot;Create Chart successfully, you can check your document!&quot;);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, &quot;Error&quot;, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          finally
          {
              if (createWordChart != null)
              {
                  createWordChart.Dispose();
              }
          }
      }

</pre>
</div>
</div>
<h2 class="endscriptcode">&nbsp;More Information</h2>
<p class="MsoNormal"><span>&nbsp;</span></p>
<p class="MsoNormal"><span><a href="http://msdn.microsoft.com/en-us/library/bb448854.aspx">Open XML SDK 2.5</a></span><span>
</span></p>
<p class="MsoNormal"><span><a href="http://msdn.microsoft.com/en-us/library/cc850833.aspx">Word Processing</a>
</span></p>
<p class="MsoNormal"><span><a href="http://msdn.microsoft.com/en-us/office/bb265236">Open XML Developer Center</a>
</span></p>
<p class="MsoNormal">&nbsp;</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt="">
</a></div>
