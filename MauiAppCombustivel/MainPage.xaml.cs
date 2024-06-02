namespace MauiAppCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasoloina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";

                if (etanol < (gasoloina * 0.7))
                {
                    msg = "O Etanol esta conpensando mais";
                }
                else
                {
                    msg = "A Gasolina esta conpensando mais";
                }

                DisplayAlert("Calculado", msg,"Ok");

            }catch (Exception ex)
            {
                DisplayAlert("Ops",ex.Message,"Fechar");
            }

        }//fecha método
    }//fecha class
}//fecha namespace
