using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Device
    {
        public string Name { get; set; }
        public bool State { get; set; }
        public Device()
        {
            State = false;
        }
        public void SwitchOn()
        {
            if (State == false)
            {
                State = true;
            }
        }
        public void SwitchOff()
        {
            if (State == true)
            {
                State = false;
            }
        }
    }
}
