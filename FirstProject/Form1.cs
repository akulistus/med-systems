using FirstProject.viewModel;
namespace FirstProject
{
    public partial class Form1 : Form
    {
        private MainViewModel viewModel;
        List<char> charList = new() { '^', '/', '*', '-', '+', '(', ')', ',' };

        public Form1(MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = viewModel.Calculate(textBox1.Text);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 32) || (e.KeyChar >= '0') && (e.KeyChar <= '9') || (charList.Contains(e.KeyChar)))
                return;

            // only evident errors (like 'A' or '&') are restricted
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("9");
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("{^}");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("0");
        }

        private void button__Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send(",");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("{+}");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            SendKeys.Send("/");
        }
    }
}
