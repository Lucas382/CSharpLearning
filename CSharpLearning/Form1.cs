using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CSharpLearning
{
    public partial class FormMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        
        public FormMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46,51,73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb =new frmDashboard() {Dock = DockStyle.Fill, TopLevel = false, TopMost= true};
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analytics";
            this.pnlFormLoader.Controls.Clear();
            frmAnalytcs frmAnalytics_Vrb = new frmAnalytcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
            frmAnalytics_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAnalytics_Vrb);
            frmAnalytics_Vrb.Show();
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            pnlNav.Left = btnCalendar.Left;
            btnCalendar.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Calendar";
            this.pnlFormLoader.Controls.Clear();
            frmCalendar frmCalendar_Vrb = new frmCalendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
            frmCalendar_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmCalendar_Vrb);
            frmCalendar_Vrb.Show();
        }
        private void btnContactus_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactus.Height;
            pnlNav.Top = btnContactus.Top;
            pnlNav.Left = btnContactus.Left;
            btnContactus.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Contact Us";
            this.pnlFormLoader.Controls.Clear();
            frmContactUS frmContact_Vrb = new frmContactUS() { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
            frmContact_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmContact_Vrb);
            frmContact_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.pnlFormLoader.Controls.Clear();
            frmSettings frmSettings_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
            frmSettings_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmSettings_Vrb);
            frmSettings_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactus_Leave(object sender, EventArgs e)
        {
            btnContactus.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void userAvatar_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Point lastPoint;
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        
        private void FormDrag_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


    }
}
