using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btLauncher_Click(object sender, RoutedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(@"C:\Users\kss3htv\Desktop\AFP_LEV_2020_CSAP5\2D_Game_Project_T5\Assets\Sunnyland\Scenes\demo.unity");
            MessageBox.Show("játék elinditva");
        }

        private void btLink_Click(object sender, RoutedEventArgs e)
        {
            //megnyitja a böngészőt erre az oldalra mutatva
            System.Diagnostics.Process.Start("https://github.com/bencespinter/AFP_LEV_2020_CSAP5");
            MessageBox.Show("Ez a játék oldala");
        }

        private void btQuit_Click(object sender, RoutedEventArgs e)
        {
            // bezárja a programot 
            MessageBox.Show("Várunk vissza");
            Thread.Sleep(400);
            System.Windows.Application.Current.Shutdown();
            
        }
    }
}
