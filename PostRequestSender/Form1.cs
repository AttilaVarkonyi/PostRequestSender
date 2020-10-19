using System;
using System.Windows.Forms;

namespace PostRequestSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string addressString = "";
            string workString = "";
            string result = "";

            if (txtBxAddress.Text != "" && txtBxInputString.Text != "")
            {
                addressString = txtBxAddress.Text;
                workString = txtBxInputString.Text;
            }
            else
            {
                MessageBox.Show("Please fill empty area(s).");
                return;
            }

            try
            {
                result = PostRequestString.PostRequest(addressString, workString);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
            richTxtBxResponseContent.Text = result;
        }
    }
}
