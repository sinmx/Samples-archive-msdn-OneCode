# Import/Export GridView data in asp.net (VBOpenXmlExportImportExcel)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Office Development
## Topics
* GridView
* Export/Import
## IsPublished
* True
## ModifiedDate
* 2012-12-25 02:22:37
## Description

<h1>How to Import/Export GridView data in Asp.NET (VBOpenXmlExportImportExcel)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">The sample demonstrates how to export Data in GridView control to Excel and import excel data to GridView using Open XML SDK.
</p>
<h2>Building the Sample</h2>
<p class="MsoNormal">Before building the sample, please make sure you have installed
<a href="http://www.microsoft.com/en-us/download/details.aspx?id=5124">Open XML SDK 2.0 for Microsoft Office</a>.</p>
<h2>Running the Sample</h2>
<p class="MsoNormal">Step 1. Open &quot;VBOpenXmlExportImportExcel.sln&quot; and click Ctrl&#43;F5 to run this project. You will see the following web form:</p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/73488/1/image.png" alt="" width="417" height="314" align="middle">
</span></p>
<p class="MsoNormal">Step 2. <span style="">You can click &quot;Browser&quot; button to select an existing excel file and then click
</span><span style="">&quot;</span><span style="">Import</span><span style="">&quot;
</span><span style="">button to import the data to GridView control. If this operation is successful, the GridView control will fill the data in excel file. At this moment, the &quot;Export&quot; button will be enable.
</span></p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/73489/1/image.png" alt="" width="419" height="314" align="middle">
</span></p>
<p class="MsoNormal">Step 3. Click &quot;Export&quot; button to export the Data in GridView control to excel file. The file will save in the root of current project.</p>
<h2>Using the Code</h2>
<p class="MsoNormal">Step 1. Create &quot;Asp.NET Empty Web Application&quot; project</p>
<p class="MsoNormal">Step 2. <span style="">After you have installed the Open XML SDK 2.0, add the Open xml reference to the project. To reference the Open XML, right click the project file and click the &quot;Add Reference&quot; button. In the Add Reference
 dialog, navigate to the .Net tab, find DocumentFormat.OpenXml and WindowsBase, click Ok button.
</span></p>
<p class="MsoNormal"><span style="">Step 3. Create CreateSpreadSheetProvider class to create excel file using Open XML API.
</span></p>
<p class="MsoNormal"><span style="">Step 4. Import Open XML namespace into the class.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet

</pre>
<pre id="codePreview" class="vb">
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step 5. Define ExportToExcel method to export the data in GridView control to Excel file.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
''' &lt;summary&gt;
   '''  Generate an excel file with data in GridView control
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;datatable&quot;&gt;DataTable object&lt;/param&gt;
   ''' &lt;param name=&quot;filepath&quot;&gt;The Path of exported excel file&lt;/param&gt;
   Public Sub ExportToExcel(datatable As DataTable, filepath As String)
       ' Initialize an instance of  SpreadSheet Document 
       Using _spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook)
           CreateExcelFile(_spreadsheetDocument, datatable)
       End Using
   End Sub


   ''' &lt;summary&gt;
   '''  Create SpreadSheet Document and Fill datas
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;spreadsheetdoc&quot;&gt;SpreadSheet Document&lt;/param&gt;
   ''' &lt;param name=&quot;table&quot;&gt;DataTable Object&lt;/param&gt;
   Private Sub CreateExcelFile(spreadsheetdoc As SpreadsheetDocument, table As DataTable)
       ' Initialize an instance of WorkbookPart
       Dim workBookPart As WorkbookPart = spreadsheetdoc.AddWorkbookPart()


       ' Create WorkBook 
       CreateWorkBookPart(workBookPart)


       ' Add WorkSheetPart into WorkBook
       Dim worksheetPart1 As WorksheetPart = workBookPart.AddNewPart(Of WorksheetPart)(&quot;rId1&quot;)
       CreateWorkSheetPart(worksheetPart1, table)


       ' Add SharedStringTable Part into WorkBook
       Dim sharedStringTablePart As SharedStringTablePart = workBookPart.AddNewPart(Of SharedStringTablePart)(&quot;rId2&quot;)
       CreateSharedStringTablePart(sharedStringTablePart, table)


       ' Add WorkbookStyles Part into Workbook
       Dim workbookStylesPart As WorkbookStylesPart = workBookPart.AddNewPart(Of WorkbookStylesPart)(&quot;rId3&quot;)
       CreateWorkBookStylesPart(workbookStylesPart)


       ' Save workbook
       workBookPart.Workbook.Save()
   End Sub


   ''' &lt;summary&gt;
   ''' Create an Workbook instance and add its children
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;workbookPart&quot;&gt;WorkbookPart Object&lt;/param&gt;
   Private Sub CreateWorkBookPart(workbookPart As WorkbookPart)
       Dim workbook As New Workbook()
       Dim sheets As New Sheets()


       ' Initilize an instance of Sheet Object
       Dim sheet1 As New Sheet() With { _
        .Name = &quot;Sheet1&quot;, _
        .SheetId = Convert.ToUInt32(1),
        .Id = &quot;rId1&quot;
       }


       ' Add the sheet into sheets collection
       sheets.Append(sheet1)


       Dim calculationProperties1 As New CalculationProperties() With { _
         .CalculationId = Convert.ToUInt32(111222)
       }


       ' Add elements into workbook
       workbook.Append(sheets)
       workbook.Append(calculationProperties1)
       workbookPart.Workbook = workbook
   End Sub


   ''' &lt;summary&gt;
   '''  Generates content of worksheetPart
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;worksheetPart&quot;&gt;WorksheetPart Object&lt;/param&gt;
   ''' &lt;param name=&quot;table&quot;&gt;DataTable Object&lt;/param&gt;
   Private Sub CreateWorkSheetPart(worksheetPart As WorksheetPart, table As DataTable)
       ' Initialize worksheet and set the properties
       Dim worksheet1 As New Worksheet() With { _
         .MCAttributes = New MarkupCompatibilityAttributes() With {
          .Ignorable = &quot;x14ac&quot;
        }
       }
       worksheet1.AddNamespaceDeclaration(&quot;r&quot;, &quot;http://schemas.openxmlformats.org/officeDocument/2006/relationships&quot;)
       worksheet1.AddNamespaceDeclaration(&quot;mc&quot;, &quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;)
       worksheet1.AddNamespaceDeclaration(&quot;x14ac&quot;, &quot;http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac&quot;)


       Dim sheetViews1 As New SheetViews()


       ' Initialize an instance of the sheetview class
       Dim sheetView1 As New SheetView() With { _
         .WorkbookViewId = Convert.ToUInt32(0)
       }


       Dim selection As New Selection() With { _
         .ActiveCell = &quot;A1&quot;
       }


       sheetView1.Append(selection)


       sheetViews1.Append(sheetView1)
       Dim sheetFormatProperties1 As New SheetFormatProperties() With { _
         .DefaultRowHeight = 15.0, _
         .DyDescent = 0.25 _
       }


       Dim sheetData1 As New SheetData()
       Dim rowIndex As UInt32 = 1UI
       Dim pageMargins1 As New PageMargins() With { _
         .Left = 0.7, _
         .Right = 0.7, _
         .Top = 0.75, _
         .Bottom = 0.75, _
         .Header = 0.3, _
         .Footer = 0.3
       }


       Dim row1 As New Row() With { _
         .RowIndex = rowIndex, _
         .Spans = New ListValue(Of StringValue)() With { _
          .InnerText = &quot;1:3&quot; _
        }, _
         .DyDescent = 0.25 _
       }


       ' Add columns in DataTable to columns collection of SpreadSheet Document 
       For columnindex As Integer = 0 To table.Columns.Count - 1
           Dim cell As New Cell() With { _
             .CellReference = New CreateSpreadSheetProvider().[Get](columnindex, (Convert.ToInt32(UInt32Value.ToUInt32(rowIndex)) - 1)), _
             .DataType = CellValues.[String]
           }


           ' Get Value of DataTable and append the value to cell of spreadsheet document
           Dim cellValue As New CellValue()
           cellValue.Text = table.Columns(columnindex).ColumnName.ToString()
           cell.Append(cellValue)


           row1.Append(cell)
       Next


       ' Add row to sheet
       sheetData1.Append(row1)


       ' Add rows in DataTable to rows collection of SpreadSheet Document 
       For rIndex As Integer = 0 To table.Rows.Count - 1
           rowIndex = UInt32Value.ToUInt32(rowIndex) &#43; 1
           Dim row As New Row() With { _
             .RowIndex = rowIndex, _
             .Spans = New ListValue(Of StringValue)() With { _
              .InnerText = &quot;1:3&quot; _
            }, _
             .DyDescent = 0.25 _
           }


           For cIndex As Integer = 0 To table.Columns.Count - 1
               Dim cell As New Cell() With { _
                 .CellReference = New CreateSpreadSheetProvider().[Get](cIndex, (Convert.ToInt32(UInt32Value.ToUInt32(rowIndex)) - 1)), _
                 .DataType = CellValues.[String] _
               }


               Dim cellValue As New CellValue()
               cellValue.Text = table.Rows(rIndex)(cIndex).ToString()
               cell.Append(cellValue)
               row.Append(cell)
           Next


           ' Add row to Sheet Data
           sheetData1.Append(row)
       Next


       ' Add elements to worksheet
       worksheet1.Append(sheetViews1)
       worksheet1.Append(sheetFormatProperties1)
       worksheet1.Append(sheetData1)
       worksheet1.Append(pageMargins1)


       worksheetPart.Worksheet = worksheet1
   End Sub


   ''' &lt;summary&gt;
   ''' Generates content of sharedStringTablePart
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;sharedStringTablePart&quot;&gt;SharedStringTablePart Object&lt;/param&gt;
   ''' &lt;param name=&quot;table&quot;&gt;DataTable Object&lt;/param&gt;
   Private Sub CreateSharedStringTablePart(sharedStringTablePart As SharedStringTablePart, table As DataTable)
       Dim stringCount As UInt32Value = Convert.ToUInt32(table.Rows.Count) &#43; Convert.ToUInt32(table.Columns.Count)


       ' Initialize an instance of SharedString Table
       Dim sharedStringTable As New SharedStringTable() With { _
         .Count = stringCount, _
         .UniqueCount = stringCount
       }


       ' Add columns of DataTable to sharedString iteam
       For columnIndex As Integer = 0 To table.Columns.Count - 1
           Dim sharedStringItem As New SharedStringItem()
           Dim text As New Text()
           text.Text = table.Columns(columnIndex).ColumnName
           sharedStringItem.Append(text)


           ' Add sharedstring item to sharedstring Table
           sharedStringTable.Append(sharedStringItem)
       Next


       ' Add rows of DataTable to sharedString iteam
       For rowIndex As Integer = 0 To table.Rows.Count - 1
           Dim sharedStringItem As New SharedStringItem()
           Dim text As New Text()
           text.Text = table.Rows(rowIndex)(0).ToString()
           sharedStringItem.Append(text)
           sharedStringTable.Append(sharedStringItem)
       Next


       sharedStringTablePart.SharedStringTable = sharedStringTable
   End Sub


   ''' &lt;summary&gt;
   ''' Generates content of workbookStylesPart
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;workbookStylesPart&quot;&gt;WorkbookStylesPart Object&lt;/param&gt;
   Private Sub CreateWorkBookStylesPart(workbookStylesPart As WorkbookStylesPart)
       ' Define Style of Sheet in workbook
       Dim stylesheet1 As New Stylesheet() With { _
         .MCAttributes = New MarkupCompatibilityAttributes() With { _
          .Ignorable = &quot;x14ac&quot; _
        } _
       }
       stylesheet1.AddNamespaceDeclaration(&quot;mc&quot;, &quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;)
       stylesheet1.AddNamespaceDeclaration(&quot;x14ac&quot;, &quot;http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac&quot;)


       ' Initialize  an instance of fonts
       Dim fonts As New Fonts() With { _
         .Count = 2UI, _
         .KnownFonts = True
       }


       ' Initialize  an instance of font,fontsize,color
       Dim font As New Font()
       Dim fontSize As New FontSize() With { _
         .Val = 14.0 _
       }
       Dim color As New Color() With { _
         .Theme = 1UI
       }
       Dim fontName As New FontName() With { _
         .Val = &quot;Calibri&quot; _
       }
       Dim fontFamilyNumbering As New FontFamilyNumbering() With { _
         .Val = 2UI
       }
       Dim fontScheme As New FontScheme() With { _
         .Val = FontSchemeValues.Minor _
       }


       ' Add elements to font
       font.Append(fontSize)
       font.Append(color)
       font.Append(fontName)
       font.Append(fontFamilyNumbering)
       font.Append(fontScheme)


       fonts.Append(font)


       ' Define the StylesheetExtensionList Class. When the object is serialized out as xml, its qualified name is x:extLst
       Dim stylesheetExtensionList1 As New StylesheetExtensionList()


       ' Define the StylesheetExtension Class
       Dim stylesheetExtension1 As New StylesheetExtension() With { _
         .Uri = &quot;{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}&quot; _
       }
       stylesheetExtension1.AddNamespaceDeclaration(&quot;x14&quot;, &quot;http://schemas.microsoft.com/office/spreadsheetml/2009/9/main&quot;)
       Dim slicerStyles1 As New DocumentFormat.OpenXml.Office2010.Excel.SlicerStyles() With { _
         .DefaultSlicerStyle = &quot;SlicerStyleLight1&quot; _
       }


       stylesheetExtension1.Append(slicerStyles1)
       stylesheetExtensionList1.Append(stylesheetExtension1)


       ' Add elements to stylesheet
       stylesheet1.Append(fonts)
       stylesheet1.Append(stylesheetExtensionList1)


       ' Set the style of workbook
       workbookStylesPart.Stylesheet = stylesheet1
   End Sub

</pre>
<pre id="codePreview" class="vb">
''' &lt;summary&gt;
   '''  Generate an excel file with data in GridView control
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;datatable&quot;&gt;DataTable object&lt;/param&gt;
   ''' &lt;param name=&quot;filepath&quot;&gt;The Path of exported excel file&lt;/param&gt;
   Public Sub ExportToExcel(datatable As DataTable, filepath As String)
       ' Initialize an instance of  SpreadSheet Document 
       Using _spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook)
           CreateExcelFile(_spreadsheetDocument, datatable)
       End Using
   End Sub


   ''' &lt;summary&gt;
   '''  Create SpreadSheet Document and Fill datas
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;spreadsheetdoc&quot;&gt;SpreadSheet Document&lt;/param&gt;
   ''' &lt;param name=&quot;table&quot;&gt;DataTable Object&lt;/param&gt;
   Private Sub CreateExcelFile(spreadsheetdoc As SpreadsheetDocument, table As DataTable)
       ' Initialize an instance of WorkbookPart
       Dim workBookPart As WorkbookPart = spreadsheetdoc.AddWorkbookPart()


       ' Create WorkBook 
       CreateWorkBookPart(workBookPart)


       ' Add WorkSheetPart into WorkBook
       Dim worksheetPart1 As WorksheetPart = workBookPart.AddNewPart(Of WorksheetPart)(&quot;rId1&quot;)
       CreateWorkSheetPart(worksheetPart1, table)


       ' Add SharedStringTable Part into WorkBook
       Dim sharedStringTablePart As SharedStringTablePart = workBookPart.AddNewPart(Of SharedStringTablePart)(&quot;rId2&quot;)
       CreateSharedStringTablePart(sharedStringTablePart, table)


       ' Add WorkbookStyles Part into Workbook
       Dim workbookStylesPart As WorkbookStylesPart = workBookPart.AddNewPart(Of WorkbookStylesPart)(&quot;rId3&quot;)
       CreateWorkBookStylesPart(workbookStylesPart)


       ' Save workbook
       workBookPart.Workbook.Save()
   End Sub


   ''' &lt;summary&gt;
   ''' Create an Workbook instance and add its children
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;workbookPart&quot;&gt;WorkbookPart Object&lt;/param&gt;
   Private Sub CreateWorkBookPart(workbookPart As WorkbookPart)
       Dim workbook As New Workbook()
       Dim sheets As New Sheets()


       ' Initilize an instance of Sheet Object
       Dim sheet1 As New Sheet() With { _
        .Name = &quot;Sheet1&quot;, _
        .SheetId = Convert.ToUInt32(1),
        .Id = &quot;rId1&quot;
       }


       ' Add the sheet into sheets collection
       sheets.Append(sheet1)


       Dim calculationProperties1 As New CalculationProperties() With { _
         .CalculationId = Convert.ToUInt32(111222)
       }


       ' Add elements into workbook
       workbook.Append(sheets)
       workbook.Append(calculationProperties1)
       workbookPart.Workbook = workbook
   End Sub


   ''' &lt;summary&gt;
   '''  Generates content of worksheetPart
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;worksheetPart&quot;&gt;WorksheetPart Object&lt;/param&gt;
   ''' &lt;param name=&quot;table&quot;&gt;DataTable Object&lt;/param&gt;
   Private Sub CreateWorkSheetPart(worksheetPart As WorksheetPart, table As DataTable)
       ' Initialize worksheet and set the properties
       Dim worksheet1 As New Worksheet() With { _
         .MCAttributes = New MarkupCompatibilityAttributes() With {
          .Ignorable = &quot;x14ac&quot;
        }
       }
       worksheet1.AddNamespaceDeclaration(&quot;r&quot;, &quot;http://schemas.openxmlformats.org/officeDocument/2006/relationships&quot;)
       worksheet1.AddNamespaceDeclaration(&quot;mc&quot;, &quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;)
       worksheet1.AddNamespaceDeclaration(&quot;x14ac&quot;, &quot;http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac&quot;)


       Dim sheetViews1 As New SheetViews()


       ' Initialize an instance of the sheetview class
       Dim sheetView1 As New SheetView() With { _
         .WorkbookViewId = Convert.ToUInt32(0)
       }


       Dim selection As New Selection() With { _
         .ActiveCell = &quot;A1&quot;
       }


       sheetView1.Append(selection)


       sheetViews1.Append(sheetView1)
       Dim sheetFormatProperties1 As New SheetFormatProperties() With { _
         .DefaultRowHeight = 15.0, _
         .DyDescent = 0.25 _
       }


       Dim sheetData1 As New SheetData()
       Dim rowIndex As UInt32 = 1UI
       Dim pageMargins1 As New PageMargins() With { _
         .Left = 0.7, _
         .Right = 0.7, _
         .Top = 0.75, _
         .Bottom = 0.75, _
         .Header = 0.3, _
         .Footer = 0.3
       }


       Dim row1 As New Row() With { _
         .RowIndex = rowIndex, _
         .Spans = New ListValue(Of StringValue)() With { _
          .InnerText = &quot;1:3&quot; _
        }, _
         .DyDescent = 0.25 _
       }


       ' Add columns in DataTable to columns collection of SpreadSheet Document 
       For columnindex As Integer = 0 To table.Columns.Count - 1
           Dim cell As New Cell() With { _
             .CellReference = New CreateSpreadSheetProvider().[Get](columnindex, (Convert.ToInt32(UInt32Value.ToUInt32(rowIndex)) - 1)), _
             .DataType = CellValues.[String]
           }


           ' Get Value of DataTable and append the value to cell of spreadsheet document
           Dim cellValue As New CellValue()
           cellValue.Text = table.Columns(columnindex).ColumnName.ToString()
           cell.Append(cellValue)


           row1.Append(cell)
       Next


       ' Add row to sheet
       sheetData1.Append(row1)


       ' Add rows in DataTable to rows collection of SpreadSheet Document 
       For rIndex As Integer = 0 To table.Rows.Count - 1
           rowIndex = UInt32Value.ToUInt32(rowIndex) &#43; 1
           Dim row As New Row() With { _
             .RowIndex = rowIndex, _
             .Spans = New ListValue(Of StringValue)() With { _
              .InnerText = &quot;1:3&quot; _
            }, _
             .DyDescent = 0.25 _
           }


           For cIndex As Integer = 0 To table.Columns.Count - 1
               Dim cell As New Cell() With { _
                 .CellReference = New CreateSpreadSheetProvider().[Get](cIndex, (Convert.ToInt32(UInt32Value.ToUInt32(rowIndex)) - 1)), _
                 .DataType = CellValues.[String] _
               }


               Dim cellValue As New CellValue()
               cellValue.Text = table.Rows(rIndex)(cIndex).ToString()
               cell.Append(cellValue)
               row.Append(cell)
           Next


           ' Add row to Sheet Data
           sheetData1.Append(row)
       Next


       ' Add elements to worksheet
       worksheet1.Append(sheetViews1)
       worksheet1.Append(sheetFormatProperties1)
       worksheet1.Append(sheetData1)
       worksheet1.Append(pageMargins1)


       worksheetPart.Worksheet = worksheet1
   End Sub


   ''' &lt;summary&gt;
   ''' Generates content of sharedStringTablePart
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;sharedStringTablePart&quot;&gt;SharedStringTablePart Object&lt;/param&gt;
   ''' &lt;param name=&quot;table&quot;&gt;DataTable Object&lt;/param&gt;
   Private Sub CreateSharedStringTablePart(sharedStringTablePart As SharedStringTablePart, table As DataTable)
       Dim stringCount As UInt32Value = Convert.ToUInt32(table.Rows.Count) &#43; Convert.ToUInt32(table.Columns.Count)


       ' Initialize an instance of SharedString Table
       Dim sharedStringTable As New SharedStringTable() With { _
         .Count = stringCount, _
         .UniqueCount = stringCount
       }


       ' Add columns of DataTable to sharedString iteam
       For columnIndex As Integer = 0 To table.Columns.Count - 1
           Dim sharedStringItem As New SharedStringItem()
           Dim text As New Text()
           text.Text = table.Columns(columnIndex).ColumnName
           sharedStringItem.Append(text)


           ' Add sharedstring item to sharedstring Table
           sharedStringTable.Append(sharedStringItem)
       Next


       ' Add rows of DataTable to sharedString iteam
       For rowIndex As Integer = 0 To table.Rows.Count - 1
           Dim sharedStringItem As New SharedStringItem()
           Dim text As New Text()
           text.Text = table.Rows(rowIndex)(0).ToString()
           sharedStringItem.Append(text)
           sharedStringTable.Append(sharedStringItem)
       Next


       sharedStringTablePart.SharedStringTable = sharedStringTable
   End Sub


   ''' &lt;summary&gt;
   ''' Generates content of workbookStylesPart
   ''' &lt;/summary&gt;
   ''' &lt;param name=&quot;workbookStylesPart&quot;&gt;WorkbookStylesPart Object&lt;/param&gt;
   Private Sub CreateWorkBookStylesPart(workbookStylesPart As WorkbookStylesPart)
       ' Define Style of Sheet in workbook
       Dim stylesheet1 As New Stylesheet() With { _
         .MCAttributes = New MarkupCompatibilityAttributes() With { _
          .Ignorable = &quot;x14ac&quot; _
        } _
       }
       stylesheet1.AddNamespaceDeclaration(&quot;mc&quot;, &quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;)
       stylesheet1.AddNamespaceDeclaration(&quot;x14ac&quot;, &quot;http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac&quot;)


       ' Initialize  an instance of fonts
       Dim fonts As New Fonts() With { _
         .Count = 2UI, _
         .KnownFonts = True
       }


       ' Initialize  an instance of font,fontsize,color
       Dim font As New Font()
       Dim fontSize As New FontSize() With { _
         .Val = 14.0 _
       }
       Dim color As New Color() With { _
         .Theme = 1UI
       }
       Dim fontName As New FontName() With { _
         .Val = &quot;Calibri&quot; _
       }
       Dim fontFamilyNumbering As New FontFamilyNumbering() With { _
         .Val = 2UI
       }
       Dim fontScheme As New FontScheme() With { _
         .Val = FontSchemeValues.Minor _
       }


       ' Add elements to font
       font.Append(fontSize)
       font.Append(color)
       font.Append(fontName)
       font.Append(fontFamilyNumbering)
       font.Append(fontScheme)


       fonts.Append(font)


       ' Define the StylesheetExtensionList Class. When the object is serialized out as xml, its qualified name is x:extLst
       Dim stylesheetExtensionList1 As New StylesheetExtensionList()


       ' Define the StylesheetExtension Class
       Dim stylesheetExtension1 As New StylesheetExtension() With { _
         .Uri = &quot;{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}&quot; _
       }
       stylesheetExtension1.AddNamespaceDeclaration(&quot;x14&quot;, &quot;http://schemas.microsoft.com/office/spreadsheetml/2009/9/main&quot;)
       Dim slicerStyles1 As New DocumentFormat.OpenXml.Office2010.Excel.SlicerStyles() With { _
         .DefaultSlicerStyle = &quot;SlicerStyleLight1&quot; _
       }


       stylesheetExtension1.Append(slicerStyles1)
       stylesheetExtensionList1.Append(stylesheetExtension1)


       ' Add elements to stylesheet
       stylesheet1.Append(fonts)
       stylesheet1.Append(stylesheetExtensionList1)


       ' Set the style of workbook
       workbookStylesPart.Stylesheet = stylesheet1
   End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step 6. Add Web Form to this project and user can use the control in this Web form to import or export.</p>
<p class="MsoNormal">Step 7. Click &quot;Browser…&quot; button to choose the existing excel file on client and then click import button to import the data in excel to GridView.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
''' &lt;summary&gt;
    '''  Import Excel Data into GridView Control 
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
    Protected Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        ' The condition that FileUpload control contains a file 
        If FileUpload1.HasFile Then
            ' Get selected file name
            Dim filename As String = FileUpload1.PostedFile.FileName


            ' Get the extension of the selected file
            Dim fileExten As String = Path.GetExtension(filename)


            ' The condition that the extension is not xlsx
            If Not fileExten.Equals(&quot;.xlsx&quot;, StringComparison.OrdinalIgnoreCase) Then
                Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert('The extension of selected file is incorrect ,please select again');&lt;/script&gt;&quot;)
                Return
            End If


            ' Read Data in excel file
            Try
                Dim dt As DataTable = ReadExcelFile(filename)


                If dt.Rows.Count = 0 Then
                    Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert('The first sheet is empty.');&lt;/script&gt;&quot;)
                    Return
                End If


                ' Bind Datasource
                Me.gridViewTest.DataSource = dt
                Me.gridViewTest.DataBind()


                ' Enable Export button
                Me.btnExport.Enabled = True
            Catch ex As IOException
                Dim exceptionmessage As String = ex.Message
                Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert(&quot;&quot;&quot; & exceptionmessage & &quot;&quot;&quot;);&lt;/script&gt;&quot;)
            End Try
        Else
            Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert('You did not specify a file to import');&lt;/script&gt;&quot;)
        End If
    End Sub


    ''' &lt;summary&gt;
    '''  Read Data from selected excel file on client
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;filename&quot;&gt;File Path&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    Private Function ReadExcelFile(filename As String) As DataTable
        ' Initializate an instance of DataTable
        Dim dt As New DataTable()


        Try
            ' Use SpreadSheetDocument class of Open XML SDK to open excel file
            Using _spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Open(filename, False)
                ' Get Workbook Part of Spread Sheet Document
                Dim workbookPart As WorkbookPart = _spreadsheetDocument.WorkbookPart


                ' Get all sheets in spread sheet document 
                Dim sheetcollection As IEnumerable(Of Sheet) = _spreadsheetDocument.WorkbookPart.Workbook.GetFirstChild(Of Sheets)().Elements(Of Sheet)()


                ' Get relationship Id
                Dim relationshipId As String = sheetcollection.First().Id.Value


                ' Get sheet1 Part of Spread Sheet Document
                Dim worksheetPart As WorksheetPart = DirectCast(_spreadsheetDocument.WorkbookPart.GetPartById(relationshipId), WorksheetPart)


                ' Get Data in Excel file
                Dim sheetData As SheetData = worksheetPart.Worksheet.Elements(Of SheetData)().First()
                Dim rowcollection As IEnumerable(Of Row) = sheetData.Descendants(Of Row)()


                If rowcollection.Count() = 0 Then
                    Return dt
                End If


                ' Add columns
                For Each cell As Cell In rowcollection.ElementAt(0)
                    dt.Columns.Add(GetValueOfCell(_spreadsheetDocument, cell))
                Next


                ' Add rows into DataTable
                For Each row As Row In rowcollection
                    Dim temprow As DataRow = dt.NewRow()
                    For i As Integer = 0 To row.Descendants(Of Cell)().Count() - 1
                        temprow(i) = GetValueOfCell(_spreadsheetDocument, row.Descendants(Of Cell)().ElementAt(i))
                    Next


                    ' Add the row to DataTable
                    ' the rows include header row
                    dt.Rows.Add(temprow)
                Next
            End Using


            ' Here remove header row
            dt.Rows.RemoveAt(0)
            Return dt
        Catch ex As IOException
            Throw New IOException(ex.Message)
        End Try
    End Function


    ''' &lt;summary&gt;
    '''  Get Value in Cell 
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;spreadsheetdocument&quot;&gt;SpreadSheet Document&lt;/param&gt;
    ''' &lt;param name=&quot;cell&quot;&gt;Cell in SpreadSheet Document&lt;/param&gt;
    ''' &lt;returns&gt;The value in cell&lt;/returns&gt;
    Private Shared Function GetValueOfCell(spreadsheetdocument As SpreadsheetDocument, cell As Cell) As String
        ' Get value in Cell
        Dim sharedString As SharedStringTablePart = spreadsheetdocument.WorkbookPart.SharedStringTablePart
        If cell.CellValue Is Nothing Then
            Return String.Empty
        End If


        Dim cellValue As String = cell.CellValue.InnerText


        ' The condition that the Cell DataType is SharedString
        If cell.DataType IsNot Nothing AndAlso cell.DataType.Value = CellValues.SharedString Then
            Return sharedString.SharedStringTable.ChildElements(Integer.Parse(cellValue)).InnerText
        Else
            Return cellValue
        End If
    End Function

</pre>
<pre id="codePreview" class="vb">
''' &lt;summary&gt;
    '''  Import Excel Data into GridView Control 
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
    Protected Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        ' The condition that FileUpload control contains a file 
        If FileUpload1.HasFile Then
            ' Get selected file name
            Dim filename As String = FileUpload1.PostedFile.FileName


            ' Get the extension of the selected file
            Dim fileExten As String = Path.GetExtension(filename)


            ' The condition that the extension is not xlsx
            If Not fileExten.Equals(&quot;.xlsx&quot;, StringComparison.OrdinalIgnoreCase) Then
                Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert('The extension of selected file is incorrect ,please select again');&lt;/script&gt;&quot;)
                Return
            End If


            ' Read Data in excel file
            Try
                Dim dt As DataTable = ReadExcelFile(filename)


                If dt.Rows.Count = 0 Then
                    Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert('The first sheet is empty.');&lt;/script&gt;&quot;)
                    Return
                End If


                ' Bind Datasource
                Me.gridViewTest.DataSource = dt
                Me.gridViewTest.DataBind()


                ' Enable Export button
                Me.btnExport.Enabled = True
            Catch ex As IOException
                Dim exceptionmessage As String = ex.Message
                Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert(&quot;&quot;&quot; & exceptionmessage & &quot;&quot;&quot;);&lt;/script&gt;&quot;)
            End Try
        Else
            Response.Write(&quot;&lt;script language=&quot;&quot;javascript&quot;&quot;&gt;alert('You did not specify a file to import');&lt;/script&gt;&quot;)
        End If
    End Sub


    ''' &lt;summary&gt;
    '''  Read Data from selected excel file on client
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;filename&quot;&gt;File Path&lt;/param&gt;
    ''' &lt;returns&gt;&lt;/returns&gt;
    Private Function ReadExcelFile(filename As String) As DataTable
        ' Initializate an instance of DataTable
        Dim dt As New DataTable()


        Try
            ' Use SpreadSheetDocument class of Open XML SDK to open excel file
            Using _spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Open(filename, False)
                ' Get Workbook Part of Spread Sheet Document
                Dim workbookPart As WorkbookPart = _spreadsheetDocument.WorkbookPart


                ' Get all sheets in spread sheet document 
                Dim sheetcollection As IEnumerable(Of Sheet) = _spreadsheetDocument.WorkbookPart.Workbook.GetFirstChild(Of Sheets)().Elements(Of Sheet)()


                ' Get relationship Id
                Dim relationshipId As String = sheetcollection.First().Id.Value


                ' Get sheet1 Part of Spread Sheet Document
                Dim worksheetPart As WorksheetPart = DirectCast(_spreadsheetDocument.WorkbookPart.GetPartById(relationshipId), WorksheetPart)


                ' Get Data in Excel file
                Dim sheetData As SheetData = worksheetPart.Worksheet.Elements(Of SheetData)().First()
                Dim rowcollection As IEnumerable(Of Row) = sheetData.Descendants(Of Row)()


                If rowcollection.Count() = 0 Then
                    Return dt
                End If


                ' Add columns
                For Each cell As Cell In rowcollection.ElementAt(0)
                    dt.Columns.Add(GetValueOfCell(_spreadsheetDocument, cell))
                Next


                ' Add rows into DataTable
                For Each row As Row In rowcollection
                    Dim temprow As DataRow = dt.NewRow()
                    For i As Integer = 0 To row.Descendants(Of Cell)().Count() - 1
                        temprow(i) = GetValueOfCell(_spreadsheetDocument, row.Descendants(Of Cell)().ElementAt(i))
                    Next


                    ' Add the row to DataTable
                    ' the rows include header row
                    dt.Rows.Add(temprow)
                Next
            End Using


            ' Here remove header row
            dt.Rows.RemoveAt(0)
            Return dt
        Catch ex As IOException
            Throw New IOException(ex.Message)
        End Try
    End Function


    ''' &lt;summary&gt;
    '''  Get Value in Cell 
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;spreadsheetdocument&quot;&gt;SpreadSheet Document&lt;/param&gt;
    ''' &lt;param name=&quot;cell&quot;&gt;Cell in SpreadSheet Document&lt;/param&gt;
    ''' &lt;returns&gt;The value in cell&lt;/returns&gt;
    Private Shared Function GetValueOfCell(spreadsheetdocument As SpreadsheetDocument, cell As Cell) As String
        ' Get value in Cell
        Dim sharedString As SharedStringTablePart = spreadsheetdocument.WorkbookPart.SharedStringTablePart
        If cell.CellValue Is Nothing Then
            Return String.Empty
        End If


        Dim cellValue As String = cell.CellValue.InnerText


        ' The condition that the Cell DataType is SharedString
        If cell.DataType IsNot Nothing AndAlso cell.DataType.Value = CellValues.SharedString Then
            Return sharedString.SharedStringTable.ChildElements(Integer.Parse(cellValue)).InnerText
        Else
            Return cellValue
        End If
    End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal">Step 8. Click &quot;Export&quot; button to export data in GridView control to excel file.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
''' &lt;summary&gt;
    '''  Export Data in GridView control to Excel file
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
    Protected Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Initialize an instance of DataTable
        Dim dt As DataTable = CreateDataTable(Me.gridViewTest)


        ' Save the exported file 
        Dim appPath As String = Request.PhysicalApplicationPath
        Dim filename As String = Guid.NewGuid().ToString() & &quot;.xlsx&quot;
        Dim filePath As String = appPath & filename


        Dim exportprovider As CreateSpreadSheetProvider = New CreateSpreadSheetProvider()
        exportprovider.ExportToExcel(dt, filePath)


        Dim savefilepath As String = &quot;Export Excel file successfully, the exported excel file is placed in: &quot; & filePath
        Response.Write(&quot;&lt;script language='javascript'&gt;alert('&quot; & savefilepath.Replace(&quot;\&quot;, &quot;\\&quot;) & &quot;');&lt;/script&gt;&quot;)


    End Sub


    ''' &lt;summary&gt;
    '''  Create DataTable from GridView Control
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;girdViewtest&quot;&gt;GridView Control&lt;/param&gt;
    ''' &lt;returns&gt;An instance of DataTable Object&lt;/returns&gt;
    Private Function CreateDataTable(girdViewtest As GridView) As DataTable
        Dim dt As New DataTable()


        ' Get columns from GridView
        ' Add value of columns to DataTable 
        For i As Integer = 0 To gridViewTest.HeaderRow.Cells.Count - 1
            dt.Columns.Add(gridViewTest.HeaderRow.Cells(i).Text)
        Next


        ' Get rows from GridView
        For Each row As GridViewRow In gridViewTest.Rows
            Dim datarow As DataRow = dt.NewRow()
            For i As Integer = 0 To row.Cells.Count - 1
                datarow(i) = row.Cells(i).Text.Replace(&quot;&nbsp;&quot;, &quot; &quot;)
            Next


            ' Add rows to DataTable
            dt.Rows.Add(datarow)


        Next


        Return dt
    End Function

</pre>
<pre id="codePreview" class="vb">
''' &lt;summary&gt;
    '''  Export Data in GridView control to Excel file
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;sender&quot;&gt;&lt;/param&gt;
    ''' &lt;param name=&quot;e&quot;&gt;&lt;/param&gt;
    Protected Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Initialize an instance of DataTable
        Dim dt As DataTable = CreateDataTable(Me.gridViewTest)


        ' Save the exported file 
        Dim appPath As String = Request.PhysicalApplicationPath
        Dim filename As String = Guid.NewGuid().ToString() & &quot;.xlsx&quot;
        Dim filePath As String = appPath & filename


        Dim exportprovider As CreateSpreadSheetProvider = New CreateSpreadSheetProvider()
        exportprovider.ExportToExcel(dt, filePath)


        Dim savefilepath As String = &quot;Export Excel file successfully, the exported excel file is placed in: &quot; & filePath
        Response.Write(&quot;&lt;script language='javascript'&gt;alert('&quot; & savefilepath.Replace(&quot;\&quot;, &quot;\\&quot;) & &quot;');&lt;/script&gt;&quot;)


    End Sub


    ''' &lt;summary&gt;
    '''  Create DataTable from GridView Control
    ''' &lt;/summary&gt;
    ''' &lt;param name=&quot;girdViewtest&quot;&gt;GridView Control&lt;/param&gt;
    ''' &lt;returns&gt;An instance of DataTable Object&lt;/returns&gt;
    Private Function CreateDataTable(girdViewtest As GridView) As DataTable
        Dim dt As New DataTable()


        ' Get columns from GridView
        ' Add value of columns to DataTable 
        For i As Integer = 0 To gridViewTest.HeaderRow.Cells.Count - 1
            dt.Columns.Add(gridViewTest.HeaderRow.Cells(i).Text)
        Next


        ' Get rows from GridView
        For Each row As GridViewRow In gridViewTest.Rows
            Dim datarow As DataRow = dt.NewRow()
            For i As Integer = 0 To row.Cells.Count - 1
                datarow(i) = row.Cells(i).Text.Replace(&quot;&nbsp;&quot;, &quot; &quot;)
            Next


            ' Add rows to DataTable
            dt.Rows.Add(datarow)


        Next


        Return dt
    End Function

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"></p>
<h2>More Information</h2>
<p class="MsoNormal" style=""><span style=""><a href="http://msdn.microsoft.com/en-us/library/documentformat.openxml.spreadsheet(v=office.14).aspx">Spreadsheet Namespace</a>
</span></p>
<p class="MsoNormal" style=""><span style=""><a href="http://msdn.microsoft.com/en-us/office/bb265236.aspx">Open XML for Office Developers</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.fileupload.aspx">FileUpload Class</a>
</span></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>