using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class PC : IPCtex
    {

        string kol = "Количесвто ПК - 4";
        string type = "Тип ПК  - игрвой  ";

        void IPCtex.see()
        {
            Console.WriteLine("///////////////// PC /////////////////////");
            Console.WriteLine(kol);
            Console.WriteLine(type);
        }

    }
}
