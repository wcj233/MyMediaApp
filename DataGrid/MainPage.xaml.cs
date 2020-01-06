using Microsoft.Toolkit.Uwp.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataGrid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    //backing data source in MyViewModel
    public class Customer
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public Boolean IsNew { get; set; }

        public Customer(String firstName, String lastName,
            String address, Boolean isNew)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.IsNew = isNew;

            
        }

        
        
    }

    public sealed partial class MainPage : Page
    {
        public List<Customer> Customers { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            //MyViewModel = new Customer("W","J","Wuxi",true);
            Customers = new List<Customer>(new Customer[] {
            new Customer("A.", "Zero",
                "12 North Third Street, Apartment 45",
                false),
            new Customer("B.", "One",
                "34 West Fifth Street, Apartment 67",
                false),
            new Customer("C.", "Two",
                "56 East Seventh Street, Apartment 89",
                true),
            new Customer("D.", "Three",
                "78 South Ninth Street, Apartment 10",
                true),
            new Customer("A.", "Zero",
                "12 North Third Street, Apartment 45",
                false),
            new Customer("B.", "One",
                "34 West Fifth Street, Apartment 67",
                false),
            new Customer("C.", "Two",
                "56 East Seventh Street, Apartment 89",
                true),
            new Customer("D.", "Three",
                "78 South Ninth Street, Apartment 10",
                true),
            new Customer("A.", "Zero",
                "12 North Third Street, Apartment 45",
                false),
            new Customer("B.", "One",
                "34 West Fifth Street, Apartment 67",
                false),
            new Customer("C.", "Two",
                "56 East Seventh Street, Apartment 89",
                true),
            new Customer("D.", "Three",
                "78 South Ninth Street, Apartment 10",
                true)
        });
        }
        private Customer MyViewModel { get; set; }

        private PrintHelper _printHelper;

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create a new PrintHelper instance
            // "container" is a XAML panel that will be used to get the list of printable controls.
            var printHelper = new PrintHelper(CustomPrintContainer);

            await printHelper.ShowPrintUIAsync("Title");

            //var pageNumber = 0;

            //for (int i = 0; i < Customers.Count; i = i + 10)
            //{
            //    var grid = new Grid();
            //    grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            //    grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            //    grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });

            //    // Static header
            //    var header = new TextBlock { Text = "Custom Print", Margin = new Thickness(0, 0, 0, 20) };
            //    Grid.SetRow(header, 0);
            //    grid.Children.Add(header);

            //    // Main content with layout from data template
            //    var dataGrid = new DataGrid();
            //    dataGrid.AutoGenerateColumns = true;
            //    dataGrid.ItemsSource = Persons.Skip(i).Take(10);
            //    Grid.SetRow(dataGrid, 1);
            //    grid.Children.Add(dataGrid);

            //    // Footer with page number
            //    pageNumber++;
            //    var footer = new TextBlock { Text = string.Format("page {0}", pageNumber), Margin = new Thickness(0, 20, 0, 0) };
            //    Grid.SetRow(footer, 2);
            //    grid.Children.Add(footer);

            //    _printHelper.AddFrameworkElementToPrint(grid);
            //}

            //_printHelper.OnPrintCanceled += _printHelper_OnPrintCanceled;
            //_printHelper.OnPrintFailed += _printHelper_OnPrintFailed;
            //_printHelper.OnPrintSucceeded += _printHelper_OnPrintSucceeded;

            //var printHelperOptions = new PrintHelperOptions(false);
            //printHelperOptions.Orientation = Windows.Graphics.Printing.PrintOrientation.Default;
            //printHelperOptions.AddDisplayOption(StandardPrintTaskOptions.Orientation);
            //await _printHelper.ShowPrintUIAsync("print sample");
        }
    }
}
