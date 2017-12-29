using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksk ksk = new Ksk();
            Apartment apartment1 = new Apartment();

            //добавляем свет в квартиру
            apartment1.device1 = new Device { Name = "Lamp1" };

            //КСК отключило свет
            ksk.SwitchOff(apartment1.device1);
            Console.WriteLine("Состояние устройства " + apartment1.device1.Name + ": " + apartment1.device1.State);

            //КСК включило свет
            ksk.SwitchOn(apartment1.device1);
            Console.WriteLine("Состояние устройства " + apartment1.device1.Name + ": " + apartment1.device1.State);

            Console.ReadLine();
        }
    }
}
