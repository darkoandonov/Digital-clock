using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int hr, min, sec;
        

        public Form1()
        {
            InitializeComponent();

            hr = DateTime.UtcNow.Hour;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hr = DateTime.UtcNow.Hour;
            hr =hr+2;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
            
            if (sec % 2 == 0)
            {
                time.Text = hr + ":" + min + ":" + sec;
            }
            else
            {
                time.Text = hr + " " + min + " " + sec;
            }

        }
        
    }
}
