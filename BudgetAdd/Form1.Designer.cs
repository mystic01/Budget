namespace BudgetAdd
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.amount = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.TextBox();
            this.resultMonth = new System.Windows.Forms.Label();
            this.resultAmount = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(92, 142);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(132, 25);
            this.amount.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(92, 204);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 29);
            this.save.TabIndex = 2;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(92, 86);
            this.month.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(132, 25);
            this.month.TabIndex = 3;
            // 
            // resultMonth
            // 
            this.resultMonth.AutoSize = true;
            this.resultMonth.Location = new System.Drawing.Point(336, 95);
            this.resultMonth.Name = "resultMonth";
            this.resultMonth.Size = new System.Drawing.Size(54, 15);
            this.resultMonth.TabIndex = 4;
            this.resultMonth.Text = "2018-02";
            // 
            // resultAmount
            // 
            this.resultAmount.AutoSize = true;
            this.resultAmount.Location = new System.Drawing.Point(339, 151);
            this.resultAmount.Name = "resultAmount";
            this.resultAmount.Size = new System.Drawing.Size(28, 15);
            this.resultAmount.TabIndex = 5;
            this.resultAmount.Text = "500";
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 15;
            this.resultListBox.Items.AddRange(new object[] {
            "2018-02 500"});
            this.resultListBox.Location = new System.Drawing.Point(407, 95);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(120, 94);
            this.resultListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 341);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.resultAmount);
            this.Controls.Add(this.resultMonth);
            this.Controls.Add(this.month);
            this.Controls.Add(this.save);
            this.Controls.Add(this.amount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label resultMonth;
        private System.Windows.Forms.Label resultAmount;
        private System.Windows.Forms.ListBox resultListBox;
    }
}

