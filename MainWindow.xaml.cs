using ScrumAssist.Data;
using ScrumAssist.Static;
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
using ScrumAssist.Pages;

namespace ScrumAssist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataHolder.ConnectToSqlDatabase();

        }

        private void OpenDataEditorBtn_Click(object sender, RoutedEventArgs e)
        {
            var editor = new DataEditorWindow();
            editor.Show();
        }
    }
}
