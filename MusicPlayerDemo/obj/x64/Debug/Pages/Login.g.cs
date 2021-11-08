﻿#pragma checksum "C:\Users\nguye\source\repos\MusicPlayerDemo\Pages\Login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "369E2DA9FEAA3385D79F11FED99BE4C72B2D6526F4826E80F3604EA32B35F5D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicPlayerDemo.Pages
{
    partial class Login : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Login.xaml line 19
                {
                    this.loginForm = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Pages\Login.xaml line 38
                {
                    this.registerForm = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Pages\Login.xaml line 96
                {
                    this.LoadingEffect = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // Pages\Login.xaml line 99
                {
                    this.RegisterButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RegisterButton).Click += this.OnRegister;
                }
                break;
            case 6: // Pages\Login.xaml line 100
                {
                    this.ShowLoginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShowLoginButton).Click += this.ShowLoginForm;
                }
                break;
            case 7: // Pages\Login.xaml line 97
                {
                    this.progressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 8: // Pages\Login.xaml line 91
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element8 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element8).Checked += this.OnChooseGender;
                }
                break;
            case 9: // Pages\Login.xaml line 92
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element9 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element9).Checked += this.OnChooseGender;
                }
                break;
            case 10: // Pages\Login.xaml line 86
                {
                    this.birthdayPicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 11: // Pages\Login.xaml line 81
                {
                    this.addressTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.addressTxt).TextChanged += this.HandleChangeEmailLogin;
                }
                break;
            case 12: // Pages\Login.xaml line 73
                {
                    this.avatarTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.avatarTxt).TextChanged += this.HandleChangeEmailLogin;
                }
                break;
            case 13: // Pages\Login.xaml line 74
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.UploadAvatar;
                }
                break;
            case 14: // Pages\Login.xaml line 67
                {
                    this.repasswordTxt = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.repasswordTxt).PasswordChanged += this.HandleChangePasswordLogin;
                }
                break;
            case 15: // Pages\Login.xaml line 63
                {
                    this.passwordRegisterTxt = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.passwordRegisterTxt).PasswordChanged += this.HandleChangePasswordLogin;
                }
                break;
            case 16: // Pages\Login.xaml line 57
                {
                    this.emailRegisterTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.emailRegisterTxt).TextChanged += this.HandleChangeEmailLogin;
                }
                break;
            case 17: // Pages\Login.xaml line 53
                {
                    this.phoneTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.phoneTxt).TextChanged += this.HandleChangeEmailLogin;
                }
                break;
            case 18: // Pages\Login.xaml line 47
                {
                    this.lastNameTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.lastNameTxt).TextChanged += this.HandleChangeEmailLogin;
                }
                break;
            case 19: // Pages\Login.xaml line 43
                {
                    this.firstNameTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.firstNameTxt).TextChanged += this.HandleChangeEmailLogin;
                }
                break;
            case 20: // Pages\Login.xaml line 23
                {
                    this.emailTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.emailTxt).TextChanged += this.HandleChangeEmailLogin;
                }
                break;
            case 21: // Pages\Login.xaml line 25
                {
                    this.passwordTxt = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.passwordTxt).PasswordChanged += this.HandleChangePasswordLogin;
                }
                break;
            case 22: // Pages\Login.xaml line 26
                {
                    this.LoadingEffectLogin = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 23: // Pages\Login.xaml line 29
                {
                    this.LoginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoginButton).Click += this.OnLogin;
                }
                break;
            case 24: // Pages\Login.xaml line 30
                {
                    this.ShowRegisterButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShowRegisterButton).Click += this.ShowRegisterForm;
                }
                break;
            case 25: // Pages\Login.xaml line 32
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element25 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element25).Click += this.SkipLoginPage;
                }
                break;
            case 26: // Pages\Login.xaml line 27
                {
                    this.progressBarLogin = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 27: // Pages\Login.xaml line 13
                {
                    this.musicPlayerLogo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

