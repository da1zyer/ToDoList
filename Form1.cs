namespace ToDoList
{
    public partial class Form1 : Form
    {
        private const string Nothing = "";
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void Add()
        {
            if (textBox1.Text != Nothing)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Select();
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}