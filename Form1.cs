using System.Xml.Linq;

namespace ExpemseTracker
{
    public partial class Form1 : Form
    {
        private readonly ExpenseService _service = new ExpenseService();
        private List<Expense> _expenses = new List<Expense>();

        public Form1()
        {
            InitializeComponent();
            LoadExpenses();
            UpdateDisplay();
        }

        private void LoadExpenses()
        {
            _expenses = _service.LoadExpenses();
        }

        private void SaveExpenses()
        {
            _service.SaveExpenses(_expenses);
        }

        private void UpdateDisplay()
        {
            ExpenseTracker.Items.Clear();
            decimal total = 0;

            foreach (var expense in _expenses)
            {
                ExpenseTracker.Items.Add(expense);
                total += expense.Amount;
            }

            lb_total.Text = $"Total: ${total}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_expense.Text) || !decimal.TryParse(tb_amount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid name and amount.");
                return;
            }

            var expense = new Expense
            {
                Name = tb_expense.Text,
                Amount = amount,
                Date = DateTime.Now
            };

            _expenses.Add(expense);
            SaveExpenses();
            UpdateDisplay();

            tb_expense.Clear();
            tb_amount.Clear();
        }
    }
}


