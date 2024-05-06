using NavigateByWPF.Views;
using NavigateByWPF.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace NavigateByWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginView loginView = new LoginView();
        public MainWindow()
        {
            InitializeComponent();
            LoadViews();
        }


        public void LoadViews()
        {
            loginView.Visibility = Visibility.Collapsed;
            Panel.SetZIndex(loginView, 1);
            gridViewHost.Children.Add(loginView);

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type != typeof(IViewBase) && typeof(IViewBase).IsAssignableFrom(type))
                {
                    UserControl page = (UserControl)assembly.CreateInstance(type.FullName, true);
                    page.Name = type.Name;
                    Panel.SetZIndex(page,0);
                    page.Visibility = Visibility.Collapsed;
                    gridViewHost.Children.Add(page);

                    RadioButton radioButton = new RadioButton();
                    radioButton.Content = type.Name;
                    radioButton.Checked += RadioButton_Checked;
                    pnlNavigate.Children.Add(radioButton);
                }
            }


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            foreach (UserControl item in gridViewHost.Children)
            {
                if (item.Name == radioButton.Content)
                {
                    IViewBase view = item as IViewBase;
                    if (view.IsNeedLogin)
                    {
                        loginView.Visibility = Visibility.Visible;
                        loginView.UpdateView();
                    }
                    else
                    {
                        loginView.Visibility = Visibility.Collapsed;
                    }
                    item.Visibility = Visibility.Visible;
                }
                else
                {
                    item.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
