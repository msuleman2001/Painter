using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter
{
    public partial class DrawingSample : Form
    {
        Graphics graphics_context;
        Pen outline;
        SolidBrush fill_color;

        //Constructor of Form
        public DrawingSample()
        {
            InitializeComponent();
            graphics_context = this.CreateGraphics();
            outline = new Pen(Color.Red);
            fill_color = new SolidBrush(Color.Green);
        }

        //Show Location of Mouse Pointer on label
        private void DrawingSample_MouseMove(object sender, MouseEventArgs e)
        {
            lblLocation.Text = "X: " + e.X.ToString() + "," + "Y:" + e.Y.ToString();
        }

        //Drawing shapes
        public void DrawShape(object sender, EventArgs e)
        {
            Button btnShape = (Button)sender;
            switch (btnShape.Text)
            {
                case "Line":
                    graphics_context.DrawLine(outline, 150, 10, 250, 100);
                    break;
                case "Circle":
                    graphics_context.DrawEllipse(outline, 300, 10, 50, 50);
                    break;
                case "Rectangle":
                    graphics_context.DrawRectangle(outline, 300, 150, 50, 50);
                    break;
                case "Polygon":
                    Point[] points = new Point[5];
                    points[0] = new Point(150, 120);
                    points[1] = new Point(120, 180);
                    points[2] = new Point(190, 180);
                    points[3] = new Point(200, 241);
                    points[4] = new Point(214, 180);
                    graphics_context.DrawPolygon(outline, points);
                    break;
                case "Arc":
                    Rectangle rect = new Rectangle(450, 50, 100, 100);
                    graphics_context.DrawArc(outline, rect, 90,100);
                    break;
                case "Curve":
                    Point[] points_curve = new Point[5];
                    points_curve[0] = new Point(250, 220);
                    points_curve[1] = new Point(220, 280);
                    points_curve[2] = new Point(290, 280);
                    points_curve[3] = new Point(300, 341);
                    points_curve[4] = new Point(314, 280);
                    graphics_context.DrawCurve(outline, points_curve);
                    break;
                case "Text":
                    Font font = new Font("Verdana", 20);
                    Point location = new Point(400, 200);
                    StringFormat draw_format = new StringFormat();
                    draw_format.FormatFlags = StringFormatFlags.DirectionVertical;
                    graphics_context.DrawString("hello world!", font, fill_color, location, draw_format);
                    break;
                case "Image":
                    PictureBox picture_box = new PictureBox();
                    picture_box.Location = new Point(550, 100);
                    picture_box.Size = new Size(200, 250);
                    picture_box.BorderStyle = BorderStyle.FixedSingle;
                    picture_box.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture_box.Image = Image.FromFile(@"E:\ImageBank\icon\png1\014-book.png");
                    this.Controls.Add(picture_box);
                    break;
            }
        }
    }
}
