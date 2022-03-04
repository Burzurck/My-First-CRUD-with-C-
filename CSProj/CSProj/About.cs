using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSProj
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            
            richTextBox1.Select(0, 25);
            richTextBox1.SelectionColor = Color.DarkBlue;

            richTextBox1.Select(25, 195);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 10);

            richTextBox1.Select(195, 250);
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 11);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
