using System;
using Xamarin.Forms;

namespace TableSectionTitleIssue
{
    public partial class MainPage : ContentPage
    {
        public int _count = 0;
        private TableSection _sectionWithIssue;
        private TableSection _sectionGood;
        private TextCell _cellWithIssue;
        private TextCell _cellGood;

        public MainPage()
        {
            InitializeComponent();

            _sectionWithIssue = new TableSection("0");
            _sectionGood = new TableSection("0");
            _cellWithIssue = new TextCell { Text = "0" };
            _cellGood = new TextCell { Text = "0" };

            _sectionWithIssue.Add(_cellWithIssue);
            TableViewWithIssue.Root.Add(_sectionWithIssue);

            _sectionGood.Add(_cellGood);
            TableViewGood.Root = new TableRoot { _sectionGood };

            Increment.Clicked += Increment_Clicked;
        }

        private void Increment_Clicked(object sender, EventArgs e)
        {
            _count++;

            _sectionWithIssue.Title = _count.ToString();
            _sectionGood.Title = _count.ToString();

            _cellWithIssue.Text = _count.ToString();
            _cellGood.Text = _count.ToString();
        }
    }
}
