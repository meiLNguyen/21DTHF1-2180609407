using Lab04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
// Hoang da o day
// Duong da o day
namespace Lab04
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<Faculty> listFalcultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember ="FacultyName";
            this.cmbFaculty.ValueMember ="FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach
            (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells["MSSV"].Value = item.StudentID;
                dgvStudent.Rows[index].Cells["FullName"].Value = item.FullName;
                dgvStudent.Rows[index].Cells["Faculty"].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells["AverageScore"].Value = item.AverageScore;
            }
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private bool IsValidName(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }

        private bool check()
        {
            string studentID = txtMSSV.Text;
            string fullname = txtFullName.Text.Trim();
            string averageScore = txtAverageScore.Text.Trim();

            // Kiểm tra mã số sinh viên
            if (string.IsNullOrEmpty(studentID) || !IsNumeric(studentID) || studentID.Length != 10)
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ. Vui lòng nhập lại (phải là số và có đủ 10 ký tự).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra họ tên
            if (string.IsNullOrEmpty(fullname) || fullname.Length < 3 || fullname.Length > 100 || !IsValidName(fullname))
            {
                MessageBox.Show("Họ tên không hợp lệ. Vui lòng nhập lại (từ 3 đến 100 ký tự, không chứa ký tự đặc biệt hoặc số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra điểm trung bình
            if (!float.TryParse(averageScore, out float score) || score < 0 || score > 10)
            {
                MessageBox.Show("Điểm trung bình không hợp lệ. Vui lòng nhập lại (phải là số từ 0 đến 10).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                var studentID = txtMSSV.Text;
                var fullname = txtFullName.Text;
                var facultyID = (int)cmbFaculty.SelectedValue;
                var averageScore = txtAverageScore.Text;

                Model1 context = new Model1();

                Student student = new Student()
                {
                    FullName = fullname,
                    FacultyID = facultyID,
                    AverageScore = double.Parse(averageScore),
                    StudentID = studentID
                };

                context.Students.Add(student);
                try
                {
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BindGrid(context.Students.ToList());
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txtMSSV.Text = dgvStudent.Rows[rowIndex].Cells["MSSV"].Value.ToString();
                txtFullName.Text = dgvStudent.Rows[rowIndex].Cells["FullName"].Value.ToString();
                txtAverageScore.Text = dgvStudent.Rows[rowIndex].Cells["AverageScore"].Value.ToString();
                cmbFaculty.Text = dgvStudent.Rows[rowIndex].Cells["Faculty"].Value.ToString();
            }
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var updateStudent = db.Students.SingleOrDefault(c => c.StudentID.Equals(txtMSSV.Text));
            if (updateStudent == null)
            {
                MessageBox.Show("Không tồn tại sinh viên có MSSV {0}", txtMSSV.Text);
                return;
            }
            updateStudent.FullName = txtFullName.Text;
            updateStudent.AverageScore = double.Parse(txtAverageScore.Text);
            updateStudent.FacultyID = (int)cmbFaculty.SelectedValue;

            db.SaveChanges();
            BindGrid(db.Students.ToList());
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 student = new Model1();
                string studentID = txtMSSV.Text;
                Student selectedStudent = student.Students.FirstOrDefault(s => s.StudentID == studentID);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    student.Students.Remove(selectedStudent);
                    student.SaveChanges();
                    MessageBox.Show("Xóa sinh viên thành công !!!");
                    List<Student> listStudents = student.Students.ToList();
                    BindGrid(listStudents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void mnFaculty_Click(object sender, EventArgs e)
        {
            frmFaculty frm = new frmFaculty();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void mnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ?", " Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
