using System.Collections.ObjectModel;

namespace Notatki_16_06
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Notatka> notatki { get; set; } = new();
        public MainPage()
        {
            InitializeComponent();
            notatkiListView.ItemsSource = notatki;
            BindingContext = this;
            notatki.Add(new Notatka("notatka1", "treść1"));
        }

        private void DodajNotatkeButton_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tytulEntry.Text) || string.IsNullOrWhiteSpace(trescEntry.Text))
            {
                DisplayAlert("Błąd", "Nie wprowadzono wszystkich danych", "OK");
            }
            else
            {
                Notatka nowaNotatka = new Notatka(tytulEntry.Text, trescEntry.Text);
                notatki.Add(nowaNotatka);
                tytulEntry.Text = "";
                trescEntry.Text = "";
            }
        }

        private void notatkiListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            foreach(var n in notatki)
            {
                if (notatkiListView.SelectedItem == n)
                {
                    DisplayAlert(n.tytul, n.tresc, "OK");
                }
            }
        }
    }
    public class Notatka
    {
        public string tytul { get; set; }
        public string tresc { get; set; }

        public Notatka(string _tytul, string _tresc)
        {
            tytul = _tytul;
            tresc = _tresc;
        }
    }
}
