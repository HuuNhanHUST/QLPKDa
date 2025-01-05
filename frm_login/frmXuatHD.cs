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
                                // Create a new PDF document
                                Document doc = new Document(PageSize.A4);

                                try
                                {
                                    // Define the path where the PDF will be saved
                                    string filePath = "D:\\HoaDon.pdf"; // PDF will be saved on D: drive

                                    // Create a FileStream to write the PDF content
                                    PdfWriter.GetInstance(doc, new System.IO.FileStream(filePath, System.IO.FileMode.Create));

                                    // Open the document to write
                                    doc.Open();

                                    // Add title and form details
                                    doc.Add(new Paragraph("Hoa Don Details"));
                                    doc.Add(new Paragraph("\n"));

                                    // Adding labels and values similar to the form layout
                                    PdfPTable table = new PdfPTable(2); // 2 columns (for label and value)

                                    // Add rows for each label and value
                                    table.AddCell("Ten Benh Nhan:");
                                    table.AddCell(lbltenkh.Text);

                                    table.AddCell("Ten Dich Vu:");
                                    table.AddCell(lbltendv.Text);

                                    table.AddCell("Ten Thuoc:");
                                    table.AddCell(lbltenth.Text);

                                    table.AddCell("Gia Thuoc:");
                                    table.AddCell(lblgiathuoc.Text);

                                    table.AddCell("Gia Dich Vu:");
                                    table.AddCell(lblgiadv.Text);

                                    table.AddCell("Ngay Lap:");
                                    table.AddCell(lblngaylap.Text);

                                    table.AddCell("Tong Gia:");
                                    table.AddCell(lblgiatong.Text);

                                    // Add the table to the document
                                    doc.Add(table);

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


                     }
        }
    }
