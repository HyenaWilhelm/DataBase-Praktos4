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
using Изменение.fovorite_colorDataSetTableAdapters;


namespace Изменение
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        colorsTableAdapter adapter = new colorsTableAdapter();
        public FirstPage()
        {
            InitializeComponent();
        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            object id = (MyDataGrid.SelectedItem as DataRowView).Row[0];
            adapter.UpdateQuery(MyTbx.Text, Convert.ToInt32(id));
        }
    }
}
