﻿#pragma checksum "..\..\..\Test.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A73CAC48B167A6372BDBD64751B3BBDBE9454DB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TEST;


namespace TEST {
    
    
    /// <summary>
    /// Test
    /// </summary>
    public partial class Test : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _message;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _title;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _desc;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button answer_1_button;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button answer_2_button;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button answer_3_button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TEST;component/test.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Test.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this._title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this._desc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.answer_1_button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Test.xaml"
            this.answer_1_button.Click += new System.Windows.RoutedEventHandler(this.answer_1_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.answer_2_button = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Test.xaml"
            this.answer_2_button.Click += new System.Windows.RoutedEventHandler(this.answer_2_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.answer_3_button = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Test.xaml"
            this.answer_3_button.Click += new System.Windows.RoutedEventHandler(this.answer_3_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

