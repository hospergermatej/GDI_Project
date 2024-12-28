using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public class Methods
    {
        public int AccessModifier { get; set; }
        public string Name { get; set; }
        public string ReturnType { get; set; }

        public List<string> Arguments { get; set; }

        public Methods(string name)
        {
            AccessModifier=0;
            Name = name;
            ReturnType = "";
            
        }

        public Methods(int accessModifier, string name, string returnType, List<string> arguments)
        {
            AccessModifier = accessModifier;
            Name = name;
            ReturnType = returnType;
            Arguments = arguments;
        }
    }
}
