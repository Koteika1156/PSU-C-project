namespace MDIPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            основноеМеню.Size = new Size(800, 24);
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
            оПрограммеToolStripMenuItem.Size = new Size(180, 22);
            оПрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // панельИнструментов
            // 
            панельИнструментов.Items.AddRange(new ToolStripItem[] { цветToolStripDropDownButton, toolStripSeparator3, кистьLabel, инструментTextBox });
            панельИнструментов.Location = new Point(0, 24);
            панельИнструментов.Name = "панельИнструментов";
            панельИнструментов.Size = new Size(800, 25);
            панельИнструментов.TabIndex = 1;
            панельИнструментов.Text = "toolStrip1";
            // 
            // цветToolStripDropDownButton
            // 
            цветToolStripDropDownButton.BackgroundImageLayout = ImageLayout.Center;
            цветToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            цветToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { красныйToolStripMenuItem, синийToolStripMenuItem, зеленыйToolStripMenuItem, другойToolStripMenuItem });
            цветToolStripDropDownButton.Image = Properties.Resources.paint_brush;
            цветToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            цветToolStripDropDownButton.Name = "цветToolStripDropDownButton";
            цветToolStripDropDownButton.Size = new Size(29, 22);
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.ForeColor = SystemColors.ControlText;
            красныйToolStripMenuItem.Image = Properties.Resources.red;
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(180, 22);
            красныйToolStripMenuItem.Text = "Красный";
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Image = Properties.Resources.blue;
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(180, 22);
            синийToolStripMenuItem.Text = "Синий";
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.Image = Properties.Resources.green;
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
            инструментTextBox.Size = new Size(100, 25);
            инструментTextBox.Text = "3"; // Значение по умолчанию
            инструментTextBox.KeyDown += new KeyEventHandler(инструментTextBox_KeyDown);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(панельИнструментов);
            Controls.Add(основноеМеню);
            IsMdiContainer = true;
            MainMenuStrip = основноеМеню;
            Name = "MainForm";
            Text = "MDI Paint";
            основноеМеню.ResumeLayout(false);
            основноеМеню.PerformLayout();
            панельИнструментов.ResumeLayout(false);
            панельИнструментов.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}