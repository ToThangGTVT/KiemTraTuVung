﻿#pragma checksum "..\..\Them_tu_moi.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA9F40FA33EDACADE2AEB061E2B0024F864F51096F09A4053227365F82DB1F18"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Học_tiếng_Nhật {
    
    
    /// <summary>
    /// Them_tu_moi
    /// </summary>
    public partial class Them_tu_moi : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Them_tu_moi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Học_tiếng_Nhật.Them_tu_moi them_tu_moi;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Them_tu_moi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lst_excel;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Them_tu_moi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Vie;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Them_tu_moi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Eng;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Them_tu_moi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btn_htm;
        
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
            System.Uri resourceLocater = new System.Uri("/Học tiếng Nhật;component/them_tu_moi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Them_tu_moi.xaml"
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
            this.them_tu_moi = ((Học_tiếng_Nhật.Them_tu_moi)(target));
            
            #line 8 "..\..\Them_tu_moi.xaml"
            this.them_tu_moi.Closing += new System.ComponentModel.CancelEventHandler(this.Them_tu_moi_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\Them_tu_moi.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lst_excel = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.txt_Vie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_Eng = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 58 "..\..\Them_tu_moi.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 64 "..\..\Them_tu_moi.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_htm = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 68 "..\..\Them_tu_moi.xaml"
            this.btn_htm.Checked += new System.Windows.RoutedEventHandler(this.ToggleButton_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

