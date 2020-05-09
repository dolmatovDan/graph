using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        private Button start;
        private Button end;
        private Graph graph;
        public Form1()
        {
            InitializeComponent();
            start = null;
            end = null;
            btnSearch.Enabled = false;
        }
        private List<Button> get_list_buttons()
        {
            List<Button> buttons = new List<Button>();

            buttons.Add(vertex1);
            buttons.Add(vertex2);
            buttons.Add(vertex3);
            buttons.Add(vertex4);
            buttons.Add(vertex5);
            buttons.Add(vertex6);
            buttons.Add(vertex7);
            buttons.Add(vertex8);
            buttons.Add(vertex9);
            buttons.Add(vertex10);
            buttons.Add(vertex11);

            return buttons;
        }
        private List<Edge> get_list_edges(List<Vertex> vertices)
        {
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(vertices[0], vertices[1], DrawDirections.right));
            edges.Add(new Edge(vertices[0], vertices[2], DrawDirections.down));
            edges.Add(new Edge(vertices[2], vertices[3], DrawDirections.down));
            edges.Add(new Edge(vertices[3], vertices[4], DrawDirections.right));
            edges.Add(new Edge(vertices[5], vertices[4], DrawDirections.down));
            edges.Add(new Edge(vertices[5], vertices[6], DrawDirections.right));
            edges.Add(new Edge(vertices[6], vertices[7], DrawDirections.down));
            edges.Add(new Edge(vertices[7], vertices[8], DrawDirections.down));
            edges.Add(new Edge(vertices[8], vertices[9], DrawDirections.right));
            edges.Add(new Edge(vertices[9], vertices[10], DrawDirections.down));
            edges.Add(new Edge(vertices[4], vertices[8], DrawDirections.right));


            return edges;
        }
        private void init_graph()
        {
            List<Button> buttons = get_list_buttons();
            List<Vertex> vertices = new List<Vertex>();
            for(int i = 0; i < buttons.Count; i++)
            {
                vertices.Add(new Vertex(buttons[i]));
            }
            List<Edge> edges = get_list_edges(vertices);
            graph = new Graph(vertices, edges);
        }
        private void draw_horizontal_vertex(PaintEventArgs e, Pen pen, Edge edge)
        {
            Size size_X = edge.X.Btn.Size;
            size_X.Height /= 2;
            Size size_Y = edge.Y.Btn.Size;
            size_Y.Height /= 2;
            Point p1 = edge.Y.Btn.Location;
            p1.Y += size_Y.Height;
            e.Graphics.DrawLine(pen, edge.X.Btn.Location + size_X, p1);
        }
        private void draw_vertical_vertex(PaintEventArgs e, Pen pen, Edge edge)
        {
            Size size_X = edge.X.Btn.Size;
            Size size_Y = edge.Y.Btn.Size;
            size_X.Width /= 2;
            size_Y.Width /= 2;
            Point p1 = edge.X.Btn.Location + size_X;
            Point p2 = edge.Y.Btn.Location;
            p2.X += size_Y.Width;
            e.Graphics.DrawLine(pen, p1, p2);
        } 
        private void btn_pressed(Button btn)
        {
            if(start != null)
            {
                start = btn;
                start.BackColor = Color.GreenYellow;
                return;
            }
            if (end != null)
            {
                end = btn;
                end.BackColor = Color.AntiqueWhite;
            }
            if(start != null && end != null)
            {
                btnSearch.Enabled = true;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            init_graph();
            using (var black_pen = new Pen (Color.Black, 15))
            {
                for(int i = 0; i < graph.Edges.Count; i++)
                {
                    switch (graph.Edges[i].Draw_Directions)
                    {
                        case DrawDirections.down:
                            draw_vertical_vertex(e, black_pen, graph.Edges[i]);
                            graph.Edges[i].Length = Math.Abs(graph.Edges[i].X.Btn.Location.Y - graph.Edges[i].Y.Btn.Location.Y);
                            break;
                        case DrawDirections.right:
                            draw_horizontal_vertex(e, black_pen, graph.Edges[i]);
                            graph.Edges[i].Length = Math.Abs(graph.Edges[i].X.Btn.Location.X - graph.Edges[i].Y.Btn.Location.X);
                            break;
                    }
                }
            }
        }

        private void vertex1_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex1);
        }

        private void vertex2_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex2);
        }

        private void vertex3_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex3);
        }

        private void vertex4_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex4);
        }

        private void vertex6_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex6);
        }

        private void vertex7_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex7);
        }

        private void vertex5_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex5);
        }

        private void vertex8_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex8);
        }

        private void vertex9_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex9);
        }

        private void vertex10_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex10);
        }

        private void vertex11_Click(object sender, EventArgs e)
        {
            btn_pressed(vertex11);
        }
    }
}
