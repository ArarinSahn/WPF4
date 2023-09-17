using System;
using System.Collections.Generic;
using System.Windows;

namespace Culcul
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtplayClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((DateTime)DateYou.SelectedDate < DateTime.Now)
                {
                    DateTime birthDate = (DateTime)DateYou.SelectedDate;
                    DateTime today = DateTime.Today;
                    AmtTimeAll(birthDate, today);
                    DayOffWeek(birthDate, today);
                    LeapAllYears(birthDate, today);
                }
                else
                {
                    MessageBox.Show("Это не так работает :(");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AmtTimeAll(DateTime birthDate, DateTime today)
        {
            if ((today.Month - birthDate.Month) > 0)
            {
                Mo.Text = ((today.Month - birthDate.Month) + 12).ToString();
                Le.Text = ((today.Year - birthDate.Year) - 1).ToString();
            }
            else
            {
                Mo.Text = (today.Month - birthDate.Month).ToString();
                Le.Text = (today.Year - birthDate.Year).ToString();
            }
            if (today.Day - birthDate.Day < 0)
            {
                if (today.Month == 1)
                {
                    Da.Text = (today.Day - birthDate.Day + DateTime.DaysInMonth(today.Year, 12)).ToString();
                }
                else
                {
                    Da.Text = (today.Day - birthDate.Day + DateTime.DaysInMonth(today.Year, today.Month - 1)).ToString();

                }

            }
            else
            {
                Le.Text = (today.Day - birthDate.Day).ToString();

            }

        }
        private void DayOffWeek(DateTime birthDate, DateTime today)
        {
            Dn.Text = birthDate.ToString("dddd");
            int DnNed = 0;
            for (int i = birthDate.Year; i <= today.Year; i++)
            {
                DateTime time = new DateTime(i, birthDate.Month, birthDate.Day);
                if (time.DayOfWeek == birthDate.DayOfWeek)
                {
                    DnNed++;
                }
                Ra.Text = DnNed.ToString();
            }
        }
        private void LeapAllYears(DateTime birthDate, DateTime today)
        {

            int VisYer = 0;
            List<int> list = new List<int>();
            for (int i = birthDate.Year; i <= today.Year; i++)
            {
                if (DateTime.IsLeapYear(i) == true)
                {
                    VisYer++;
                    list.Add(i);
                }
            }
            VisTex.Text = VisYer.ToString();
            Vis.ItemsSource = list;


        }

        private void ButtZadiakClicker(object sender, RoutedEventArgs e)
        {    
                if (VotEto.SelectedIndex != 0)
                {
                    switch (VotEto.SelectedIndex)
                    {
                        case 1:
                            {
                                Vividalendar.Text = EasternCalendar();
                            }
                            break;
                        case 2:
                            {
                                Vividalendar.Text = TheOldSlavicCalendar();
                            }
                            break;
                    }
                }
        }

        private string EasternCalendar()
        {
            string value = "В Восточном гороскопе вы будете ";
            DateTime date = DateYou.SelectedDate.Value;
            switch (date.Year % 12)
            {
                case 0:
                    {
                        value += "Обезьяной";
                    }
                    break;
                case 1:
                    {
                        value += "Петушок";
                    }
                    break;
                case 2:
                    {
                        value += "Собакой";
                    }
                    break;
                case 3:
                    {
                        value += "Кабан";
                    }
                    break;
                case 4:
                    {
                        value += "Крыса";
                    }
                    break;
                case 5:
                    {
                        value += "Бык";
                    }
                    break;
                case 6:
                    {
                        value += "Тигр";
                    }
                    break;
                case 7:
                    {
                        value += "Кот ";
                    }
                    break;
                case 8:
                    {
                        value += "Дракон ";
                    }
                    break;
                case 9:
                    {
                        value += "Змея";
                    }
                    break;
                case 10:
                    {
                        value += "Конь";
                    }
                    break;
                case 11:
                    {
                        value += "Овца ";
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Что-то определенно не так");
                        return "";
                    }
            }
            return value;

        }

        private string TheOldSlavicCalendar()
        {
            String value = "В древнеславянском гороскопе вы будете  ";
            DateTime date = DateYou.SelectedDate.Value;
            if (date >= new DateTime(date.Year, 12, 24) && date <= new DateTime(date.Year, 1, 30))
            {
                value += "Морозко ";
            }
            else if (date >= new DateTime(date.Year, 1, 31) && date <= new DateTime(date.Year, 2, 28))
            {
                value += "Велес ";
            }
            else if (date >= new DateTime(date.Year, 3, 1) && date <= new DateTime(date.Year, 3, 31))
            {
                value += "Макошь ";
            }
            else if (date >= new DateTime(date.Year, 4, 1) && date <= new DateTime(date.Year, 4, 30))
            { 
                value += "Жива ";
            }
            else if (date >= new DateTime(date.Year, 5, 1) && date <= new DateTime(date.Year, 5, 14))
            {
                value += "Ярила ";
            }
            else if (date >= new DateTime(date.Year, 5, 15) && date <= new DateTime(date.Year, 6, 2))
            {
                value += "Леля ";
            }
            else if (date >= new DateTime(date.Year, 6, 3) && date <= new DateTime(date.Year, 6, 12))
            {
                value += "Кострома ";

            }
            else if (date >= new DateTime(date.Year, 6, 13) && date <= new DateTime(date.Year, 7, 6) && date != new DateTime(date.Year, 6, 24))
            {
                value += "Додола ";
            }
            else if (date == new DateTime(date.Year, 6, 24))
            {
                value += "Иван Купала ";
            }
            else if (date >= new DateTime(date.Year, 7, 7) && date <= new DateTime(date.Year, 7, 31))
            {
                value += "Лада ";
            }
            else if (date >= new DateTime(date.Year, 8, 1) && date <= new DateTime(date.Year, 8, 28))
            {
                value += "Перун ";
            }
            else if (date >= new DateTime(date.Year, 8, 29) && date <= new DateTime(date.Year, 9, 13))
            {
                value += "Сева ";
            }
            else if (date >= new DateTime(date.Year, 9, 14) || date <= new DateTime(date.Year, 9, 27))
            {
                value += "Рожаница ";
            }
            else if (date >= new DateTime(date.Year, 9, 28) || date <= new DateTime(date.Year, 10, 15))
            {
                value += "Сварожичи ";
            }
            else if (date >= new DateTime(date.Year, 10, 16) || date <= new DateTime(date.Year, 11, 8))
            {
                value += "Морена ";
            }
            else if (date >= new DateTime(date.Year, 11, 9) || date <= new DateTime(date.Year, 11, 28))
            {
                value += "Зима ";
            }
            else if (date >= new DateTime(date.Year, 11, 29) || date <= new DateTime(date.Year, 12, 23))
            {
                value += "Карачун ";
            }
            return value;
        }
    }

}
