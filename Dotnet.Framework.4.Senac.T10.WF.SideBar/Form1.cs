using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dotnet.Framework._4.Senac.T10.WF.SideBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool submenuExpandida = false;  

        bool sidebarExpandida =true;
        private void dashboard_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSubmenu.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandida)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 64)
                {
                    sidebarExpandida = false;
                    timerSidebar.Stop();
                    return;


                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 204)
                {
                    sidebarExpandida = true;
                    timerSidebar.Stop();
                    return;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timerSubmenu_Tick(object sender, EventArgs e)
        {
            if (submenuExpandida)
            {
                submenu.Height -= 10;
                if(submenu.Height <= 81)
                {
                    submenuExpandida = false;
                    timerSubmenu.Stop();
                }
            }
            else
            {
                submenu.Height += 10;
                if(submenu.Height >= 249)
                {
                    submenuExpandida = true;
                    timerSubmenu.Stop();
                }
                
            }
        }
    }
}
