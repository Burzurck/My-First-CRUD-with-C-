using CSProj.Helpers;
using System;
using System.Data;
using System.Windows.Forms;

namespace CSProj
{
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable returndata = DataHelper.FindMovie(txtMovieTitle.Text);
            if (returndata.Rows.Count > 0)
            {
                txtId.Text = returndata.Rows[0].ItemArray[0].ToString();
                txtMovieTitle.Text = returndata.Rows[0].ItemArray[1].ToString();
                txtYear.Text = returndata.Rows[0].ItemArray[2].ToString();
                txtDirector.Text = returndata.Rows[0].ItemArray[3].ToString();
                comboGenre.SelectedIndex = Convert.ToInt32(returndata.Rows[0].ItemArray[4].ToString()) - 1;
                txtRottenTomatoesScore.Text = returndata.Rows[0].ItemArray[5].ToString();
                txtBoxOfficeEarnings.Text = returndata.Rows[0].ItemArray[6].ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DataHelper.DeleteMovie(Convert.ToInt32(txtId.Text));
                }
                this.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtMovieTitle.Text = string.Empty;
            txtDirector.Text = string.Empty;
            txtBoxOfficeEarnings.Text = string.Empty;
            txtRottenTomatoesScore.Text = string.Empty;
            txtYear.Text = string.Empty;
            comboGenre.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
