namespace Quiz.NovaPasta1;

public partial class Pergunta2 : ContentPage
{
    public Pergunta2()
    {
        InitializeComponent();
    }
   
    private async void btnP2_Clicked_1(object sender, EventArgs e)
    {
        if (radAlternativa3.IsChecked)
        {
            Pontuacao.p2 = true;
        }
        else
        {
            Pontuacao.p2 = false;
        }
        await Navigation.PushAsync(new Placar());
    }
}