using BeatrizPinheiroAG13DS.Views; // Adicionado o namespace correto

namespace BeatrizPinheiroAG13DS;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new ContratacaoHospedagem()); // Configuração correta para navegação
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = base.CreateWindow(activationState);
        window.Width = 400;
        window.Height = 600;
        return window;
    }
}