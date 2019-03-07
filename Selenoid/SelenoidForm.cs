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
        }
        //Creating an object of ObjectManager class
        ObjectManager om = new ObjectManager();
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            om.ScreenName = comboBox_ScreenName.Text;
            om.ObjectName = textBox_ObjectName.Text;
            om.ObjectType = comboBox_ObjectType.Text;
            om.LocatorType = comboBox_LocatorType.Text;
            om.LocatorValue = textBox_LocatorValue.Text;

            //Inserting data into database using the Insert method in ObjectManager class
            bool success = om.Insert(om);
            if (success == true)
            {
                MessageBox.Show("Object "+om.ObjectName+"added successfully");
            }
            else
            {
                MessageBox.Show("Error while adding object. Please try again.");
            }
        }
    }
}
