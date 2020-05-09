using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private List<Vertex> vertices;
        private List<Edge> edges;
        public List<Vertex> Vertices
        {
            get
            {
                return vertices;
            }
        }
        public List<Edge> Edges
        {
            get
            {
                return edges;
            }
        }
        public Graph()
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
        }
        public Graph(List<Vertex> _vertices, List<Edge> _edges)
        {
            vertices = _vertices;
            edges = _edges;
        }
    }
}
