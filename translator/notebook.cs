using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class notebook : IPCtex
    {

        string kol = "Количесвто ноутбуков - 4";
        string type = "Тип ноутбука  - игрвой  ";

        void IPCtex.see()
        {
            Console.WriteLine("///////////////// notebook /////////////////////");
            Console.WriteLine(kol);
            Console.WriteLine(type);
        }

    }

}
