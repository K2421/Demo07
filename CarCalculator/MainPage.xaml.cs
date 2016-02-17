using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void truckButton_Click(object sender, RoutedEventArgs e)
        {
            // haetaan käyttöliittymästä trucksTextBlockin sisältämä teksti
            string trucksString = truckTextBlock.Text;
            int trucks = int.Parse(trucksString); // 0
            trucks++; // trucks = trucks + 1;
            //näytetään uusi lukumäärä näytöllä
            truckTextBlock.Text = trucks.ToString(); // 1 --> "1"
        }

        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            // haetaan käyttöliittymästä trucksTextBlockin sisältämä teksti
            string carsString = carTextBlock.Text;
            int cars = int.Parse(carsString); // 0
            cars++; // trucks = trucks + 1;
            //näytetään uusi lukumäärä näytöllä
            carTextBlock.Text = cars.ToString(); // 1 --> "1"
        }
    }
}
