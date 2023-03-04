using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw1Practice
{
    //internal - виден внутри сборки
    internal class Person
    {
        //private - виден только внутри класса
        private string _name;
        //свойство Name
        public string Name
        {
            get
            {
                return _name;   
            }

            set
            {
                //value - передаваемый параметр
                _name = value;  
            }
        }
        public Person(string name)
        {
            _name = name;
        }
    }
}
