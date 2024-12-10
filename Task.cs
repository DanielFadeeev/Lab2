using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            lst.Items.Add("Ширина: 20");
            lst.Items.Add("Ширина: 50");
            lst.Items.Add("Ширина: 100");
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem.ToString() == "Ширина: 20")
            {
                txt.Size = new System.Drawing.Size(20, txt.Size.Height);
            }
            else if (lst.SelectedItem.ToString() == "Ширина: 50")
            {
                txt.Size = new System.Drawing.Size(50, txt.Size.Height);
            }
            else if (lst.SelectedItem.ToString() == "Ширина: 100")
            {
                txt.Size = new System.Drawing.Size(100, txt.Size.Height);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
