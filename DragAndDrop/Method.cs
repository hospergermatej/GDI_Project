using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public class Method
    {
        public int AccessModifier { get; set; }
        public string Name { get; set; }
        public string ReturnType { get; set; }

        public List<string> Arguments { get; set; }

        public Method(string name)
        {
            AccessModifier=0;
            Name = name;
            ReturnType = "";

        }

        public Method()
        {
            
        }

        public Method(int accessModifier, string name, string returnType, List<string> arguments)
        {
            AccessModifier = accessModifier;
            Name = name;
            ReturnType = returnType;
            Arguments = arguments;
        }

        private string GetAccessModifierSymbol()
        {
            return AccessModifier switch
            {
                0 => "+",
                1 => "-",
                2 => "#",
                _ => "+"
            };
        }

        public override string ToString()
        {
            string argumentsString = Arguments != null ? string.Join(" , ", Arguments) : string.Empty;
            return $"{GetAccessModifierSymbol()} {ReturnType} : {Name} , {argumentsString}";
        }
    }
}
