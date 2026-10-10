namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            epCheck.Clear();
            var isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống.");
                isValid = false;
            }

            if (!string.Equals(txtPassword.Text, txtConfirmPassword.Text, StringComparison.Ordinal))
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu xác nhận không khớp.");
                isValid = false;
            }

            if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-18))
            {
                epCheck.SetError(dtpBirthDate, "Bạn phải đủ 18 tuổi.");
                isValid = false;
            }

            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Vui lòng đồng ý với điều khoản dịch vụ.");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetButton_Click(object? sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpBirthDate.Value = DateTime.Today;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkTerms.Checked = false;
            epCheck.Clear();
        }
    }
}
