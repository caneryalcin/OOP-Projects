﻿#pragma checksum "..\..\Kelime_Ekle_Cikar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "499C4C6ADE7564E3546D19A7291265AAB8F4409D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdamAsmacaOyun;
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


namespace AdamAsmacaOyun {
    
    
    /// <summary>
    /// Kelime_Ekle_Cikar
    /// </summary>
    public partial class Kelime_Ekle_Cikar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Kelime_Ekle_Cikar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button kelimeEkle;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Kelime_Ekle_Cikar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kelimeText;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Kelime_Ekle_Cikar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button kelimeCikar;
        
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
            System.Uri resourceLocater = new System.Uri("/AdamAsmacaOyun;component/kelime_ekle_cikar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Kelime_Ekle_Cikar.xaml"
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
            this.kelimeEkle = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Kelime_Ekle_Cikar.xaml"
            this.kelimeEkle.Click += new System.Windows.RoutedEventHandler(this.kelimeEkle_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.kelimeText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.kelimeCikar = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Kelime_Ekle_Cikar.xaml"
            this.kelimeCikar.Click += new System.Windows.RoutedEventHandler(this.kelimeCikar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

