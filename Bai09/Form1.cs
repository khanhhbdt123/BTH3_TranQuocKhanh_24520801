using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai09
{

    public partial class Form1 : Form
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
            cbCN.SelectedIndex = 0;
            lbDaChon.Items.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = danhSachSinhVien;
        }
        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSinhVien;
        }
        private void XoaThongTinNhap()
        {
            tbMSV.Clear();
            tbHT.Clear();
            cbCN.SelectedIndex = 0;
            chbGT1.Checked = false;
            chbGT2.Checked = false;
            lbDaChon.Items.Clear();
            tbMSV.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lbCanChon.SelectedItem != null)
            {
                string monHoc = lbCanChon.SelectedItem.ToString();
                if (!lbDaChon.Items.Contains(monHoc))
                {
                    lbDaChon.Items.Add(monHoc);
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (lbDaChon.SelectedItem != null)
            {
                lbDaChon.Items.Remove(lbDaChon.SelectedItem);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMSV.Text) || string.IsNullOrEmpty(tbHT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ Tên.", "Lỗi");
                return;
            }
            foreach (SinhVien sv in danhSachSinhVien)
            {
                if (sv.MSSV == tbMSV.Text)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại, vui lòng nhập mã khác.", "Lỗi");
                    return;
                }
            }
            string gioiTinh = "";
            if (chbGT1.Checked) gioiTinh = "Nam";
            else if (chbGT2.Checked) gioiTinh = "Nữ";
            else
            {
                MessageBox.Show("Thiếu Giới Tính. Vui lòng chọn lại Giới Tính.", "Lỗi");
                return;
            }
            SinhVien svMoi = new SinhVien
                {
                    MSSV = tbMSV.Text,
                    HoTen = tbHT.Text,
                    ChuyenNganh = cbCN.SelectedItem.ToString(),
                    GioiTinh = gioiTinh
                };
            foreach (var item in lbDaChon.Items)
            {
                svMoi.MonHocDaChon.Add(item.ToString());
            }
            danhSachSinhVien.Add(svMoi);
            CapNhatDataGridView();
            XoaThongTinNhap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lbDaChon.Items.Clear();
        }

        private void chbGT1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGT1.Checked) chbGT2.Checked = false;
        }

        private void chbGT2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGT2.Checked) chbGT1.Checked = false;
        }
    }
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string ChuyenNganh { get; set; }
        public string GioiTinh { get; set; }
        public List<string> MonHocDaChon { get; set; } = new List<string>();

        public int SoMon
        {
            get { return MonHocDaChon.Count; }
        }
    }
}
