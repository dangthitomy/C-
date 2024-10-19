using System;
using System.Windows.Forms;

namespace bai20
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        // Khi nhấn nút "Quản lý sinh viên"
        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            // Mở Form quản lý sinh viên (Form1)
            Form1 form1 = new Form1();
            form1.Show(); // Hiển thị Form quản lý sinh viên
            this.Hide();  // Ẩn Form trang chủ (HomeForm)
        }

        // Nút "Thoát" - Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát chương trình
            }
        }

        // Nút "Quản lý khóa học"
      

        // Nút "Quản lý giáo viên"
        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý giáo viên đang được phát triển.", "Thông báo");
        }

        // Nút "Quản lý lớp học"
        private void btnManageClasses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý lớp học đang được phát triển.", "Thông báo");
        }

        // Nút "Quản lý điểm số"
        private void btnManageScores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý điểm số đang được phát triển.", "Thông báo");
        }

        // Nút "Đăng xuất"
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();  // Quay lại Form đăng nhập
                this.Hide();       // Ẩn HomeForm
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Tùy chỉnh thêm khi form tải
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            // Có thể thêm logic cho nhãn tiêu đề nếu cần
        }
    }
}
