using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpemseTracker
{
    public partial class Form1 : Form
    {
        private List<Expense> _expenses = new List<Expense>();
        private readonly ExpenseService _service = new ExpenseService();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_expense.Text) || string.IsNullOrWhiteSpace(tb_amount.Text))
            {
                MessageBox.Show("Please enter both expense name and amount.");
                return;
            }

            if (!double.TryParse(tb_amount.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            var expense = new Expense
            {
                Name = tb_expense.Text,
                Amount = amount,
                Date = DateTime.Now
            };

            _expenses.Add(expense);
            UpdateDisplay();

            tb_expense.Text = "";
            tb_amount.Text = "";
        }

        private void UpdateDisplay()
        {
            ExpenseTracker.Items.Clear();
            double total = 0;

            foreach (var expense in _expenses)
            {
                ExpenseTracker.Items.Add(expense);
                total += expense.Amount;
            }

            lb_total.Text = $"Total: ${total:F2}";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = ExpenseTracker.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select an expense to remove.");
                return;
            }

            _expenses.RemoveAt(selectedIndex);
            UpdateDisplay();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _service.SaveExpenses(_expenses);
            MessageBox.Show("Expenses saved successfully.");
        }
    }
}



