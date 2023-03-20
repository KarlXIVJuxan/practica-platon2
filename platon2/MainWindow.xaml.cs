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

using platon2.lab2DataSetTableAdapters;

namespace platon2
{
    public partial class MainWindow : Window
    {
        ColorTableAdapter color = new ColorTableAdapter();
        HumanTableAdapter human = new HumanTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

            ColourComboBox.ItemsSource = color.GetData();
            ColourComboBox.DisplayMemberPath = "Name_color";

            HumanComboBox.ItemsSource = human.GetData();
            HumanComboBox.DisplayMemberPath = "Name_Human";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            color.InsertQuery(NamecolorTbx.Text);
            ColourComboBox.ItemsSource = color.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            human.InsertQuery1(NameHumanTbx.Text);
            HumanComboBox.ItemsSource = human.GetData();
        }
    }
}
