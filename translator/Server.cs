using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Server: IPCtex
    {

        string kol = "Количесвто серверов - 5";
        string type = "Тип сервера - Tower";

        void IPCtex.see()
        {
            Console.WriteLine("///////////////// server /////////////////////");
            Console.WriteLine(kol);
            Console.WriteLine(type);
        }
    }
}
