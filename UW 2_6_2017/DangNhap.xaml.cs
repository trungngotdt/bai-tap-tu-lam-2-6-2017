using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UW_2_6_2017
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DangNhap : Page
    {
        public DangNhap()
        {
            this.InitializeComponent();
        }

        private void Btn_Menu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Spv_menu.IsPaneOpen = !Spv_menu.IsPaneOpen;
        }

       
        private void Lsbi_Home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame_DangNhap.Navigate(typeof(Home));
        }

        private void Lsbi_Admin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame_DangNhap.Navigate(typeof(Admin));
        }

        private void Lsbi_SignOut_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage));
        }
    }
}
