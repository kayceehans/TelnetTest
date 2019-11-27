using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telnet
{
    class NumberInput:TextInput
    {
        public override void Add(string x)
        {
            base.Add(x);

            TextInput input = new TextInput();

            input.Add("a");
        }
    }
}
