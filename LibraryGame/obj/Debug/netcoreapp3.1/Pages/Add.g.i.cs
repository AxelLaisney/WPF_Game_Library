﻿#pragma checksum "..\..\..\..\Pages\Add.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F65EE7FC74B8C0FDDC0E63F60E0CB2196578F58E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
    /// Add
    /// </summary>
    public partial class Add : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\Pages\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelTitle;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Pages\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbox_title;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Pages\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbox_genre;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Pages\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbox_publisher;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Pages\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Tbox_date;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\Pages\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgCover;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryGame;component/pages/add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Add.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LabelTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 74 "..\..\..\..\Pages\Add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButton);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 80 "..\..\..\..\Pages\Add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Tbox_title = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\..\Pages\Add.xaml"
            this.Tbox_title.GotFocus += new System.Windows.RoutedEventHandler(this.Tbox_title_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Tbox_genre = ((System.Windows.Controls.TextBox)(target));
            
            #line 95 "..\..\..\..\Pages\Add.xaml"
            this.Tbox_genre.GotFocus += new System.Windows.RoutedEventHandler(this.Tbox_genre_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Tbox_publisher = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\..\..\Pages\Add.xaml"
            this.Tbox_publisher.GotFocus += new System.Windows.RoutedEventHandler(this.Tbox_publisher_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Tbox_date = ((System.Windows.Controls.DatePicker)(target));
            
            #line 111 "..\..\..\..\Pages\Add.xaml"
            this.Tbox_date.GotFocus += new System.Windows.RoutedEventHandler(this.Tbox_date_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 112 "..\..\..\..\Pages\Add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CoverButton);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ImgCover = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

