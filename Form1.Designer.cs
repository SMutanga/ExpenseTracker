namespace ExpemseTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_expense = new TextBox();
            tb_amount = new TextBox();
            ExpenseTracker = new ListBox();
            btnAdd = new Button();
            lb_total = new Label();
            label3 = new Label();
            BtnRemove = new Button();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 42);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Expense:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // tb_expense
            // 
            tb_expense.Location = new Point(487, 40);
            tb_expense.Name = "tb_expense";
            tb_expense.Size = new Size(100, 23);
            tb_expense.TabIndex = 2;
            // 
            // tb_amount
            // 
            tb_amount.Location = new Point(490, 72);
            tb_amount.Name = "tb_amount";
            tb_amount.Size = new Size(100, 23);
            tb_amount.TabIndex = 3;
            // 
            // ExpenseTracker
            // 
            ExpenseTracker.FormattingEnabled = true;
            ExpenseTracker.ItemHeight = 15;
            ExpenseTracker.Location = new Point(44, 50);
            ExpenseTracker.Name = "ExpenseTracker";
            ExpenseTracker.Size = new Size(352, 304);
            ExpenseTracker.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(460, 121);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 31);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Expense";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(531, 277);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(13, 15);
            lb_total.TabIndex = 6;
            lb_total.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 277);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Total Expenses:";
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(460, 174);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(109, 33);
            BtnRemove.TabIndex = 8;
            BtnRemove.Text = "Remove Expense";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(460, 226);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(109, 30);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSave);
            Controls.Add(BtnRemove);
            Controls.Add(label3);
            Controls.Add(lb_total);
            Controls.Add(btnAdd);
            Controls.Add(ExpenseTracker);
            Controls.Add(tb_amount);
            Controls.Add(tb_expense);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_expense;
        private TextBox tb_amount;
        private ListBox ExpenseTracker;
        private Button btnAdd;
        private Label lb_total;
        private Label label3;
        private Button BtnRemove;
        private Button BtnSave;
    }
}
