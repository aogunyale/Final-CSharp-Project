using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO; //For GetCurrentDirectory()

namespace PhotoGallery
{
    public partial class Form1 : Form
    {
        string strConnectionString = "Data Source=C;Initial Catalog=Barcelona;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds;
        DataTable dtBarcelona;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCommand = "SELECT * FROM PlayerPictures";

            da = new SqlDataAdapter(strCommand, strConnectionString);
            ds = new DataSet();
            da.Fill(ds, "Sheet1"); 

            dtBarcelona = ds.Tables["Sheet1"];
            cmbImage.DataSource = dtBarcelona;
            cmbImage.DisplayMember = "playername";
            cmbImage.ValueMember = "id";
        }

        private void cmbImage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int intImageNumber = Convert.ToInt32(cmbImage.SelectedValue);
            string strFilename;
            string strDirectory = Directory.GetCurrentDirectory();

            txtAuthor.Text = dtBarcelona.Rows[intImageNumber - 1]["author"].ToString();
            strFilename = dtBarcelona.Rows[intImageNumber - 1]["filename"].ToString();

            pictureBox1.Image = Image.FromFile(strDirectory + "\\PlayerPictures\\" + strFilename);
        }
    }
}
