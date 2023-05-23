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
using FactoryInClass.Factorires;
using FactoryInClass.Interfaces;

namespace FactoryInClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UIFramworkFactory Jsonfactory;
        public MainWindow()
        {
            InitializeComponent();
            Jsonfactory = new UIFramworkFactory();

        }

        private void NewButtonClick(object sender, RoutedEventArgs e)
        {
            ICommonElement newButton = UIFramworkFactory.GetElement(IReturnElementType.ElementType.button);
            newButton.SetContext(Context.Text);
            newButton.SetWidth(int.Parse(heigh.Text));
            newButton.SetHeight(int.Parse(width.Text));
            newButton.SetTop(int.Parse(top.Text));
            newButton.SetLeft(int.Parse(left.Text));
            newButton.Write("C:\\Users\\lbailey\\TestToSee.json");
        }

        private void NewTextBoxClick(object sender, RoutedEventArgs e)
        {
            ICommonElement newTextbox = UIFramworkFactory.GetElement(IReturnElementType.ElementType.textBox);
            newTextbox.SetContext(Context.Text);
            newTextbox.SetWidth(int.Parse(heigh.Text));
            newTextbox.SetHeight(int.Parse(width.Text));
            newTextbox.SetTop(int.Parse(top.Text));
            newTextbox.SetLeft(int.Parse(left.Text));
            newTextbox.Write("C:\\Users\\lbailey\\TestToSee.json");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ICommonElement newTextbox = HTMLFactory.GetElement(IReturnElementType.ElementType.textBox);
            newTextbox.SetContext(Context.Text);
            newTextbox.SetWidth(int.Parse(heigh.Text));
            newTextbox.SetHeight(int.Parse(width.Text));
            newTextbox.SetTop(int.Parse(top.Text));
            newTextbox.SetLeft(int.Parse(left.Text));
            newTextbox.Write("C:\\Users\\lbailey\\HTML.txt");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ICommonElement newButton = HTMLFactory.GetElement(IReturnElementType.ElementType.button);
            newButton.SetContext(Context.Text);
            newButton.SetWidth(int.Parse(heigh.Text));
            newButton.SetHeight(int.Parse(width.Text));
            newButton.SetTop(int.Parse(top.Text));
            newButton.SetLeft(int.Parse(left.Text));
            newButton.Write("C:\\Users\\lbailey\\HTML.txt");
        }
    }
}
