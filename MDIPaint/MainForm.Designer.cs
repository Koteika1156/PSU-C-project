namespace MDIPaint
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip основноеМеню;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новыйToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator разделитель1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripSeparator разделитель2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem рисунокToolStripMenuItem;
        private ToolStripMenuItem размерХолстаToolStripMenuItem;
        private ToolStripMenuItem окноToolStripMenuItem;
        private ToolStripMenuItem каскадомToolStripMenuItem;
        private ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStrip панельИнструментов;
        private ToolStripDropDownButton цветToolStripDropDownButton;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ToolStripMenuItem другойToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel кистьLabel;
        private ToolStripTextBox инструментTextBox;
        private ToolStripButton кистьToolStripButton;
        private ToolStripButton линияToolStripButton;
        private ToolStripButton эллипсToolStripButton;
        private ToolStripButton прямоугольникToolStripButton;
        private ToolStripButton ластикToolStripButton;
        private ToolStripButton заливкаToolStripButton;
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
            основноеМеню = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новыйToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            разделитель1 = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            разделитель2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            рисунокToolStripMenuItem = new ToolStripMenuItem();
            размерХолстаToolStripMenuItem = new ToolStripMenuItem();
            окноToolStripMenuItem = new ToolStripMenuItem();
            каскадомToolStripMenuItem = new ToolStripMenuItem();
            слеваНаправоToolStripMenuItem = new ToolStripMenuItem();
            сверхуВнизToolStripMenuItem = new ToolStripMenuItem();
            упорядочитьЗначкиToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            панельИнструментов = new ToolStrip();
            кистьToolStripButton = new ToolStripButton();
            линияToolStripButton = new ToolStripButton();
            эллипсToolStripButton = new ToolStripButton();
            прямоугольникToolStripButton = new ToolStripButton();
            ластикToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            заливкаToolStripButton = new ToolStripButton();
            цветToolStripDropDownButton = new ToolStripDropDownButton();
            красныйToolStripMenuItem = new ToolStripMenuItem();
            синийToolStripMenuItem = new ToolStripMenuItem();
            зеленыйToolStripMenuItem = new ToolStripMenuItem();
            другойToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            кистьLabel = new ToolStripLabel();
            инструментTextBox = new ToolStripTextBox();
            основноеМеню.SuspendLayout();
            панельИнструментов.SuspendLayout();
            SuspendLayout();
            // 
            // основноеМеню
            // 
            основноеМеню.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, рисунокToolStripMenuItem, окноToolStripMenuItem, справкаToolStripMenuItem });
            основноеМеню.Location = new Point(0, 0);
            основноеМеню.MdiWindowListItem = окноToolStripMenuItem;
            основноеМеню.Name = "основноеМеню";
            основноеМеню.Padding = new Padding(7, 2, 0, 2);
            основноеМеню.Size = new Size(933, 24);
            основноеМеню.TabIndex = 0;
            основноеМеню.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйToolStripMenuItem, открытьToolStripMenuItem, разделитель1, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, разделитель2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // новыйToolStripMenuItem
            // 
            новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            новыйToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            новыйToolStripMenuItem.Size = new Size(235, 22);
            новыйToolStripMenuItem.Text = "&Новый";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(235, 22);
            открытьToolStripMenuItem.Text = "&Открыть...";
            // 
            // разделитель1
            // 
            разделитель1.Name = "разделитель1";
            разделитель1.Size = new Size(232, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(235, 22);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            сохранитьКакToolStripMenuItem.Size = new Size(235, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить &как...";
            // 
            // разделитель2
            // 
            разделитель2.Name = "разделитель2";
            разделитель2.Size = new Size(232, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            выходToolStripMenuItem.Size = new Size(235, 22);
            выходToolStripMenuItem.Text = "&Выход";
            // 
            // рисунокToolStripMenuItem
            // 
            рисунокToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размерХолстаToolStripMenuItem });
            рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            рисунокToolStripMenuItem.Size = new Size(65, 20);
            рисунокToolStripMenuItem.Text = "&Рисунок";
            // 
            // размерХолстаToolStripMenuItem
            // 
            размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            размерХолстаToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            размерХолстаToolStripMenuItem.Size = new Size(204, 22);
            размерХолстаToolStripMenuItem.Text = "&Размер холста...";
            // 
            // окноToolStripMenuItem
            // 
            окноToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { каскадомToolStripMenuItem, слеваНаправоToolStripMenuItem, сверхуВнизToolStripMenuItem, упорядочитьЗначкиToolStripMenuItem });
            окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            окноToolStripMenuItem.Size = new Size(48, 20);
            окноToolStripMenuItem.Text = "&Окно";
            // 
            // каскадомToolStripMenuItem
            // 
            каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            каскадомToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            каскадомToolStripMenuItem.Size = new Size(256, 22);
            каскадомToolStripMenuItem.Text = "&Каскадом";
            // 
            // слеваНаправоToolStripMenuItem
            // 
            слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            слеваНаправоToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            слеваНаправоToolStripMenuItem.Size = new Size(256, 22);
            слеваНаправоToolStripMenuItem.Text = "&Слева направо";
            // 
            // сверхуВнизToolStripMenuItem
            // 
            сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            сверхуВнизToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;
            сверхуВнизToolStripMenuItem.Size = new Size(256, 22);
            сверхуВнизToolStripMenuItem.Text = "&Сверху вниз";
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            упорядочитьЗначкиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.I;
            упорядочитьЗначкиToolStripMenuItem.Size = new Size(256, 22);
            упорядочитьЗначкиToolStripMenuItem.Text = "&Упорядочить значки";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.ShortcutKeys = Keys.F1;
            оПрограммеToolStripMenuItem.Size = new Size(177, 22);
            оПрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // панельИнструментов
            // 
            панельИнструментов.Items.AddRange(new ToolStripItem[] { кистьToolStripButton, линияToolStripButton, эллипсToolStripButton, прямоугольникToolStripButton, ластикToolStripButton, toolStripSeparator1, заливкаToolStripButton, цветToolStripDropDownButton, toolStripSeparator3, кистьLabel, инструментTextBox });
            панельИнструментов.Location = new Point(0, 24);
            панельИнструментов.Name = "панельИнструментов";
            панельИнструментов.Size = new Size(933, 25);
            панельИнструментов.TabIndex = 1;
            панельИнструментов.Text = "toolStrip1";
            // 
            // кистьToolStripButton
            // 
            кистьToolStripButton.CheckOnClick = true;
            кистьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            кистьToolStripButton.Image = Properties.Resources.paint_brush;
            кистьToolStripButton.ImageTransparentColor = Color.Magenta;
            кистьToolStripButton.Name = "кистьToolStripButton";
            кистьToolStripButton.Size = new Size(23, 22);
            кистьToolStripButton.Text = "Кисть";
            // 
            // линияToolStripButton
            // 
            линияToolStripButton.CheckOnClick = true;
            линияToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            линияToolStripButton.Image = Properties.Resources.line;
            линияToolStripButton.ImageTransparentColor = Color.Magenta;
            линияToolStripButton.Name = "линияToolStripButton";
            линияToolStripButton.Size = new Size(23, 22);
            линияToolStripButton.Text = "Линия";
            // 
            // эллипсToolStripButton
            // 
            эллипсToolStripButton.CheckOnClick = true;
            эллипсToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            эллипсToolStripButton.Image = Properties.Resources.cir;
            эллипсToolStripButton.ImageTransparentColor = Color.Magenta;
            эллипсToolStripButton.Name = "эллипсToolStripButton";
            эллипсToolStripButton.Size = new Size(23, 22);
            эллипсToolStripButton.Text = "Эллипс";
            // 
            // прямоугольникToolStripButton
            // 
            прямоугольникToolStripButton.CheckOnClick = true;
            прямоугольникToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            прямоугольникToolStripButton.Image = Properties.Resources.rec;
            прямоугольникToolStripButton.ImageTransparentColor = Color.Magenta;
            прямоугольникToolStripButton.Name = "прямоугольникToolStripButton";
            прямоугольникToolStripButton.Size = new Size(23, 22);
            прямоугольникToolStripButton.Text = "Прямоугольник";
            // 
            // ластикToolStripButton
            // 
            ластикToolStripButton.CheckOnClick = true;
            ластикToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ластикToolStripButton.Image = Properties.Resources.erase;
            ластикToolStripButton.ImageTransparentColor = Color.Magenta;
            ластикToolStripButton.Name = "ластикToolStripButton";
            ластикToolStripButton.Size = new Size(23, 22);
            ластикToolStripButton.Text = "Ластик";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // заливкаToolStripButton
            // 
            // Изменим кнопку на переключаемую
            this.заливкаToolStripButton.CheckOnClick = true;
            this.заливкаToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.заливкаToolStripButton.ImageTransparentColor = Color.Magenta;
            this.заливкаToolStripButton.Name = "заливкаToolStripButton";
            this.заливкаToolStripButton.Size = new Size(23, 22);
            this.заливкаToolStripButton.Text = "Заливка фигур";
            // 
            // цветToolStripDropDownButton
            // 
            цветToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            цветToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { красныйToolStripMenuItem, синийToolStripMenuItem, зеленыйToolStripMenuItem, другойToolStripMenuItem });
            цветToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            цветToolStripDropDownButton.Name = "цветToolStripDropDownButton";
            цветToolStripDropDownButton.Size = new Size(13, 22);
            цветToolStripDropDownButton.Text = "Цвет";
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(180, 22);
            красныйToolStripMenuItem.Text = "Красный";
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(180, 22);
            синийToolStripMenuItem.Text = "Синий";
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            зеленыйToolStripMenuItem.Size = new Size(180, 22);
            зеленыйToolStripMenuItem.Text = "Зеленый";
            // 
            // другойToolStripMenuItem
            // 
            другойToolStripMenuItem.Name = "другойToolStripMenuItem";
            другойToolStripMenuItem.Size = new Size(180, 22);
            другойToolStripMenuItem.Text = "Другой...";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // кистьLabel
            // 
            кистьLabel.Name = "кистьLabel";
            кистьLabel.Size = new Size(41, 22);
            кистьLabel.Text = "Кисть:";
            // 
            // инструментTextBox
            // 
            инструментTextBox.Name = "инструментTextBox";
            инструментTextBox.Size = new Size(116, 25);
            инструментTextBox.Text = "3";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(панельИнструментов);
            Controls.Add(основноеМеню);
            IsMdiContainer = true;
            MainMenuStrip = основноеМеню;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MDI Paint";
            основноеМеню.ResumeLayout(false);
            основноеМеню.PerformLayout();
            панельИнструментов.ResumeLayout(false);
            панельИнструментов.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}