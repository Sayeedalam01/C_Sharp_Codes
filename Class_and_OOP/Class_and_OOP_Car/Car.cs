using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_OOP
{
    internal class Car
    {
        private int lid;
        private string model;
        private int cc;
        public void setLid(int lid) {
            this.lid = lid;
        }
        public void setModel(string model) {
            this.model = model;
        }
        public void setCc(int cc) {
            this.cc = cc;
        }

        public int getLid() { 
            return lid;
        }
        public string getModel()
        {
            return model;
        }
        public int getCc()
        {
            return cc;
        }

        public void printDetails() {
            Console.WriteLine("Car id: " + lid);
            Console.WriteLine("Car model: " + model);
            Console.WriteLine("Car cc: " + cc);
        }
    }
}
