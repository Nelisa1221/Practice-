namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(278, 397);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(255, 192, 192);
            btnSignIn.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(543, 397);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(153, 55);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = "Sign In ";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 525);
            Controls.Add(btnSignIn);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Muffin Bombshells";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnSignIn;
    }
}
