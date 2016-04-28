using System;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenNet
{
    partial class CreatingForm : Form
    {
        Point begin, end;
        Rectangle selected;
        Image screenshot;

        internal CreatingForm()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
                gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.Location, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            BackgroundImage = bmp;
        }
        protected override void OnClosed(EventArgs e)
        {
            AppContext.FinishCreating(screenshot);
            Dispose();
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();//OnLostFocus(EventArgs.Empty);
        }

        #region Selection
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            begin = e.Location;
            selected = new Rectangle(e.Location, Size.Empty);
            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            end = e.Location;
            Point LeftTop = new Point(Math.Min(begin.X, end.X), Math.Min(begin.Y, end.Y));
            Size RectSize = new Size(Math.Max(begin.X, end.X) - LeftTop.X, Math.Max(begin.Y, end.Y) - LeftTop.Y);
            selected = new Rectangle(LeftTop, RectSize);
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            end = e.Location;
            selected = Rectangle.Empty;
            Invalidate();
            if (Math.Abs(begin.X - end.X) < 20 && Math.Abs(begin.Y - end.Y) < 20)
                return;

            screenshot = new Bitmap(Math.Abs(end.X - begin.X), Math.Abs(end.Y - begin.Y));
            using (Graphics gr = Graphics.FromImage(screenshot))
            {
                Rectangle r = new Rectangle(Math.Min(begin.X, end.X), Math.Min(begin.Y, end.Y), Math.Abs(end.X - begin.X), Math.Abs(end.Y - begin.Y));
                gr.DrawImage(BackgroundImage, -r.X, -r.Y);
            }
            Close();
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Brush br = new SolidBrush(Color.FromArgb(128, Color.White)))
            {
                int x1 = selected.X;
                int y1 = selected.Y;
                int x2 = selected.X + selected.Width;
                int y2 = selected.Y + selected.Height;
                e.Graphics.FillRectangle(br, new Rectangle(0, 0, x1, Screen.PrimaryScreen.Bounds.Height));
                e.Graphics.FillRectangle(br, new Rectangle(x2, 0, Screen.PrimaryScreen.Bounds.Width - x2, Screen.PrimaryScreen.Bounds.Height));
                e.Graphics.FillRectangle(br, new Rectangle(x1, 0, x2 - x1, y1));
                e.Graphics.FillRectangle(br, new Rectangle(x1, y2, x2 - x1, Screen.PrimaryScreen.Bounds.Height - y2));
            }
            using (Pen pen = new Pen(Brushes.Red, .5F))
                e.Graphics.DrawRectangle(pen, selected);
        }
    }
}