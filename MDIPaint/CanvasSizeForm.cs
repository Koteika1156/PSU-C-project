using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class CanvasSizeForm : Form
    {
        public int CanvasWidth
        {
            get { return (int)widthNumericUpDown.Value; }
            set { widthNumericUpDown.Value = value; }
        }

        public int CanvasHeight
        {
            get { return (int)heightNumericUpDown.Value; }
            set { heightNumericUpDown.Value = value; }
        }

        public CanvasSizeForm()
        {
            InitializeComponent();
        }
    }
}
