﻿#pragma checksum "C:\Users\aaa48571\Source\Repos\audioCreation\AudioCreation\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "32AE2D9966C0BE1849B0D53D8C702EAB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDKTemplate
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 13
                {
                    this.Main = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // MainPage.xaml line 32
                {
                    this.Splitter = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // MainPage.xaml line 73
                {
                    this.HeaderPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // MainPage.xaml line 81
                {
                    this.WindowsLogo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // MainPage.xaml line 82
                {
                    this.Header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // MainPage.xaml line 75
                {
                    global::Windows.UI.Xaml.Controls.Primitives.ToggleButton element6 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)element6).Click += this.Button_Click;
                }
                break;
            case 7: // MainPage.xaml line 77
                {
                    this.Hamburger = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 8: // MainPage.xaml line 35
                {
                    this.SampleTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainPage.xaml line 36
                {
                    this.ScenarioControl = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.ScenarioControl).SelectionChanged += this.ScenarioControl_SelectionChanged;
                }
                break;
            case 10: // MainPage.xaml line 45
                {
                    this.FooterPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11: // MainPage.xaml line 47
                {
                    this.Copyright = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // MainPage.xaml line 50
                {
                    this.LinksPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 13: // MainPage.xaml line 51
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element13 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element13).Click += this.Footer_Click;
                }
                break;
            case 14: // MainPage.xaml line 54
                {
                    this.PrivacyLink = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.PrivacyLink).Click += this.Footer_Click;
                }
                break;
            case 15: // MainPage.xaml line 60
                {
                    this.ScenarioFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 16: // MainPage.xaml line 61
                {
                    this.StatusPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 17: // MainPage.xaml line 62
                {
                    this.StatusLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // MainPage.xaml line 63
                {
                    this.StatusBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 19: // MainPage.xaml line 65
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

