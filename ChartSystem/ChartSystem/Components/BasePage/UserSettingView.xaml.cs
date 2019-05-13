using FirstFloor.ModernUI.Windows.Controls;
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

namespace ChartSystem.Components.BasePage
{
    /// <summary>
    /// UserSettingView.xaml 的交互逻辑
    /// </summary>
    public partial class UserSettingView : UserControl
    {
        public UserSettingView()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var win = new ModifyUserView();
            win.Margin = new Thickness(32);
            var wnd = new ModernWindow
            {
                Title = "新增用户",
                Style = (Style)App.Current.Resources["EmptyWindow"],
                Content = win,
                Width = win.Width,
                Height = win.Height
            };
            wnd.ResizeMode = ResizeMode.NoResize;
            wnd.ShowDialog(); 
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            var win = new ModifyUserView();
            win.Margin = new Thickness(32);
            var wnd = new ModernWindow
            {
                Title = "修改用户",
                Style = (Style)App.Current.Resources["EmptyWindow"],
                Content = win, 
                Width = win.Width,
                Height = win.Height
            };
            wnd.ResizeMode = ResizeMode.NoResize;
            wnd.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = ModernDialog.ShowMessage("是否删除用户信息?", "提示", MessageBoxButton.YesNo);
            if(result == true)
            {
                ModernDialog.ShowMessage("A messagebox triggered by selecting a hyperlink", "Messagebox", MessageBoxButton.OK);
            }
            else
            {
                new ModernDialog
                {
                    Title = "提示",
                    Content = "否"
                }.ShowDialog();
            }
        }
    }
}
