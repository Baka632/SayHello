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
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

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

            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = "提示"
                            },
                            new AdaptiveText()
                            {
                                Text = "在更改主题后请务必重启应用"
                            }
                        }
                    }
                }
            };
            // Create the toast notification
            var toastNotif = new ToastNotification(toastContent.GetXml());

            // And send the notification
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
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

        private async void Mail(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("mailto:stevemc123456@outlook.com"));
        }

        private async void Github(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://github.com/Baka632"));
        }
    }
}
