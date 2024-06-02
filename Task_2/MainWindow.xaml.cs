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

namespace Light
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Flashlight flashlight = new Flashlight(false, 0.05, false);
        private TableLamp tableLamp = new TableLamp(false, 0.05, false, false);
        private FloorLamp floorLamp = new FloorLamp(false, 0.08, false, false);
        private Chandelier chandelier = new Chandelier(false, 0.1, false, 0);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTurnOnTableLamp_Click(object sender, RoutedEventArgs e)
        {
            tableLamp.TurnOn();
            if (tableLamp.IsOn)
                rctTableLamp.Fill = Brushes.Yellow;
            else
                rctTableLamp.Fill = Brushes.LightGray;
            if (tableLamp.IsBroken)
                tbBroken1.Visibility = Visibility.Visible;
        }

        private void btnTurnOnFloorLamp_Click(object sender, RoutedEventArgs e)
        {
            floorLamp.TurnOn();
            if (floorLamp.IsOn)
                rctFloorLamp.Fill = Brushes.Yellow;
            else
                rctFloorLamp.Fill = Brushes.LightGray;
            if (floorLamp.IsBroken)
                tbBroken2.Visibility = Visibility.Visible;
        }

        private void btnTurnOnChandelier_Click(object sender, RoutedEventArgs e)
        {
            chandelier.TurnOn();
            switch(chandelier.CurrentMode)
            {
                case 0:
                    rctChandelier1.Fill = Brushes.LightGray;
                    rctChandelier2.Fill = Brushes.LightGray;
                    break;
                case 1:
                    rctChandelier1.Fill = Brushes.Yellow;
                    rctChandelier2.Fill = Brushes.LightGray;
                    break;
                case 2:
                    rctChandelier1.Fill = Brushes.LightGray;
                    rctChandelier2.Fill = Brushes.Yellow;
                    break;
                case 3:
                    rctChandelier1.Fill = Brushes.Yellow;
                    rctChandelier2.Fill = Brushes.Yellow;
                    break;
            }
            if (chandelier.IsBroken)
                tbBroken3.Visibility = Visibility.Visible;
        }

        private void btnTurnOffFlashlight_Click(object sender, RoutedEventArgs e)
        {
            flashlight.TurnOff();
            if (!flashlight.IsOn)
                rctFlashlight.Fill = Brushes.LightGray;
        }

        private void btnTurnOffTableLamp_Click(object sender, RoutedEventArgs e)
        {
            tableLamp.TurnOff();
            if (!tableLamp.IsOn)
                rctTableLamp.Fill = Brushes.LightGray;
        }

        private void btnTurnOffFloorLamp_Click(object sender, RoutedEventArgs e)
        {
            floorLamp.TurnOff();
            if (!floorLamp.IsOn)
                rctFloorLamp.Fill = Brushes.LightGray;
        }

        private void btnTurnOffChandelier_Click(object sender, RoutedEventArgs e)
        {
            chandelier.TurnOff();
            switch (chandelier.CurrentMode)
            {
                case 0:
                    rctChandelier1.Fill = Brushes.LightGray;
                    rctChandelier2.Fill = Brushes.LightGray;
                    break;
                case 1:
                    rctChandelier1.Fill = Brushes.Yellow;
                    rctChandelier2.Fill = Brushes.LightGray;
                    break;
                case 2:
                    rctChandelier1.Fill = Brushes.LightGray;
                    rctChandelier2.Fill = Brushes.Yellow;
                    break;
                case 3:
                    rctChandelier1.Fill = Brushes.Yellow;
                    rctChandelier2.Fill = Brushes.Yellow;
                    break;
            }
        }

        private void btnPlugInFloorLamp_Click(object sender, RoutedEventArgs e)
        {
            floorLamp.ConnectToNetwork();
        }

        private void btnPlugInTableLamp_Click(object sender, RoutedEventArgs e)
        {
            tableLamp.ConnectToNetwork();
        }

        private void btnUnplugFloorLamp_Click(object sender, RoutedEventArgs e)
        {
            floorLamp.DisconnectFromNetwork();
            rctFloorLamp.Fill = Brushes.LightGray;
        }

        private void btnUnplugTableLamp_Click(object sender, RoutedEventArgs e)
        {
            tableLamp.DisconnectFromNetwork();
            rctTableLamp.Fill = Brushes.LightGray;
        }

        private void btnTurnOnFlashlight_Click(object sender, RoutedEventArgs e)
        {
            flashlight.TurnOn();
            if (flashlight.IsOn)
                rctFlashlight.Fill = Brushes.Yellow;
            else
                rctFlashlight.Fill = Brushes.LightGray;
            if (flashlight.IsBroken)
                tbBroken0.Visibility = Visibility.Visible;
        }

    }
}
