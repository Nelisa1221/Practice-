namespace WinFormsApp3
{
    partial class Login
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
            lblLogin = new Label();
            label1 = new Label();
            txtEmailLogIn = new TextBox();
            label2 = new Label();
            txtPhoneLogin = new TextBox();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(43, 25);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 25);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 166);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtEmailLogIn
            // 
            txtEmailLogIn.Location = new Point(246, 166);
            txtEmailLogIn.Name = "txtEmailLogIn";
            txtEmailLogIn.Size = new Size(150, 31);
            txtEmailLogIn.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 290);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 8;
            label2.Text = "Phone";
            // 
            // txtPhoneLogin
            // 
            txtPhoneLogin.Location = new Point(246, 284);
            txtPhoneLogin.Name = "txtPhoneLogin";
            txtPhoneLogin.Size = new Size(150, 31);
            txtPhoneLogin.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Transparansy_Flower_Background;
            ClientSize = new Size(983, 489);
            Controls.Add(txtPhoneLogin);
            Controls.Add(label2);
            Controls.Add(txtEmailLogIn);
            Controls.Add(label1);
            Controls.Add(lblLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label label1;
        private TextBox txtEmailLogIn;
        private Label label2;
        private TextBox txtPhoneLogin;
    }
}