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
        string strConnectionString = "Data Source=(local);Initial Catalog=UPBSoccer;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dtUPBSoccerlist;

        string getPlayerById = "Select * from UPBSoccer where Id = {0} ";
        string updatePlayerById = "Update UPBSoccer set player_name = {0}, player_num = {1}, biography = {2}, year = {3}, gplayed = {4}, gstarted = {5}, goals = {6}, assist = {7}, filename = {8}, position = {9}   where Id = {10}";
        string deletePlayerByID = "delete from UPBSoccer where Id = {0}";
        string searchPlayer = "Select top 15 * from UPBSoccer ";
        string addPlayer = "insert into UPBSoccer (player_name, player_num, bio, year, gplayed, gstarted, goals, assist, filename, position) values ({0}, {1}, {2}, {3}, {4}, {5}, {7}, {8}, {9}, {10})";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCommand = "SELECT * FROM UPBSoccer";

            da = new SqlDataAdapter(strCommand, strConnectionString);
            ds = new DataSet();
            da.Fill(ds, "UPBSoccer");

            dtUPBSoccerlist = ds.Tables["UPBSoccer"];
            cmbImage.DataSource = dtUPBSoccerlist;
            cmbImage.DisplayMember = "playername";
            cmbImage.ValueMember = "id";
        }

        private void cmbImage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int intImageNumber = Convert.ToInt32(cmbImage.SelectedValue);
            string strFilename;
            string strDirectory = Directory.GetCurrentDirectory();

            txtYear.Text = dtUPBSoccerlist.Rows[intImageNumber - 1]["Year"].ToString();
            bioTextBox.Text = dtUPBSoccerlist.Rows[intImageNumber - 1]["biography"].ToString();
            gpTextBox.Text = dtUPBSoccerlist.Rows[intImageNumber - 1]["games played"].ToString();
            gsTextBox.Text = dtUPBSoccerlist.Rows[intImageNumber - 1]["games started"].ToString();
            goalsTextBox.Text = dtUPBSoccerlist.Rows[intImageNumber - 1]["Goals"].ToString();
            assistTextBox.Text = dtUPBSoccerlist.Rows[intImageNumber - 1]["assist"].ToString();
            strFilename = dtUPBSoccerlist.Rows[intImageNumber - 1]["filename"].ToString();

            pictureBox1.Image = Image.FromFile(strDirectory + "\\UPBSoccer\\" + strFilename);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtYear.Text = String.Empty;
            bioTextBox.Text = String.Empty;
            gpTextBox.Text = String.Empty;
            gsTextBox.Text = String.Empty;
            goalsTextBox.Text = String.Empty;
            assistTextBox.Text = String.Empty;
        }

        private void search_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(String.Format(searchPlayer, txtYear.Text), strConnectionString);
            ds = new DataSet();
            da.Fill(ds, "UPBSoccer");

            dtUPBSoccerlist = ds.Tables["UPBSoccer"];
            cmbImage.DataSource = dtUPBSoccerlist;
            cmbImage.DisplayMember = "player name";
            cmbImage.ValueMember = "id";

            string strFilename;
            string strDirectory = Directory.GetCurrentDirectory();

            txtYear.Text = dtUPBSoccerlist.Rows[0]["Year"].ToString();
            bioTextBox.Text = dtUPBSoccerlist.Rows[0]["biography"].ToString();
            gpTextBox.Text = dtUPBSoccerlist.Rows[0]["games played"].ToString();
            gsTextBox.Text = dtUPBSoccerlist.Rows[0]["games started"].ToString();
            goalsTextBox.Text = dtUPBSoccerlist.Rows[0]["Goals"].ToString();
            assistTextBox.Text = dtUPBSoccerlist.Rows[0]["assist"].ToString();
            strFilename = dtUPBSoccerlist.Rows[0]["filename"].ToString();

            pictureBox1.Image = Image.FromFile(strDirectory + "\\UPBSoccer\\" + strFilename);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            string strCommand = "UPDATE UPBSoccerlist SET games played = @games played WHERE games started = @games started";
            SqlCommand command = new SqlCommand(strCommand, conn);
            command.Parameters.AddWithValue("@games played", gpTextBox.Text);
            command.Parameters.AddWithValue("@games started", gsTextBox.Text);
            conn.Open();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }



    }
}
