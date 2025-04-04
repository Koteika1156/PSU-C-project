using System.Drawing.Imaging;
using static MDIPaint.MainForm;

namespace MDIPaint
{
    public partial class DocumentForm : Form
    {
        private Cursor[] _toolCursors;
        private Point _startPoint;
        private bool _isDrawing = false;
        private Bitmap _mainBitmap;
        private Bitmap _previewBitmap;
        private Point _lastPoint;
        private Point _currentMousePos;
        public string FilePath { get; set; }
        private bool _isModified = false;

        public bool IsModified
        {
            get => _isModified;
            set
            {
                _isModified = value;
                UpdateTitle();
            }
        }

        public Bitmap Bitmap
        {
            get => _mainBitmap;
            set
            {
                _mainBitmap?.Dispose();
                _mainBitmap = value;
                IsModified = true;
                Invalidate();
            }
        }

        private void UpdateTitle()
        {
            string title = string.IsNullOrEmpty(FilePath) ? "Untitled" : Path.GetFileName(FilePath);
            if (_isModified) title += " *";
            this.Text = title;
        }

        public DocumentForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(600, 600);
            ClearCanvas();

            _toolCursors = new Cursor[]
            {
                Cursors.Cross,
                Cursors.Arrow,
                Cursors.Hand,
                Cursors.UpArrow,
                Cursors.Default
            };

            this.MouseDown += DocumentForm_MouseClick;
            this.MouseMove += DocumentForm_MouseMove;
            this.MouseUp += DocumentForm_MouseUp;
            this.DoubleBuffered = true;

            UpdateCursor();
            UpdateTitle();
        }
        public void UpdateCursor()
        {
            this.Cursor = _toolCursors[(int)MainForm.CurrentTool];
        }
        public bool PromptToSave()
        {
            if (!_isModified) return true;

            string fileName = string.IsNullOrEmpty(FilePath) ? "Untitled" : Path.GetFileName(FilePath);
            var result = MessageBox.Show(
                $"Do you want to save changes to {fileName}?",
                "MDI Paint",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(FilePath))
                {
                    using (var saveDialog = new SaveFileDialog())
                    {
                        saveDialog.Filter = "Windows Bitmap (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|PNG (*.png)|*.png";
                        saveDialog.DefaultExt = "bmp";
                        saveDialog.FileName = fileName;

                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            SaveToFile(saveDialog.FileName);
                            return true;
                        }
                        return false;
                    }
                }
                else
                {
                    SaveToFile(FilePath);
                    return true;
                }
            }
            return result != DialogResult.Cancel;
        }
        public void SaveToFile(string filePath)
        {
            try
            {
                ImageFormat format = Path.GetExtension(filePath).ToLower() switch
                {
                    ".jpg" or ".jpeg" => ImageFormat.Jpeg,
                    ".png" => ImageFormat.Png,
                    _ => ImageFormat.Bmp,
                };

                Bitmap.Save(filePath, format);
                FilePath = filePath;
                IsModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void DocumentForm_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateCursor();
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