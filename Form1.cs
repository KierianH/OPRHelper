namespace SpaceCeption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FontBox.Text == "Choose Font" || FontSizeBox.Text == "Font Size")
            {
                MessageBox.Show("Please enter a font and fontsize");
                return;
            }
            else
            {
                var inputtext = InputText.Text;
                var font = FontBox.Text;
                var fontSize = FontSizeBox.Text;
                var handler = new Handler(font, fontSize);
                var returnText = handler.FitToLine(inputtext, font, fontSize);
                OutputText.Text = returnText;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(" ", TextDataFormat.UnicodeText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(" ", TextDataFormat.UnicodeText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(" ", TextDataFormat.UnicodeText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(" ", TextDataFormat.UnicodeText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}