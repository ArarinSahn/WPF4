# Практическая работа номер №4. Основы WPF

## Оглавление

0. [Описание приложения](#Описание-приложения)
 1. [Истинное предназначе́ние:sparkles:](#Истинное-предназначе́ние)
 2. [Что ты можешь в ней делать какой код у этого приложения?:flushed:](#Что-ты-можешь-в-ней-делать?)
1. [Технологии в процессе использования](#Истинное-предназначе́ние)
2. [Возможно оно не идеально, но и ты не котик](#Возможно-оно-не-идеально,-но-и-ты-не-котик)
3. [Инструкция для самых маленьких пользователей:relieved:](#Инструкция-для-самых-маленьких-пользователей)

## Описание приложения

Приложение ***CulculYou*** представляет собой собственную разработку по Предмету _МДК 01.01 Разработка программных модулей_

### Истинное предназначе́ние:sparkles:
**Функционал, который даст понять что это за приложение:**
- [X] Первое, что видит пользователь на экране, это поле для ввода (или выбора) даты, где ему предлагается ввести дату своего рождения. Далее программно необходимо рассчитать сколько пользователю лет, месяцев и дней прошло с даты рождения и вывести результат на экран.
- [X] Также необходимо вывести на экран день недели, в который был рожден пользователь и количество дней рождения, которые он отпраздновал в этот же день недели за всю свою жизнь (до сегодняшнего дня)
- [X] Затем необходимо определить количество високосных лет, прошедших со дня рождения и до сегодняшнего дня; вывести все номера найденных високосных годов
- [X] Далее пользователю нужно предоставить выбор из двух позиций, хочет ли он узнать, кто он по восточному или древнеславянскому календарю. При выборе одного из этих вариантов на экране появляется поле с ответом. При выборе другого варианта поле с предыдущим ответом должно быть скрыто.
### Что ты можешь в ней делать и какой код у этого приложения?:flushed:
Для начала начнем с того, что при открытии приложения, вам высвечивается 1 страничка с полным набором разных функций:

![image](https://github.com/ArarinSahn/WPF4/assets/145285306/6cfec053-c3ec-4db4-ad8a-0d8521ed1af2)

При заполнении даты ты можешь нажать на кнопочки ![image](https://github.com/ArarinSahn/WPF4/assets/145285306/f25d8126-dcd3-4b58-a050-4c9a47a077e1)
 и ![image](https://github.com/ArarinSahn/WPF4/assets/145285306/30a7a504-e440-4613-9b8f-fa7f13b485bb)

После того как ты нажмешь _"Вычислить дату"_ то ты увидишь что все что можно у тебя посчиталось _(Можешь почитать если интересно или найти нужную информацию)_

![image](https://github.com/ArarinSahn/WPF4/assets/145285306/577164ed-d578-4a65-aed2-708b2dfe6c35)

И такая же история с _"Узнать кто я"_

![image](https://github.com/ArarinSahn/WPF4/assets/145285306/2b2fc042-9121-41d3-8ea4-f42f7cf97e34)
![image](https://github.com/ArarinSahn/WPF4/assets/145285306/4fbf22e8-9e20-4b9f-9821-91483d875613)

Что касается кода, для начала представлен код на стороне `XAML`

```XAML
<StackPanel>
            <StackPanel Margin="0 10" Width="300">
                <TextBlock Text="Введите свою дату рождения" HorizontalAlignment="Left" Style="{StaticResource TBstyle}"></TextBlock>
                <DatePicker Name="DateYou"></DatePicker>
            </StackPanel>

            <StackPanel Orientation="Horizontal">
                <TextBlock Text="С твоего дня рожения прошло" Style="{StaticResource TBstyle}"/>
                <TextBlock Name="Le" Style="{StaticResource TBstyle}"/>
                <TextBlock Style="{StaticResource TBstyle}">лет,</TextBlock>
                <TextBlock Name="Mo" Style="{StaticResource TBstyle}"/>
                <TextBlock Style="{StaticResource TBstyle}">месяцев и</TextBlock>
                <TextBlock Name="Da" Style="{StaticResource TBstyle}"/>
                <TextBlock Style="{StaticResource TBstyle}">дней.</TextBlock>
            </StackPanel>

            <StackPanel Orientation="Horizontal">
                <TextBlock Text="День рождения, в который ты родился" Style="{StaticResource TBstyle}"/>
                <TextBlock Name="Dn" Style="{StaticResource TBstyle}"/>
                <TextBlock Text=", так же в этот день недели ты отмечал день рождение" Style="{StaticResource TBstyle}"/>
                <TextBlock Name="Ra" Style="{StaticResource TBstyle}"></TextBlock>
                <TextBlock Text="раз." Style="{StaticResource TBstyle}"/>
            </StackPanel>

            <StackPanel Orientation="Horizontal">
                <TextBlock Text="Количество високосных  лет, прошедших со дня рождения" Style="{StaticResource TBstyle}"/>
                <TextBlock Name="VisTex" Style="{StaticResource TBstyle}"></TextBlock>
            </StackPanel>

            <StackPanel Width="300" HorizontalAlignment="Left">
                <TextBlock Text="Високосные года"  Style="{StaticResource TBstyle}"/>
                <ListBox Name="Vis" Margin="10 0" Width="Auto"></ListBox>
            </StackPanel>

            <StackPanel Width="Auto"  Orientation="Vertical">
                <TextBlock Text="Выберете календарь по которому хотите узнать кто вы по гороскопу" Style="{StaticResource TBstyle}"/>
                <ComboBox Width="247" Name="VotEto">
                    <ComboBoxItem Name="CMBSel"  IsSelected="True" IsEnabled="False">Выбор способов</ComboBoxItem>
                    <ComboBoxItem>Восточный календарь</ComboBoxItem>
                    <ComboBoxItem>Древнеславянский календарь</ComboBoxItem>
                </ComboBox>

            </StackPanel>
            <TextBlock Name="Vividalendar" Style="{DynamicResource TBstyle}" Margin="0 10"/>
        </StackPanel>
        <Button x:Name="ButtZadiak" Style="{StaticResource SaB}" Content="Узнать кто я" Click="ButtZadiakClicker" HorizontalAlignment="Left" VerticalAlignment="Bottom" Margin="10,0,0,10"></Button>
        <Button x:Name="Buttplay" Style="{StaticResource SaB}"  Content="Вычислить дату" Click="ButtplayClick"  HorizontalAlignment="Right" VerticalAlignment="Bottom" Margin="0 0 10 10"></Button>
```
Пример функция `C#` которые прощитывают, месяца, дни, года, и весокосные дни!
```C# 
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
```
Функция `C#` которая вычисляет кто вы по *Восточному* календарю!
```C# 
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
```
Функция `C#` которая вычисляет кто вы по *Древнесловянскому* календарю!
```C#
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
   ```
## Технологии в процессе использования
Во время работы над приложением я использовала такие средства разработки как:
- WPF (помогло написать интерфейс данного калькулятора ). 
  -  С# ( для написании логики приложения ).
- Сторонние источники. Типа видео и множества умных сайтов.
## Возможно оно не идеально, но и ты не котик
```
Практически все работы которые я делаю поддаются гонению самых сильных умников нашей группы, так что я просто скажу, что могла лучше, но времени что бы это превратить в конфетку нужно было больше.
```
___Держите котика:___

![image](https://github.com/ArarinSahn/WPF4/assets/145285306/ca6d8a45-dec2-462b-82c3-e0cd848c28ba)

## Инструкция для самых маленьких пользователей:relieved:
1. Открываешь приложение
2. Вводишь в поле свою дату рождения
3. Если будет введено что-то нет так, приложение тебе подскажет, если же все правильно то нажимаешь на _"Вычислить дату"_
4. Если хочешь узнать кто ты по календарям, то нажимаешь на плашечку, выбераешь нужный и тогда кнопочка _"Узнать кто я"_ в твоем распоряжении
5. Радуешься, что ты по календарю Дракончик :dragon:
Поставьте оцеку тут  :point_right: https://moodle.ngknn.ru/mod/assign/view.php?id=38820





















____
[:point_up_2::К оглавлению](#Оглавление)
____
