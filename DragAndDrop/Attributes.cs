using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public class Attributes
    {
        public int AccessModifier { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }

        public Attributes(string name) 
        {
            AccessModifier = 0;
            Name = name;
            DataType = "void";
        }

        //bude slouzit pro nacitani ze souboru
        public Attributes(int accessModifier, string name, string dataType)
        {
            AccessModifier = accessModifier;
            Name = name;
            DataType = dataType;
        }
    }
}
