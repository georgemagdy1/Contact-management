using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Gender", "Gender");

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text,comboBox1.Text);
            ClearTextBoxes();
            ClearTextBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[selectedIndex].Cells["Name"].Value = textBox1.Text;
                dataGridView1.Rows[selectedIndex].Cells["Email"].Value = textBox3.Text;
                dataGridView1.Rows[selectedIndex].Cells["Phone"].Value = textBox2.Text;
                dataGridView1.Rows[selectedIndex].Cells["Gender"].Value = textBox3.Text;
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select a row to edit");
            }
        }
    }
    }

