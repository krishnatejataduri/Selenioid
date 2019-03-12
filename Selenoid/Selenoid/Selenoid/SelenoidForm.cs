using Selenoid.SelenoidClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenoid
{
    public partial class SelenoidForm : Form
    {
        public SelenoidForm()
        {
            InitializeComponent();
            om = new ObjectManager();
            this.dataGridView_Screens.DataSource = om.getScreenData();
            this.dataGridView_Screens.MultiSelect = false;
            this.dataGridView_Screens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Screens.Rows[0].Selected = true;
            this.dataGridView_Objects.DataSource = om.getObjectData(this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString());
            this.dataGridView_Objects.MultiSelect = false;
            this.dataGridView_Objects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Creating an object of ObjectManager class
        ObjectManager om;
        int selectedRow;
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SelenoidForm_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.button_Cancel.Enabled = true;
            selectedRow = this.dataGridView_Screens.SelectedRows[0].Index;
            foreach(DataGridViewColumn col in this.dataGridView_Screens.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


                this.dataGridView_Screens.ReadOnly = false;
                //this.dataGridView2.CurrentRow.ReadOnly = false;
                foreach (DataGridViewRow row in this.dataGridView_Screens.Rows)
                {
                    if (row.Index != selectedRow)
                    {
                        row.ReadOnly = true;
                    }
                }

        }

        private void DataGridView_Screens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedScreen = this.dataGridView_Screens.CurrentRow.Cells[0].Value.ToString();
            this.dataGridView_Objects.DataSource = om.getObjectData(selectedScreen);
            this.dataGridView_Objects.Refresh();
        }

    }
}
