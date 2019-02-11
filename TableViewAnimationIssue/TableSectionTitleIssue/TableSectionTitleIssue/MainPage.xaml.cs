using System;
using Xamarin.Forms;

namespace TableSectionTitleIssue
{
    public partial class MainPage : ContentPage
    {
        public int _count = 0;
        private TableSection _sectionBad;
        private TableSection _sectionGood;
        private TextCell _cellBad;
        private TextCell _cellGood;

        public MainPage()
        {
            InitializeComponent();

            _sectionBad = new TableSection("0");
            _sectionGood = new TableSection("0");
            _cellBad = new TextCell { Text = "0" };
            _cellGood = new TextCell { Text = "0" };

            var sectionBad2 = new TableSection("Text");
            var cellBad2 = new TextCell { Text = "Text" };
            var sectionGood2 = new TableSection("Text");
            var cellGood2 = new TextCell { Text = "Text" };

            _sectionBad.Add(_cellBad);
            sectionBad2.Add(cellBad2);
            TableViewBad.Root = new TableRoot { _sectionBad, sectionBad2 };

            _sectionGood.Add(_cellGood);
            sectionGood2.Add(cellGood2);
            TableViewGood.Root.Add(_sectionGood);
            TableViewGood.Root.Add(sectionGood2);

            Increment.Clicked += Increment_Clicked;
        }

        private void Increment_Clicked(object sender, EventArgs e)
        {
            _count++;

            _sectionBad.Title = _count.ToString();
            _sectionGood.Title = _count.ToString();

            _cellBad.Text = _count.ToString();
            _cellGood.Text = _count.ToString();
        }
    }
}