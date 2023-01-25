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
    class Class1
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> Parkingqueue;

        public Class1()
        {
            x = 10000;
            Parkingqueue = new Queue<string>();
                
        }
        public string
        GeneratePlateNumber(string ParkingNumber)
        {
            x++;
            ParkingNumber = ParkingNumber + x.ToString();
            return ParkingNumber;
        }

    }
}
