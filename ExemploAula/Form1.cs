namespace ExemploAula
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text == "Admin" && txtsenha.Text =="123456")
            {
                MessageBox.Show("Usuario Logado com sucesso");
                txtusuario.Clear();
                txtsenha.Clear();
                    
            }               
            else
            {
                MessageBox.Show("Usuario/senha invalidos");
                txtusuario.Clear();
                txtsenha.Clear();
            }
        }
    }
}
