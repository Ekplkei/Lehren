using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;

namespace Сериализация_XML_Json
    /*В бинарном и soup сериализуются все (приватные и публичные)
      В XML сериализуются публичные (приватные не сериализуются)
      В Json нужно отдельно отмечать каждое свойство, которое нужно сериализовать*/
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();
            for (int i = 1; i < 10; i++)
            {
                groups.Add(new Group(i, "Группа " + i));
            }

            for (int i = 0; i < 300; i++)
            {
                var studen = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };
                students.Add(studen);
            }
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
#pragma warning disable SYSLIB0011 // Тип или член устарел
                binFormatter.Serialize(file, groups);
#pragma warning restore SYSLIB0011 // Тип или член устарел
            }

            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
#pragma warning disable SYSLIB0011 // Тип или член устарел
                List<Group> newGroups = binFormatter.Deserialize(file) as List<Group>;
#pragma warning restore SYSLIB0011 // Тип или член устарел

                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            //var soap = new SoapFormatter
        }
    }
}
