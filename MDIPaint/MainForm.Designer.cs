namespace MDIPaint
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator separator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator separator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem drawingToolStripMenuItem;
        private ToolStripMenuItem canvasSizeToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton colorToolStripDropDownButton;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel brushLabel;
        private ToolStripTextBox toolTextBox;
        private ToolStripButton brushToolStripButton;
        private ToolStripButton lineToolStripButton;
        private ToolStripButton ellipseToolStripButton;
        private ToolStripButton rectangleToolStripButton;
        private ToolStripButton eraserToolStripButton;
        private ToolStripButton fillToolStripButton;
        private ToolStripSeparator toolStripSeparator1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            separator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            separator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            drawingToolStripMenuItem = new ToolStripMenuItem();
            canvasSizeToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            brushToolStripButton = new ToolStripButton();
            lineToolStripButton = new ToolStripButton();
            ellipseToolStripButton = new ToolStripButton();
            rectangleToolStripButton = new ToolStripButton();
            eraserToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            fillToolStripButton = new ToolStripButton();
            colorToolStripDropDownButton = new ToolStripDropDownButton();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            brushLabel = new ToolStripLabel();
            toolTextBox = new ToolStripTextBox();
            mainMenu.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();

            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, drawingToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.MdiWindowListItem = windowToolStripMenuItem;
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(7, 2, 0, 2);
            mainMenu.Size = new Size(933, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";

            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, separator1, saveToolStripMenuItem, saveAsToolStripMenuItem, separator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";

            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&New";

            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open...";

            separator1.Name = "separator1";
            separator1.Size = new Size(177, 6);

            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";

            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save &as...";

            separator2.Name = "separator2";
            separator2.Size = new Size(177, 6);

            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";

            drawingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { canvasSizeToolStripMenuItem });
            drawingToolStripMenuItem.Name = "drawingToolStripMenuItem";
            drawingToolStripMenuItem.Size = new Size(59, 20);
            drawingToolStripMenuItem.Text = "&Drawing";

            canvasSizeToolStripMenuItem.Name = "canvasSizeToolStripMenuItem";
            canvasSizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            canvasSizeToolStripMenuItem.Size = new Size(180, 22);
            canvasSizeToolStripMenuItem.Text = "Canvas &size...";

            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(63, 20);
            windowToolStripMenuItem.Text = "&Window";

            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "&Cascade";

            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            tileVerticalToolStripMenuItem.Size = new Size(180, 22);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";

            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;
            tileHorizontalToolStripMenuItem.Size = new Size(180, 22);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";

            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.I;
            arrangeIconsToolStripMenuItem.Size = new Size(180, 22);
            arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";

            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";

            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.F1;
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About...";

            toolStrip.Items.AddRange(new ToolStripItem[] { brushToolStripButton, lineToolStripButton, ellipseToolStripButton, rectangleToolStripButton, eraserToolStripButton, toolStripSeparator1, fillToolStripButton, colorToolStripDropDownButton, toolStripSeparator3, brushLabel, toolTextBox });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(933, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";

            brushToolStripButton.CheckOnClick = true;
            brushToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            brushToolStripButton.Image = Properties.Resources.paint_brush;
            brushToolStripButton.ImageTransparentColor = Color.Magenta;
            brushToolStripButton.Name = "brushToolStripButton";
            brushToolStripButton.Size = new Size(23, 22);
            brushToolStripButton.Text = "Brush";

            lineToolStripButton.CheckOnClick = true;
            lineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            lineToolStripButton.Image = Properties.Resources.line;
            lineToolStripButton.ImageTransparentColor = Color.Magenta;
            lineToolStripButton.Name = "lineToolStripButton";
            lineToolStripButton.Size = new Size(23, 22);
            lineToolStripButton.Text = "Line";

            ellipseToolStripButton.CheckOnClick = true;
            ellipseToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ellipseToolStripButton.Image = Properties.Resources.cir;
            ellipseToolStripButton.ImageTransparentColor = Color.Magenta;
            ellipseToolStripButton.Name = "ellipseToolStripButton";
            ellipseToolStripButton.Size = new Size(23, 22);
            ellipseToolStripButton.Text = "Ellipse";

            rectangleToolStripButton.CheckOnClick = true;
            rectangleToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rectangleToolStripButton.Image = Properties.Resources.rec;
            rectangleToolStripButton.ImageTransparentColor = Color.Magenta;
            rectangleToolStripButton.Name = "rectangleToolStripButton";
            rectangleToolStripButton.Size = new Size(23, 22);
            rectangleToolStripButton.Text = "Rectangle";

            eraserToolStripButton.CheckOnClick = true;
            eraserToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            eraserToolStripButton.Image = Properties.Resources.erase;
            eraserToolStripButton.ImageTransparentColor = Color.Magenta;
            eraserToolStripButton.Name = "eraserToolStripButton";
            eraserToolStripButton.Size = new Size(23, 22);
            eraserToolStripButton.Text = "Eraser";

            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);

            fillToolStripButton.CheckOnClick = true;
            fillToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fillToolStripButton.Image = Properties.Resources.fill_on;
            fillToolStripButton.ImageTransparentColor = Color.Magenta;
            fillToolStripButton.Name = "fillToolStripButton";
            fillToolStripButton.Size = new Size(23, 22);
            fillToolStripButton.Text = "Fill shapes (off)";
            fillToolStripButton.Click += FillToolStripButton_Click;

            colorToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colorToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, blueToolStripMenuItem, greenToolStripMenuItem, otherToolStripMenuItem });
            colorToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            colorToolStripDropDownButton.Name = "colorToolStripDropDownButton";
            colorToolStripDropDownButton.Size = new Size(13, 22);
            colorToolStripDropDownButton.Text = "Color";

            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(180, 22);
            redToolStripMenuItem.Text = "Red";

            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(180, 22);
            blueToolStripMenuItem.Text = "Blue";

            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(180, 22);
            greenToolStripMenuItem.Text = "Green";

            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(180, 22);
            otherToolStripMenuItem.Text = "Other...";

            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);

            brushLabel.Name = "brushLabel";
            brushLabel.Size = new Size(36, 22);
            brushLabel.Text = "Size:";

            toolTextBox.Name = "toolTextBox";
            toolTextBox.Size = new Size(116, 25);
            toolTextBox.Text = "3";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(toolStrip);
            Controls.Add(mainMenu);
            IsMdiContainer = true;
            MainMenuStrip = mainMenu;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MDI Paint";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}