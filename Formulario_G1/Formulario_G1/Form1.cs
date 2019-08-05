using System;
using System.Windows.Forms;



namespace Formulario_G1
{
    public partial class Form1 : Form
    {

        int seleccionado;
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            seleccionado = 1;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {

            string edificio = cbxEdificio.SelectedItem.ToString();
            string genero = "";
            if(seleccionado == 1)
            {
                genero = "Hombres";
            }else if(seleccionado == 2)
            {
                genero = "Mujeres";
            }
            int inodoros = int.Parse(txtInodoros.Text);
            double litros = double.Parse(txtLitros.Text);
            int lavamanos = int.Parse(txtLavamanos.Text);
            double tiempo = double.Parse(txtTiempo.Text);


            Formulario f = new Formulario(edificio, genero, inodoros, litros, lavamanos, tiempo);

            MessageBox.Show(f.guardar(edificio, genero, inodoros, litros, lavamanos, tiempo));
           

        }

        private void BtRegistros_Click(object sender, EventArgs e)
        {
            Formulario f = new Formulario();
            txtRegistros.Text = f.leer();
            MessageBox.Show("Estos son los registros encontrados");
        }

        private void RbtMujeres_CheckedChanged(object sender, EventArgs e)
        {
            seleccionado = 2;
        }


    }
}
