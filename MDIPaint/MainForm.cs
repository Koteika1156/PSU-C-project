using System.Drawing.Imaging;

namespace MDIPaint
{
    public partial class MainForm : Form
    {
        public static Color CurrentColor { get; set; }
        public static int PenWidth { get; set; }
        public string CurrentFilePath { get; set; }

        public enum DrawingTool
        {
            Brush,
            Line,
            Ellipse,
            Rectangle,
            Eraser
        }

        public static DrawingTool CurrentTool { get; set; } = DrawingTool.Brush;
        public static bool FillShapes { get; set; } = false;

        public MainForm()
        {
            InitializeComponent();
            CurrentColor = System.Drawing.Color.Black;
            PenWidth = 3;
            toolTextBox.Text = PenWidth.ToString();
            WireUpEventHandlers();
            UpdateColorSelection();
            UpdateToolSelection();

            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
        }

        private void WireUpEventHandlers()
        {
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            drawingToolStripMenuItem.DropDownOpening += DrawingToolStripMenuItem_DropDownOpening;
            canvasSizeToolStripMenuItem.Click += CanvasSizeToolStripMenuItem_Click;

            redToolStripMenuItem.Click += RedToolStripMenuItem_Click;
            blueToolStripMenuItem.Click += BlueToolStripMenuItem_Click;
            greenToolStripMenuItem.Click += GreenToolStripMenuItem_Click;
            otherToolStripMenuItem.Click += OtherToolStripMenuItem_Click;

            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += (s, e) => Close();

            cascadeToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            tileVerticalToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);
            tileHorizontalToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            arrangeIconsToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.ArrangeIcons);

            this.MdiChildActivate += MainForm_MdiChildActivate;
            toolTextBox.KeyDown += ToolTextBox_KeyDown;

            fillToolStripButton.Click += FillToolStripButton_Click;

            brushToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Brush;
                UpdateToolSelection();
            };

            lineToolStripButton.Click += (s, e) =>
            {
                CurrentTool = DrawingTool.Line;
                UpdateToolSelection();
            };

            ellipseToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Ellipse;
                UpdateToolSelection();
            };

            rectangleToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Rectangle;
                UpdateToolSelection();
            };

            eraserToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Eraser;
                UpdateToolSelection();
            };
        }

        private void UpdateToolSelection()
        {
            brushToolStripButton.Checked = (CurrentTool == DrawingTool.Brush);
            lineToolStripButton.Checked = (CurrentTool == DrawingTool.Line);
            ellipseToolStripButton.Checked = (CurrentTool == DrawingTool.Ellipse);
            rectangleToolStripButton.Checked = (CurrentTool == DrawingTool.Rectangle);
            eraserToolStripButton.Checked = (CurrentTool == DrawingTool.Eraser);

            toolTextBox.Text = PenWidth.ToString();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = (ActiveMdiChild != null);
            saveAsToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }

        private void ToolTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(toolTextBox.Text, out int width) && width > 0)
                {
                    PenWidth = width;
                }
                else
                {
                    toolTextBox.Text = PenWidth.ToString();
                    MessageBox.Show("Please enter a positive number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AboutBox1();
            frmAbout.ShowDialog();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DocumentForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DrawingToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            canvasSizeToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }

        private void CanvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm activeDoc)
            {
                using (var sizeDialog = new CanvasSizeForm())
                {
                    sizeDialog.CanvasWidth = activeDoc.Bitmap.Width;
                    sizeDialog.CanvasHeight = activeDoc.Bitmap.Height;

                    if (sizeDialog.ShowDialog() == DialogResult.OK)
                    {
                        activeDoc.ResizeCanvas(sizeDialog.CanvasWidth, sizeDialog.CanvasHeight);
                    }
                }
            }
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
            UpdateColorSelection();
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
            UpdateColorSelection();
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
            UpdateColorSelection();
        }

        private void OtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    CurrentColor = cd.Color;
                    UpdateColorSelection();
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm activeDoc)
            {
                if (string.IsNullOrEmpty(activeDoc.FilePath))
                {
                    SaveAsToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    SaveDocument(activeDoc, activeDoc.FilePath);
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm activeDoc)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.AddExtension = true;
                    dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|PNG (*.png)|*.png";
                    dlg.DefaultExt = "bmp";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        SaveDocument(activeDoc, dlg.FileName);
                        activeDoc.Text = Path.GetFileName(dlg.FileName);
                        activeDoc.FilePath = dlg.FileName;
                    }
                }
            }
        }

        private void SaveDocument(DocumentForm doc, string filePath)
        {
            try
            {
                ImageFormat format = Path.GetExtension(filePath).ToLower() switch
                {
                    ".jpg" or ".jpeg" => ImageFormat.Jpeg,
                    ".png" => ImageFormat.Png,
                    _ => ImageFormat.Bmp,
                };

                doc.Bitmap.Save(filePath, format);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            FillShapes = fillToolStripButton.Checked;
            fillToolStripButton.Image = FillShapes ?
                Properties.Resources.fill_off :
                Properties.Resources.fill_on;
            fillToolStripButton.ToolTipText = FillShapes ?
                "Mode: outline + fill" : "Mode: outline only";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Images (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var image = Image.FromFile(dlg.FileName);
                        var frm = new DocumentForm();
                        frm.MdiParent = this;
                        frm.Bitmap = new Bitmap(image);
                        frm.Text = Path.GetFileName(dlg.FileName);
                        frm.FilePath = dlg.FileName;
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateColorSelection()
        {
            redToolStripMenuItem.Checked = (CurrentColor == Color.Red);
            blueToolStripMenuItem.Checked = (CurrentColor == Color.Blue);
            greenToolStripMenuItem.Checked = (CurrentColor == Color.Green);
            otherToolStripMenuItem.Checked = !(CurrentColor == Color.Red ||
                                            CurrentColor == Color.Blue ||
                                            CurrentColor == Color.Green);
        }
    }
}