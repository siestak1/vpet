﻿#pragma checksum "..\..\..\..\Display\MessageBar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66FC4B341C67E6671993FE10B15F8B765D935DBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
using Panuon.WPF.UI.Resources;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using VPet_Simulator.Core;


namespace VPet_Simulator.Core {
    
    
    /// <summary>
    /// MessageBar
    /// </summary>
    public partial class MessageBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Display\MessageBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderMain;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Display\MessageBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LName;
        
        #line default
        #line hidden
        
        /// <summary>
        /// TText Name Field
        /// </summary>
        
        #line 18 "..\..\..\..\Display\MessageBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBlock TText;
        
        #line default
        #line hidden
        
        /// <summary>
        /// MessageBoxContent Name Field
        /// </summary>
        
        #line 21 "..\..\..\..\Display\MessageBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Grid MessageBoxContent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VPet-Simulator.Core;V1.0.0.0;component/display/messagebar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Display\MessageBar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 6 "..\..\..\..\Display\MessageBar.xaml"
            ((VPet_Simulator.Core.MessageBar)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BorderMain = ((System.Windows.Controls.Border)(target));
            
            #line 11 "..\..\..\..\Display\MessageBar.xaml"
            this.BorderMain.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\Display\MessageBar.xaml"
            this.BorderMain.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Border_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.MessageBoxContent = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

