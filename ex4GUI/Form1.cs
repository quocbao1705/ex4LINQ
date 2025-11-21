using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ex4LINQDTO;      
using ex4LINQBUS;     

namespace QLPhieuNhap_GUI
{
    public partial class Form1 : Form
    {
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        SanPhamBUS spBUS = new SanPhamBUS();
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        ChiTietPhieuNhapBUS ctBUS = new ChiTietPhieuNhapBUS();

        private string maSpDangSua = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxNhaCungCap();
                LoadComboBoxSanPham();
                LoadComboBoxPhieuNhap();
                LoadDataGridView();

                groupBoxChiTiet.Enabled = false;
                txtDonGia.ReadOnly = true;
                txtThanhTien.ReadOnly = true;

                dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvChiTiet.ReadOnly = true;
                dgvChiTiet.ContextMenuStrip = contextMenuStrip1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form: " + ex.Message);
            }
        }

        private void LoadComboBoxNhaCungCap()
        {
            cboNhaCungCap.DataSource = nccBUS.LayDanhSach();
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
        }

        private void LoadComboBoxSanPham()
        {
            cboMaSanPham.DataSource = spBUS.LayDanhSach();
            cboMaSanPham.DisplayMember = "TenSP";
            cboMaSanPham.ValueMember = "MaSP";
        }

        private void LoadComboBoxPhieuNhap()
        {
            cboMaPN_ChiTiet.DataSource = pnBUS.LayDanhSach();
            cboMaPN_ChiTiet.DisplayMember = "MaPN";
            cboMaPN_ChiTiet.ValueMember = "MaPN";
        }

        private void LoadDataGridView()
        {
            dgvChiTiet.DataSource = ctBUS.LayDanhSachChiTiet();

            if (dgvChiTiet.Columns["DonGia"] != null)
                dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";

            if (dgvChiTiet.Columns["MaPN"] != null) dgvChiTiet.Columns["MaPN"].HeaderText = "Mã Phiếu";
            if (dgvChiTiet.Columns["MaSP"] != null) dgvChiTiet.Columns["MaSP"].HeaderText = "Mã SP";
            if (dgvChiTiet.Columns["SoLuong"] != null) dgvChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (dgvChiTiet.Columns["DonGia"] != null) dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn Giá";
            foreach (DataGridViewColumn col in dgvChiTiet.Columns)
            {
                if (col.Name != "MaPN" && col.Name != "MaSP" &&
                    col.Name != "SoLuong" && col.Name != "DonGia")
                {
                    col.Visible = false;
                }
            }
        }

        private void UpdateTongTien(string maPN)
        {
            decimal tong = ctBUS.TinhTongTien(maPN);
            txtThanhTien.Text = tong.ToString("N0") + " VNĐ";
        }

        private void ResetChiTietControls()
        {
            cboMaSanPham.SelectedIndex = -1;
            txtSoLuong.Text = "1";
            txtDonGia.Text = "";

            maSpDangSua = null;
            btnThemSanPham.Text = "Thêm sản phẩm";

            cboMaSanPham.Enabled = true;
            cboMaPN_ChiTiet.Enabled = true;
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            string maPN = txtMaPhieuNhap.Text.Trim();
            string maNCC = cboNhaCungCap.SelectedValue?.ToString();
            DateTime ngayNhap = dtpNgayNhap.Value;

            if (string.IsNullOrEmpty(maPN) || string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin phiếu nhập.");
                return;
            }

            string ketQua = pnBUS.ThemPhieuNhap(maPN, maNCC, ngayNhap);

            if (ketQua == null)
            {
                MessageBox.Show("Lưu phiếu nhập thành công!");
                LoadComboBoxPhieuNhap();
                cboMaPN_ChiTiet.SelectedValue = maPN;
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            groupBoxPhieuNhap.Enabled = false; 
            groupBoxChiTiet.Enabled = true;    

            string maPN_tren = txtMaPhieuNhap.Text.Trim();

            if (!string.IsNullOrEmpty(maPN_tren) && cboMaPN_ChiTiet.FindStringExact(maPN_tren) != -1)
            {
                cboMaPN_ChiTiet.SelectedValue = maPN_tren;
            }
            else
            {
                if (cboMaPN_ChiTiet.Items.Count > 0)
                {
                    cboMaPN_ChiTiet.SelectedIndex = 0;
                }
            }
            cboMaPN_ChiTiet.Enabled = true;
        }
        private void cboMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSanPham.SelectedValue == null) return;

            if (cboMaSanPham.SelectedValue is string maSP)
            {
                SanPhamDTO sp = spBUS.LayTheoMa(maSP);
                if (sp != null)
                {
                    decimal gia = sp.DonGia.HasValue ? sp.DonGia.Value : 0;
                    txtDonGia.Text = gia.ToString("N0");
                }
                else
                {
                    txtDonGia.Text = "0";
                }
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (cboMaPN_ChiTiet.SelectedValue == null || cboMaSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập và sản phẩm.");
                return;
            }

            string maPN = cboMaPN_ChiTiet.SelectedValue.ToString();
            string maSP = cboMaSanPham.SelectedValue.ToString();

            int soLuong = 0;
            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là số.");
                return;
            }

            decimal donGia = 0;
            string strDonGia = txtDonGia.Text.Replace(",", "").Replace(".", "").Replace(" VNĐ", "").Trim();
            decimal.TryParse(strDonGia, out donGia);

            bool cheDoSua = (maSpDangSua != null);
            if (cheDoSua) maSP = maSpDangSua;

            string ketQua = ctBUS.ThemHoacCapNhat(maPN, maSP, soLuong, donGia, cheDoSua);

            if (ketQua == null)
            {
                LoadDataGridView();
                UpdateTongTien(maPN);
                ResetChiTietControls();

                if (cheDoSua) MessageBox.Show("Cập nhật thành công!");
                else MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMaPN_ChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaPN_ChiTiet.SelectedValue is string maPN)
            {
                UpdateTongTien(maPN);
            }
        }

        private void dgvChiTiet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvChiTiet.CurrentCell = dgvChiTiet.Rows[e.RowIndex].Cells[1];
                dgvChiTiet.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) return;

            string maPN = dgvChiTiet.CurrentRow.Cells["MaPN"].Value.ToString();
            string maSP = dgvChiTiet.CurrentRow.Cells["MaSP"].Value.ToString();
            string soLuong = dgvChiTiet.CurrentRow.Cells["SoLuong"].Value.ToString();
            string donGiaStr = dgvChiTiet.CurrentRow.Cells["DonGia"].Value.ToString();

            cboMaPN_ChiTiet.SelectedValue = maPN;
            cboMaSanPham.SelectedValue = maSP;
            txtSoLuong.Text = soLuong;

            decimal donGiaVal = 0;
            if (decimal.TryParse(donGiaStr.Replace(",", "").Replace(".", ""), out donGiaVal))
            {
                txtDonGia.Text = donGiaVal.ToString("N0");
            }
            else
            {
                txtDonGia.Text = donGiaStr;
            }

            maSpDangSua = maSP;
            btnThemSanPham.Text = "Cập nhật";

            cboMaPN_ChiTiet.Enabled = false;
            cboMaSanPham.Enabled = false;
        }

        private void menuXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) return;

            string maPN = dgvChiTiet.CurrentRow.Cells["MaPN"].Value.ToString();
            string maSP = dgvChiTiet.CurrentRow.Cells["MaSP"].Value.ToString();

            var confirm = MessageBox.Show($"Bạn muốn xóa sản phẩm {maSP} khỏi phiếu {maPN}?",
                                          "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string ketQua = ctBUS.XoaChiTiet(maPN, maSP);

                if (ketQua == null)
                {
                    LoadDataGridView();
                    UpdateTongTien(maPN);
                    MessageBox.Show("Đã xóa!");
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
            }
        }
    }
}