// Updated by XamlIntelliSenseFileGenerator 08.12.2023 11:00:22
#pragma checksum "..\..\..\Pages\tovar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A1D2DF4529768802AFA131F5ADF00CE55C21FC08BD4E812211437F6FF3EB6FD"
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
using WpfAppOreshnikov.Pages;


namespace WpfAppOreshnikov.Pages
{


    /// <summary>
    /// tovar
    /// </summary>
    public partial class tovar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 32 "..\..\..\Pages\tovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_Data;

#line default
#line hidden


#line 48 "..\..\..\Pages\tovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_back;

#line default
#line hidden


#line 50 "..\..\..\Pages\tovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filtr_box;

#line default
#line hidden


#line 51 "..\..\..\Pages\tovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_kol;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfAppOreshnikov;component/pages/tovar.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Pages\tovar.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.grid_Data = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 2:
                    this.btn_back = ((System.Windows.Controls.Button)(target));

#line 48 "..\..\..\Pages\tovar.xaml"
                    this.btn_back.Click += new System.Windows.RoutedEventHandler(this.Btn_back_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.sort_box = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 4:
                    this.filtr_box = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 5:
                    this.lbl_kol = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

