using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NSTP_Management_System
{
    public partial class frmStudentInfocs : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\uvo\Desktop\record.accdb");
        int chck;

        public frmStudentInfocs()
        {
            InitializeComponent();
        }
        void dataviewer()
        {
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from record";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void frmStudentInfocs_Load(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into record(Studentno,LastName,FirstName,TypeStudent,NstpProgram,Email,SubjectProf,SectionCourse)values('" + txtSN.Text + "','" + txtLN.Text + "','" + txtFN.Text + "','" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + txtEmail.Text + "', '" + txtSP.Text + "', '" + txtCN.Text + "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record save", "Info Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update record set Studentno='" + txtSN.Text + "' where LastName ='" + txtLN.Text + "' and FirstName = '" + txtFN.Text + "' ";

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataviewer();
            txtSN.Text = "";
            txtLN.Text = "";
            txtFN.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            txtEmail.Text = "";
            txtSP.Text = "";
            txtCN.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSN.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtLN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtFN.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtSP.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtCN.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete *from record where Studentno='" + txtSN.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Successfully Delete", "Record Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
                txtSN.Text = "";
                txtLN.Text = "";
                txtFN.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                txtEmail.Text = "";
                txtSP.Text = "";
                txtCN.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Record Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
    }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            chck = 0;
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from record where Studentno='" + txtSearch.Text + "' or LastName ='" + txtSearch.Text + "' or FirstName ='" + txtSearch.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                chck = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                conn.Close();

                if (chck == 0)
                {
                    MessageBox.Show("Record not found", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        } 

        }
    }
