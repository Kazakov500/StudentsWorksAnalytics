﻿#pragma checksum "..\..\..\UserControls\ParamInputControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3CA3724DED423E16D393FD15CEF0C4A8"
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
using System.Windows.Forms.Integration;
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
using WpfApplication2.UserControls;


namespace WpfApplication2.UserControls {
    
    
    /// <summary>
    /// ParamInputControl
    /// </summary>
    public partial class ParamInputControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\UserControls\ParamInputControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tBl_Title;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\UserControls\ParamInputControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tBl_Description;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserControls\ParamInputControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Value;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UserControls\ParamInputControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tBl_Number;
        
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
            System.Uri resourceLocater = new System.Uri("/StudentsWorkAnalytics;component/usercontrols/paraminputcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\ParamInputControl.xaml"
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
            this.tBl_Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tBl_Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tb_Value = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\UserControls\ParamInputControl.xaml"
            this.tb_Value.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\UserControls\ParamInputControl.xaml"
            this.tb_Value.LostFocus += new System.Windows.RoutedEventHandler(this.tb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tBl_Number = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

