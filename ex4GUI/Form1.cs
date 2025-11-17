//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using ex4BUS;
//using ex4DAO;
//using QLPhieuNhap_BUS;

//namespace ex4GUI
//{
//    public partial class FormNhapHang : Form
//    {
//        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
//        SanPhamBUS spBUS = new SanPhamBUS();
//        NhaCungCapBUS nccBUS = new NhaCungCapBUS();

//        private string MaPNCurrent = string.Empty;
//        public FormNhapHang()
//        {
//            InitializeComponent();
//            LoadInitialData();
//            SetInitialFormState();
//        }

//        private void LoadInitialData()
//        {
//            cboNhaCungCap.DataSource = nccBUS.GetDanhSachNhaCungCap();
//            cboNhaCungCap.DisplayMember = "TenNCC";
//            cboNhaCungCap.ValueMember = "MaNCC";
//            cboNhaCungCap.SelectedIndex = -1;

//            cboMaSanPham.DataSource = spBUS.GetDanhSachSanPham();
//            cboMaSanPham.DisplayMember = "TenSP";
//            cboMaSanPham.ValueMember = "MaSP";
//            cboMaSanPham.SelectedIndex = -1;
//        }
//        private void FormNhapHang_Load(object sender, EventArgs e)
//        {
//            LoadInitialData();
//        }
//        private void SetInitialFormState()
//        {
//            txtMaPhieuNhap.ReadOnly = true;
//            dtpNgayNhap.Enabled = false;
//            cboNhaCungCap.Enabled = false;
//            txtThanhTien.ReadOnly = true;
//            button_LuuPhieu.Enabled = false;
//            button_TaoPhieu.Enabled = true;

//            groupBoxChiTiet.Enabled = false;
//        }

//        private void textBox_MaPN_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void combobox_NhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void dateTimePicker_NgayNhap_ValueChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox_ThanhTien_TextChanged(object sender, EventArgs e)
//        {

//        }
//        private void button_TaoPhieu_Click(object sender, EventArgs e)
//        {
//            txtMaPhieuNhap.Text = string.Empty;
//            txtThanhTien.Text = string.Empty;
//            cboNhaCungCap.SelectedIndex = -1;

//            txtMaPhieuNhap.ReadOnly = false;
//            txtMaPhieuNhap.Focus();
//            dtpNgayNhap.Enabled = true;
//            cboNhaCungCap.Enabled = true;

//            button_TaoPhieu.Enabled = false;
//            button_LuuPhieu.Enabled = true;

//            groupBoxChiTiet.Enabled = false;

//            MessageBox.Show("Vui lòng nhập Mã Phiếu Nhập, chọn Nhà cung cấp và Lưu phiếu.", "Thông báo");
//        }

//        private void button_LuuPhieu_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(txtMaPhieuNhap.Text))
//            {
//                MessageBox.Show("Mã Phiếu Nhập không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                txtMaPhieuNhap.Focus();
//                return;
//            }
//            if (cboNhaCungCap.SelectedValue == null)
//            {
//                MessageBox.Show("Vui lòng chọn Nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            MaPNCurrent = txtMaPhieuNhap.Text;

//            PhieuNhapDTO pnDTO = new PhieuNhapDTO
//            {
//                MaPN = MaPNCurrent,
//                NgayNhap = dtpNgayNhap.Value,
//                MaNCC = cboNhaCungCap.SelectedValue.ToString()
//            };

//            if (pnBUS.insert(pnDTO))
//            {
//                MessageBox.Show("Lưu Phiếu Nhập thành công! Bạn có thể thêm Chi tiết sản phẩm.", "Thành công");

//                txtMaPhieuNhap.ReadOnly = true;
//                button_LuuPhieu.Enabled = false;
//                dtpNgayNhap.Enabled = false;
//                cboNhaCungCap.Enabled = false;

//                groupBoxChiTiet.Enabled = true;

//            }
//            else
//            {
//                MessageBox.Show("Lưu Phiếu Nhập thất bại. Có thể Mã PN đã tồn tại hoặc lỗi kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void comboBox_MaPN_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void combobox_MaSP_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (cboMaSanPham.SelectedValue != null && cboMaSanPham.SelectedIndex != -1)
//            {
//                string maSP = cboMaSanPham.SelectedValue.ToString();

//                SanPhamDTO sp = spBUS.GetSanPhamByMaSP(maSP);

//                if (sp != null)
//                {
//                    txtDonGia.Text = sp.DonGia.ToString("N0");
//                }
//            }
//            else
//            {
//                txtDonGia.Text = "0";
//            }
//        }

//        private void textbox_DonGia_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textbox_SoLuong_TextChanged(object sender, EventArgs e)
//        {

//        }
//        private void button4_Click(object sender, EventArgs e)
//        {
//            if (cboMaSanPham.SelectedValue == null || !int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0 ||
//        !decimal.TryParse(txtDonGia.Text.Replace(",", "").Replace(".", ""), out decimal donGia) || donGia <= 0)
//            {
//                MessageBox.Show("Vui lòng kiểm tra lại Số lượng (> 0) và Đơn giá.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            ChiTietDTO ct = new ChiTietDTO
//            {
//                MaPN = MaPNCurrent,
//                MaSP = cboMaSanPham.SelectedValue.ToString(),
//                SoLuong = soLuong,
//                DonGia = donGia
//            };
//            if (pnBUS.ThemChiTietPhieuNhap(ct))
//            {
//                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");

//                DisplayAllData();

//                cboMaSanPham.SelectedIndex = -1;
//                txtDonGia.Text = "0";
//                txtSoLuong.Text = "0";
//            }
//            else
//            {
//                MessageBox.Show("Thêm sản phẩm thất bại. Có thể sản phẩm đã tồn tại trong phiếu nhập này.", "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void button_In_Click(object sender, EventArgs e)
//        {

//        }

//        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }
//        private void DisplayChiTiet(string maPN)
//        {
//            List<ChiTietDTO> chiTietList = pnBUS.GetChiTiet(maPN);
//            dgvChiTiet.DataSource = chiTietList;

//            decimal tongTien = chiTietList.Sum(c => c.ThanhTien);

//            txtThanhTien.Text = tongTien.ToString("N0");
//        }
//        private void DisplayAllData()
//        {
//            DisplayChiTiet(MaPNCurrent);

//        }

//        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
//        {

//        }

//        private void btnThemSanPham_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
using QLPhieuNhap_BUS; // Using BUS
using QLPhieuNhap_DAO; // Using DAO (cho DTO)
using System;
using System.Windows.Forms;
using ex4DAO;

namespace QLPhieuNhap_GUI
{
    public partial class Form1 : Form
    {
        // Khởi tạo các BUS
        NhaCungCap_BUS nccBUS = new NhaCungCap_BUS();
        SanPham_BUS spBUS = new SanPham_BUS();
        PhieuNhap_BUS pnBUS = new PhieuNhap_BUS();
        ChiTietPhieuNhap_BUS ctBUS = new ChiTietPhieuNhap_BUS();

        // Biến trạng thái
        private string maSpDangSua = null; // null = chế độ Thêm, "SPxxx" = chế độ Sửa

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Tải ComboBox
            LoadComboBoxNhaCungCap();
            LoadComboBoxSanPham();
            LoadComboBoxPhieuNhap();
            LoadDataGridView();

            // 2. Cài đặt trạng thái ban đầu
            groupBoxChiTiet.Enabled = false;
            txtThanhTien.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.ReadOnly = true; // Chỉ cho xem
        }

        #region HÀM CHUNG
        private void LoadComboBoxPhieuNhap()
        {
            cboMaPN_ChiTiet.DataSource = pnBUS.LayDanhSach();
            cboMaPN_ChiTiet.DisplayMember = "MaPN";
            cboMaPN_ChiTiet.ValueMember = "MaPN";
            cboMaPN_ChiTiet.SelectedIndex = -1; // Không chọn gì ban đầu
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


        private void LoadDataGridView()
        {
            dgvChiTiet.DataSource = ctBUS.LayDanhSachChiTiet();
            if (dgvChiTiet.Columns["DonGia"] != null)
                dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";

            dgvChiTiet.Columns["MaPN"].HeaderText = "Mã Phiếu";
            dgvChiTiet.Columns["MaSP"].HeaderText = "Mã SP";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn Giá";
        }
        private void UpdateTongTien(string maPN)
        {
            decimal tong = ctBUS.TinhTongTien(maPN);
            txtThanhTien.Text = tong.ToString("N0");
        }

        private void ResetChiTietControls()
        {
            cboMaSanPham.SelectedIndex = 0; // Về sản phẩm đầu tiên
            txtSoLuong.Text = "1";
            maSpDangSua = null; // Trở về chế độ Thêm
            btnThemSanPham.Text = "Thêm sản phẩm";
            cboMaSanPham.Enabled = true;
        }

        #endregion

        #region SỰ KIỆN HEADER

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            string maPN = txtMaPhieuNhap.Text;
            string maNCC = cboNhaCungCap.SelectedValue.ToString();
            DateTime ngayNhap = dtpNgayNhap.Value;

            string ketQua = pnBUS.ThemPhieuNhap(maPN, maNCC, ngayNhap);

            if (ketQua == null) // Nếu lưu thành công
            {
                MessageBox.Show("Lưu phiếu nhập thành công!", "Thông báo");

                // --- BẠN THÊM 2 DÒNG NÀY ---
                LoadComboBoxPhieuNhap(); // Tải lại danh sách ComboBox phiếu nhập
                cboMaPN_ChiTiet.SelectedValue = maPN; // Tự động chọn phiếu vừa lưu
                                                      // -----------------------------
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

            // Tự động chọn phiếu nhập ở trên (nếu có)
            string maPN_tren = txtMaPhieuNhap.Text;
            if (!string.IsNullOrEmpty(maPN_tren) && cboMaPN_ChiTiet.FindStringExact(maPN_tren) != -1)
            {
                cboMaPN_ChiTiet.SelectedValue = maPN_tren;
            }
            else
            {
                // Nếu không có, chọn phiếu đầu tiên
                if (cboMaPN_ChiTiet.Items.Count > 0)
                    cboMaPN_ChiTiet.SelectedIndex = 0;
            }
        }

        #endregion

        #region SỰ KIỆN CHI TIẾT

        private void cboMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dừng lại nếu ComboBox chưa tải xong
            if (cboMaSanPham.SelectedValue == null) return;

            // Đảm bảo SelectedValue là kiểu string (đôi khi bị lỗi
            // DataRowView trong lần tải đầu tiên)
            if (!(cboMaSanPham.SelectedValue is string)) return;

            string maSP = cboMaSanPham.SelectedValue.ToString();
            SanPham sp = spBUS.LayTheoMa(maSP); // spBUS đã được khai báo

            if (sp != null)
            {
                // Dùng .Value và .ToString("N0") để định dạng
                // "N0" sẽ hiển thị 15000000 thành "15,000,000"
                txtDonGia.Text = sp.DonGia.HasValue ? sp.DonGia.Value.ToString("N0") : "0";
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            string maPN = cboMaPN_ChiTiet.Text;
            string maSP;
            int soLuong;
            decimal donGia;

            // Kiểm tra nhập
            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }
            if (!decimal.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }

            // Kiểm tra xem đang "Sửa" hay "Thêm"
            bool dangSua = (maSpDangSua != null);
            maSP = dangSua ? maSpDangSua : cboMaSanPham.SelectedValue.ToString();

            // Gọi BUS
            string ketQua = ctBUS.ThemHoacCapNhat(maPN, maSP, soLuong, donGia, dangSua);

            if (ketQua == null) // Thành công
            {
                LoadDataGridView();
                UpdateTongTien(maPN);
                ResetChiTietControls();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region SỰ KIỆN DATA GRID VIEW (SỬA / XÓA)

        private void menuXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có dòng nào được chọn không
            if (dgvChiTiet.CurrentRow == null) return;

            // 2. Lấy khóa chính (MaPN và MaSP) từ dòng đang được chọn
            string maPN = dgvChiTiet.CurrentRow.Cells["MaPN"].Value.ToString();
            string maSP = dgvChiTiet.CurrentRow.Cells["MaSP"].Value.ToString();

            // 3. Hiển thị hộp thoại xác nhận
            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm '{maSP}' của phiếu '{maPN}'?",
                                          "Xác nhận xóa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            // 4. Chỉ thực hiện nếu người dùng nhấn "Yes"
            if (confirm == DialogResult.Yes)
            {
                // 5. Gọi BUS để xóa
                string ketQua = ctBUS.XoaChiTiet(maPN, maSP); // ctBUS là ChiTietPhieuNhap_BUS

                if (ketQua == null) // Nếu BUS trả về null (thành công)
                {
                    // 6. Tải lại DataGridView để hiển thị danh sách mới
                    LoadDataGridView();

                    // 7. Cập nhật lại tổng tiền (của phiếu vừa bị xóa)
                    UpdateTongTien(maPN);
                }
                else
                {
                    // 8. Hiển thị lỗi nếu BUS báo lỗi
                    MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void menuSua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có dòng nào được chọn không
            if (dgvChiTiet.CurrentRow == null) return;

            // 2. Lấy dữ liệu từ các ô trong dòng đang được chọn
            string maPN = dgvChiTiet.CurrentRow.Cells["MaPN"].Value.ToString();
            string maSP = dgvChiTiet.CurrentRow.Cells["MaSP"].Value.ToString();
            string soLuong = dgvChiTiet.CurrentRow.Cells["SoLuong"].Value.ToString();

            // Lấy đơn giá (và định dạng lại cho đẹp)
            decimal donGia = (decimal)dgvChiTiet.CurrentRow.Cells["DonGia"].Value;

            // 3. Đổ dữ liệu này lên các control ở GroupBox "Chi tiết"
            cboMaPN_ChiTiet.SelectedValue = maPN;
            cboMaSanPham.SelectedValue = maSP;
            txtSoLuong.Text = soLuong;
            txtDonGia.Text = donGia.ToString("N0"); // "N0" để format số (ví dụ: 15,000,000)

            // 4. Chuyển sang "chế độ Sửa"

            // Đặt biến trạng thái (biến này đã được khai báo ở đầu Form)
            maSpDangSua = maSP;

            // Đổi chữ trên nút "Thêm" thành "Cập nhật"
            btnThemSanPham.Text = "Cập nhật";

            cboMaPN_ChiTiet.Enabled = false;    
            cboMaSanPham.Enabled = false;
        }
        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
