    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using BUS_DA;
    using DAL_DA.Model1;
    using iTextSharp.text.pdf;
    using iTextSharp.text;
    namespace frm_login
    {
        public partial class frmXuatHD : Form
        {
            string maHoaDon;
            HoadonService hoadonService = new HoadonService();
            private thuocService thuocService;
            public frmXuatHD()
            {
                InitializeComponent();
                this.maHoaDon = maHoaDon;
            }
            private TThoadon tThoadon;
            private void guna2HtmlLabel3_Click(object sender, EventArgs e)
            {

            }
            public void SetBillDetails(TThoadon tThoadon)
            {
                // Lưu đối tượng TThoadon vào biến lớp
                this.tThoadon = tThoadon;

                // Hiển thị thông tin lên các điều khiển trong form
                lblgiathuoc.Text = tThoadon.giathuoc;
                lblgiadv.Text = tThoadon.giadv;
                lbltenkh.Text = tThoadon.tenbn;
                lbltendv.Text = tThoadon.tendv;
                lbltenth.Text = tThoadon.tenthuoc;
                lblngaylap.Text = tThoadon.NgayLap;

                // Ensure proper conversion of giathuoc and giadv to decimal or double
                decimal giaThuocDecimal;
                decimal giaDichVuDecimal;

                bool isGiaThuocValid = decimal.TryParse(tThoadon.giathuoc, out giaThuocDecimal);
                bool isGiaDichVuValid = decimal.TryParse(tThoadon.giadv, out giaDichVuDecimal);

                if (isGiaThuocValid && isGiaDichVuValid)
                {
                    // Calculate the total price and display it
                    decimal totalPrice = giaThuocDecimal + giaDichVuDecimal;
                    lblgiatong.Text = totalPrice.ToString("N2");  // Display the total with 2 decimal places
                }
                else
                {
                    // Handle invalid numeric data (e.g., show an error message or set default values)
                    lblgiatong.Text = "Invalid data";
                }
            }
            private void frmXuatHD_Load(object sender, EventArgs e)
            {
           
            }

            private void guna2Button1_Click(object sender, EventArgs e)
            {




            // Ẩn nút "Xuất" trong khi đang xử lý
            guna2Button1.Visible = false;

            // Create a new PDF document
            Document doc = new Document(PageSize.A4);

            try
            {
                // Define the path where the PDF will be saved
                string filePath = "D:\\VISUAL STUDIO\\QLPKDa\\HoaDon.pdf"; // PDF will be saved on D: drive

                // Create a FileStream to write the PDF content
                PdfWriter.GetInstance(doc, new System.IO.FileStream(filePath, System.IO.FileMode.Create));

                // Open the document to write
                doc.Open();

                // Capture the screenshot of the form
                Bitmap formImage = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(formImage, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

                // Create an Image object to add to the PDF
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(formImage, System.Drawing.Imaging.ImageFormat.Bmp);

                // Set the image scale (if necessary)
                img.ScaleToFit(PageSize.A4.Width - 40, PageSize.A4.Height - 40);
                img.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

                // Add the form image to the PDF
                doc.Add(img);

                // Close the document
                doc.Close();

                // Show a message when the PDF is successfully created
                MessageBox.Show("Hoa Don has been exported to PDF successfully!");
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file path issues)
                MessageBox.Show("Error exporting PDF: " + ex.Message);
            }
            finally
            {
                // Hiển thị lại nút "Xuất" sau khi xuất xong
                guna2Button1.Visible = true;
            }






        }
        }
    }
