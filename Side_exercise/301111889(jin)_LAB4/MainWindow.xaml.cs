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

namespace _301111889_jin__LAB4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BothContext context = new BothContext();
        public MainWindow()
        {
            InitializeComponent();

            // Binding DB to gridview
            reloadGridview_fruit();
            reloadGridview_planet();
            reloadGridview_both();
        }

        // Button click events
        private void clear_click(object sender, RoutedEventArgs e)
        {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE FRUITS");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE PLANETS");
            reloadGridview_fruit();
            reloadGridview_planet();
            reloadGridview_both();

            fruit_combo.SelectedIndex = 0;
            planet_combo.SelectedIndex = 0;
        }
        private void delete_click(object sender, RoutedEventArgs e)
        {
            var selected_fruit = fruit_data.SelectedIndex;
            var selected_planet = planet_data.SelectedIndex;

            if (selected_fruit != -1) 
            {
                DataGridRow row = (DataGridRow)fruit_data.ItemContainerGenerator.ContainerFromIndex(selected_fruit);
                TextBlock cellContent = fruit_data.Columns[0].GetCellContent(row) as TextBlock;
                string result = cellContent.Text;
                context.Database.ExecuteSqlCommand("DELETE FROM FRUITS WHERE FRUITID = "+result);
                reloadGridview_fruit();
            }

            if (selected_planet != -1)
            {
                DataGridRow row = (DataGridRow)planet_data.ItemContainerGenerator.ContainerFromIndex(selected_planet);
                TextBlock cellContent = planet_data.Columns[0].GetCellContent(row) as TextBlock;
                string result = cellContent.Text;
                context.Database.ExecuteSqlCommand("DELETE FROM PLANETS WHERE PLANETID = " + result);
                reloadGridview_planet();
            }
        }
        private void project_click(object sender, RoutedEventArgs e)
        {
            var fruits = from p in context.Fruits
                         select new
                         {
                             FruitName = p.Name
                         };
            this.both_data.ItemsSource = fruits.ToList();
        }
        private void filter_click(object sender, RoutedEventArgs e)
        {
            var filter = fruit_combo.SelectedItem.ToString().Split(' ')[2];
            var fruits = from p in context.Fruits
                         where p.Color == filter
                         select new
                         {
                             FruitName = p.Name
                         };
            this.both_data.ItemsSource = fruits.ToList();
        }
        private void join_click(object sender, RoutedEventArgs e)
        {
            var fruits = from p in context.Fruits
                         join q in context.Planets
                         on p.Color equals q.Color2
                         select new
                         {
                             FruitName = p.Name,
                             PlanetNmae = q.Name2
                         };
            this.both_data.ItemsSource = fruits.ToList();
        }
        private void ascending_click(object sender, RoutedEventArgs e)
        {
            var fruits = from p in context.Fruits
                         orderby p.Name ascending
                         select new
                         {
                             FruitName = p.Name
                         };
            this.both_data.ItemsSource = fruits.ToList();
        }

        // Renew gridviews
        private void reloadGridview_fruit()
        {
            var fruits = from p in context.Fruits
                         select new
                         {
                             FruitId = p.FruitId,
                             Name = p.Name,
                             Color = p.Color
                         };
            this.fruit_data.ItemsSource = fruits.ToList();
        }
        private void reloadGridview_planet()
        {
            var planets = from p in context.Planets
                         select new
                         {
                             PlanetId = p.PlanetId,
                             Name2 = p.Name2,
                             Color2 = p.Color2
                         };
            this.planet_data.ItemsSource = planets.ToList();
        }
        private void reloadGridview_both()
        {
            this.both_data.ItemsSource = null;
        }

        // Combox Fruit events
        private void Fruit_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsInitialized) return;

            ComboBoxItem item = e.OriginalSource as ComboBoxItem;

            if (item != null)
            {
                string s = (string)item.Content;
                string[] result = s.Split(' ');

                using (var both = new BothContext())
                {
                    var fruit = new Fruit() { Name = result[0], Color = result[1] };
                    both.Fruits.Add(fruit);
                    both.SaveChanges();
                }
                reloadGridview_fruit();
            }
        }
        private void Fruit_selected(object sender, RoutedEventArgs e) 
        {
            if (!IsInitialized) return;
            
            ComboBoxItem item = e.OriginalSource as ComboBoxItem;

            if (item != null)
            {
                string s = (string)item.Content;
                string[] result = s.Split(' ');

                using (var both = new BothContext())
                {
                    var fruit = new Fruit() { Name = result[0], Color = result[1] };
                    both.Fruits.Add(fruit);
                    both.SaveChanges();
                }
                reloadGridview_fruit();
            }
        }

        // Combox Planet events
        private void Planet_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsInitialized) return;

            ComboBoxItem item = e.OriginalSource as ComboBoxItem;

            if (item != null)
            {
                string s = (string)item.Content;
                string[] result = s.Split(' ');

                using (var both = new BothContext())
                {
                    var planet = new Planet() { Name2 = result[0], Color2 = result[1] };
                    both.Planets.Add(planet);
                    both.SaveChanges();
                }
                reloadGridview_planet();
            }
        }
        private void Planet_selected(object sender, RoutedEventArgs e)
        {
            if (!IsInitialized) return;

            ComboBoxItem item = e.OriginalSource as ComboBoxItem;

            if (item != null)
            {
                string s = (string)item.Content;
                string[] result = s.Split(' ');

                using (var both = new BothContext())
                {
                    var planet = new Planet() { Name2 = result[0], Color2 = result[1] };
                    both.Planets.Add(planet);
                    both.SaveChanges();
                }
                reloadGridview_planet();
            }
        }
    }
}
