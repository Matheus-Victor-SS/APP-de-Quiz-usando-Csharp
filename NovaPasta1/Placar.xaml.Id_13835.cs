namespace Quiz.NovaPasta1;

public partial class Placar : ContentPage
{
    public Placar()
    {
        InitializeComponent();
        AtualizarPlacar();
    }

    private async void btnNovamente_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private void AtualizarPlacar()
    {
        int acertos = 0;

        if (Pontuacao.p1)
        {
            acertos++;
        }
        if (Pontuacao.p2)
        {
            acertos++;
        }

        int erros = 2 - acertos;

        lblAcertos.Text = acertos.ToString();
        lblErros.Text = erros.ToString();
        btnNovamente.IsVisible = true;
    }

    private void btnResultado_Clicked(object sender, EventArgs e)
    {

    }
}
