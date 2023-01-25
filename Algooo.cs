using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_PROJ
{
    public partial class ParkingQueueForm : Form
    {

        Class1 obj = new Class1();
        public ParkingQueueForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            DisplayParkingQueue(Class1.Parkingqueue);
        }

        public void DisplayParkingQueue(IEnumerable ParkingList)
        {
            Parkinglistt.Items.Clear();
            foreach (Object obj in ParkingList)
            {
                Parkinglistt.Items.Add(obj.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Timer_tick(object sender, EventArgs e)
        {
            btnref.PerformClick();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            Class1.Parkingqueue.Dequeue();
        }
    }
}
