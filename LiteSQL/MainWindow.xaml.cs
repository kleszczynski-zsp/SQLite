using LiteSQL.Models.DB;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
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

namespace LiteSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using var context = new LiteSQLContext();
           

           //var x = context.Brands.Add(new Brand
           // {
           //     BrandName = "Audi",
           //     YearOfEstablishment = 2137
           // });

           // context.SaveChanges();
            
           // context.Add(new Model
           // {
           //     ModelName = "A8",
           //     YearOfStartProduction = "2137",
           //     BrandId = x.Entity.BrandId,
           // });

           // context.SaveChanges();
            foreach (var item in context.Models.Include(x => x.Brand).Where(x=>x.BrandId==1))
            {
                var x = item.Brand.BrandName + " " + item.ModelName;
                cbx.Items.Add(x);
            }

            //foreach (var brands in context.Brands.Include(x => x.Models))
            //{
            //    foreach (var model in brands.Models)
            //    {
            //        var x = brands.BrandName + " " + model.ModelName;
            //    }
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            
            var x =  cbx.SelectedItem + tbx.Text;

        }
    }
}
