using MySql.Data.MySqlClient;
namespace KayıpEşyaOtomasyonu
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=kayipesya;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT COUNT(*) FROM admin WHERE username=@username AND password=@password";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@password", textBox2.Text);

            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Giriş Başarılı!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e) => this.Text = "Kayıp Eşya Otomasyonu";
    }
}