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
Namespace WS_BLOCKCHAIN
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WS_BLOCKCHAINSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class WS_BLOCKCHAIN
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private WS_BLOCK_CHAINOperationCompleted As System.Threading.SendOrPostCallback
        
        Private WS_BLOCK_CHAIN_GET_DATAOperationCompleted As System.Threading.SendOrPostCallback
        
        Private WS_BLOCK_CHAIN_GET_DATA_V2OperationCompleted As System.Threading.SendOrPostCallback
        
        Private WS_BLOCK_CHAIN_V3OperationCompleted As System.Threading.SendOrPostCallback
        
        Private WS_BLOCK_CHAIN_V2OperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
<<<<<<<< HEAD:FDA_TABEAN_HERB_NEW/Web References/WS_BLOCKCHAIN/Reference.vb
            Me.Url = Global.FDA_TABEAN_HERB_NEW.My.MySettings.Default.FDA_LCN_HERB_NEW_WS_BLOCKCHAIN_WS_BLOCKCHAIN
========
            Me.Url = Global.FDA_TABEAN_HERB_DEMO.My.MySettings.Default.FDA_LCN_HERB_NEW_WS_BLOCKCHAIN_WS_BLOCKCHAIN
>>>>>>>> 5ea1ad78a7a4d702f4c22e17424ee87d07bc9d38:FDA_TABEAN_HERB_DEMO/Web References/WS_BLOCKCHAIN/Reference.vb
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
        Public Event WS_BLOCK_CHAINCompleted As WS_BLOCK_CHAINCompletedEventHandler
        
        '''<remarks/>
        Public Event WS_BLOCK_CHAIN_GET_DATACompleted As WS_BLOCK_CHAIN_GET_DATACompletedEventHandler
        
        '''<remarks/>
        Public Event WS_BLOCK_CHAIN_GET_DATA_V2Completed As WS_BLOCK_CHAIN_GET_DATA_V2CompletedEventHandler
        
        '''<remarks/>
        Public Event WS_BLOCK_CHAIN_V3Completed As WS_BLOCK_CHAIN_V3CompletedEventHandler
        
        '''<remarks/>
        Public Event WS_BLOCK_CHAIN_V2Completed As WS_BLOCK_CHAIN_V2CompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_BLOCK_CHAIN", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WS_BLOCK_CHAIN(ByVal XML_BLOCKs As XML_BLOCK) As XML_RETURN
            Dim results() As Object = Me.Invoke("WS_BLOCK_CHAIN", New Object() {XML_BLOCKs})
            Return CType(results(0),XML_RETURN)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAINAsync(ByVal XML_BLOCKs As XML_BLOCK)
            Me.WS_BLOCK_CHAINAsync(XML_BLOCKs, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAINAsync(ByVal XML_BLOCKs As XML_BLOCK, ByVal userState As Object)
            If (Me.WS_BLOCK_CHAINOperationCompleted Is Nothing) Then
                Me.WS_BLOCK_CHAINOperationCompleted = AddressOf Me.OnWS_BLOCK_CHAINOperationCompleted
            End If
            Me.InvokeAsync("WS_BLOCK_CHAIN", New Object() {XML_BLOCKs}, Me.WS_BLOCK_CHAINOperationCompleted, userState)
        End Sub
        
        Private Sub OnWS_BLOCK_CHAINOperationCompleted(ByVal arg As Object)
            If (Not (Me.WS_BLOCK_CHAINCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WS_BLOCK_CHAINCompleted(Me, New WS_BLOCK_CHAINCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_BLOCK_CHAIN_GET_DATA", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WS_BLOCK_CHAIN_GET_DATA(ByVal TR_ID As String) As String
            Dim results() As Object = Me.Invoke("WS_BLOCK_CHAIN_GET_DATA", New Object() {TR_ID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_GET_DATAAsync(ByVal TR_ID As String)
            Me.WS_BLOCK_CHAIN_GET_DATAAsync(TR_ID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_GET_DATAAsync(ByVal TR_ID As String, ByVal userState As Object)
            If (Me.WS_BLOCK_CHAIN_GET_DATAOperationCompleted Is Nothing) Then
                Me.WS_BLOCK_CHAIN_GET_DATAOperationCompleted = AddressOf Me.OnWS_BLOCK_CHAIN_GET_DATAOperationCompleted
            End If
            Me.InvokeAsync("WS_BLOCK_CHAIN_GET_DATA", New Object() {TR_ID}, Me.WS_BLOCK_CHAIN_GET_DATAOperationCompleted, userState)
        End Sub
        
        Private Sub OnWS_BLOCK_CHAIN_GET_DATAOperationCompleted(ByVal arg As Object)
            If (Not (Me.WS_BLOCK_CHAIN_GET_DATACompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WS_BLOCK_CHAIN_GET_DATACompleted(Me, New WS_BLOCK_CHAIN_GET_DATACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_BLOCK_CHAIN_GET_DATA_V2", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WS_BLOCK_CHAIN_GET_DATA_V2(ByVal TR_ID As String) As String
            Dim results() As Object = Me.Invoke("WS_BLOCK_CHAIN_GET_DATA_V2", New Object() {TR_ID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_GET_DATA_V2Async(ByVal TR_ID As String)
            Me.WS_BLOCK_CHAIN_GET_DATA_V2Async(TR_ID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_GET_DATA_V2Async(ByVal TR_ID As String, ByVal userState As Object)
            If (Me.WS_BLOCK_CHAIN_GET_DATA_V2OperationCompleted Is Nothing) Then
                Me.WS_BLOCK_CHAIN_GET_DATA_V2OperationCompleted = AddressOf Me.OnWS_BLOCK_CHAIN_GET_DATA_V2OperationCompleted
            End If
            Me.InvokeAsync("WS_BLOCK_CHAIN_GET_DATA_V2", New Object() {TR_ID}, Me.WS_BLOCK_CHAIN_GET_DATA_V2OperationCompleted, userState)
        End Sub
        
        Private Sub OnWS_BLOCK_CHAIN_GET_DATA_V2OperationCompleted(ByVal arg As Object)
            If (Not (Me.WS_BLOCK_CHAIN_GET_DATA_V2CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WS_BLOCK_CHAIN_GET_DATA_V2Completed(Me, New WS_BLOCK_CHAIN_GET_DATA_V2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_BLOCK_CHAIN_V3", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WS_BLOCK_CHAIN_V3(ByVal XML_BLOCKs As XML_BLOCK) As XML_RETURN
            Dim results() As Object = Me.Invoke("WS_BLOCK_CHAIN_V3", New Object() {XML_BLOCKs})
            Return CType(results(0),XML_RETURN)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_V3Async(ByVal XML_BLOCKs As XML_BLOCK)
            Me.WS_BLOCK_CHAIN_V3Async(XML_BLOCKs, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_V3Async(ByVal XML_BLOCKs As XML_BLOCK, ByVal userState As Object)
            If (Me.WS_BLOCK_CHAIN_V3OperationCompleted Is Nothing) Then
                Me.WS_BLOCK_CHAIN_V3OperationCompleted = AddressOf Me.OnWS_BLOCK_CHAIN_V3OperationCompleted
            End If
            Me.InvokeAsync("WS_BLOCK_CHAIN_V3", New Object() {XML_BLOCKs}, Me.WS_BLOCK_CHAIN_V3OperationCompleted, userState)
        End Sub
        
        Private Sub OnWS_BLOCK_CHAIN_V3OperationCompleted(ByVal arg As Object)
            If (Not (Me.WS_BLOCK_CHAIN_V3CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WS_BLOCK_CHAIN_V3Completed(Me, New WS_BLOCK_CHAIN_V3CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_BLOCK_CHAIN_V2", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WS_BLOCK_CHAIN_V2(ByVal XML_DATA As String) As XML_RETURN
            Dim results() As Object = Me.Invoke("WS_BLOCK_CHAIN_V2", New Object() {XML_DATA})
            Return CType(results(0),XML_RETURN)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_V2Async(ByVal XML_DATA As String)
            Me.WS_BLOCK_CHAIN_V2Async(XML_DATA, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WS_BLOCK_CHAIN_V2Async(ByVal XML_DATA As String, ByVal userState As Object)
            If (Me.WS_BLOCK_CHAIN_V2OperationCompleted Is Nothing) Then
                Me.WS_BLOCK_CHAIN_V2OperationCompleted = AddressOf Me.OnWS_BLOCK_CHAIN_V2OperationCompleted
            End If
            Me.InvokeAsync("WS_BLOCK_CHAIN_V2", New Object() {XML_DATA}, Me.WS_BLOCK_CHAIN_V2OperationCompleted, userState)
        End Sub
        
        Private Sub OnWS_BLOCK_CHAIN_V2OperationCompleted(ByVal arg As Object)
            If (Not (Me.WS_BLOCK_CHAIN_V2CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WS_BLOCK_CHAIN_V2Completed(Me, New WS_BLOCK_CHAIN_V2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    Partial Public Class XML_BLOCK
        
        Private iDENTIFYField As String
        
        Private pROCESS_IDField As String
        
        Private sYSTEM_IDField As String
        
        Private tR_IDField As String
        
        Private xML_DATAField As String
        
        Private sOP_STATUSField As String
        
        Private sOP_REMARKField As String
        
        Private sEND_TIMEField As Date
        
        Private rEF_TR_IDField As String
        
        Private rEF_XML_DATAField As String
        
        Private mAIN_TR_IDField As String
        
        '''<remarks/>
        Public Property IDENTIFY() As String
            Get
                Return Me.iDENTIFYField
            End Get
            Set
                Me.iDENTIFYField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property PROCESS_ID() As String
            Get
                Return Me.pROCESS_IDField
            End Get
            Set
                Me.pROCESS_IDField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property SYSTEM_ID() As String
            Get
                Return Me.sYSTEM_IDField
            End Get
            Set
                Me.sYSTEM_IDField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property TR_ID() As String
            Get
                Return Me.tR_IDField
            End Get
            Set
                Me.tR_IDField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property XML_DATA() As String
            Get
                Return Me.xML_DATAField
            End Get
            Set
                Me.xML_DATAField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property SOP_STATUS() As String
            Get
                Return Me.sOP_STATUSField
            End Get
            Set
                Me.sOP_STATUSField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property SOP_REMARK() As String
            Get
                Return Me.sOP_REMARKField
            End Get
            Set
                Me.sOP_REMARKField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property SEND_TIME() As Date
            Get
                Return Me.sEND_TIMEField
            End Get
            Set
                Me.sEND_TIMEField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property REF_TR_ID() As String
            Get
                Return Me.rEF_TR_IDField
            End Get
            Set
                Me.rEF_TR_IDField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property REF_XML_DATA() As String
            Get
                Return Me.rEF_XML_DATAField
            End Get
            Set
                Me.rEF_XML_DATAField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MAIN_TR_ID() As String
            Get
                Return Me.mAIN_TR_IDField
            End Get
            Set
                Me.mAIN_TR_IDField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class XML_RETURN
        
        Private hASH_DATAField As String
        
        Private cREATE_DATEField As Date
        
        Private mSG_CODEField As String
        
        Private mSG_DESField As String
        
        '''<remarks/>
        Public Property HASH_DATA() As String
            Get
                Return Me.hASH_DATAField
            End Get
            Set
                Me.hASH_DATAField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CREATE_DATE() As Date
            Get
                Return Me.cREATE_DATEField
            End Get
            Set
                Me.cREATE_DATEField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MSG_CODE() As String
            Get
                Return Me.mSG_CODEField
            End Get
            Set
                Me.mSG_CODEField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MSG_DES() As String
            Get
                Return Me.mSG_DESField
            End Get
            Set
                Me.mSG_DESField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub WS_BLOCK_CHAINCompletedEventHandler(ByVal sender As Object, ByVal e As WS_BLOCK_CHAINCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WS_BLOCK_CHAINCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As XML_RETURN
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),XML_RETURN)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub WS_BLOCK_CHAIN_GET_DATACompletedEventHandler(ByVal sender As Object, ByVal e As WS_BLOCK_CHAIN_GET_DATACompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WS_BLOCK_CHAIN_GET_DATACompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub WS_BLOCK_CHAIN_GET_DATA_V2CompletedEventHandler(ByVal sender As Object, ByVal e As WS_BLOCK_CHAIN_GET_DATA_V2CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WS_BLOCK_CHAIN_GET_DATA_V2CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub WS_BLOCK_CHAIN_V3CompletedEventHandler(ByVal sender As Object, ByVal e As WS_BLOCK_CHAIN_V3CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WS_BLOCK_CHAIN_V3CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As XML_RETURN
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),XML_RETURN)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub WS_BLOCK_CHAIN_V2CompletedEventHandler(ByVal sender As Object, ByVal e As WS_BLOCK_CHAIN_V2CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WS_BLOCK_CHAIN_V2CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As XML_RETURN
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),XML_RETURN)
            End Get
        End Property
    End Class
End Namespace
