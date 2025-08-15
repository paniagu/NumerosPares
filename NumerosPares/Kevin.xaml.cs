namespace NumerosPares;

public partial class Kevin : ContentPage
{
	public Kevin()
	{
		InitializeComponent();
	}
   
    private void Convertir_Clicked(object sender, EventArgs e)
    {
        double mexico = 0;
        mexico = double.Parse(mx.Text);

        double cambio = 0.05;

        double dolares = mexico * cambio;
        resultado.Text = "$" + dolares.ToString("F2");

    }
}