using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            try
            {
                var content = File.ReadAllText(path);
                content = content.Replace("|", "\t");
                resultTextBox.Text = content;
            }
            catch (Exception)
            {
                MessageBox.Show("This file does not exist.");
            }
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            var lines = File.ReadAllLines(path);

            var categories = new HashSet<string>();
            var total = 0.0;
            var days = new HashSet<string>();
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split('|');
                var price = double.Parse(split[1]);
                total += price;
                categories.Add(split[2]);
                days.Add(split[0]);
            }

            resultTextBox.Text = $"Total expenses {total}{Environment.NewLine}" +
                $"Number of categories {categories.Count}{Environment.NewLine}" +
                $"Total day of payment {days.Count}";
        }
    }
}
