namespace pmejiaST3.Vistas;

public partial class Vprincipal : ContentPage
{
    public Vprincipal(string usuario)
    {
        InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido : " + usuario, "cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void btnPiker_Clicked(object sender, EventArgs e)
    {
        double seguimiento1 = Convert.ToDouble(txtSeguimiento.Text);

        double examen1 = Convert.ToDouble(txtExamel.Text);

        double total1 = seguimiento1 * (0.3) + examen1 * (0.2);

        lblsuma1.Text = "Su Nota es: " + Convert.ToString(total1);

        double seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);

        double examen2 = Convert.ToDouble(txtExamel2.Text);

        double total2 = seguimiento2 * (0.3) + examen2 * (0.2);
        lblsuma2.Text = " Su Nota es: " + Convert.ToString(total2);


        double resultado = total1 + total2;
        lblsumafinal.Text = "Su nota final es: " + resultado.ToString();

        lblestadofinal.Text = resultado.ToString();



        if (resultado >= 7.0)
        {
            lblestadofinal.Text = "Su estado es: Aprobado";
        }
        else if (resultado >= 5.0 && resultado < 7.0)
        {
            lblestadofinal.Text = "Su estado es Complementario";
        }
        else
        {
            lblestadofinal.Text = "Su estado es: Reprobado";

        }
        string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
        lblFecha.Text = "La fecha seleccionada es: " + fecha;

        string dato = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
        DisplayAlert("Alerta", " Estudiante: " + dato + "\n Fecha: " + fecha + "\n Parcial 1: " + total1 + "\n Parcial 2:  " + total2 +
                " \n Nota Final es: " + resultado + "\n " + lblestadofinal.Text, "Cerrar");
    }
}
   
