using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public class generic : Object, IList
    {


        list list_ = new list();

        //add
        void IList.add()
        {

            Console.WriteLine("///////////////////  Добавление  /////////////////////////////");
            list_.Translator.Add(new translator() { Name = "Cервер" });
            list_.Translator.Add(new translator() { Name = "ПК" });
            list_.Translator.Add(new translator() { Name = "Ноутбук" });
            foreach (translator p in list_.Translator)
            {
                Console.WriteLine(p.Name);
            }

        }

        //insert
        void IList.insert()
        {

            Console.WriteLine("/////////////////////////////////////  Добавление в определённое место  ///////////////////////////////");
            list_.Translator.Insert(0, new translator() { Name = "Мышка " });
            foreach (translator p in list_.Translator)
            {
                Console.WriteLine(p.Name);
            }

        }

        //remove
        void IList.Remove()
        {

            Console.WriteLine("////////////////////////  Удаление из листа  //////////////////");
            list_.Translator.RemoveAt(0);
            foreach (translator p in list_.Translator)
            {
                Console.WriteLine(p.Name);
            }


        }

        //clear
        void IList.Clear()
        {

            Console.WriteLine("///////////////////////// Удаление из листа 2  /////////////////////////");

            list_.Translator.RemoveAt(0);
            //list_.Translator.RemoveAll(5);
            foreach (translator p in list_.Translator)
            {
                Console.WriteLine(p.Name);
            }

        }

        //sort
        void IList.Sort()
        {

            Console.WriteLine("//////////////////////  Сортировка  ////////////////////////");

            //list_.Translator.Sort();

            list_.Translator.Reverse();
            foreach (translator p in list_.Translator)
            {
                Console.WriteLine(p.Name);
            }
           
        }


    }
}
