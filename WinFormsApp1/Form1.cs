using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
            public Form1()
        {
            InitializeComponent();
            richTextBox1.AppendText("Hello World!");        
        }
          

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains(textBox1.Text)) 
            {
                int index = richTextBox1.Text.IndexOf(textBox1.Text);  
                string str1, str2;
                str1 = richTextBox1.Text.Substring(0, index); 
                str2 = richTextBox1.Text.Substring((index + textBox1.TextLength), (richTextBox1.TextLength - (index + textBox1.TextLength))); 
                string result = str1 + textBox2.Text + str2; 
                richTextBox1.Clear(); 
                richTextBox1.AppendText(result);
                richTextBox1.Select(str1.Length, textBox2.Text.Length); 
                
            }
            else
                MessageBox.Show("Такого слова в RichTextBox не найдено");  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
