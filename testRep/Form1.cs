using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testRep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.TextChanged += textBox1_TextChanged;
            
                AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "Aaaaa",
                "Bbbbb",
                "Ccccc",
                "Ddddd"
            };
                textBox1.AutoCompleteCustomSource = source;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }
            
            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                label1.Text = textBox1.Text;
            }


        }
}
