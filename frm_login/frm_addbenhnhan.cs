using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_DA.Model1;

namespace frm_login
{
    public partial class frm_addbenhnhan : Form
    {
        public BenhNhan benhNhan;
        private byte[] ConvertImageToByteArray(System.Drawing.Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Chọn định dạng ảnh phù hợp
                return ms.ToArray();
            }
        }
        private System.Drawing.Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        public frm_addbenhnhan(BenhNhan benhNhan = null)
        {
            InitializeComponent();
            this.benhNhan = benhNhan;

            if (benhNhan != null)
            {
                txt_id.Enabled = false; 
                // Load thông tin bệnh nhân vào form để sửa
                txt_id.Text = benhNhan.MaBenhNhan.Trim();
                txthoten.Text = benhNhan.TenBenhNhan;
                txt_phoen.Text = benhNhan.SoDienThoai;
                txt_address.Text = benhNhan.DiaChi;
                if (benhNhan.Avatar != null && benhNhan.Avatar.Length > 0)
                {
                    guna2PictureBox1.Image = ConvertByteArrayToImage(benhNhan.Avatar);
                }
                else
                {
                    guna2PictureBox1.Image = Properties.Resources.THUOC; // Ảnh mặc định
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (benhNhan == null) // Thêm mới
                {
                    benhNhan = new BenhNhan
                    {
                        MaBenhNhan = txt_id.Text,
                        TenBenhNhan = txthoten.Text,
                        SoDienThoai = txt_phoen.Text,
                        DiaChi = txt_address.Text,
                        Avatar = guna2PictureBox1.Image != null ? ConvertImageToByteArray(guna2PictureBox1.Image) : null
                    };
                }
                else 
                {
                    benhNhan.TenBenhNhan = txthoten.Text;
                    benhNhan.SoDienThoai = txt_phoen.Text;
                    benhNhan.DiaChi = txt_address.Text;
                    benhNhan.Avatar = guna2PictureBox1.Image != null ? ConvertImageToByteArray(guna2PictureBox1.Image) : null;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
