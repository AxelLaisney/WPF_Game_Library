﻿#pragma checksum "..\..\..\..\Pages\Home.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436E601DA7A11B8617A88D200370AAEA8D685179"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryGame.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LibraryGame.Pages {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Pages\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GameGrid;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelTitle;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Pages\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddGameButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Pages\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditGameButton;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Pages\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteGameButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryGame;component/pages/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Home.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GameGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\..\..\Pages\Home.xaml"
            this.GameGrid.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.GameGridAutoGeneratingColoumn);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.AddGameButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Pages\Home.xaml"
            this.AddGameButton.Click += new System.Windows.RoutedEventHandler(this.AddButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditGameButton = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\Pages\Home.xaml"
            this.EditGameButton.Click += new System.Windows.RoutedEventHandler(this.EditButton);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteGameButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\Pages\Home.xaml"
            this.DeleteGameButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

