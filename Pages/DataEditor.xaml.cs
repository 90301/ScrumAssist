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
using System.Windows.Shapes;
using ScrumAssist.Data;

namespace ScrumAssist.Pages
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DataEditorWindow : Window
    {

        public Team currentTeam = new Team();
        public Developer currentDeveloper = new Developer();
        public DataEditorWindow()
        {
            InitializeComponent();
            setValues();
        }

        public void setValues()
        {
            
            currentTeam.Name = "A test";

            TeamEditorGrid.DataContext = currentTeam;
            DeveloperNameTextbox.DataContext = currentDeveloper;

        }

        private void SaveTeamBtn_Click(object sender, RoutedEventArgs e)
        {
            currentTeam.Name = "Test Set";
        }
    }
}
