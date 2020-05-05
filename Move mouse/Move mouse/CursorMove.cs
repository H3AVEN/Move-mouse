using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MoveCursor()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 100, Cursor.Position.Y);
            Thread.Sleep(5);
            Cursor.Position = new Point(Cursor.Position.X + 100, Cursor.Position.Y);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int interval = Convert.ToInt32(txtInterval.Text);
            this.WindowState = FormWindowState.Minimized;
            while(true)
            {
                Thread.Sleep(interval * 1000);
                MoveCursor();
            }
        }
    }
}
