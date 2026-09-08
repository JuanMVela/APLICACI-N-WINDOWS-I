namespace MiPrimerAplicacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            //Primer commit
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

       
    }
}
