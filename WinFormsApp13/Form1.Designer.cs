namespace WinFormsApp13
{
    partial class Form1
    {
        private GroupBox grpPersonal;
        private GroupBox grpAdditional;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblBirthDate;
        private Label lblGender;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private DateTimePicker dtpBirthDate;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkTerms;
        private Button btnRegister;
        private Button btnReset;
        private ErrorProvider epCheck;

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
            grpPersonal = new GroupBox();
            grpAdditional = new GroupBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblBirthDate = new Label();
            lblGender = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            dtpBirthDate = new DateTimePicker();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkTerms = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            components = new System.ComponentModel.Container();

            grpPersonal.SuspendLayout();
            grpAdditional.SuspendLayout();
            SuspendLayout();

            grpPersonal.Controls.Add(lblUsername);
            grpPersonal.Controls.Add(txtUsername);
            grpPersonal.Controls.Add(lblPassword);
            grpPersonal.Controls.Add(txtPassword);
            grpPersonal.Controls.Add(lblConfirmPassword);
            grpPersonal.Controls.Add(txtConfirmPassword);
            grpPersonal.Location = new Point(20, 15);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Size = new Size(750, 190);
            grpPersonal.TabIndex = 0;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "Thông tin cá nhân";

            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(25, 39);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Tên đăng nhập:";

            txtUsername.Location = new Point(175, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(420, 27);
            txtUsername.TabIndex = 0;

            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Mật khẩu:";

            txtPassword.Location = new Point(175, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(420, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;

            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(25, 129);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";

            txtConfirmPassword.Location = new Point(175, 125);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(420, 27);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.UseSystemPasswordChar = true;

            grpAdditional.Controls.Add(lblBirthDate);
            grpAdditional.Controls.Add(dtpBirthDate);
            grpAdditional.Controls.Add(lblGender);
            grpAdditional.Controls.Add(rdoMale);
            grpAdditional.Controls.Add(rdoFemale);
            grpAdditional.Controls.Add(chkTerms);
            grpAdditional.Location = new Point(20, 215);
            grpAdditional.Name = "grpAdditional";
            grpAdditional.Size = new Size(750, 150);
            grpAdditional.TabIndex = 1;
            grpAdditional.TabStop = false;
            grpAdditional.Text = "Thông tin bổ sung";

            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(25, 36);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Text = "Ngày sinh:";

            dtpBirthDate.Location = new Point(175, 28);
            dtpBirthDate.MaxDate = DateTime.Today;
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 3;
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            lblGender.AutoSize = true;
            lblGender.Location = new Point(25, 68);
            lblGender.Name = "lblGender";
            lblGender.Text = "Giới tính:";

            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(175, 65);
            rdoMale.Name = "rdoMale";
            rdoMale.TabIndex = 4;
            rdoMale.Text = "Nam";

            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(250, 65);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.TabIndex = 5;
            rdoFemale.Text = "Nữ";

            chkTerms.AutoSize = true;
            chkTerms.Location = new Point(175, 100);
            chkTerms.Name = "chkTerms";
            chkTerms.TabIndex = 6;
            chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";

            btnRegister.Location = new Point(490, 390);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += RegisterButton_Click;

            btnReset.Location = new Point(630, 390);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 35);
            btnReset.TabIndex = 8;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += ResetButton_Click;

            epCheck = new ErrorProvider(components);
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epCheck.ContainerControl = this;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(grpPersonal);
            Controls.Add(grpAdditional);
            Controls.Add(btnRegister);
            Controls.Add(btnReset);
            MinimumSize = new Size(816, 499);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";

            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpAdditional.ResumeLayout(false);
            grpAdditional.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
