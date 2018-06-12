﻿Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        Dim myScriptResDef As New ScriptResourceDefinition()
        myScriptResDef.Path = "~/JS/jquery-1.8.1.js"
        myScriptResDef.DebugPath = "~/JS/jquery-1.8.1.js"
        myScriptResDef.CdnPath = "http://code.jquery.com/jquery-1.8.1.js"
        myScriptResDef.CdnDebugPath = "http://code.jquery.com/jquery-1.8.1.js"
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", Nothing, myScriptResDef)
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class