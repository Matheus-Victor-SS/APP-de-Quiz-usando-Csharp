using Quiz.NovaPasta1;
using System.Threading.Tasks;

namespace Quiz
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pergunta1());
        }
    }
}