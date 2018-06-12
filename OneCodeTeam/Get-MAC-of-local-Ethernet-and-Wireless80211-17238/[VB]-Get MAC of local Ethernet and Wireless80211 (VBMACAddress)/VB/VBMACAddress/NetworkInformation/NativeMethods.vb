﻿'************************** Module Header ******************************'
' Module Name:  NativeMethods.vb
' Project:      VBMACAddress
' Copyright (c) Microsoft Corporation.
' 
' This class wraps the GetIpNetTable2 method in iphlpapi.dll. 
' 
' 
' 
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.
' 
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'************************************************************************'


Imports System.Runtime.InteropServices

Namespace NetworkInformation
    Friend NotInheritable Class NativeMethods

        ''' <summary>
        ''' The GetIpNetTable2 function retrieves the IP neighbor table on the local
        ''' computer.
        ''' http://msdn.microsoft.com/en-us/library/aa814420(VS.85).aspx
        ''' </summary>
        ''' <param name="Family">
        ''' AF_UNSPEC 0 The address family is unspecified. 
        ''' AF_INET   2 The Internet Protocol version 4 (IPv4) address family. 
        ''' AF_INET6 23 The Internet Protocol version 6 (IPv6) address family. 
        ''' </param>
        ''' <param name="Table">
        ''' A pointer to a MIB_IPNET_TABLE2 structure that contains a table of
        ''' neighbor IP address entries on the local computer. 
        ''' </param>
        <DllImport("iphlpapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
        Friend Shared Function GetIpNetTable2(ByVal Family As UShort,
                                              <Out()> ByRef Table As IntPtr) As Integer
        End Function

    End Class
End Namespace
