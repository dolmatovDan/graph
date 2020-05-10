using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Pair
    {
        Vertex vertex; //если не указываем идентификатор доступа, то по умолчанию private
        int lenght;

        public Vertex Vertex
        {
            get
            {
                return vertex;
            }
        }
        public int Lenght
        {
            get { return lenght; }
        }

        public Pair(Vertex _vertex, int _lenght)
        {
            vertex = _vertex;
            lenght = _lenght;
        }
    }
}
