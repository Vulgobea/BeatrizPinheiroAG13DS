namespace BeatrizPinheiroAG13DS.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private void OnSobreClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Sobre()); // Navega corretamente para a página Sobre
    }
}