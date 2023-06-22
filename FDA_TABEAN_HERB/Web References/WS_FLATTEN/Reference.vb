﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace WS_FLATTEN
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WS_FLATTENSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class WS_FLATTEN
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private FlattenPDFOperationCompleted As System.Threading.SendOrPostCallback
        
        Private FlattenPDF_DIGITALOperationCompleted As System.Threading.SendOrPostCallback
        
        Private FlattenPDF_DIGITAL_V2OperationCompleted As System.Threading.SendOrPostCallback
        
        Private FlattenPDF_DIGITAL_V3OperationCompleted As System.Threading.SendOrPostCallback
        
        Private FlattenPDF_DIGITAL_V4OperationCompleted As System.Threading.SendOrPostCallback
        
        Private PDF_DIGITAL_SIGNOperationCompleted As System.Threading.SendOrPostCallback
        
        Private FlattenPDF_fileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private Get_FILEsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.FDA_TABEAN_HERB.My.MySettings.Default.FDA_LCN_HERB_NEW_WS_FLATTEN_WS_FLATTEN
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event FlattenPDFCompleted As FlattenPDFCompletedEventHandler
        
        '''<remarks/>
        Public Event FlattenPDF_DIGITALCompleted As FlattenPDF_DIGITALCompletedEventHandler
        
        '''<remarks/>
        Public Event FlattenPDF_DIGITAL_V2Completed As FlattenPDF_DIGITAL_V2CompletedEventHandler
        
        '''<remarks/>
        Public Event FlattenPDF_DIGITAL_V3Completed As FlattenPDF_DIGITAL_V3CompletedEventHandler
        
        '''<remarks/>
        Public Event FlattenPDF_DIGITAL_V4Completed As FlattenPDF_DIGITAL_V4CompletedEventHandler
        
        '''<remarks/>
        Public Event PDF_DIGITAL_SIGNCompleted As PDF_DIGITAL_SIGNCompletedEventHandler
        
        '''<remarks/>
        Public Event FlattenPDF_fileCompleted As FlattenPDF_fileCompletedEventHandler
        
        '''<remarks/>
        Public Event Get_FILEsCompleted As Get_FILEsCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FlattenPDF", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function FlattenPDF(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal sourcePdfPath() As Byte) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("FlattenPDF", New Object() {sourcePdfPath})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub FlattenPDFAsync(ByVal sourcePdfPath() As Byte)
            Me.FlattenPDFAsync(sourcePdfPath, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlattenPDFAsync(ByVal sourcePdfPath() As Byte, ByVal userState As Object)
            If (Me.FlattenPDFOperationCompleted Is Nothing) Then
                Me.FlattenPDFOperationCompleted = AddressOf Me.OnFlattenPDFOperationCompleted
            End If
            Me.InvokeAsync("FlattenPDF", New Object() {sourcePdfPath}, Me.FlattenPDFOperationCompleted, userState)
        End Sub
        
        Private Sub OnFlattenPDFOperationCompleted(ByVal arg As Object)
            If (Not (Me.FlattenPDFCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FlattenPDFCompleted(Me, New FlattenPDFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FlattenPDF_DIGITAL", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function FlattenPDF_DIGITAL(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal sourcePdfPath() As Byte) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("FlattenPDF_DIGITAL", New Object() {sourcePdfPath})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITALAsync(ByVal sourcePdfPath() As Byte)
            Me.FlattenPDF_DIGITALAsync(sourcePdfPath, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITALAsync(ByVal sourcePdfPath() As Byte, ByVal userState As Object)
            If (Me.FlattenPDF_DIGITALOperationCompleted Is Nothing) Then
                Me.FlattenPDF_DIGITALOperationCompleted = AddressOf Me.OnFlattenPDF_DIGITALOperationCompleted
            End If
            Me.InvokeAsync("FlattenPDF_DIGITAL", New Object() {sourcePdfPath}, Me.FlattenPDF_DIGITALOperationCompleted, userState)
        End Sub
        
        Private Sub OnFlattenPDF_DIGITALOperationCompleted(ByVal arg As Object)
            If (Not (Me.FlattenPDF_DIGITALCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FlattenPDF_DIGITALCompleted(Me, New FlattenPDF_DIGITALCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FlattenPDF_DIGITAL_V2", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function FlattenPDF_DIGITAL_V2(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("FlattenPDF_DIGITAL_V2", New Object() {sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITAL_V2Async(ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String)
            Me.FlattenPDF_DIGITAL_V2Async(sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITAL_V2Async(ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String, ByVal userState As Object)
            If (Me.FlattenPDF_DIGITAL_V2OperationCompleted Is Nothing) Then
                Me.FlattenPDF_DIGITAL_V2OperationCompleted = AddressOf Me.OnFlattenPDF_DIGITAL_V2OperationCompleted
            End If
            Me.InvokeAsync("FlattenPDF_DIGITAL_V2", New Object() {sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO}, Me.FlattenPDF_DIGITAL_V2OperationCompleted, userState)
        End Sub
        
        Private Sub OnFlattenPDF_DIGITAL_V2OperationCompleted(ByVal arg As Object)
            If (Not (Me.FlattenPDF_DIGITAL_V2CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FlattenPDF_DIGITAL_V2Completed(Me, New FlattenPDF_DIGITAL_V2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FlattenPDF_DIGITAL_V3", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function FlattenPDF_DIGITAL_V3(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("FlattenPDF_DIGITAL_V3", New Object() {sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITAL_V3Async(ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String)
            Me.FlattenPDF_DIGITAL_V3Async(sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITAL_V3Async(ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String, ByVal userState As Object)
            If (Me.FlattenPDF_DIGITAL_V3OperationCompleted Is Nothing) Then
                Me.FlattenPDF_DIGITAL_V3OperationCompleted = AddressOf Me.OnFlattenPDF_DIGITAL_V3OperationCompleted
            End If
            Me.InvokeAsync("FlattenPDF_DIGITAL_V3", New Object() {sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO}, Me.FlattenPDF_DIGITAL_V3OperationCompleted, userState)
        End Sub
        
        Private Sub OnFlattenPDF_DIGITAL_V3OperationCompleted(ByVal arg As Object)
            If (Not (Me.FlattenPDF_DIGITAL_V3CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FlattenPDF_DIGITAL_V3Completed(Me, New FlattenPDF_DIGITAL_V3CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FlattenPDF_DIGITAL_V4", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function FlattenPDF_DIGITAL_V4(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String, ByVal Link As String, ByVal Ver As String) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("FlattenPDF_DIGITAL_V4", New Object() {sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO, Link, Ver})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITAL_V4Async(ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String, ByVal Link As String, ByVal Ver As String)
            Me.FlattenPDF_DIGITAL_V4Async(sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO, Link, Ver, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_DIGITAL_V4Async(ByVal sourcePdfPath() As Byte, ByVal TR_ID As String, ByVal TEMPLATE_ID As String, ByVal CTZNO As String, ByVal Link As String, ByVal Ver As String, ByVal userState As Object)
            If (Me.FlattenPDF_DIGITAL_V4OperationCompleted Is Nothing) Then
                Me.FlattenPDF_DIGITAL_V4OperationCompleted = AddressOf Me.OnFlattenPDF_DIGITAL_V4OperationCompleted
            End If
            Me.InvokeAsync("FlattenPDF_DIGITAL_V4", New Object() {sourcePdfPath, TR_ID, TEMPLATE_ID, CTZNO, Link, Ver}, Me.FlattenPDF_DIGITAL_V4OperationCompleted, userState)
        End Sub
        
        Private Sub OnFlattenPDF_DIGITAL_V4OperationCompleted(ByVal arg As Object)
            If (Not (Me.FlattenPDF_DIGITAL_V4CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FlattenPDF_DIGITAL_V4Completed(Me, New FlattenPDF_DIGITAL_V4CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PDF_DIGITAL_SIGN", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function PDF_DIGITAL_SIGN(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal sourcePdfPath() As Byte) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("PDF_DIGITAL_SIGN", New Object() {sourcePdfPath})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub PDF_DIGITAL_SIGNAsync(ByVal sourcePdfPath() As Byte)
            Me.PDF_DIGITAL_SIGNAsync(sourcePdfPath, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub PDF_DIGITAL_SIGNAsync(ByVal sourcePdfPath() As Byte, ByVal userState As Object)
            If (Me.PDF_DIGITAL_SIGNOperationCompleted Is Nothing) Then
                Me.PDF_DIGITAL_SIGNOperationCompleted = AddressOf Me.OnPDF_DIGITAL_SIGNOperationCompleted
            End If
            Me.InvokeAsync("PDF_DIGITAL_SIGN", New Object() {sourcePdfPath}, Me.PDF_DIGITAL_SIGNOperationCompleted, userState)
        End Sub
        
        Private Sub OnPDF_DIGITAL_SIGNOperationCompleted(ByVal arg As Object)
            If (Not (Me.PDF_DIGITAL_SIGNCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent PDF_DIGITAL_SIGNCompleted(Me, New PDF_DIGITAL_SIGNCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FlattenPDF_file", RequestNamespace:="http://tempuri.org/", OneWay:=true, Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub FlattenPDF_file(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal sourcePdfPath() As Byte, ByVal filename As String)
            Me.Invoke("FlattenPDF_file", New Object() {sourcePdfPath, filename})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_fileAsync(ByVal sourcePdfPath() As Byte, ByVal filename As String)
            Me.FlattenPDF_fileAsync(sourcePdfPath, filename, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlattenPDF_fileAsync(ByVal sourcePdfPath() As Byte, ByVal filename As String, ByVal userState As Object)
            If (Me.FlattenPDF_fileOperationCompleted Is Nothing) Then
                Me.FlattenPDF_fileOperationCompleted = AddressOf Me.OnFlattenPDF_fileOperationCompleted
            End If
            Me.InvokeAsync("FlattenPDF_file", New Object() {sourcePdfPath, filename}, Me.FlattenPDF_fileOperationCompleted, userState)
        End Sub
        
        Private Sub OnFlattenPDF_fileOperationCompleted(ByVal arg As Object)
            If (Not (Me.FlattenPDF_fileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FlattenPDF_fileCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get_FILEs", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Get_FILEs(ByVal filename As String) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("Get_FILEs", New Object() {filename})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub Get_FILEsAsync(ByVal filename As String)
            Me.Get_FILEsAsync(filename, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Get_FILEsAsync(ByVal filename As String, ByVal userState As Object)
            If (Me.Get_FILEsOperationCompleted Is Nothing) Then
                Me.Get_FILEsOperationCompleted = AddressOf Me.OnGet_FILEsOperationCompleted
            End If
            Me.InvokeAsync("Get_FILEs", New Object() {filename}, Me.Get_FILEsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGet_FILEsOperationCompleted(ByVal arg As Object)
            If (Not (Me.Get_FILEsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Get_FILEsCompleted(Me, New Get_FILEsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub FlattenPDFCompletedEventHandler(ByVal sender As Object, ByVal e As FlattenPDFCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class FlattenPDFCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub FlattenPDF_DIGITALCompletedEventHandler(ByVal sender As Object, ByVal e As FlattenPDF_DIGITALCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class FlattenPDF_DIGITALCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub FlattenPDF_DIGITAL_V2CompletedEventHandler(ByVal sender As Object, ByVal e As FlattenPDF_DIGITAL_V2CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class FlattenPDF_DIGITAL_V2CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub FlattenPDF_DIGITAL_V3CompletedEventHandler(ByVal sender As Object, ByVal e As FlattenPDF_DIGITAL_V3CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class FlattenPDF_DIGITAL_V3CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub FlattenPDF_DIGITAL_V4CompletedEventHandler(ByVal sender As Object, ByVal e As FlattenPDF_DIGITAL_V4CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class FlattenPDF_DIGITAL_V4CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub PDF_DIGITAL_SIGNCompletedEventHandler(ByVal sender As Object, ByVal e As PDF_DIGITAL_SIGNCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class PDF_DIGITAL_SIGNCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub FlattenPDF_fileCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub Get_FILEsCompletedEventHandler(ByVal sender As Object, ByVal e As Get_FILEsCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Get_FILEsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
End Namespace
