namespace MDIPaint
{
    public partial class DocumentForm : Form
    {
        private int x, y;
        private Bitmap _bitmap;

        public Bitmap Bitmap
        {
            get => _bitmap;
            set
            {
                _bitmap?.Dispose();
                _bitmap = value;
                Invalidate();
            }
        }

        public string FilePath { get; set; }
        public bool IsSaved { get; set; }

        public DocumentForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(300, 200);
            ClearCanvas();
            this.MouseDown += DocumentForm_MouseDown;
            this.MouseMove += DocumentForm_MouseMove;
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
            x = e.X;
            y = e.Y;
        }

        private void DocumentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(Bitmap))
                {
                    // Используем PenWidth из MainForm
                    g.DrawLine(new Pen(MainForm.Color, MainForm.PenWidth), x, y, e.X, e.Y);
                }
                Invalidate();
                x = e.X;
                y = e.Y;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(Bitmap, 0, 0);
        }
    }
}