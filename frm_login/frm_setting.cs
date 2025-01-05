using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_login
{
    public partial class frm_setting : Form
    {
        public frm_setting()
        {
            InitializeComponent();
        }

      

        private void frm_setting_Load(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Đóng toàn bộ ứng dụng và mở lại từ đầu
            Application.Restart();

        }
    }
}
