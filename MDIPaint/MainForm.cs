using System.Drawing.Imaging;

namespace MDIPaint
{
    public partial class MainForm : Form
    {
        public static Color Color { get; set; }
        public static int PenWidth { get; set; }
        public string CurrentFilePath { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Color = Color.Black;
            PenWidth = 3;
            ����������TextBox.Text = PenWidth.ToString();
            WireUpEventHandlers();
            UpdateColorSelection();

            ���������ToolStripMenuItem.Enabled = false;
            ������������ToolStripMenuItem.Enabled = false;
        }

        private void WireUpEventHandlers()
        {
            // Existing handlers
            ����������ToolStripMenuItem.Click += ����������ToolStripMenuItem_Click;
            �����ToolStripMenuItem.Click += �����ToolStripMenuItem_Click;
            �������ToolStripMenuItem.DropDownOpening += �������ToolStripMenuItem_DropDownOpening;
            ������������ToolStripMenuItem.Click += ������������ToolStripMenuItem_Click;

            // Color selection handlers
            �������ToolStripMenuItem.Click += �������ToolStripMenuItem_Click;
            �����ToolStripMenuItem.Click += �����ToolStripMenuItem_Click;
            �������ToolStripMenuItem.Click += �������ToolStripMenuItem_Click;
            ������ToolStripMenuItem.Click += ������ToolStripMenuItem_Click;

            // File operations
            ���������ToolStripMenuItem.Click += ���������ToolStripMenuItem_Click;
            ������������ToolStripMenuItem.Click += ������������ToolStripMenuItem_Click;
            �������ToolStripMenuItem.Click += �������ToolStripMenuItem_Click;
            �����ToolStripMenuItem.Click += (s, e) => Close();

            // Window arrangement
            ��������ToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            ������������ToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);
            ����������ToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            �����������������ToolStripMenuItem.Click += (s, e) => LayoutMdi(MdiLayout.ArrangeIcons);

            this.MdiChildActivate += MainForm_MdiChildActivate;
            ����������TextBox.KeyDown += ����������TextBox_KeyDown;
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            // ��������� ��������� ������ ����������
            ���������ToolStripMenuItem.Enabled = (ActiveMdiChild != null);
            ������������ToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }

        private void ����������TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(����������TextBox.Text, out int width) && width > 0)
                {
                    PenWidth = width;
                }
                else
                {
                    ����������TextBox.Text = PenWidth.ToString();
                    MessageBox.Show("����������, ������� ������������� �����", "������",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AboutBox1();
            frmAbout.ShowDialog();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DocumentForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void �������ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ������������ToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color = Color.Red;
            UpdateColorSelection();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color = Color.Blue;
            UpdateColorSelection();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color = Color.Green;
            UpdateColorSelection();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Color = cd.Color;
                    UpdateColorSelection();
                }
            }
        }
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm activeDoc)
            {
                if (string.IsNullOrEmpty(activeDoc.FilePath))
                {
                    ������������ToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    SaveDocument(activeDoc, activeDoc.FilePath);
                }
            }
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is DocumentForm activeDoc)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.AddExtension = true;
                    dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp|����� JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
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
                MessageBox.Show($"������ ��� ����������: {ex.Message}", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "����������� (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|��� ����� (*.*)|*.*";

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
                        MessageBox.Show($"������ ��� ��������: {ex.Message}", "������",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateColorSelection()
        {
            // Update visual indicators for selected color
            �������ToolStripMenuItem.Checked = (Color == Color.Red);
            �����ToolStripMenuItem.Checked = (Color == Color.Blue);
            �������ToolStripMenuItem.Checked = (Color == Color.Green);
            ������ToolStripMenuItem.Checked = !(Color == Color.Red ||
                                              Color == Color.Blue ||
                                              Color == Color.Green);
        }

    }
}