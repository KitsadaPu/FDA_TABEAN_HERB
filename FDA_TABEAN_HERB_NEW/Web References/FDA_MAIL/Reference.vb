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
Namespace FDA_MAIL
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="FDA_MAILSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class FDA_MAIL
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private SendMailOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_NO_SMSOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_ASY_ATTACHOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_ASYOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_ASY_NO_SMSOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMailHTMLOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_CCOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_ATTACHOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_ATTACH_OBJOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SendMail_CC_ATTACHOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
<<<<<<<< HEAD:FDA_TABEAN_HERB_NEW/Web References/FDA_MAIL/Reference.vb
            Me.Url = Global.FDA_TABEAN_HERB_NEW.My.MySettings.Default.FDA_LCN_HERB_NEW_FDA_MAIL_FDA_MAIL
========
            Me.Url = Global.FDA_TABEAN_HERB_DEMO.My.MySettings.Default.FDA_LCN_HERB_NEW_FDA_MAIL_FDA_MAIL
>>>>>>>> 5ea1ad78a7a4d702f4c22e17424ee87d07bc9d38:FDA_TABEAN_HERB_DEMO/Web References/FDA_MAIL/Reference.vb
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
        Public Event SendMailCompleted As SendMailCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_NO_SMSCompleted As SendMail_NO_SMSCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_ASY_ATTACHCompleted As SendMail_ASY_ATTACHCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_ASYCompleted As SendMail_ASYCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_ASY_NO_SMSCompleted As SendMail_ASY_NO_SMSCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMailHTMLCompleted As SendMailHTMLCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_CCCompleted As SendMail_CCCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_ATTACHCompleted As SendMail_ATTACHCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_ATTACH_OBJCompleted As SendMail_ATTACH_OBJCompletedEventHandler
        
        '''<remarks/>
        Public Event SendMail_CC_ATTACHCompleted As SendMail_CC_ATTACHCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail(ByVal Mail As Fields_Mail)
            Me.Invoke("SendMail", New Object() {Mail})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMailAsync(ByVal Mail As Fields_Mail)
            Me.SendMailAsync(Mail, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMailAsync(ByVal Mail As Fields_Mail, ByVal userState As Object)
            If (Me.SendMailOperationCompleted Is Nothing) Then
                Me.SendMailOperationCompleted = AddressOf Me.OnSendMailOperationCompleted
            End If
            Me.InvokeAsync("SendMail", New Object() {Mail}, Me.SendMailOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMailOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMailCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMailCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_NO_SMS", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_NO_SMS(ByVal Mail As Fields_Mail)
            Me.Invoke("SendMail_NO_SMS", New Object() {Mail})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_NO_SMSAsync(ByVal Mail As Fields_Mail)
            Me.SendMail_NO_SMSAsync(Mail, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_NO_SMSAsync(ByVal Mail As Fields_Mail, ByVal userState As Object)
            If (Me.SendMail_NO_SMSOperationCompleted Is Nothing) Then
                Me.SendMail_NO_SMSOperationCompleted = AddressOf Me.OnSendMail_NO_SMSOperationCompleted
            End If
            Me.InvokeAsync("SendMail_NO_SMS", New Object() {Mail}, Me.SendMail_NO_SMSOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_NO_SMSOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_NO_SMSCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_NO_SMSCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_ASY_ATTACH", RequestNamespace:="http://tempuri.org/", OneWay:=true, Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_ASY_ATTACH(ByVal Mail As Fields_Mail, ByVal XMLs As String, ByVal FILENAME As String)
            Me.Invoke("SendMail_ASY_ATTACH", New Object() {Mail, XMLs, FILENAME})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ASY_ATTACHAsync(ByVal Mail As Fields_Mail, ByVal XMLs As String, ByVal FILENAME As String)
            Me.SendMail_ASY_ATTACHAsync(Mail, XMLs, FILENAME, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ASY_ATTACHAsync(ByVal Mail As Fields_Mail, ByVal XMLs As String, ByVal FILENAME As String, ByVal userState As Object)
            If (Me.SendMail_ASY_ATTACHOperationCompleted Is Nothing) Then
                Me.SendMail_ASY_ATTACHOperationCompleted = AddressOf Me.OnSendMail_ASY_ATTACHOperationCompleted
            End If
            Me.InvokeAsync("SendMail_ASY_ATTACH", New Object() {Mail, XMLs, FILENAME}, Me.SendMail_ASY_ATTACHOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_ASY_ATTACHOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_ASY_ATTACHCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_ASY_ATTACHCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_ASY", RequestNamespace:="http://tempuri.org/", OneWay:=true, Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_ASY(ByVal Mail As Fields_Mail)
            Me.Invoke("SendMail_ASY", New Object() {Mail})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ASYAsync(ByVal Mail As Fields_Mail)
            Me.SendMail_ASYAsync(Mail, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ASYAsync(ByVal Mail As Fields_Mail, ByVal userState As Object)
            If (Me.SendMail_ASYOperationCompleted Is Nothing) Then
                Me.SendMail_ASYOperationCompleted = AddressOf Me.OnSendMail_ASYOperationCompleted
            End If
            Me.InvokeAsync("SendMail_ASY", New Object() {Mail}, Me.SendMail_ASYOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_ASYOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_ASYCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_ASYCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_ASY_NO_SMS", RequestNamespace:="http://tempuri.org/", OneWay:=true, Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_ASY_NO_SMS(ByVal Mail As Fields_Mail)
            Me.Invoke("SendMail_ASY_NO_SMS", New Object() {Mail})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ASY_NO_SMSAsync(ByVal Mail As Fields_Mail)
            Me.SendMail_ASY_NO_SMSAsync(Mail, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ASY_NO_SMSAsync(ByVal Mail As Fields_Mail, ByVal userState As Object)
            If (Me.SendMail_ASY_NO_SMSOperationCompleted Is Nothing) Then
                Me.SendMail_ASY_NO_SMSOperationCompleted = AddressOf Me.OnSendMail_ASY_NO_SMSOperationCompleted
            End If
            Me.InvokeAsync("SendMail_ASY_NO_SMS", New Object() {Mail}, Me.SendMail_ASY_NO_SMSOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_ASY_NO_SMSOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_ASY_NO_SMSCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_ASY_NO_SMSCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMailHTML", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMailHTML(ByVal Mail As Fields_Mail)
            Me.Invoke("SendMailHTML", New Object() {Mail})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMailHTMLAsync(ByVal Mail As Fields_Mail)
            Me.SendMailHTMLAsync(Mail, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMailHTMLAsync(ByVal Mail As Fields_Mail, ByVal userState As Object)
            If (Me.SendMailHTMLOperationCompleted Is Nothing) Then
                Me.SendMailHTMLOperationCompleted = AddressOf Me.OnSendMailHTMLOperationCompleted
            End If
            Me.InvokeAsync("SendMailHTML", New Object() {Mail}, Me.SendMailHTMLOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMailHTMLOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMailHTMLCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMailHTMLCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_CC", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_CC(ByVal Mail As Fields_Mail, ByVal CC As String)
            Me.Invoke("SendMail_CC", New Object() {Mail, CC})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_CCAsync(ByVal Mail As Fields_Mail, ByVal CC As String)
            Me.SendMail_CCAsync(Mail, CC, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_CCAsync(ByVal Mail As Fields_Mail, ByVal CC As String, ByVal userState As Object)
            If (Me.SendMail_CCOperationCompleted Is Nothing) Then
                Me.SendMail_CCOperationCompleted = AddressOf Me.OnSendMail_CCOperationCompleted
            End If
            Me.InvokeAsync("SendMail_CC", New Object() {Mail, CC}, Me.SendMail_CCOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_CCOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_CCCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_CCCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_ATTACH", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_ATTACH(ByVal Mail As Fields_Mail, ByVal XMLs As String, ByVal FILENAME As String)
            Me.Invoke("SendMail_ATTACH", New Object() {Mail, XMLs, FILENAME})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ATTACHAsync(ByVal Mail As Fields_Mail, ByVal XMLs As String, ByVal FILENAME As String)
            Me.SendMail_ATTACHAsync(Mail, XMLs, FILENAME, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ATTACHAsync(ByVal Mail As Fields_Mail, ByVal XMLs As String, ByVal FILENAME As String, ByVal userState As Object)
            If (Me.SendMail_ATTACHOperationCompleted Is Nothing) Then
                Me.SendMail_ATTACHOperationCompleted = AddressOf Me.OnSendMail_ATTACHOperationCompleted
            End If
            Me.InvokeAsync("SendMail_ATTACH", New Object() {Mail, XMLs, FILENAME}, Me.SendMail_ATTACHOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_ATTACHOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_ATTACHCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_ATTACHCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_ATTACH_OBJ", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_ATTACH_OBJ(ByVal Mail As Fields_Mail, ByVal B64 As String, ByVal filename As String)
            Me.Invoke("SendMail_ATTACH_OBJ", New Object() {Mail, B64, filename})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ATTACH_OBJAsync(ByVal Mail As Fields_Mail, ByVal B64 As String, ByVal filename As String)
            Me.SendMail_ATTACH_OBJAsync(Mail, B64, filename, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_ATTACH_OBJAsync(ByVal Mail As Fields_Mail, ByVal B64 As String, ByVal filename As String, ByVal userState As Object)
            If (Me.SendMail_ATTACH_OBJOperationCompleted Is Nothing) Then
                Me.SendMail_ATTACH_OBJOperationCompleted = AddressOf Me.OnSendMail_ATTACH_OBJOperationCompleted
            End If
            Me.InvokeAsync("SendMail_ATTACH_OBJ", New Object() {Mail, B64, filename}, Me.SendMail_ATTACH_OBJOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_ATTACH_OBJOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_ATTACH_OBJCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_ATTACH_OBJCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail_CC_ATTACH", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SendMail_CC_ATTACH(ByVal Mail As Fields_Mail, ByVal CC As String, ByVal XMLs As String, ByVal FILENAME As String)
            Me.Invoke("SendMail_CC_ATTACH", New Object() {Mail, CC, XMLs, FILENAME})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_CC_ATTACHAsync(ByVal Mail As Fields_Mail, ByVal CC As String, ByVal XMLs As String, ByVal FILENAME As String)
            Me.SendMail_CC_ATTACHAsync(Mail, CC, XMLs, FILENAME, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SendMail_CC_ATTACHAsync(ByVal Mail As Fields_Mail, ByVal CC As String, ByVal XMLs As String, ByVal FILENAME As String, ByVal userState As Object)
            If (Me.SendMail_CC_ATTACHOperationCompleted Is Nothing) Then
                Me.SendMail_CC_ATTACHOperationCompleted = AddressOf Me.OnSendMail_CC_ATTACHOperationCompleted
            End If
            Me.InvokeAsync("SendMail_CC_ATTACH", New Object() {Mail, CC, XMLs, FILENAME}, Me.SendMail_CC_ATTACHOperationCompleted, userState)
        End Sub
        
        Private Sub OnSendMail_CC_ATTACHOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendMail_CC_ATTACHCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendMail_CC_ATTACHCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Fields_Mail
        
        Private eMAIL_FROMField As String
        
        Private eMAIL_PASSField As String
        
        Private eMAIL_TOField As String
        
        Private eMAIL_TILEField As String
        
        Private eMAIL_CONTENTField As String
        
        '''<remarks/>
        Public Property EMAIL_FROM() As String
            Get
                Return Me.eMAIL_FROMField
            End Get
            Set
                Me.eMAIL_FROMField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property EMAIL_PASS() As String
            Get
                Return Me.eMAIL_PASSField
            End Get
            Set
                Me.eMAIL_PASSField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property EMAIL_TO() As String
            Get
                Return Me.eMAIL_TOField
            End Get
            Set
                Me.eMAIL_TOField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property EMAIL_TILE() As String
            Get
                Return Me.eMAIL_TILEField
            End Get
            Set
                Me.eMAIL_TILEField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property EMAIL_CONTENT() As String
            Get
                Return Me.eMAIL_CONTENTField
            End Get
            Set
                Me.eMAIL_CONTENTField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMailCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_NO_SMSCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_ASY_ATTACHCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_ASYCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_ASY_NO_SMSCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMailHTMLCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_CCCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_ATTACHCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_ATTACH_OBJCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub SendMail_CC_ATTACHCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
End Namespace
