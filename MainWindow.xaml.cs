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

namespace _312576driving
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int yearBorn;
        int age;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnAge_Click(object sender, RoutedEventArgs e)
            
        {
            int.TryParse(ageInput.Text, out yearBorn);

            if (yearBorn <= 15)
            {
                lblOutput.Content = "You can not do anything.";
            }
            if (yearBorn == 16 || yearBorn == 17)
            {
                lblOutput.Content = "You can drive but not drink or vote.";
            }
            if (yearBorn == 18)
            {
                lblOutput.Content = "You can drive and vote.";
            }
            if (yearBorn >= 19)
            {
                lblOutput.Content = "You can drive, drink and vote not at the same time.";
            }
           
           
        }
    }
}
