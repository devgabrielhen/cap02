using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap_02___Terceiro_Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show($"Nome é {name} \nx é {x} \nd é {d}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show("O resultado é: " + count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("X tem é 10");
            }
            else
            {
                MessageBox.Show("X não é 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor = 3;
            string name = "Joe";
            if ((valor <= 3) && (name.Equals("Joe")))
            {
                MessageBox.Show("x é 3 e o nome é Joe");
            }
            MessageBox.Show("Essa caixa é exibida em qualquer caso");
        }
    }
}
