using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pract61_Kovyazin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : CarouselPage
    {
        public Buttons(string Login, string Pass)
        {
            InitializeComponent();
            login.Text = $"Ваш логин: {Login}";
            password.Text = $"Ваш пароль: {Pass}";
            
        }

        private void sw1_Toggled(object sender, ToggledEventArgs e)
        {
           if(sw1.IsToggled != true)
            {
                labelswitch1.Text = "OFF";
                sw3.IsToggled = true;
                
            }
           else
            {
                labelswitch1.Text = "ON";
                sw3.IsToggled = false;
            }
        }

        private void sw2_Toggled(object sender, ToggledEventArgs e)
        {
            if(sw2.IsToggled != true)
            {
                labelswitch2.Text = "☓";
                sw4.IsToggled = true;
            }
            else
            {
                labelswitch2.Text = "✓";
                sw4.IsToggled= false;
            }
        }

        private void sw3_Toggled(object sender, ToggledEventArgs e)
        {
            if (sw3.IsToggled != true)
            {
                labelswitch3.Text = "OFF";
                sw1.IsToggled = true;

            }
            else
            {
                labelswitch3.Text = "ON";
                sw1.IsToggled = false;
            }
        }

        private void sw4_Toggled(object sender, ToggledEventArgs e)
        {
            if (sw4.IsToggled != true)
            {
                labelswitch4.Text = "☓";
                sw2.IsToggled = true;
            }
            else
            {
                labelswitch4.Text = "✓";
                sw2.IsToggled = false;
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             if (picker.SelectedItem.ToString() == "Select One")
            {
                sl1.IsEnabled = true;
                sl2.IsEnabled = false;
                sl3.IsEnabled = false;
                sl4.IsEnabled = false;
                pickedrop.Text = " Ваш выбор Picker`a Select One";
            }
            else if (picker.SelectedItem.ToString() == "Select Two")
            {
                sl2.IsEnabled = true;
                sl1.IsEnabled = false;
                sl3.IsEnabled = false;
                sl4.IsEnabled = false;
                pickedrop.Text = " Ваш выбор Picker`a Select Two";
            }
            else if (picker.SelectedItem.ToString() == "Select Three")
            {
                sl3.IsEnabled = true;
                sl2.IsEnabled = false;
                sl1.IsEnabled = false;
                sl4.IsEnabled = false;
                pickedrop.Text = " Ваш выборе Picker`a Select Three";
            }
            else if (picker.SelectedItem.ToString() == "Select Four")
            {
                sl4.IsEnabled = true;
                sl2.IsEnabled = false;
                sl3.IsEnabled = false;
                sl1.IsEnabled = false;
                pickedrop.Text = " Ваш выборе Picker`a Select Four";
            }
        }

        private void rad1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(rad1.IsEnabled == true)
            {
                sl1.IsEnabled = true;
                sl2.IsEnabled = false;
                sl3.IsEnabled = false;
                sl4.IsEnabled = false;
            }
           
        }

        private void rad2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rad2.IsEnabled == true)
            {
                sl2.IsEnabled = true;
                sl1.IsEnabled = false;
                sl3.IsEnabled = false;
                sl4.IsEnabled = false;
            }
            else
            {

            }
        }

        private void check1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (check1.IsEnabled == true)
            {
                sl3.IsEnabled = true;
                sl2.IsEnabled = false;
                sl1.IsEnabled = false;
                sl4.IsEnabled = false;
            }
        }

        private void check2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (check2.IsEnabled == true)
            {
                sl4.IsEnabled = true;
                sl2.IsEnabled = false;
                sl3.IsEnabled = false;
                sl1.IsEnabled = false;
            }
        }
    }
}