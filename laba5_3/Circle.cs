using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5_3
{
    public class Circle : Figure
    {
        private int radius;
        public Circle(int centerX, int centerY, int radius)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }
        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, GetRectangle());
        }
        private Rectangle GetRectangle()
        {
            return new Rectangle(centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), GetRectangle());
        }
    }
}
