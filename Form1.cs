using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum
{

    public partial class FrmMain : Form
    {
        public string ConnectionString {  set; get; }

        public FrmMain()
        {
            ConnectionString =
            @"Server = (localdb)\MSSQLLocalDB;" +
            "Database = music";
            InitializeComponent();
        }
            private void FrmMain_Load(object sender, EventArgs e)
        {
            cbAlb.Enabled = false;
            txtbx.Enabled = false;
            addbnt.Enabled = false;
            addurlbnt.Enabled = false;
            editbnt.Enabled = false;
            FillComboBox_1();
        }

        private void FillRichTextBox()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var r = new SqlCommand(
                    "SELECT release " + 
                    "FROM albums,tracks " +
                    $"WHERE albums.Id=tracks.album AND tracks.id = '{int.Parse(dgv.CurrentRow.Cells[3].Value.ToString())}' ", connection).ExecuteReader();
                while (r.Read())
                {
                    richtxtbx.Text = $"Year of publication: {DateTime.Parse(r[0].ToString()).ToString("yyyy. MMMM dd.")}";
                }
                r.Close();
                var s = new SqlCommand(
                    "SELECT SUM(DATEDIFF(MINUTE, '00:00', tracks.length)) " +
                    "FROM albums,tracks " +
                    $"WHERE albums.Id=tracks.album AND albums.title LIKE '{cbAlb.SelectedItem}' " +
                    $"GROUP BY tracks.album;", connection).ExecuteReader();
                while (s.Read())
                {
                    richtxtbx.Text += $"\n{s[0]} minutes";
                }
                
            }
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var r = new SqlCommand(
                    "SELECT tracks.title, tracks.length, tracks.url, tracks.id " +
                    "FROM tracks, albums " +
                    $"WHERE albums.Id = tracks.album AND albums.title LIKE '{cbAlb.SelectedItem}%' AND tracks.title LIKE '{txtbx.Text}%' ;", connection).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
                
            }
            txtbx.Enabled = true;
        }

        private void FillComboBox_2()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var r = new SqlCommand(
                    $"SELECT title FROM albums WHERE artist LIKE '{cbArt.SelectedItem}%' ", connection).ExecuteReader();
                while (r.Read())
                {
                    cbAlb.Items.Add($"{r["title"]}");
                }
            }
        }

        private void FillComboBox_1()
        {
            
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var r = new SqlCommand(
                    "SELECT artist FROM albums GROUP BY artist",  connection).ExecuteReader();
                while (r.Read())
                {
                    cbArt.Items.Add($"{r[0]}");
                }
            }         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV();
            if (cbAlb.SelectedItem.ToString() == "Hold Your Colour")
            {
                picbx.Image = Properties.Resources.hold_your_colour;
            }
            if (cbAlb.SelectedItem.ToString() == "In Silico")
            {
                picbx.Image = Properties.Resources.in_silico;
            }
            if(cbAlb.SelectedItem.ToString() == "Immersion")
            {
                picbx.Image = Properties.Resources.immersion;
            }
            FillRichTextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAlb.Enabled = true;
            FillComboBox_2();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Cells[2].Value.ToString() == "")
            {
                link.Text = "Link not found";
                addurlbnt.Enabled = true;
            }
            else
            {
                link.Text = $"https://youtu.be/{dgv.CurrentRow.Cells[2].Value.ToString()}";
                addurlbnt.Enabled = false;
            }
            addbnt.Enabled = true;
            editbnt.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form_URL frmurl = new Form_URL(int.Parse(dgv.CurrentRow.Cells[3].Value.ToString()), ConnectionString);
            frmurl.ShowDialog();
        }

        private void editbnt_Click(object sender, EventArgs e)
        {
            FormEdit frmedit = new FormEdit(int.Parse(dgv.CurrentRow.Cells[3].Value.ToString()), ConnectionString);
            frmedit.ShowDialog();
        }
    }
}
