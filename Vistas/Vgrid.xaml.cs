namespace pmejiaST3.Vistas;

public partial class Vgrid : ContentPage
{
	public Vgrid()
	{
		InitializeComponent();
	}

    private void BtnIngresar_Clicked_2(object sender, EventArgs e)
    {
		string [] usuario = ["Carlos", "Ana", "Jose"];
		string [] contrase�a = ["carlos123" , "ana123" , "jose123"];

		int posicion = Array.IndexOf(usuario, txtusuario.Text);

		if(posicion !=-1 && txtcontrase�a.Text==contrase�a[posicion])
		{
			Navigation.PushAsync(new Vprincipal(usuario[posicion]));
		}
		else
		{
			DisplayAlert("Alerta", "Usuario/Contrase�a Incorrecto", "Cerrar");
		}
    }
}