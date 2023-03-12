namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void in_edad_Click(object sender, EventArgs e)
        {
            MessageBox.Show (Saludo());
            try
            {
                int edad = int.Parse(this.edad.Text);
                if (edad <= 20)
                {
                this.out_edad.Text += "\n" + edad.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void out_edad_Click(object sender, EventArgs e)
        {

        }

        private void out_rechazados_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(this.edad.Text);
            switch (edad)
            {
                case 15:
                    MessageBox.Show(this.out_edad.Text += "El jugador no puede participar porque tiene 15 años");
                        break;
                case 18:
                    MessageBox.Show(this.out_edad.Text += "El jugador tiene que tener permiso de sus padres");
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] mensajes =
            {
                "Esta es la primera advertencia",
                "No sigas, esta es tu segunda advertencia",
                "Esta es tu tercera advertencia, para por favor."
            };
            for (int i = 1; i <= 3; i++)
            {
                MessageBox.Show("Advertencia No. " + i.ToString());
            }
        }

        private void botonwhile_Click(object sender, EventArgs e)
        {
            //Este es While
            int numero = 10;
            while(numero <= 100)
            {
                MessageBox.Show("El nivel de carga es: " + numero.ToString());
                numero = numero + 10;
            }
            //do while
            int numero2 = 50;
            do
            {
                MessageBox.Show("La carga del dispositivo es: " + numero2.ToString());
                numero2 = numero2 - 10;
            } while (numero2 >= 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Saludo()
        {
            return "Saludos para el usuario";
        }

        private void edad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}