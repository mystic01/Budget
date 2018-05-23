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
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.month = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(82, 112);
            this.amount.Margin = new System.Windows.Forms.Padding(4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(132, 25);
            this.amount.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(20, 175);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 45);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 15;
            this.resultListBox.Items.AddRange(new object[] {
            "2018-02 500"});
            this.resultListBox.Location = new System.Drawing.Point(285, 39);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(257, 229);
            this.resultListBox.TabIndex = 6;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(82, 55);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(132, 25);
            this.month.TabIndex = 7;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(145, 177);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 41);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.month);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.amount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

