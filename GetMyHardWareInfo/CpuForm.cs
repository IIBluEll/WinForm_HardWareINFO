using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMyHardWareInfo
{
    public partial class CpuForm : Form
    {
        private string cpu = "Win32_Processor";
   
        Form1 baseForm = new Form1();

        public CpuForm()
        {
            InitializeComponent();

            txtModel.Text = baseForm.GetHardWareInfo(cpu, "Name");
            txtManu.Text = baseForm.GetHardWareInfo(cpu, "Manufacturer");
            txtSN.Text = baseForm.GetHardWareInfo(cpu, "SerialNumber");
        }
    }
}
