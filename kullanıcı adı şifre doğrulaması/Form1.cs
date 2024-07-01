namespace kullanıcı_adı_şifre_doğrulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi= textBox1.Text;
            int sifre = Convert.ToInt32(textBox2.Text);

            if (kullaniciadi=="mühendis"&& sifre==123)
            {
                label3.Text = "doğru";

            }
            else
            {
                label3.Text = "yanlış";

            }
        }
    }
}