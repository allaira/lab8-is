namespace MVP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPrompt = new Label();
            txtSalaries = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(20, 15);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(311, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Введіть зарплати працівників (через кому):";
            // 
            // txtSalaries
            // 
            txtSalaries.Location = new Point(20, 35);
            txtSalaries.Name = "txtSalaries";
            txtSalaries.Size = new Size(340, 27);
            txtSalaries.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(20, 70);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblResult.Location = new Point(20, 115);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(129, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "Результат = ";
            // 
            // Form1
            // 
            ClientSize = new Size(414, 180);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtSalaries);
            Controls.Add(lblPrompt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MVP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtSalaries;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}