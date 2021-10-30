using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CraftopiaSavefileEditor.Controller;
using ScintillaNET;

namespace CraftopiaSavefileEditor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            // https://github.com/robinrodricks/ScintillaNET.Demo/blob/b5f0e74bce15b8f18d0ffd5d5c7a8ba382162ff1/ScintillaNET.Demo/MainForm.cs
            InitSyntaxColoring();
            InitNumberMargin();
            InitCodeFolding();
        }

        #region Scintilla
        private void InitHotkeys()
        {

            // register the hotkeys with the form
            //HotKeyManager.AddHotKey(this, OpenSearch, Keys.F, true);
            //HotKeyManager.AddHotKey(this, OpenFindDialog, Keys.F, true, false, true);
            //HotKeyManager.AddHotKey(this, OpenReplaceDialog, Keys.R, true);
            //HotKeyManager.AddHotKey(this, OpenReplaceDialog, Keys.H, true);
            //HotKeyManager.AddHotKey(this, Uppercase, Keys.U, true);
            //HotKeyManager.AddHotKey(this, Lowercase, Keys.L, true);
            //HotKeyManager.AddHotKey(this, ZoomIn, Keys.Oemplus, true);
            //HotKeyManager.AddHotKey(this, ZoomOut, Keys.OemMinus, true);
            //HotKeyManager.AddHotKey(this, ZoomDefault, Keys.D0, true);
            //HotKeyManager.AddHotKey(this, CloseSearch, Keys.Escape);

            //// remove conflicting hotkeys from scintilla
            //TextArea.ClearCmdKey(Keys.Control | Keys.F);
            //TextArea.ClearCmdKey(Keys.Control | Keys.R);
            //TextArea.ClearCmdKey(Keys.Control | Keys.H);
            //TextArea.ClearCmdKey(Keys.Control | Keys.L);
            //TextArea.ClearCmdKey(Keys.Control | Keys.U);

        }

        private Color RED = Color.FromArgb(255, 163, 21, 21);
        private Color GREEN = Color.FromArgb(255, 0, 128, 0);
        private void InitSyntaxColoring()
        {
            // Configure the default style
            Manual_Scintilla.StyleResetDefault();
            Manual_Scintilla.Styles[Style.Default].Font = "Consolas";
            Manual_Scintilla.Styles[Style.Default].Size = 10;
            Manual_Scintilla.StyleClearAll();

            // https://tewarid.github.io/2017/02/07/json-syntax-highlighting-in-scintillanet.html
            Manual_Scintilla.Styles[Style.Json.Default].ForeColor = Color.Silver;
            Manual_Scintilla.Styles[Style.Json.BlockComment].ForeColor = GREEN;
            Manual_Scintilla.Styles[Style.Json.LineComment].ForeColor = GREEN;
            Manual_Scintilla.Styles[Style.Json.Number].ForeColor = Color.Olive;
            Manual_Scintilla.Styles[Style.Json.PropertyName].ForeColor = Color.Blue;
            Manual_Scintilla.Styles[Style.Json.String].ForeColor = RED;
            Manual_Scintilla.Styles[Style.Json.StringEol].BackColor = Color.Pink;
            Manual_Scintilla.Styles[Style.Json.Operator].ForeColor = Color.Purple;
            Manual_Scintilla.Lexer = Lexer.Json;
        }

        private const int NUMBER_MARGIN = 1;
        private void InitNumberMargin()
        {
            var nums = Manual_Scintilla.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;
        }

        private Color BACK_COLOR = Color.FromArgb(255, 42, 33, 28);
        private Color FORE_COLOR = Color.FromArgb(255, 183, 183, 183);
        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;
        private void InitCodeFolding()
        {
            // Enable code folding
            Manual_Scintilla.SetProperty("fold", "1");
            Manual_Scintilla.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            Manual_Scintilla.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            Manual_Scintilla.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            Manual_Scintilla.Margins[FOLDING_MARGIN].Sensitive = true;
            Manual_Scintilla.Margins[FOLDING_MARGIN].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                Manual_Scintilla.Markers[i].SetForeColor(BACK_COLOR); // styles for [+] and [-]
                Manual_Scintilla.Markers[i].SetBackColor(FORE_COLOR); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            Manual_Scintilla.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            Manual_Scintilla.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            Manual_Scintilla.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            Manual_Scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            Manual_Scintilla.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            Manual_Scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            Manual_Scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            Manual_Scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }
        #endregion

        #region ScintillaNET-FindReplaceDialog
        //private FindReplace MyFindReplace;


        #endregion

        #region OCS-JSON変換
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
        #endregion

        #region OCS手動編集
        private void Manual_Open_Button_Click(object sender, EventArgs e)
        {
            string path = Manual_Filepath_TextBox.Text;
            if (path == "" || !File.Exists(path))
            {
                MessageBox.Show("ファイルが存在しません。", "エラー", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                return;
            }
            if(Path.GetExtension(path) != ".ocs")
            {
                MessageBox.Show("ocs以外のファイルが選択されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Manual_Scintilla.Text = OcsController.LoadOcs(path);
        }

        private void Manual_FileBrowse_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() {
                Filter = "OCSファイル(*.ocs)|*.ocs",
                Title = "OCSファイルを選択",
                RestoreDirectory = true
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                Manual_Filepath_TextBox.Text = path;
                Manual_Scintilla.Text = OcsController.LoadOcs(path);
            }
        }

        private void Manual_FileSave_Button_Click(object sender, EventArgs e)
        {
            string path = Manual_Filepath_TextBox.Text;
            if (path == "")
            {
                MessageBox.Show("保存先が不明です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                //OcsController.SaveOcs(path, Manual_Scintilla.Text);
                MessageBox.Show("OCSファイルを保存しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OCSファイルの保存に失敗しました。\r\nエラー詳細: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
