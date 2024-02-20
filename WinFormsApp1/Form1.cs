namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label2.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool CheckAge(int age)
        {
            bool result = true;
            if (age <= 50)
            {
                result = false;
            }
            return result;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool resChekAge = CheckAge(Convert.ToInt32(textBox1.Text));
            int age = Convert.ToInt32(textBox1.Text);
            label2.Text = resChekAge ? ("Ты в аду, брат") : ("Челик, ты в раю");
            if ( age >= 50)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox2.Visible = true;
            }
        }
    }
}
