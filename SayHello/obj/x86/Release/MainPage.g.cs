﻿#pragma checksum "E:\Code\SayHello\SayHello\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CFD35EBB68256DF972BDC1BD30AACC69"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SayHello
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 11
                {
                    this.MainPageGird = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 12
                {
                    this.TitleText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 18
                {
                    this.SayHelloButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SayHelloButton).Click += this.SayHelloButton_Click;
                }
                break;
            case 5: // MainPage.xaml line 31
                {
                    this.textBox1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 46
                {
                    this.Disapper = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Disapper).Checked += this.DisapperChenked;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Disapper).Unchecked += this.DisapperUnchenked;
                }
                break;
            case 7: // MainPage.xaml line 58
                {
                    this.GoToNewPage = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 8: // MainPage.xaml line 77
                {
                    this.TopButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TopButton).Click += this.TopMode;
                }
                break;
            case 9: // MainPage.xaml line 80
                {
                    this.TopButtonBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TopButtonBack).Click += this.CloseTopMode;
                }
                break;
            case 10: // MainPage.xaml line 66
                {
                    this.AddNewPage = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.AddNewPage).Click += this.About;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

