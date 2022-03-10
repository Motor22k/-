using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Импортозамещение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string url_forgot = "http://google.com"; //сменить сайт

            try
            {
                Process.Start(url_forgot);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url_forgot = url_forgot.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url_forgot) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url_forgot);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url_forgot);
                }
                else
                {
                    throw;
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
