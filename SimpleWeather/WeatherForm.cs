//WinForms SimpleWeather, developed by Alexey Kuzub
using System;
using System.Net;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SimpleWeather
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void ShowWeatherInfo()
        {
            //Establishing a connection with the site via API
            string GetFromUser = InputTextBox.Text.Trim();
            string URL = "http://api.openweathermap.org/data/2.5/weather?q=" + GetFromUser + "&units=metric&appid=b8644caf0826b86815ab5f062919284a&lang=ru";
            string response;
            
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse httpWebResponse;

            try
            {
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch (Exception)
            {
                MessageBox.Show("Имя города введено некорректно '\n' или нет интернет-соединения!", "Предупреждение!");
                return;
            }

            using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
                response = reader.ReadToEnd();

            //Deserializating site's json response and output deserealized data to the user interface
            WeatherJsonReader Menu = JsonConvert.DeserializeObject<WeatherJsonReader>(response);

            CurrentCityLabel.Text = "Текущий город:   " + Menu.CityName;
            TemperatureLabel.Text = "Температура:   " + Math.Round(Menu.Main.temperature) + "°C";
            FellsTemperatureLabel.Text = "Ощущается:   " + Math.Round(Menu.Main.FellsTemperature) + "°C";
            MinTemperatureLabel.Text = "Минимально:   " + Math.Round(Menu.Main.MinTemperature) + "°C";
            MaxTemperatureLabel.Text = "Максимально:   " + Math.Round(Menu.Main.MaxTemperature) + "°C";
            PressureLabel.Text = "Давление:   " + Math.Round(Menu.Main.Pressure * 0.75) + "  мм рт ст";
            HumidityLabel.Text = "Влажность:   " + Menu.Main.Humidity + " %";
            WeatherConditionsLabel.Text = "Условия:   " + Menu.Conditions[0].WeatherConditions;
            CloudyLabel.Text = "Облачность:   " + Menu.Clouds.Cloudy + " %";
            SpeedWindLabel.Text = "Скорость ветра:   " + Math.Round(Menu.Wind.SpeedWind) + "  м/с";
            VisibilityLabel.Text = "Видимость:   " + Menu.Visibility + "  м";

            //Output to the user interface of weather conditions in the photos form
            try
            {
                if (Menu.Conditions[0].IconConditions == "01d")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\ClearSun.png");
                else if (Menu.Conditions[0].IconConditions == "01n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\ClearMoon.png");
                else if (Menu.Conditions[0].IconConditions == "02d" || Menu.Conditions[0].IconConditions == "03d")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\PartlyCloudySun.png");
                else if (Menu.Conditions[0].IconConditions == "02n" || Menu.Conditions[0].IconConditions == "03n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\PartlyCloudyMoon.png");
                else if (Menu.Conditions[0].IconConditions == "04d" || Menu.Conditions[0].IconConditions == "04n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\MainlyCloudy.png");
                else if (Menu.Conditions[0].IconConditions == "09d" || Menu.Conditions[0].IconConditions == "09n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\ShowerRain.png");
                else if (Menu.Conditions[0].IconConditions == "10d")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\RainSun.png");
                else if (Menu.Conditions[0].IconConditions == "10n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\RainMoon.png");
                else if (Menu.Conditions[0].IconConditions == "10d")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\RainSun.png");
                else if (Menu.Conditions[0].IconConditions == "11d")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\ThunderstormSun.png");
                else if (Menu.Conditions[0].IconConditions == "11n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\ThunderstormMoon.png");
                else if (Menu.Conditions[0].IconConditions == "13d")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\SnowSun.png");
                else if (Menu.Conditions[0].IconConditions == "13n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\SnowMoon.png");
                else if (Menu.Conditions[0].IconConditions == "50d" || Menu.Conditions[0].IconConditions == "50n")
                    WeatherShowPictureBox.Image = new Bitmap(@"resources\Mist.png");
                else
                    WeatherShowPictureBox.Image = null;
            }
            catch (Exception)
            {
                WeatherShowPictureBox.Image = null;
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ShowWeatherInfo();
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                ShowWeatherInfo();
        }
    }
}
