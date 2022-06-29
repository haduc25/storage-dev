using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Custom_ProGress : ProgressBar
    {
        public Custom_ProGress()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics graphics = pe.Graphics;
            ProgressBarRenderer.DrawHorizontalBar(graphics, rect);
            if (this.Value > 0)
            {
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round(((float)this.Value / this.Maximum) * rect.Width), rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(graphics, clip);
            }
            using (Font f = new Font("Arial", 10, FontStyle.Regular))
            {
                SizeF size = graphics.MeasureString(string.Format("{0} %", this.Value), f);
                Point location = new Point((int)((rect.Width / 2) - (size.Width / 2)), (int)((rect.Height / 2) - (size.Height / 2) + 2));
                graphics.DrawString(string.Format("{0} %", this.Value), f, Brushes.Black, location);
            }
        }
    }
}
