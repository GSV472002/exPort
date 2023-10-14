namespace exPort
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

        private void MouseEnterEffect(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).FlatAppearance.BorderColor = Color.Red;
        }

        private void MouseExitEffect(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
            ((Button)sender).FlatAppearance.BorderColor = Color.LightSeaGreen;
        }

        private void textArea_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}