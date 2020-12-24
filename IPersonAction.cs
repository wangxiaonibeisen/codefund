using System;
using System.Collections.Generic;
using System.Text;

namespace System.MyPersonInferface
{
     interface IPersonAction
    {
        static bool isPerson = true;
        string Name { get; set; }
        int Age { get; set; }
        string Sex { get; set; }
        void Eat();
        void Sleep();
        void PrintInfo();
        
    }
}
