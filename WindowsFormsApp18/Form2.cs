using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string saveValue = Convert.ToString(guna2TextBox1.Text);

            if (saveValue.Length != 0)
            {
                var myForm = new Form1();
                myForm.name = saveValue;
                myForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Вы не ввели имя!", "Предупреждение!");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
