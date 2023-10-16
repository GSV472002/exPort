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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app helps you to upload code to pastebin easy and faster.", "Help", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void saveHere_button_Click(object sender, EventArgs e)
        {

        }

        private void saveHereAs_button_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "New Pastebin Document";
                saveFileDialog.Filter = "Text documents (*.txt)|*.txt|C# source code (*.cs)|*.cs|C++ source code (*.cpp)|*.cpp|C source code (*.c)|*.c" +
                    "|Java source code (*.java)|*.java|Javascript file (*.js)|*.js|Python source code (*.py)|*.py|HTML file (*.html)|*.html|CSS file (*.css)|*.css" +
                    "|All files (*.*)|*.*";
                saveFileDialog.Title = "Save file as";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.ShowHiddenFiles = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textArea.Text);
                }
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
        }
    }
}