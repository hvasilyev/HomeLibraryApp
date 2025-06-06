using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLibrary.Forms
{
    public partial class ExportOptionsForm: Form
    {
        public bool ExportAsReadable => radioReadable.Checked;
        public ExportOptionsForm()
        {
            InitializeComponent();
        }
    }
}
