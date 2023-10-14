using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    class Button_with_rounded_boarders : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle MyRect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(MyRect.X, MyRect.Y, 40, 40, 180, 90);
            GraphPath.AddArc(MyRect.X + MyRect.Width - 40, MyRect.Y, 40, 40, 270, 90);
            GraphPath.AddArc(MyRect.X + MyRect.Width - 40, MyRect.Y + MyRect.Height - 40, 40, 40, 0, 90);
            GraphPath.AddArc(MyRect.X, MyRect.Y + MyRect.Height - 40, 40, 40, 90, 90);
            this.Region = new Region(GraphPath);
        }
    }
}
