﻿#pragma checksum "C:\Users\nguye\source\repos\MusicPlayerDemo\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD6C7CC1FBC2D35C605A98B8E9069988CED9987C299F8A5468ECA4065B68E747"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicPlayerDemo
{
    partial class MainPage : 
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
            case 2: // MainPage.xaml line 12
                {
                    this.navView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.navView).SelectionChanged += this.NavigationView_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.navView).Loaded += this.LoadedPage;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.navView).BackRequested += this.NavigationView_BackRequested;
                }
                break;
            case 3: // MainPage.xaml line 27
                {
                    this.AddMediaPlayNav = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 4: // MainPage.xaml line 33
                {
                    this.CreateNewSong = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 38
                {
                    this.CreateMySong = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 43
                {
                    this.MyMusic = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 7: // MainPage.xaml line 48
                {
                    this.RecentPlays = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 8: // MainPage.xaml line 53
                {
                    this.NowPlaying = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 9: // MainPage.xaml line 58
                {
                    this.GetMyProfile = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 10: // MainPage.xaml line 64
                {
                    this.Playlist = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 11: // MainPage.xaml line 69
                {
                    this.Register = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 12: // MainPage.xaml line 74
                {
                    this.Login = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 13: // MainPage.xaml line 79
                {
                    this.Logout = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 14: // MainPage.xaml line 87
                {
                    this.PaneHyperlink = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 15: // MainPage.xaml line 95
                {
                    this.FooterStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 16: // MainPage.xaml line 100
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

