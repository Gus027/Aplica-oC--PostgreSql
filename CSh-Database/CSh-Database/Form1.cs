using MySql.Data.MySqlClient;

namespace CSh_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Conectar()){
                Console.WriteLine("Conexão Realizada com Sucesso!");
                MessageBox.Show("Conexão Realizada com Sucesso!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private bool Conectar()
        {
            var result = false;
            try
            {
                using (var conexao = new MySqlConnection(Conexao.Conn))
                {
                    conexao.Open();
                    result = true;

                }
            }
            catch
            (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result;
        }
    }
}