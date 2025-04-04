using static MDIPaint.MainForm;

namespace MDIPaint
{
    public partial class DocumentForm : Form
    {
        private Point _startPoint;
        private bool _isDrawing = false;
        private Bitmap _mainBitmap;
        private Bitmap _previewBitmap;
        private Point _lastPoint;
        private Rectangle _currentShape;
        private Point _currentMousePos;

        public Bitmap Bitmap
        {
            get => _mainBitmap;
            set
            {
                _mainBitmap?.Dispose();
                _mainBitmap = value;
                Invalidate();
            }
        }

        public string FilePath { get; set; }
        public bool IsSaved { get; set; }

        public DocumentForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(600, 600);
            ClearCanvas();
            this.MouseDown += DocumentForm_MouseDown;
            this.MouseMove += DocumentForm_MouseMove;
            this.MouseUp += DocumentForm_MouseUp;
            this.DoubleBuffered = true;
        }

        private void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                g.Clear(Color.White);
            }
        }

        public void ResizeCanvas(int newWidth, int newHeight)
        {
            if (newWidth <= 0 || newHeight <= 0) return;

            Bitmap newBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White);
                g.DrawImage(Bitmap, 0, 0);
            }

            Bitmap = newBitmap;
            Invalidate();
        }

        private void DocumentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _startPoint = e.Location;
                _currentMousePos = e.Location;
                _lastPoint = e.Location;

                if (MainForm.CurrentTool == DrawingTool.Line ||
                    MainForm.CurrentTool == DrawingTool.Rectangle ||
                    MainForm.CurrentTool == DrawingTool.Ellipse)
                {
                    _previewBitmap = (Bitmap)_mainBitmap.Clone();
                    _isDrawing = true;
                }
                else if (MainForm.CurrentTool == DrawingTool.Brush ||
                         MainForm.CurrentTool == DrawingTool.Eraser)
                {
                    DrawBrushPoint(e.Location);
                }
            }
        }

        private void DocumentForm_MouseMove(object sender, MouseEventArgs e)
        {
            _currentMousePos = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                if (MainForm.CurrentTool == DrawingTool.Brush ||
                    MainForm.CurrentTool == DrawingTool.Eraser)
                {
                    DrawBrushLine(_lastPoint, e.Location);
                    _lastPoint = e.Location;
                }
                else if (_isDrawing)
                {
                }

                Invalidate();
            }
        }

        private Rectangle GetCurrentShape(Point start, Point end)
        {
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);

            return new Rectangle(x, y, width, height);
        }

        private void DocumentForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                using (Graphics g = Graphics.FromImage(Bitmap))
                {
                    Pen pen = new Pen(MainForm.CurrentColor, MainForm.PenWidth);
                    Brush brush = new SolidBrush(MainForm.CurrentColor);
                    Rectangle rect = GetRectangle(_startPoint, e.Location);

                    switch (MainForm.CurrentTool)
                    {
                        case DrawingTool.Line:
                            g.DrawLine(pen, _startPoint, e.Location);
                            break;
                        case DrawingTool.Rectangle:
                            if (MainForm.FillShapes)
                                g.FillRectangle(brush, rect);
                            g.DrawRectangle(pen, rect);
                            break;
                        case DrawingTool.Ellipse:
                            if (MainForm.FillShapes)
                                g.FillEllipse(brush, rect);
                            g.DrawEllipse(pen, rect);
                            break;
                    }
                }
                _isDrawing = false;
                _previewBitmap?.Dispose();
                _previewBitmap = null;
            }
            Invalidate();
        }

        private Rectangle GetRectangle(Point start, Point end)
        {
            return new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(start.X - end.X),
                Math.Abs(start.Y - end.Y));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(Bitmap, 0, 0);

            if (_isDrawing && _previewBitmap != null)
            {
                e.Graphics.DrawImage(_previewBitmap, 0, 0);
                using (Pen pen = new Pen(MainForm.CurrentColor, MainForm.PenWidth))
                using (Brush brush = new SolidBrush(MainForm.CurrentColor))
                {
                    Rectangle rect = GetRectangle(_startPoint, _currentMousePos);

                    switch (MainForm.CurrentTool)
                    {
                        case DrawingTool.Line:
                            e.Graphics.DrawLine(pen, _startPoint, _currentMousePos);
                            break;
                        case DrawingTool.Rectangle:
                            if (MainForm.FillShapes)
                                e.Graphics.FillRectangle(brush, rect);
                            e.Graphics.DrawRectangle(pen, rect);
                            break;
                        case DrawingTool.Ellipse:
                            if (MainForm.FillShapes)
                                e.Graphics.FillEllipse(brush, rect);
                            e.Graphics.DrawEllipse(pen, rect);
                            break;
                    }
                }
            }
        }

        private void DrawBrushPoint(Point point)
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                Color drawColor = MainForm.CurrentTool == DrawingTool.Eraser ? Color.White : MainForm.CurrentColor;
                int size = MainForm.PenWidth;

                g.FillRectangle(new SolidBrush(drawColor),
                               point.X - size / 2,
                               point.Y - size / 2,
                               size,
                               size);
            }
        }

        private void DrawBrushLine(Point start, Point end)
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                Color drawColor = MainForm.CurrentTool == DrawingTool.Eraser ? Color.White : MainForm.CurrentColor;
                int size = MainForm.PenWidth;
                var brush = new SolidBrush(drawColor);

                float distance = (float)Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));

                int steps = Math.Max(1, (int)distance / (size / 2));

                for (int i = 0; i <= steps; i++)
                {
                    float ratio = (float)i / steps;
                    int x = (int)(start.X + (end.X - start.X) * ratio);
                    int y = (int)(start.Y + (end.Y - start.Y) * ratio);

                    g.FillRectangle(brush,
                                  x - size / 2,
                                  y - size / 2,
                                  size,
                                  size);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _previewBitmap?.Dispose();
                _mainBitmap?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}