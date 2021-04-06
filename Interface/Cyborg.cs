using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Cyborg : ICar, IPerson
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        /* int Move(int distance) // Можно сделать общий метод
{
  return distance / 50;
}*/

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
    }
}
