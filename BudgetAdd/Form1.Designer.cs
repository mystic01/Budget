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
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(69, 114);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 22);
            this.amount.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(69, 163);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(69, 69);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 22);
            this.month.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 273);
            this.Controls.Add(this.month);
            this.Controls.Add(this.save);
            this.Controls.Add(this.amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox month;
    }
}

