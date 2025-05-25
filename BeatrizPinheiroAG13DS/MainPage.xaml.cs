namespace BeatrizPinheiroAG13DS.Views;

public partial class MainPage : ContentPage
{
    private int _count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;
        DisplayAlert("Contador", $"O botão foi clicado {_count} vezes!", "OK");
    }
}