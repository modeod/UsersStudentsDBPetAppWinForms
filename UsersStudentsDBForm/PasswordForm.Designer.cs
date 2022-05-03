namespace UsersStudentsDBForm
{
    partial class Password
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
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPass.Location = new System.Drawing.Point(12, 29);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(85, 28);
            this.labelPass.TabIndex = 0;
            this.labelPass.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(103, 33);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(352, 27);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.Location = new System.Drawing.Point(146, 74);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(156, 29);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Войти";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 118);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPass);
            this.MaximumSize = new System.Drawing.Size(485, 165);
            this.MinimumSize = new System.Drawing.Size(485, 165);
            this.Name = "Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Password_FormClosed);
            this.Load += new System.EventHandler(this.Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPass;
        private TextBox textBoxPassword;
        private Button buttonConnect;
    }
}