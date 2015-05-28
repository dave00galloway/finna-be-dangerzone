using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace APRESS.TimeTracker.Resources
{
    /// <summary>
    ///     Interaction logic for ImageButton.xaml
    /// </summary>
    public partial class ImageButton : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof (String), typeof (ImageButton), new UIPropertyMetadata(""));

        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof (ImageSource),
            typeof (ImageButton), new UIPropertyMetadata(null));

        public ImageButton()
        {
            InitializeComponent();
        }

        public String Text
        {
            get { return (String) GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ImageSource Image
        {
            get { return (ImageSource) GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
    }
}