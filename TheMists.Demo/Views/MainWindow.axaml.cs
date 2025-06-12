using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

using TheMists.Sdk.MistsGate;
using TheMists.Sdk.Models.Commerce;

namespace TheMists.Demo.Views
{
    public partial class MainWindow : Window
    {
        private MistsGate _client;

        public MainWindow()
        {
            InitializeComponent();

            _client = new MistsGate();
        }

        private async void OnConvertClick(object sender, RoutedEventArgs args)
        {
            if (GemsTextBox.Text != null)
            {
                if (int.TryParse(GemsTextBox.Text, out int gems))
                {
                    ExchangeRate rate = await _client.Commerce.GetGemsToCoinsRate(gems);

                    Coins c = new Coins(rate.Quantity);

                    ResultTextBlock.Text = c.ToString();
                }
            }
        }
    }
}