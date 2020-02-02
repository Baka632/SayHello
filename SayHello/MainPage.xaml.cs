using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace SayHello  //名称
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rand;
        
        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private byte[] GetRandomBytes(int n)
        {
            //用随机数填充长度为 "n" 的字节数组。
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }
                
        private void SayHelloButton_Click(object sender, RoutedEventArgs e)  //当SayHelloButton被按下时的事件
        {
            //用三个随机数来创建一个纯色画笔
            byte[] rgb = GetRandomBytes(3); 
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));

            //设置边框色和前景色为上方的纯色画笔
            textBox1.BorderBrush = randomColorBrush;
            textBox1.Foreground = randomColorBrush;
        }

        private void DisapperChenked(object sender, RoutedEventArgs e)  //Chenkbox被勾选
        {
           textBox1.Visibility = Visibility.Collapsed;
           SayHelloButton.Visibility = Visibility.Collapsed;
            //语法：(name).Visibility = Visibility.Collapsed;
            //功能：隐藏文本框
        }

        private void DisapperUnchenked(object sender, RoutedEventArgs e)  //Chenkbox未勾选
        {
            textBox1.Visibility = Visibility.Visible;
            SayHelloButton.Visibility = Visibility.Visible;
            //语法同上
            //功能：显示文本框
        }

        private void About(object sender, RoutedEventArgs e)   //当CommandBar上的"关于"按钮被按下时的事件
        {
            Frame.Navigate(typeof(About), null, new DrillInNavigationTransitionInfo());
            //语法：https://docs.microsoft.com/zh-cn/windows/uwp/design/motion/page-transitions
            //功能：导航至About页(加上页面过渡)
        }

        private async void TopMode(object sender, RoutedEventArgs e)
        {
            if (ApplicationView.GetForCurrentView().IsViewModeSupported(ApplicationViewMode.CompactOverlay))
            {
                bool modeSwitched0 = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay);
                ViewModePreferences compactOptions = ViewModePreferences.CreateDefault(ApplicationViewMode.CompactOverlay);
                compactOptions.CustomSize = new Windows.Foundation.Size(800, 600);//窗口大小
                bool modeSwitched = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay, compactOptions);
                textBox1.Visibility = Visibility.Collapsed;
                SayHelloButton.Visibility = Visibility.Collapsed;
                TitleText.Visibility = Visibility.Collapsed;
                TopButton.Visibility = Visibility.Collapsed;
                Disapper.Visibility = Visibility.Collapsed;
                GoToNewPage.Visibility = Visibility.Collapsed;
                TopButtonBack.Visibility = Visibility.Visible;
            }
            else
            {
                //Do Nothing
            }
        }

        private async void CloseTopMode(object sender, RoutedEventArgs e)
        {
            if (ApplicationView.GetForCurrentView().IsViewModeSupported(ApplicationViewMode.Default))
            {
                bool modeSwitched0 = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.Default);
                ViewModePreferences compactOptions = ViewModePreferences.CreateDefault(ApplicationViewMode.Default);
                textBox1.Visibility = Visibility.Visible;
                SayHelloButton.Visibility = Visibility.Visible;
                TitleText.Visibility = Visibility.Visible;
                TopButton.Visibility = Visibility.Visible;
                Disapper.Visibility = Visibility.Visible;
                GoToNewPage.Visibility = Visibility.Visible;
                TopButtonBack.Visibility = Visibility.Collapsed;
            }
            else
            {
                //Do Nothing
            }
        }
    }   
}
