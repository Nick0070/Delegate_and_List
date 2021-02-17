using System;

namespace lab5
{
    class main
    {
        delegate void Message();



        static void Main(string[] args)
        {
 
            IPCtex PCtex1 = new Server();
            IPCtex PCtex2 = new notebook();
            IPCtex PCtex3 = new PC();

            PCtex1.see();
            PCtex2.see();
            PCtex3.see();


            //lab6
            Console.WriteLine("//////// lab 6 ////////////");

            Console.WriteLine("Просмотр листа");

            Message mes;

            IList  PCtex4 = new generic();
            mes = PCtex4.add;
            mes += PCtex4.Clear;
            mes += PCtex4.insert;
            mes += PCtex4.Remove;
            mes += PCtex4.Sort;
            mes();

           



        }

    }
}
