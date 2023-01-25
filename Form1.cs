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
    public partial class parkingsystemform : Form
    {
        private Class1 parking = new Class1();
        public parkingsystemform()
        {
            InitializeComponent();
            parking = new Class1();
            ParkingQueueForm obj = new ParkingQueueForm();
            obj.Show();

        }

        private void generate_Click(object sender, EventArgs e)
        {
            tb1.Text = parking.GeneratePlateNumber("DSA- ");
            Class1.getNumberInQueue = tb1.Text;

            Class1.Parkingqueue.Enqueue(Class1.getNumberInQueue);
        }
    }
    
}
