using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TableSectionTitleIssue
{
    public partial class MainPage : ContentPage
    {
        public int _count = 0;

        public MainPage()
        {
            InitializeComponent();
            Increment.Clicked += Increment_Clicked;
            Decrement.Clicked += Decrement_Clicked;
        }

        private void Decrement_Clicked(object sender, EventArgs e)
        {
            _count--;
            Section.Title = _count.ToString();
            Cell.Text = _count.ToString();
        }

        private void Increment_Clicked(object sender, EventArgs e)
        {
            _count++;
            Section.Title = _count.ToString();
            Cell.Text = _count.ToString();
        }
    }
}
