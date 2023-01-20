using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAFSystem
{
     class publicstuff
    {
        private static string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\flor\\Documents\\RAFSystem-RAFSystem2\\RAFSystem\\DatabaseInfo.mdf;Integrated Security=True";

        public static string con1
        {

            get { return con; }

        }

    }
}
