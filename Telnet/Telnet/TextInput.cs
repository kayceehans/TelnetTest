using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telnet
{
    class TextInput
    {
        string myProeprty;
        public virtual void Add(char x)
        {
           
            var myValue = 12;
            List<char> newIput = new List<char>();
            newIput.Add(x);
            foreach (var item in newIput)
            {
                myProeprty = myValue.ToString() + x;
            }
            
          
        }

        public int CharCounter(string MyCount)
        {
            var lengthofChar = MyCount.Length;

            return lengthofChar;
        }



    }
}
