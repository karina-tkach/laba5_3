using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5_3
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            while (centerX + (Form1.ActiveForm.Width / 6) < Form.ActiveForm.Width-70)
            {
                DrawBlack();
                //100
                System.Threading.Thread.Sleep(50);
                HideDrawingBackGround();
                centerX++;
            }
        }
    }
}
