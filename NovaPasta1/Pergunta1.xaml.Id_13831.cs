namespace Quiz.NovaPasta1;

public partial class Pergunta1 : ContentPage
{
	public Pergunta1()
	{
		InitializeComponent();
	}
	private async void btnP1_Clicked(object sender, EventArgs e)
	{
		if (radAlternativa1.IsChecked)
		{
			Pontuacao.p1 = true;
		}
		else
		{
			Pontuacao.p1 = false;
		}
		await Navigation.PushAsync(new Pergunta2());
	}
}