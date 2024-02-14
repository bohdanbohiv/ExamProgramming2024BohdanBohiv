using System;
using System.IO;
using System.Windows.Forms;

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        private string content;
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            try
            {
                content = File.ReadAllText(path);
            }
            catch (Exception)
            {
                MessageBox.Show("This file does not exist.");
                return;
            }
            content = content.Replace("|", "\t");
            resultTextBox.Text = content;
        }
    }
}
