namespace some_app;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void CalcularArea(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Base.Text))
		{
			var localAltura = double.Parse(Altura.Text);
			var localBase = double.Parse(Base.Text);
			var localArea = localAltura * localBase;

			Resultado.Text = localArea.ToString();
		} else
		{
			Resultado.Text = "Llene todos los campos";
		}
    }

    private void LimpiarControles(object sender, EventArgs e)
    {
		Altura.Text = "";
		Base.Text = "";
		Resultado.Text = "";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Application.Current.Quit();
    }
}

