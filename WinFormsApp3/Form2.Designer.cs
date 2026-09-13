namespace WinFormsApp3
{
    partial class Form2
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
            label1 = new Label();
            lblName = new Label();
            lblSurname = new Label();
            lblEmailAddress = new Label();
            lblPhoneNumber = new Label();
            lblDateOfBirth = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmailAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Sign Up ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(33, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSurname.Location = new Point(33, 153);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(77, 21);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailAddress.Location = new Point(33, 212);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(118, 21);
            lblEmailAddress.TabIndex = 3;
            lblEmailAddress.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(33, 274);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(123, 21);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.Location = new Point(33, 332);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(109, 21);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date Of Birth";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(220, 147);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(150, 31);
            txtSurname.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(220, 212);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(150, 31);
            txtEmailAddress.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(220, 274);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 31);
            txtPhoneNumber.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(220, 332);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Transparansy_Flower_Background;
            ClientSize = new Size(988, 535);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Sign up Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblSurname;
        private Label lblEmailAddress;
        private Label lblPhoneNumber;
        private Label lblDateOfBirth;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmailAddress;
        private TextBox txtPhoneNumber;
        private DateTimePicker dateTimePicker1;
    }
}