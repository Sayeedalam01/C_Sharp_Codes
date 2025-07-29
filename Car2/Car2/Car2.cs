using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{

    internal class Car2
    {
        private int lid;
        private string model;
        private string color;

        private int cc;

        public int Cc { get; set; }

        public string Color {
            set { color = value; }
            get { return color; }
        }

        public string Model{ get; set; }
        public int Lid {
            set { lid = value; }
            get { return lid; }
        }
    }
}
