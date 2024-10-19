using System.Drawing;
using System.Windows.Forms;

namespace bai20
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvEmployees;
        private TextBox tbID;
        private TextBox tbName;
        private TextBox tbAge;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit; // Nút sửa
        private Button btnExit;
        private Label lblID;
        private Label lblName;
        private Label lblAge;
        private Label lblGender;

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
            dgvEmployees = new DataGridView();
            tbID = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnExit = new Button();
            lblID = new Label();
            lblName = new Label();
            lblAge = new Label();
            lblGender = new Label();
            SuspendLayout();

            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "Mã SV", Width = 100, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "Age", HeaderText = "Tuổi", Width = 50, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "Gender", HeaderText = "Giới tính", Width = 80, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }
            });
            dgvEmployees.Location = new Point(20, 20);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(540, 150);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;

            // 
            // tbID
            // 
            tbID.Location = new Point(80, 210);
            tbID.Name = "tbID";
            tbID.Size = new Size(120, 27);
            tbID.TabIndex = 1;

            // 
            // tbName
            // 
            tbName.Location = new Point(260, 210);
            tbName.Name = "tbName";
            tbName.Size = new Size(120, 27);
            tbName.TabIndex = 2;

            // 
            // tbAge
            // 
            tbAge.Location = new Point(440, 210);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(50, 27);
            tbAge.TabIndex = 3;

            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(100, 250);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 5;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;

            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(160, 250);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 6;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;

            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(320, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;

            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(490, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;

            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(405, 290);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;

            // 
            // btnExit
            // 
            btnExit.Location = new Point(575, 290);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;

            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(20, 210);
            lblID.Name = "lblID";
            lblID.Size = new Size(33, 20);
            lblID.TabIndex = 1;
            lblID.Text = "Mã:";

            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(220, 210);
            lblName.Name = "lblName";
            lblName.Size = new Size(35, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Tên:";

            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(400, 210);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Tuổi:";

            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(20, 250);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Giới tính:";

            // 
            // Form1
            // 
            ClientSize = new Size(680, 400);
            Controls.Add(dgvEmployees);
            Controls.Add(lblID);
            Controls.Add(tbID);
            Controls.Add(lblName);
            Controls.Add(tbName);
            Controls.Add(lblAge);
            Controls.Add(tbAge);
            Controls.Add(lblGender);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
