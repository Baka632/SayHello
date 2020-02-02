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
using Windows.UI.Core;
using Windows.UI.Composition;
using Windows.UI.Xaml.Hosting;
using System.Numerics;
using Windows.UI.Popups;
using Windows.Storage;
using Windows.UI.ViewManagement;
using Windows.ApplicationModel;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace SayHello
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            Version.Text = "版本:"+appVersion;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            bool modeSwitched = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.Default);
            Frame rootFrame = Window.Current.Content as Frame;
            if (Frame.CanGoBack)
            {
                // Show UI in title bar if opted-in and in-app backstack is not empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                // Remove the UI from the title bar if in-app back stack is empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        private async void UpdatedWhat(object sender, RoutedEventArgs e)   //更新日志
        {
            ContentDialogResult result = await UpdatedContentDialog.ShowAsync();
        }
        string appVersion = string.Format("{0}.{1}.{2}.{3}",
                    Package.Current.Id.Version.Major,
                    Package.Current.Id.Version.Minor,
                    Package.Current.Id.Version.Build,
                    Package.Current.Id.Version.Revision);

        private void Theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Egg(object sender, TextChangedEventArgs e)
        {
            //彩蛋
            if (TextAbout.Text == "New World")
            {
                Frame.Navigate(typeof(Eggs));
            }
            else if(TextAbout.Text == "Miss Kobayashi's Dangon Maid")
            {
                Frame.Navigate(typeof(Eggs));
            }
            else
            {
                //Do nothing
            }
        }

        
    }
}
