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

        public MainForm()
        {
            InitializeComponent();
            CurrentColor = System.Drawing.Color.Black; // Èçìåíåíî ñ Color íà CurrentColor
            PenWidth = 3;
            èíñòğóìåíòTextBox.Text = PenWidth.ToString();
            WireUpEventHandlers();
            UpdateColorSelection();
            UpdateToolSelection();

            ñîõğàíèòüToolStripMenuItem.Enabled = false;
            ñîõğàíèòüÊàêToolStripMenuItem.Enabled = false;
        }

        private void WireUpEventHandlers()
        {
            // Existing handlers
            îÏğîãğàììåToolStripMenuItem.Click += îÏğîãğàììåToolStripMenuItem_Click;
            íîâûéToolStripMenuItem.Click += íîâûéToolStripMenuItem_Click;
            ğèñóíîêToolStripMenuItem.DropDownOpening += ğèñóíîêToolStripMenuItem_DropDownOpening;
            ğàçìåğÕîëñòàToolStripMenuItem.Click += ğàçìåğÕîëñòàToolStripMenuItem_Click;

            // Color selection handlers
            êğàñíûéToolStripMenuItem.Click += êğàñíûéToolStripMenuItem_Click;
            ñèíèéToolStripMenuItem.Click += ñèíèéToolStripMenuItem_Click;
            çåëåíûéToolStripMenuItem.Click += çåëåíûéToolStripMenuItem_Click;
            äğóãîéToolStripMenuItem.Click += äğóãîéToolStripMenuItem_Click;

            // File operations
            ñîõğàíèòüToolStripMenuItem.Click += ñîõğàíèòüToolStripMenuItem_Click;
            ñîõğàíèòüÊàêToolStripMenuItem.Click += ñîõğàíèòüÊàêToolStripMenuItem_Click;
            îòêğûòüToolStripMenuItem.Click += îòêğûòüToolStripMenuItem_Click;
            âûõîäToolStripMenuItem.Click += (s, e) => Close();

            // Window arrangement
            êàñêàäîìToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            ñëåâàÍàïğàâîToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);
            ñâåğõóÂíèçToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            óïîğÿäî÷èòüÇíà÷êèToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.ArrangeIcons);

            this.MdiChildActivate += MainForm_MdiChildActivate;
            èíñòğóìåíòTextBox.KeyDown += èíñòğóìåíòTextBox_KeyDown;

            êèñòüToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Brush;
                UpdateToolSelection();
            };

            ëèíèÿToolStripButton.Click += (s, e) =>
            {
                MainForm.CurrentTool = DrawingTool.Line;
                UpdateToolSelection();
            };

            ıëëèïñToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Ellipse;
                UpdateToolSelection();
            };

            ïğÿìîóãîëüíèêToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Rectangle;
                UpdateToolSelection();
            };

            ëàñòèêToolStripButton.Click += (s, e) => {
                CurrentTool = DrawingTool.Eraser;
                UpdateToolSelection();
            };

        }

        private void UpdateToolSelection()
        {
            êèñòüToolStripButton.Checked = (CurrentTool == DrawingTool.Brush);
            ëèíèÿToolStripButton.Checked = (CurrentTool == DrawingTool.Line);
            ıëëèïñToolStripButton.Checked = (CurrentTool == DrawingTool.Ellipse);
            ïğÿìîóãîëüíèêToolStripButton.Checked = (CurrentTool == DrawingTool.Rectangle);
            ëàñòèêToolStripButton.Checked = (CurrentTool == DrawingTool.Eraser);

            èíñòğóìåíòTextBox.Text = MainForm.PenWidth.ToString();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            // Îáíîâëÿåì ñîñòîÿíèå êíîïîê ñîõğàíåíèÿ
            ñîõğàíèòüToolStripMenuItem.Enabled = (ActiveMdiChild != null);
            ñîõğàíèòüÊàêToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }

        private void èíñòğóìåíòTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(èíñòğóìåíòTextBox.Text, out int width) && width > 0)
                {
                    PenWidth = width;
                }
                else
                {
                    èíñòğóìåíòTextBox.Text = PenWidth.ToString();
                    MessageBox.Show("Ïîæàëóéñòà, ââåäèòå ïîëîæèòåëüíîå ÷èñëî", "Îøèáêà",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void îÏğîãğàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AboutBox1();
            frmAbout.ShowDialog();
        }

        private void íîâûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DocumentForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ğèñóíîêToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ğàçìåğÕîëñòàToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }

        private void ğàçìåğÕîëñòàToolStripMenuItem_Click(object sender, EventArgs e)
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

        // Color selection methods
        private void êğàñíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
            UpdateColorSelection();
        }

        private void ñèíèéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
            UpdateColorSelection();
        }

        private void çåëåíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
            UpdateColorSelection();
        }

        private void äğóãîéToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm activeDoc)
            {
                if (string.IsNullOrEmpty(activeDoc.FilePath))
                {
                    ñîõğàíèòüÊàêToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    SaveDocument(activeDoc, activeDoc.FilePath);
                }
            }
        }

        private void ñîõğàíèòüÊàêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm activeDoc)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.AddExtension = true;
                    dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp|Ôàéëû JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
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
                MessageBox.Show($"Îøèáêà ïğè ñîõğàíåíèè: {ex.Message}", "Îøèáêà",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Èçîáğàæåíèÿ (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|Âñå ôàéëû (*.*)|*.*";

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
                        MessageBox.Show($"Îøèáêà ïğè îòêğûòèè: {ex.Message}", "Îøèáêà",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateColorSelection()
        {
            // Update visual indicators for selected color
            êğàñíûéToolStripMenuItem.Checked = (CurrentColor == Color.Red);
            ñèíèéToolStripMenuItem.Checked = (CurrentColor == Color.Blue);
            çåëåíûéToolStripMenuItem.Checked = (CurrentColor == Color.Green);
            äğóãîéToolStripMenuItem.Checked = !(CurrentColor == Color.Red ||
                                              CurrentColor == Color.Blue ||
                                              CurrentColor == Color.Green);
        }

    }
}