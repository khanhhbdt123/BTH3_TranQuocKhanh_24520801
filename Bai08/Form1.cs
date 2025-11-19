using System.Globalization;
using System.Net;
using System.Xml.Linq;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapNhatSTTVaTien()
        {
            int sttHienTai = 1;
            long total = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                item.Text = sttHienTai.ToString();
                long tien;
                if (long.TryParse(item.SubItems[4].Text, out tien))
                {
                    total += tien;
                    item.SubItems[4].Text = tien.ToString();
                }
                sttHienTai++;
            }
            lblTongTien1.Text = total.ToString();
        }
        private void btnTvCN_Click(object sender, EventArgs e)
        {
            string stk = tbSTK.Text.Trim();
            string ten = tbTenKH.Text.Trim();
            string diachi = tbDC.Text.Trim();
            string tien = tbTien.Text.Trim();
            if (string.IsNullOrEmpty(stk) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(tien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi");
                return;
            }
            ListViewItem tontaiSTK = null;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.Equals(stk, StringComparison.OrdinalIgnoreCase))
                {
                    tontaiSTK = item;
                    break;
                }
            }
            if (tontaiSTK == null)
            {
                int sttTiepTheo = listView1.Items.Count + 1;
                var lvi = new ListViewItem(sttTiepTheo.ToString());
                lvi.SubItems.Add(stk);
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(diachi);
                lvi.SubItems.Add(tien);
                listView1.Items.Add(lvi);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
            }
            else
            {
                tontaiSTK.SubItems[2].Text = ten;
                tontaiSTK.SubItems[3].Text = diachi;
                tontaiSTK.SubItems[4].Text = tien;
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
            }
            CapNhatSTTVaTien();
            tbSTK.Clear(); tbTenKH.Clear(); tbDC.Clear(); tbTien.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string stkCanXoa = tbSTK.Text.Trim();
            if (string.IsNullOrEmpty(stkCanXoa))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản cần xóa vào ô 'Số tài khoản'.", "Lỗi");
                return;
            }
            ListViewItem ktstkCanXoa = null;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.Equals(stkCanXoa, StringComparison.OrdinalIgnoreCase))
                {
                    ktstkCanXoa = item;
                    break;
                }
            }
            if (ktstkCanXoa != null)
            {
                var xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản " + stkCanXoa + " không?", "Xác nhận Xóa", MessageBoxButtons.YesNo);
                if (xacnhan == DialogResult.Yes)
                {
                    listView1.Items.Remove(ktstkCanXoa);
                    CapNhatSTTVaTien();
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo");
                    tbSTK.Clear(); tbTenKH.Clear(); tbDC.Clear(); tbTien.Clear();
                }
                else return;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                tbSTK.Text = selectedItem.SubItems[1].Text;
                tbTenKH.Text = selectedItem.SubItems[2].Text;
                tbDC.Text = selectedItem.SubItems[3].Text;
                tbTien.Text = selectedItem.SubItems[4].Text;
            }
        }
    }
}