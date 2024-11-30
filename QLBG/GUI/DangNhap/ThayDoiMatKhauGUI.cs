using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using BUS;
using OfficeOpenXml.Drawing.Slicer.Style;
using System.Windows.Interop;
namespace GUI.DangNhap
{
    public partial class ThayDoiMatKhauGUI : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        string code = null;
        string maNV = null;
        public ThayDoiMatKhauGUI()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DangNhapGUI form = new DangNhapGUI();
            form.Show();
            this.Close();
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Chưa nhập mã xác thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (code.Equals(txtMaXacThuc.Text.Trim()))
            {
                MessageBox.Show("Xác thực thành công!");
                MatKhauMoiGUI newForm = new MatKhauMoiGUI(maNV);
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã xác thực không chính xác");
                txtMaXacThuc.Text = "";
            }
        }

        private void btnLayMa_Click(object sender, EventArgs e)
        {
            string toEmail = txtEmail.Text.Trim();
            string fromEmail = "severqlbg@gmail.com";
            string fromPass = "dhfz bpdt wrnu hxoa";

            Random random = new Random();
            int randomCode = random.Next(0, 1000000);
            code = randomCode.ToString("D6");

            maNV = nvBUS.checkEmail(toEmail);
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email của tài khoản cần tìm","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (maNV == null)
            {
                MessageBox.Show("Email không được sử dụng");
                txtEmail.Text = "";
            }
            else
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("severqlbg@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = "Mã xác nhận email";
                mail.Body = $"Mã xác nhận của bạn là: {code}";
                try
                {
                    using (SmtpClient client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(fromEmail, fromPass);
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;

                        client.Send(mail);
                    }
                    MessageBox.Show("Đã gửi mã xác thực");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }
    }
}
