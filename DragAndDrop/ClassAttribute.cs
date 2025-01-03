using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public class ClassAttribute
    {
        public int AccessModifier { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }
        

        public ClassAttribute(string name) 
        {
            AccessModifier = 0;
            Name = name;
            DataType = "void";
        }

        public ClassAttribute()
        {
            
        }

        //bude slouzit pro nacitani ze souboru
        public ClassAttribute(int accessModifier, string name, string dataType)
        {
            AccessModifier = accessModifier;
            Name = name;
            DataType = dataType;
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
            return $"{GetAccessModifierSymbol()} {DataType} : {Name}";
        }
    }
}
