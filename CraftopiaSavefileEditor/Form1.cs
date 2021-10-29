using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CraftopiaSavefileEditor.Controller;

namespace CraftopiaSavefileEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitForm();
        }

        private void InitForm()
        {
            this.MinimumSize = this.Size;
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ConvertOcs2Json_Panel_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var ocss = files.Where(f => Path.GetExtension(f) == ".ocs");

            foreach (var ocs in ocss)
                OcsController.ConvertOcs2Json(ocs);
        }

        private void ConvertJson2Ocs_Panel_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var jsons = files.Where(f => Path.GetExtension(f) == ".json");

            foreach (var json in jsons)
                OcsController.ConvertJson2Ocs(json);
        }
    }
}
