﻿#pragma checksum "..\..\W_CreateAd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD4064CDB8ADA3D8DC3EEF8DC446C91F7499C276E9B15106A77D296695D0EFA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Wpf_DeClutter_1;


namespace Wpf_DeClutter_1 {
    
    
    /// <summary>
    /// W_CreateAd
    /// </summary>
    public partial class W_CreateAd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_pName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_pCategory;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_pDesc;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_pContact;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_pLocation;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_pImage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_open;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\W_CreateAd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_add;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Wpf_DeClutter_1;component/w_createad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\W_CreateAd.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Tbx_pName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Cbx_pCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Tbx_pDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Tbx_pContact = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Tbx_pLocation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Tbx_pImage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Btn_open = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\W_CreateAd.xaml"
            this.Btn_open.Click += new System.Windows.RoutedEventHandler(this.Btn_open_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\W_CreateAd.xaml"
            this.Btn_add.Click += new System.Windows.RoutedEventHandler(this.Btn_add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
