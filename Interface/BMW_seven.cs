using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class BMW_seven : ICar
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
