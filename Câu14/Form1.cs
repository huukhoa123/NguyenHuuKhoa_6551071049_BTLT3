namespace Câu14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm dùng chung để chuyển các phần tử đang được chọn từ ListBox này sang ListBox khác
        private void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            String nameSV = txtName.Text.Trim();
            if (string.IsNullOrEmpty(nameSV))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            lstLopA.Items.Add(nameSV);
            txtName.Clear();
            txtName.Focus();
        }

        // Nút chuyển các mục chọn từ Lớp A -> Lớp B (Nút ">")
        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        // Nút chuyển tất cả từ Lớp A -> Lớp B (Nút ">>")
        private void btnSangPhaiTatca_Click(object sender, EventArgs e)
        {
            while (lstLopA.Items.Count > 0)
            {
                var item = lstLopA.Items[0];
                lstLopB.Items.Add(item);
                lstLopA.Items.Remove(item);
            }
        }

        // Nút chuyển các mục chọn từ Lớp B -> Lớp A (Nút "<")
        private void btnSangTrai_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        // Nút chuyển tất cả từ Lớp B -> Lớp A (Nút "<<")
        private void btnSangTraiTatca_Click(object sender, EventArgs e)
        {
            while (lstLopB.Items.Count > 0)
            {
                var item = lstLopB.Items[0];
                lstLopA.Items.Add(item);
                lstLopB.Items.Remove(item);
            }
        }
        private void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        // Nút Xóa Lớp A
        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        // Nút Xóa Lớp B
        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        // Nút Kết thúc
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close(); // Gọi Close() để kích hoạt sự kiện FormClosing bên dưới
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt") + "   Designed by KHOA";
        }

      
    }
}