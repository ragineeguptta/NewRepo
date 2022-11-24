﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 26;
            btn.Width = 400;
            btn.Height = 100;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;
            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            txt.Foreground = Brushes.Green;
            wrapPanel.Children.Add(txt);

            btn.Content = wrapPanel;
            grid.Children.Add(btn);
        }

        
    }
}
