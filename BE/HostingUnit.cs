using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class HostingUnit : Clonable
    {
        public int HostingUnitKey { get; set; }
        public Host Owner { get; set; }
        public string HostingUnitName { get; set; }
        internal Diary Diary { get; set ; }
        public override string ToString()
        {
            return base.ToString();//not imlemented yet
        }
    }
}
