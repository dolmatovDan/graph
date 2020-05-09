using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Edge
    {
        private Vertex x;
        private Vertex y;
        private DrawDirections draw_directions;
        private int lenght;
        public Vertex X
        {
            get
            {
                return x;
            }
        }
        public Vertex Y
        {
            get
            {
                return y;
            }
        }
        public DrawDirections Draw_Directions
        {
            get
            {
                return draw_directions;
            }
            set
            {
                draw_directions = value; ;
            }
        }
        public int Length
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value;
            }
        }
        public Edge(Vertex _x, Vertex _y)
        {
            x = _x;
            y = _y;
            draw_directions = DrawDirections.right;
            lenght = 0;
        }
        public Edge(Vertex _x, Vertex _y, DrawDirections _draw_directions)
        {
            x = _x;
            y = _y;
            draw_directions = _draw_directions;
            lenght = 0;
        }
        public Edge(Vertex _x, Vertex _y, DrawDirections _draw_directions, int _length)
        {
            x = _x;
            y = _y;
            draw_directions = _draw_directions;
            lenght = _length;
        }
    }
}
