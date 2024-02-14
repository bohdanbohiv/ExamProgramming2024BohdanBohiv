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
        private class Category
        {
            public int times;
            public HashSet<string> months;
            public double total;
            public Category()
            {
                times = 0;
                months = new HashSet<string>();
                total = 0;
            }
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

            var categories = new Dictionary<string, Category>();
            var total = 0.0;
            var days = new HashSet<string>();
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split('|');
                var price = double.Parse(split[1]);
                total += price;
                days.Add(split[0]);
                if (!categories.ContainsKey(split[2]))
                {
                    categories[split[2]] = new Category();
                }
                categories[split[2]].times += 1;
                categories[split[2]].months.Add(DateTime.Parse(split[0]).Month.ToString());
                categories[split[2]].total += price;
            }

            resultTextBox.Text = $"Total expenses {total}{Environment.NewLine}" +
                $"Number of categories {categories.Count}{Environment.NewLine}" +
                $"Total day of payment {days.Count}{Environment.NewLine}" +
                $"Categories:";
            foreach (var category in categories)
            {
                resultTextBox.Text += $"{Environment.NewLine}  " +
                    $"{category.Key}-bought {category.Value.times} times in total. " +
                    $"Purchases in: {string.Join(", ", category.Value.months)}. " +
                    $"Total expense: {category.Value.total}";
            }
        }
    }
}
