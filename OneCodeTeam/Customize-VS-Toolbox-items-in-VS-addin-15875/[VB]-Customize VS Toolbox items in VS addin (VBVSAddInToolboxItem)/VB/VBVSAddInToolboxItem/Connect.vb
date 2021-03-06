'**************************** Module Header ******************************'
' Module Name:  Connect.vb
' Project:      VBVSAddInToolboxItem
' Copyright (c) Microsoft Corporation.
'
' The CSVSAddInToolboxItem project demostrates how to customize Toolbox items
' in DTE automation model or by Toolbox service.
'
' In this sample, a add-in command button named "Add Customized Toolbox Item" 
' will be registered in the Tool menu. By clicking the menu, sample code will
' do follow two things:
' 1. Use DTE automation model to add an item under CustomTab tab
' 2. Use VS Toolbox service to add an item under CustomTab tab
'
' Both items are HTML content, they can be used by dragging and dropping to a 
' web page designer.
'
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/en-us/openness/resources/licenses.aspx#MPL.
' All other rights reserved.
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'**************************************************************************'

Imports System
Imports Microsoft.VisualStudio.CommandBars
Imports Extensibility
Imports EnvDTE
Imports EnvDTE80
Imports Microsoft.VisualStudio.Shell.Interop
Imports Microsoft.VisualStudio.Shell
Imports System.Windows.Forms

Public Class Connect

    Implements IDTExtensibility2, IDTCommandTarget


    Dim _applicationObject As DTE2
    Dim _addInInstance As AddIn

    '''<summary>Implements the constructor for the Add-in object. Place your initialization code within this method.</summary>
    Public Sub New()

    End Sub

    '''<summary>Implements the OnConnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being loaded.</summary>
    '''<param name='application'>Root object of the host application.</param>
    '''<param name='connectMode'>Describes how the Add-in is being loaded.</param>
    '''<param name='addInInst'>Object representing this Add-in.</param>
    '''<remarks></remarks>
    Public Sub OnConnection(ByVal application As Object, ByVal connectMode As ext_ConnectMode, ByVal addInInst As Object, ByRef custom As Array) Implements IDTExtensibility2.OnConnection
        _applicationObject = CType(application, DTE2)
        _addInInstance = CType(addInInst, AddIn)
        If connectMode = ext_ConnectMode.ext_cm_UISetup Then
            Dim contextGUIDS() As Object = {}
            Dim commands As Commands2 = CType(_applicationObject.Commands, Commands2)
            Dim command As Command = Nothing

            Try
                command = commands.AddNamedCommand2( _
                _addInInstance, _
                "VBVSAddInToolboxItem", _
                "VBVSAddInToolboxItem", _
                "Add item into VS Toolbox", _
                True, _
                6743, _
                contextGUIDS, _
                CInt(Fix(vsCommandStatus.vsCommandStatusSupported)) + CInt(Fix(vsCommandStatus.vsCommandStatusEnabled)), _
                CInt(Fix(vsCommandStyle.vsCommandStylePictAndText)), _
                vsCommandControlType.vsCommandControlTypeButton)
            Catch e1 As System.ArgumentException
                'If we are here, then the exception is probably because a command with that name
                '  already exists. If so there is no need to recreate the command and we can 
                '  safely ignore the exception.
            End Try

            AddCommandToToolMenubar(_applicationObject, command)
        End If
    End Sub

    Private Sub AddCommandToToolMenubar(ByVal applicationObject As DTE2, ByVal command As Command)
        Dim toolsMenuName As String = "Tools"

        ' Place the command on the tools menu.
        ' Find the MenuBar command bar, which is the top-level command bar holding all the 
        ' main menu items:
        Dim menuBarCommandBar As CommandBar = (CType(applicationObject.CommandBars, CommandBars))("MenuBar")

        'Find the Tools command bar on the MenuBar command bar:
        Dim toolsControl As CommandBarControl = menuBarCommandBar.Controls(toolsMenuName)
        Dim toolsPopup As CommandBarPopup = CType(toolsControl, CommandBarPopup)

        'Add a control for the command to the tools menu:
        If (command IsNot Nothing) AndAlso (toolsPopup IsNot Nothing) Then
            Dim commandBarControl As CommandBarControl = CType(command.AddControl(toolsPopup.CommandBar, 1), CommandBarControl)
            commandBarControl.Caption = "Add Customized Toolbox Item"
        End If
    End Sub

    '''<summary>Implements the OnDisconnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being unloaded.</summary>
    '''<param name='disconnectMode'>Describes how the Add-in is being unloaded.</param>
    '''<param name='custom'>Array of parameters that are host application specific.</param>
    '''<remarks></remarks>
    Public Sub OnDisconnection(ByVal disconnectMode As ext_DisconnectMode, ByRef custom As Array) Implements IDTExtensibility2.OnDisconnection
    End Sub

    '''<summary>Implements the OnAddInsUpdate method of the IDTExtensibility2 interface. Receives notification that the collection of Add-ins has changed.</summary>
    '''<param name='custom'>Array of parameters that are host application specific.</param>
    '''<remarks></remarks>
    Public Sub OnAddInsUpdate(ByRef custom As Array) Implements IDTExtensibility2.OnAddInsUpdate
    End Sub

    '''<summary>Implements the OnStartupComplete method of the IDTExtensibility2 interface. Receives notification that the host application has completed loading.</summary>
    '''<param name='custom'>Array of parameters that are host application specific.</param>
    '''<remarks></remarks>
    Public Sub OnStartupComplete(ByRef custom As Array) Implements IDTExtensibility2.OnStartupComplete
    End Sub

    '''<summary>Implements the OnBeginShutdown method of the IDTExtensibility2 interface. Receives notification that the host application is being unloaded.</summary>
    '''<param name='custom'>Array of parameters that are host application specific.</param>
    '''<remarks></remarks>
    Public Sub OnBeginShutdown(ByRef custom As Array) Implements IDTExtensibility2.OnBeginShutdown
    End Sub

    ''' <summary>Implements the QueryStatus method of the IDTCommandTarget interface. This is called when the command's availability is updated</summary>
    ''' <param name='commandName'>The name of the command to determine state for.</param>
    ''' <param name='neededText'>Text that is needed for the command.</param>
    ''' <param name='status'>The state of the command in the user interface.</param>
    ''' <param name='commandText'>Text requested by the neededText parameter.</param>
    ''' <seealso class='Exec' />
    Public Sub QueryStatus(ByVal commandName As String, ByVal neededText As vsCommandStatusTextWanted, ByRef status As vsCommandStatus, ByRef commandText As Object) Implements IDTCommandTarget.QueryStatus
        If neededText = vsCommandStatusTextWanted.vsCommandStatusTextWantedNone Then
            If commandName = "VBVSAddInToolboxItem.Connect.VBVSAddInToolboxItem" Then
                status = CType(vsCommandStatus.vsCommandStatusSupported, vsCommandStatus) Or vsCommandStatus.vsCommandStatusEnabled
                Return
            End If
        End If
    End Sub

    ''' <summary>Implements the Exec method of the IDTCommandTarget interface. This is called when the command is invoked.</summary>
    ''' <param name='commandName'>The name of the command to execute.</param>
    ''' <param name='executeOption'>Describes how the command should be run.</param>
    ''' <param name='varIn'>Parameters passed from the caller to the command handler.</param>
    ''' <param name='varOut'>Parameters passed from the command handler to the caller.</param>
    ''' <param name='handled'>Informs the caller if the command was handled or not.</param>
    ''' <seealso class='Exec' />
    Public Sub Exec(ByVal commandName As String, ByVal executeOption As vsCommandExecOption, ByRef varIn As Object, ByRef varOut As Object, ByRef handled As Boolean) Implements IDTCommandTarget.Exec
        handled = False
        If executeOption = vsCommandExecOption.vsCommandExecOptionDoDefault Then
            If commandName = "VBVSAddInToolboxItem.Connect.VBVSAddInToolboxItem" Then
                handled = True

                ' The first sample demostrate how to add item by DTE automation model
                AddItemByDTE()

                ' The second sample demostrat how to add item by Toolbox service
                AddItemByVsToolboxService()
                Return
            End If
        End If
    End Sub

    ''' <summary>
    ''' This method adds a Toolbox item by DTE automation model
    ''' </summary>
    Private Sub AddItemByDTE()
        ' Get tabs from automation model
        Dim tabs As ToolBoxTabs = _applicationObject.ToolWindows.ToolBox.ToolBoxTabs
        Dim e As IEnumerator = tabs.GetEnumerator()

        Dim tab As ToolBoxTab = Nothing
        Do While e.MoveNext()
            Dim ct As ToolBoxTab = TryCast(e.Current, ToolBoxTab)
            If ct.Name = "CustomTab" Then
                tab = ct
                Exit Do
            End If
        Loop

        ' If there is no CustomTab, add one
        If tab Is Nothing Then
            tab = tabs.Add("CustomTab")
        End If

        ' Add Toolbox Item, but we can't customize other information for 
        ' Toolbox item like icon and transparency.
        tab.ToolBoxItems.Add("DTE Added HTML Content", "<input id=""Button1"" type=""button"" value=""button"" />", vsToolBoxItemFormat.vsToolBoxItemFormatHTML)
    End Sub

    ''' <summary>
    ''' This method adds a Toolbox item by VS Toolbox service.
    ''' This way provides more flexibilities than DTE way.
    ''' </summary>
    Private Sub AddItemByVsToolboxService()
        ' Get shell service provider.
        Dim sp As New ServiceProvider(CType(_applicationObject, Microsoft.VisualStudio.OLE.Interop.IServiceProvider))

        ' Get the IVsToolbox interface.
        Dim tbs As IVsToolbox = TryCast(sp.GetService(GetType(SVsToolbox)), IVsToolbox)

        ' Toolbox Item Info data 
        Dim itemInfo(0) As TBXITEMINFO
        Dim bitmap As New System.Drawing.Bitmap(Me.GetType().Assembly.GetManifestResourceStream("VBVSAddInToolboxItem.Demo.bmp"))
        itemInfo(0).bstrText = "Service Added HTML Content"
        itemInfo(0).hBmp = bitmap.GetHbitmap()
        itemInfo(0).dwFlags = CUInt(__TBXITEMINFOFLAGS.TBXIF_DONTPERSIST)

        ' OleDataObject to host toolbox data
        Dim tbItem As New OleDataObject()
        tbItem.SetText(ConvertToClipboardFormat("<input id=""Button1"" type=""button"" value=""button"" />", Nothing, Nothing), TextDataFormat.Html)

        ' Add a new toolbox item to MyCustomTab tab
        tbs.AddItem(tbItem, itemInfo, "CustomTab")
    End Sub


#Region "ConvertToClipboardFormat method (Copied from http:" 'blogs.msdn.com/jmstall/pages/sample-code-html-clipboard.aspx)
    ''' <summary>
    ''' Clears clipboard and copy a HTML fragment to the clipboard, providing additional meta-information.
    ''' </summary>
    ''' <param name="htmlFragment">a html fragment</param>
    ''' <param name="title">optional title of the HTML document (can be null)</param>
    ''' <param name="sourceUrl">optional Source URL of the HTML document, for resolving relative links (can be null)</param>
    Public Shared Function ConvertToClipboardFormat(ByVal htmlFragment As String, ByVal title As String, ByVal sourceUrl As Uri) As String
        If title Is Nothing Then
            title = "From Clipboard"
        End If

        Dim sb As New System.Text.StringBuilder()

        ' Builds the CF_HTML header. See format specification here:
        ' http://msdn.microsoft.com/library/default.asp?url=/workshop/networking/clipboard/htmlclipboard.asp

        ' The string contains index references to other spots in the string, so we need placeholders so we can compute the offsets. 
        ' The <<<<<<<_ strings are just placeholders. We'll backpatch them actual values afterwards.
        ' The string layout (<<<) also ensures that it can't appear in the body of the html because the <
        ' character must be escaped.
        Dim header As String = "Format:HTML Format" & ControlChars.CrLf & "Version:1.0" & ControlChars.CrLf & "StartHTML:<<<<<<<1" & ControlChars.CrLf & "EndHTML:<<<<<<<2" & ControlChars.CrLf & "StartFragment:<<<<<<<3" & ControlChars.CrLf & "EndFragment:<<<<<<<4" & ControlChars.CrLf & "StartSelection:<<<<<<<3" & ControlChars.CrLf & "EndSelection:<<<<<<<4" & ControlChars.CrLf & ""

        Dim pre As String = "<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">" & ControlChars.CrLf & "<HTML><HEAD><TITLE>" & title & "</TITLE></HEAD><BODY><!--StartFragment-->"

        Dim post As String = "<!--EndFragment--></BODY></HTML>"

        sb.Append(header)
        If sourceUrl IsNot Nothing Then
            sb.AppendFormat("SourceURL:{0}", sourceUrl)
        End If
        Dim startHTML As Integer = sb.Length

        sb.Append(pre)
        Dim fragmentStart As Integer = sb.Length

        sb.Append(htmlFragment)
        Dim fragmentEnd As Integer = sb.Length

        sb.Append(post)
        Dim endHTML As Integer = sb.Length

        ' Backpatch offsets
        sb.Replace("<<<<<<<1", To8DigitString(startHTML))
        sb.Replace("<<<<<<<2", To8DigitString(endHTML))
        sb.Replace("<<<<<<<3", To8DigitString(fragmentStart))
        sb.Replace("<<<<<<<4", To8DigitString(fragmentEnd))

        Return sb.ToString()
    End Function

    ' Helper to convert an integer into an 8 digit string.
    ' String must be 8 characters, because it will be used to replace an 8 character string within a larger string.    
    Shared Function To8DigitString(ByVal x As Integer) As String
        Return String.Format("{0,8}", x)
    End Function
#End Region

End Class
