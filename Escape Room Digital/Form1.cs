namespace Escape_Room_Digital
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
            Form2 formulario2 = new Form2();
            formulario2.Show();
            this.Hide(); 
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
