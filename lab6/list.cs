using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
   public class list
    {
      public List<translator> Translator = new List<translator>(5);
    }

    public class translator
    {
        public string Name { get; set; }
    }


}
