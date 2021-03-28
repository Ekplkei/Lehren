using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Сериализация_XML_Json
{
    [DataContract] // Json
    public class Student
    {
        [DataMember] public string Name { get; set; }
        [DataMember] public int Age { get; set; }
        public Group Group { get; set; }
        public Student(string name, int age)
        {
            // Проверка входных параметров
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}