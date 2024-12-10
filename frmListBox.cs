using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void lst_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lst.SelectedItem.ToString() == "черный")
            {
                txt.BackColor = System.Drawing.Color.Black;
            }
            else if (lst.SelectedItem.ToString() == "красный")
            {
                txt.BackColor = System.Drawing.Color.Red;
            }
            else if (lst.SelectedItem.ToString() == "синий")
            {
                txt.BackColor = System.Drawing.Color.Blue;
            }
            else if (lst.SelectedItem.ToString() == "зеленый")
            {
                txt.BackColor = System.Drawing.Color.Green;
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void taskBtn_Click(object sender, System.EventArgs e)
        {
            Task task = new Task();
            task.Show();
        }
    }
}
