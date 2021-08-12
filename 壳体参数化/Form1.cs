using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterizationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void openMaterialPropertyFileDialogBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openMaterialPropertyFileDialog = new OpenFileDialog();
            openMaterialPropertyFileDialog.Title = "请选择新的材料属性文件";
            openMaterialPropertyFileDialog.Filter = "*.sldmat|*.sldmat";
            openMaterialPropertyFileDialog.RestoreDirectory = true;
            if (openMaterialPropertyFileDialog.ShowDialog() == DialogResult.OK)
            {

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
