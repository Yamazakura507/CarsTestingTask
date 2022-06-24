using System;
using System.Windows;
using Task1.Model;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car Car { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Car = new Car(1, Double.Parse(LitersFuelTextBox.Text),
                    Double.Parse(KilometrsFuelTextBox.Text), Double.Parse(FuelCountTextBox.Text),
                    Double.Parse(FuelTankVolumeTextBox.Text), Double.Parse(SpeedKilometersTextBox.Text),
                    Double.Parse(SpeedTimeTextBox.Text));

                if (SuperCarCheckBox.IsChecked ?? false)
                {
                    Car = Car.ToSuperCar();
                }
                else if (SmallCarCheckBox.IsChecked ?? false)
                {
                    Car = Car.ToSmallCar(Int32.Parse(MaxCargoTextBox.Text), Int32.Parse(CargoTextBox.Text));
                }
                else
                {
                    Car = Car.ToBigCar(Double.Parse(MaxCargoTextBox.Text), Double.Parse(CargoTextBox.Text));
                }

                ResultLabel.Clear();
                ResultLabel.Text += $"Осталось ехать:\nВремени: {Car.TripDurationToTime().TotalHours} ч.\nРастояние: {Car.TripDurationToDistance()} км.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SuperCarCheckBoxOnChecked(object sender, RoutedEventArgs e)
        {
            try
            {
                CargoPanel.Visibility = CargoText.Visibility = MaxCargoText.Visibility = MaxCargoPanel.Visibility = Visibility.Collapsed;
            }
            catch (Exception){}
        }

        private void SmallCarCheckBoxOnChecked(object sender, RoutedEventArgs e)
        {
            try
            {
                CargoPanel.Visibility = CargoText.Visibility = MaxCargoText.Visibility = MaxCargoPanel.Visibility = Visibility.Visible;
                CargoLabel.Content = MaxCargoLabel.Content = "количество пасажиров";
            }
            catch (Exception){}
        }

        private void BigCarCheckBoxOnChecked(object sender, RoutedEventArgs e)
        {
            try
            {
                CargoPanel.Visibility = CargoText.Visibility = MaxCargoText.Visibility = MaxCargoPanel.Visibility = Visibility.Visible;
                CargoLabel.Content = MaxCargoLabel.Content = "кг";
            }
            catch (Exception) { }
        }
    }
}
