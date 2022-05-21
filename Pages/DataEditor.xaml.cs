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
using ScrumAssist.Static;

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
            //Binding allTeamsBinding = new Binding("allTeams");

            //allTeamsBinding.Mode = BindingMode.OneWay;
            //allTeamsBinding.Source = DataHolder.AllTeams;

            AllTeamsListBox.ItemsSource = DataHolder.AllTeams;
            AddTeamComboBox.ItemsSource = DataHolder.AllTeams;

            DeveloperNameTextbox.DataContext = currentDeveloper;

        }

        private void SaveTeamBtn_Click(object sender, RoutedEventArgs e)
        {
            DataHolder.addTeam(currentTeam);
            currentTeam = new Team();
            setValues();

        }

        private void AddTeamBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AddTeamComboBox.SelectedItem != null)
            {
                currentDeveloper.TeamsOn.Add((Team)AddTeamComboBox.SelectedItem);
                DeveloperTeamList.ItemsSource = currentDeveloper.TeamsOn;
            }

        }

        private void SaveDevBtn_Click(object sender, RoutedEventArgs e)
        {
            //Save the dev
            DataHolder.addDeveloper(currentDeveloper);
            currentDeveloper = new Developer();
            setValues();
        }
    }
}
