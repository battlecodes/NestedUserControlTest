using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NestedUserControlTest
{
    /// <summary>
    /// Interaction logic for ChildControl.xaml
    /// </summary>
    public partial class ChildControl : UserControl
    {

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string),
                typeof(ChildControl), new PropertyMetadata(""));

        public static readonly DependencyProperty FieldTextProperty =
            DependencyProperty.Register("FieldText", typeof(string),
                typeof(ChildControl), new PropertyMetadata(""));

        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.Register("ClearCommand", typeof(ICommand),
                typeof(ChildControl));



        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }


        public string FieldText
        {
            get { return (string)GetValue(FieldTextProperty); }
            set { SetValue(FieldTextProperty, value); }
        }


        public ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
            set { SetValue(ClearCommandProperty, value); }
        }


        public ChildControl()
        {
            InitializeComponent();
        }
    }
}
