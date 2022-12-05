using System;
using System.Collections.Generic;
using System.Data;
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
using Пример_таблицы_WPF;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Luggage luggage;

        public int k;

        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                dataGrid.Items.Add(new Luggage { Quantity = Convert.ToInt32(QuantityTextBox.Text), Weight = Convert.ToInt32(WeightTextBox.Text)});
            }
            catch
            {

            }
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            
         
            if (dataGrid.Items.Count != 0)
            {
                double avg;
                int luggageCount = 0; double totalAverage;
                double totalWeight = 0;
                for (int i = 0; i < dataGrid.Items.Count; i++)
                {
                    totalWeight += ((Luggage)dataGrid.Items[i]).Weight;
                    luggageCount += ((Luggage)dataGrid.Items[i]).Quantity;
                }

                totalAverage = totalWeight / luggageCount;

                for (int j = 0; j < dataGrid.Items.Count; j++)
                {

                    avg = ((Luggage)dataGrid.Items[j]).Weight / ((Luggage)dataGrid.Items[j]).Quantity;


                    if (avg <= totalAverage + 0.3 && avg >= totalAverage)
                    {
                        MessageBox.Show($"Индекс багажа  {j}");
                        break;
                    }

                    if (avg >= totalAverage - 0.3 && avg <= totalAverage)
                    {
                        MessageBox.Show($"Индекс багажа  {j}");
                        break;
                    }

                    if(avg < totalAverage - 0.3 || avg > totalAverage + 0.3)
                    {
                        MessageBox.Show("Нужных грузов нет");
                        break;
                    }

                }
            }
           
            else
            {
                MessageBox.Show("Заполните информацию о багаже");
            }

        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Багаж пассажира характеризуется количеством вещей и общим весом вещей.\n Сведения о багаже каждого пассажира представляют собой структуру с двумя полями: одно поле целого типа (количество вещей) и одно - действительное (вес в килограммах).\n Вывести результат на экран.\n Найти багаж, средний вес одной вещи в котором отличается не более, чем на 0.3 кг от общего среднего веса одной вещи.\n Работу выполнил Халимов Виктор.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
