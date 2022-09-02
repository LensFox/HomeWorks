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
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Win32;
using System.Xml;
using System.IO;
using System.Xml.XPath;

namespace _5_Colour
{
    /*
     Задание 4
     Создайте приложение WPF Application, в главном окне которого поместите любой текст. Также,
должно быть окно настроек (можно реализовать с помощью TabControl). Пользователь может
изменять настройки. При повторном запуске приложения настройки должны оставаться
прежними. Реализуйте два варианта (в одном приложении или двух разных): 1) сохранение
настроек в конфигурационном файле; 2) сохранение настроек в реестре.
    В окне настроек реализуйте следующие опции: цвет фона, цвет текста, размер шрифта, стиль
шрифта, а также кнопку «Сохранить». Для выбора цвета воспользуйтесь ColorPicker-ом по
примеру задания из Урока №3.
     */
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool BackgroundOn { get; set; }
        bool ForegroundOn { get; set; }
        bool FontStyle1 { get; set; }
        private const string _settingsFilePath = @"F:\Tests\ColourUserSettings.xml";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackgroundColourButton_Click(object sender, RoutedEventArgs e)
        {
            if (BackgroundOn == false)
            {
                BackgroundOn = true;
                ForegroundOn = false;
                BackgroundColourButton.Background = Brushes.Red;
                TextColourButton.ClearValue(Control.BackgroundProperty);
            }
            else
                BackgroundOn = false;
        }

        private void ColourPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            {
                if (BackgroundOn == true)
                {
                    var color = ColourPicker.SelectedColor;
                    if (color.HasValue)
                        Text.Background = new SolidColorBrush(color.Value);
                    else
                        Text.ClearValue(Control.BackgroundProperty);
                }
                if (ForegroundOn == true)
                {
                    var color = ColourPicker.SelectedColor;
                    if (color.HasValue)
                        Text.Foreground = new SolidColorBrush(color.Value);
                    else
                        Text.ClearValue(Control.BackgroundProperty);
                }
            }
        }
        private void TextColourButton_Click(object sender, RoutedEventArgs e)
        {
            if (ForegroundOn == false)
            {
                BackgroundOn = false;
                ForegroundOn = true;
                TextColourButton.Background = Brushes.Red;
                BackgroundColourButton.ClearValue(Control.BackgroundProperty);
            }
            else
                ForegroundOn = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            var document = new XmlDocument();
            document.Load(_settingsFilePath);
            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator iterator = navigator.Select("userLoadSettings/add");

            while (iterator.MoveNext())
            {
                XPathNavigator iterator2 = iterator.Current.Clone();
                iterator2.MoveToFirstAttribute();

                if (iterator2.Name == "backgroundColour")
                {
                    var xmlWriter = new XmlTextWriter(_settingsFilePath, null);
                    xmlWriter.Formatting = Formatting.Indented;
                    var a = Text.Background.ToString();
                    iterator2.SetValue(a);
                    //xmlWriter.WriteAttributeString("backgroundColour", a);
                }
                if (iterator2.Name == "foregroundColour")
                {
                    iterator2.SetValue(Text.Foreground.ToString());
                }
            }
            #region
            /*
            RegistryKey myKey = Registry.LocalMachine;
            RegistryKey softwareKey = myKey.OpenSubKey("Software", true);
            RegistryKey colourPickerAppKey = softwareKey.CreateSubKey("ColourPickerApp", true);

            colourPickerAppKey.SetValue("backgroundColour", Text.Foreground);
            colourPickerAppKey.SetValue("foregroundColour", Text.Background);
            colourPickerAppKey.Close();
            softwareKey.Close();
            */
            #endregion
        }


        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            #region
            /*
            RegistryKey myKey = Registry.LocalMachine;
            RegistryKey softwareKey = myKey.OpenSubKey("Software");
            if (softwareKey.GetSubKeyNames().Contains("ColourPickerApp"))
            {
                BrushConverter converter = new BrushConverter();
                RegistryKey colourPickerAppKey = softwareKey.OpenSubKey("ColourPickerApp");
                if (colourPickerAppKey != null)
                {
                    Text.Background = converter.ConvertFrom(colourPickerAppKey.GetValue("backgroundColour")) as Brush;
                    Text.Foreground = converter.ConvertFrom(colourPickerAppKey.GetValue("foregroundColour")) as Brush;
                    colourPickerAppKey.Close();
                }
            }
            softwareKey.Close();
            */
            #endregion

            if (!File.Exists(_settingsFilePath))
            {
                var xmlWriter = new XmlTextWriter(_settingsFilePath, null);
                xmlWriter.Formatting = Formatting.Indented;

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("userLoadSettings");
                xmlWriter.WriteStartElement("add");
                xmlWriter.WriteStartAttribute("backgroundColour");
                xmlWriter.WriteString(null);
                xmlWriter.WriteEndAttribute();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("add");
                xmlWriter.WriteStartAttribute("foregroundColour");
                xmlWriter.WriteString(null);
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            else
            {
                var document = new XPathDocument(_settingsFilePath);
                XPathNavigator navigator = document.CreateNavigator();
                XPathNodeIterator iterator = navigator.Select("userLoadSettings/add");

                BrushConverter converter = new BrushConverter();
                while (iterator.MoveNext())
                {
                    XPathNavigator iterator2 = iterator.Current.Clone();
                    iterator2.MoveToFirstAttribute();

                    if (iterator2.Name == @"backgroundColour" && iterator2.Value != "")
                    {
                        Text.Background = converter.ConvertFromString(iterator2.Value) as Brush;
                    }
                    if (iterator2.Name == @"foregroundColour" && iterator2.Value != "")
                    {
                        Text.Foreground = converter.ConvertFromString(iterator2.Value) as Brush; ;
                    }
                }
            }

        }
    }
}
