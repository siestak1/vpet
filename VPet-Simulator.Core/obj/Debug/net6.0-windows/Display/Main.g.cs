﻿#pragma checksum "..\..\..\..\Display\Main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C5A864975C90B56B1FC074D25C4B581211FE5E00"
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
    /// Main
    /// </summary>
    public partial class Main : Panuon.WPF.UI.ContentControlX, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// MainGrid Name Field
        /// </summary>
        
        #line 7 "..\..\..\..\Display\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        /// <summary>
        /// VoicePlayer Name Field
        /// </summary>
        
        #line 10 "..\..\..\..\Display\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.MediaElement VoicePlayer;
        
        #line default
        #line hidden
        
        /// <summary>
        /// UIGrid_Back Name Field
        /// </summary>
        
        #line 11 "..\..\..\..\Display\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Grid UIGrid_Back;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Display\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PetGrid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Display\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PetGrid2;
        
        #line default
        #line hidden
        
        /// <summary>
        /// UIGrid Name Field
        /// </summary>
        
        #line 14 "..\..\..\..\Display\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Grid UIGrid;
        
        #line default
        #line hidden
        
        /// <summary>
        /// LabelDisplay Name Field
        /// </summary>
        
        #line 15 "..\..\..\..\Display\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Label LabelDisplay;
        
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
            System.Uri resourceLocater = new System.Uri("/VPet-Simulator.Core;V1.0.0.0;component/display/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Display\Main.xaml"
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
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 7 "..\..\..\..\Display\Main.xaml"
            this.MainGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MainGrid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Display\Main.xaml"
            this.MainGrid.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.MainGrid_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Display\Main.xaml"
            this.MainGrid.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MainGrid_MouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\Display\Main.xaml"
            this.MainGrid.MouseMove += new System.Windows.Input.MouseEventHandler(this.MainGrid_MouseWave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VoicePlayer = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.UIGrid_Back = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.PetGrid = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.PetGrid2 = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.UIGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.LabelDisplay = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

