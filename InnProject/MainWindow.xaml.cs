using InnLibrary.Model;
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



namespace InnProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        int idInspection;
        string codeInispection;

        public MainWindow()
        {
            InitializeComponent();
            RegionTreeView.ItemsSource = TreeSource.FillTreeNodeList(0);
        }

       

        private void RegionTreeView_SelectItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue != null)
            {
                idInspection = (e.NewValue as Node).ID;
                codeInispection = (e.NewValue as Node).Code;
                Console.WriteLine(codeInispection);
            }
        }
    }
}
