using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }
        private void MovePenal(Control btn)
        {
            panelSlide.Top= btn.Top;
            panelSlide.Height= btn.Height;
        }
        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            DialogResult result =MessageBox.Show("Are you want log out?","log out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult.Yes==result)
            {
                timer1.Stop();
            this.Close();
            }    
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePenal(buttonDashboard);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePenal(buttonClient);
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePenal(buttonRoom);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePenal(buttonReservation);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePenal(buttonSetting);
        }
    }
}
