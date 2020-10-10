using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTestThirdPrj
{
    public class Dialog
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Dialog(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
    }
}
