﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.104/WS_CENTER_CPN/WS_DATA_CENTER.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_WS_DATA_CENTER_WS_DATA_CENTER() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_WS_DATA_CENTER_WS_DATA_CENTER"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://meshlog.fda.moph.go.th/WS_DRUG_UPDATE_LCN_HERB/WS_DRUG_LCN/WS_DRUG.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_WS_DRUG_WS_DRUG() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_WS_DRUG_WS_DRUG"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://164.115.28.137/TEST_FLATEN/WS_FLATTEN.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_WS_FLATTEN_WS_FLATTEN() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_WS_FLATTEN_WS_FLATTEN"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://164.115.28.108/Mail/FDA_MAIL.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_FDA_MAIL_FDA_MAIL() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_FDA_MAIL_FDA_MAIL"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://164.115.28.104/WS_AUTHEN4/Authentication.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_Authentication_104_Authentication() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_Authentication_104_Authentication"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.66/WS_AUTHEN4/Authentication.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_Authentication_66_Authentication() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_Authentication_66_Authentication"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://meshlog.fda.moph.go.th/FDA_HERB_SW/SW_HERB_PAYMENT.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_SW_HERB_PAYMENT_SW_LCN_EDIT_PAYMENT() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_SW_HERB_PAYMENT_SW_LCN_EDIT_PAYMENT"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.65/WS_AUTHEN4/Authentication.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_Authentication_65_Authentication() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_Authentication_65_Authentication"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.66/FDA_BLOCKV2/WS_BLOCKCHAIN.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_WS_BLOCKCHAIN_WS_BLOCKCHAIN() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_WS_BLOCKCHAIN_WS_BLOCKCHAIN"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.108/WS_CITIZEN/WS_FDA_CITIZEN.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_WS_FDA_CITIZEN_WS_FDA_CITIZEN() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_WS_FDA_CITIZEN_WS_FDA_CITIZEN"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.108/WS_TRADER/WS_TRADER.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_WS_TRADER_WS_TRADER() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_WS_TRADER_WS_TRADER"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.108/WS_Taxno_TaxnoAuthorize/WS_Taxno_TaxnoAuthorize.asmx")>  _
        Public ReadOnly Property FDA_LCN_HERB_NEW_WS_Taxno_TaxnoAuthorize_WebService1() As String
            Get
                Return CType(Me("FDA_LCN_HERB_NEW_WS_Taxno_TaxnoAuthorize_WebService1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.129/WS_QR_CODE/WS_QR_CODE.asmx")>  _
<<<<<<<< HEAD:FDA_TABEAN_HERB_NEW/My Project/Settings.Designer.vb
        Public ReadOnly Property FDA_TABEAN_HERB_NEW_WS_QR_CODE_WS_QR_CODE() As String
            Get
                Return CType(Me("FDA_TABEAN_HERB_NEW_WS_QR_CODE_WS_QR_CODE"),String)
========
        Public ReadOnly Property FDA_TABEAN_HERB_DEMO_WS_QR_CODE_WS_QR_CODE() As String
            Get
                Return CType(Me("FDA_TABEAN_HERB_DEMO_WS_QR_CODE_WS_QR_CODE"),String)
>>>>>>>> 5ea1ad78a7a4d702f4c22e17424ee87d07bc9d38:FDA_TABEAN_HERB_DEMO/My Project/Settings.Designer.vb
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.111.28.108/WS_SMS/FDA_SMS.asmx")>  _
<<<<<<<< HEAD:FDA_TABEAN_HERB_NEW/My Project/Settings.Designer.vb
        Public ReadOnly Property FDA_TABEAN_HERB_NEW_FDA_SMS_FDA_SMS() As String
            Get
                Return CType(Me("FDA_TABEAN_HERB_NEW_FDA_SMS_FDA_SMS"),String)
========
        Public ReadOnly Property FDA_TABEAN_HERB_DEMO_FDA_SMS_FDA_SMS() As String
            Get
                Return CType(Me("FDA_TABEAN_HERB_DEMO_FDA_SMS_FDA_SMS"),String)
>>>>>>>> 5ea1ad78a7a4d702f4c22e17424ee87d07bc9d38:FDA_TABEAN_HERB_DEMO/My Project/Settings.Designer.vb
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
<<<<<<<< HEAD:FDA_TABEAN_HERB_NEW/My Project/Settings.Designer.vb
        Friend ReadOnly Property Settings() As Global.FDA_TABEAN_HERB_NEW.My.MySettings
            Get
                Return Global.FDA_TABEAN_HERB_NEW.My.MySettings.Default
========
        Friend ReadOnly Property Settings() As Global.FDA_TABEAN_HERB_DEMO.My.MySettings
            Get
                Return Global.FDA_TABEAN_HERB_DEMO.My.MySettings.Default
>>>>>>>> 5ea1ad78a7a4d702f4c22e17424ee87d07bc9d38:FDA_TABEAN_HERB_DEMO/My Project/Settings.Designer.vb
            End Get
        End Property
    End Module
End Namespace
