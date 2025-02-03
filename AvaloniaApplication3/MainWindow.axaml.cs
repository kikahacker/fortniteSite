using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Threading;
using System.Timers;

namespace AvaloniaApplication3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Next(object source, RoutedEventArgs args)
        {
            slides.Next();
        }

        public void Previous(object source, RoutedEventArgs args)
        {
            slides.Previous();
        }
        
    }
}