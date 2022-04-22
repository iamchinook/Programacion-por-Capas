using CapaBLL;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string saludo = CapaBLL.ClassBLL.SaludoBLL();
            InitializeComponent();
            textBox1.AppendText(saludo);
        }
    }
}