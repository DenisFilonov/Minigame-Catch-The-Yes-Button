using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp4_pd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _x;
        private double _y;
        public MainWindow()
        {
            InitializeComponent();
            _x = (double)btnYes.GetValue(Canvas.LeftProperty);
            _y = (double)btnYes.GetValue(Canvas.TopProperty);
        }

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            double rand0 = new Random().Next(400 - 10);
            double rand1 = new Random().Next(400 - 10);
            double rand2 = new Random().Next(400 - 10);
            double rand3 = new Random().Next(400 - 10);
            Canvas.SetTop(btnYes, rand0);
            Canvas.SetBottom(btnYes, rand1);
            Canvas.SetLeft(btnYes, rand2);
            Canvas.SetRight(btnYes, rand3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не верю! А ну ещё раз подумай");
            Canvas.SetLeft(btnYes, _x);
            Canvas.SetTop(btnYes, _y);
        }

        private void btn_YesClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Красавчик, ты поймал эту кнопку, не зря шансом воспользовался моим ;)\n\tТеперь ты миллионер!");
            Canvas.SetLeft(btnYes, _x);
            Canvas.SetTop(btnYes, _y);
        }
    }
}
