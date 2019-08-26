using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_en_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="juancho" && textBox2.Text=="123tamarindo")
            {
                MessageBox.Show("bienvenido agente juan cho");
            }
            else
            {
                MessageBox.Show("el nombre de agente o la contraseña es incorrecta");
                textBox1.Text = "";
                textBox2.Text="";
                textBox1.Focus();
            }
        }
    }
}
