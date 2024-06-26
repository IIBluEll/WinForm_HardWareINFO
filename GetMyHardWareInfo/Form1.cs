using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace GetMyHardWareInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string GetHardWareInfo(string wmiClass, string wmiProperty)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher($"SELECT {wmiProperty} FROM {wmiClass}");

                foreach(ManagementObject obj in searcher.Get())
                {
                    if(obj[wmiProperty] != "")
                    {
                        return obj[wmiProperty]?.ToString();
                    }
                    else
                    {
                        return "N/A";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"에러가 발생했습니다. 에러 코드 : {ex.Message}");
            }

            return "N/A";
        }

        private void cpuBtn_Click(object sender, EventArgs e)
        {
            CpuForm cpuForm = new CpuForm();
            cpuForm.Show();
        }
    }

   
}
