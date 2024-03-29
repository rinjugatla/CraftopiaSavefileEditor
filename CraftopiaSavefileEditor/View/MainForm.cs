﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CraftopiaSavefileEditor.Controller;
using CraftopiaSavefileEditor.Model;
using Jil;
using Microsoft.WindowsAPICodePack.Dialogs;
using ScintillaNET;

namespace CraftopiaSavefileEditor.View
{
    public partial class MainForm : Form
    {
        private MapPieceController MapPieceController;
        private WorldController WorldController;
        private int SelectedWorldIndex = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += $" {this.ProductVersion}";
            this.MinimumSize = this.Size;

            Init();

            // https://github.com/robinrodricks/ScintillaNET.Demo/blob/b5f0e74bce15b8f18d0ffd5d5c7a8ba382162ff1/ScintillaNET.Demo/MainForm.cs
            InitHotkeys();
            InitSyntaxColoring();
            InitNumberMargin();
            InitCodeFolding();

            InitMapEditDataGridView();
        }

        private void Init()
        {
            MapPieceController = new MapPieceController();
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

            // remove conflicting hotkeys from scintilla
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.F);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.S);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.R);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.H);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.L);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.U);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.Q);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.W);
            Manual_Scintilla.ClearCmdKey(Keys.Control | Keys.E);

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

        /// <summary>
        /// OCSからJSONに変換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertOcs2Json_Panel_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var ocss = files.Where(f => Path.GetExtension(f) == ".ocs");

            List<(string path, bool isSuccess, string message)> result = new List<(string, bool, string)>();
            foreach (var ocs in ocss)
            {
                try
                {
                    OcsController.ConvertOcs2Json(ocs);
                    result.Add((ocs, true, null));
                }
                catch (Exception ex)
                {
                    result.Add((ocs, false, ex.Message));
                }
            }

            ShowOcsJsonConvertResult(result);
        }

        /// <summary>
        /// JSONからOCSに変換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertJson2Ocs_Panel_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var jsons = files.Where(f => Path.GetExtension(f) == ".json");

            List<(string path, bool isSuccess, string message)> result = new List<(string, bool, string)>();
            foreach (var json in jsons)
            {
                try
                {
                    OcsController.ConvertJson2Ocs(json);
                    result.Add((json, true, null));
                }
                catch (Exception ex)
                {
                    result.Add((json, false, ex.Message));
                }
            }

            ShowOcsJsonConvertResult(result);
        }

        /// <summary>
        /// OCS, JSONの変換結果を表示
        /// </summary>
        /// <param name="result"></param>
        private void ShowOcsJsonConvertResult(IReadOnlyList<(string path, bool isSuccess, string message)> result)
        {
            int success = result.Where(n => n.isSuccess).Count();
            int faild = result.Count - success;
            if (MessageBox.Show($"成功: {success}\n失敗{faild}\n\n詳細を表示しますか？", "変換結果", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // 詳細表示
                OcsJsonConvertRsultForm form = new OcsJsonConvertRsultForm(result);
                form.Show();
            }
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
                OcsController.SaveOcs(path, Manual_Scintilla.Text);
                MessageBox.Show("OCSファイルを保存しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OCSファイルの保存に失敗しました。\r\nエラー詳細: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Manual_Scintilla_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Manual_Scintilla_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if(Path.GetExtension(files[0]) != ".ocs")
            {
                MessageBox.Show("ocs以外のファイルが選択されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Manual_Filepath_TextBox.Text = files[0];
            Manual_Scintilla.Text = OcsController.LoadOcs(files[0]);
        }
        #endregion

        #region MAP編集
        private void InitMapEditDataGridView()
        {
            // カラムの自動生成無効化
            MapEdit_DataGridView.AutoGenerateColumns = false;

            IEnumerable<int> headers = Enumerable.Range(1, 11);
            DataTable table = new DataTable("Map");
            foreach (var header in headers)
            {
                table.Columns.Add(new DataColumn($"{header}", typeof(string)));
            }

            // Windows フォームの DataGridViewComboBoxCell ドロップダウン リストのオブジェクトにアクセスする
            // https://docs.microsoft.com/ja-jp/dotnet/desktop/winforms/controls/access-objects-in-a-wf-datagridviewcomboboxcell-drop-down-list?view=netframeworkdesktop-4.8
            var validMapPieces = MapPieceController.GetValidMapPieces();
            List<DataGridViewComboBoxColumn> columns = new List<DataGridViewComboBoxColumn>();
            foreach (var header in headers)
            {
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn() {
                    Name = $"{header}",
                    DataPropertyName = "ID",
                    DisplayMember = "Name",
                    ValueMember = "Self",
                    FlatStyle = FlatStyle.Flat,
                };

                column.DefaultCellStyle.NullValue = "";
                foreach (var piece in validMapPieces) column.Items.Add(piece);
                
                columns.Add(column);
                MapEdit_DataGridView.Columns.Add(column);
            }
            
            foreach (var header in headers)
            {
                DataRow row = table.NewRow();
                table.Rows.Add();
            }

            MapEdit_DataGridView.DataSource = table;
            
            foreach (DataGridViewColumn column in MapEdit_DataGridView.Columns)
            {
                column.Width = 80;
            }

            //dataGridView1.Columns.AddRange(columns.ToArray());
        }

        /// <summary>
        /// DGV行ヘッダ描画
        /// </summary>
        /// <remarks>
        /// https://dobon.net/vb/dotnet/datagridview/drawrownumber.html
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapEdit_DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.RowHeadersVisible)
            {
                //行番号を描画する範囲を決定する
                Rectangle rect = new Rectangle(
                    e.RowBounds.Left, e.RowBounds.Top,
                    dgv.RowHeadersWidth, e.RowBounds.Height);
                rect.Inflate(-2, -2);
                //行番号を描画する
                TextRenderer.DrawText(e.Graphics,
                    (e.RowIndex + 1).ToString(),
                    e.InheritedRowStyle.Font,
                    rect,
                    e.InheritedRowStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
            }
        }

        private void MapEdit_Open_Button_Click(object sender, EventArgs e)
        {
            string path = MapEdit_Directorypath_TextBox.Text;
            if (path == "" || !Directory.Exists(path))
            {
                MessageBox.Show("フォルダが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateWorldController(path);
        }

        private void MapEdit_Browse_Button_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog()
            {
                Title = "Worldsフォルダを選択",
                RestoreDirectory = true,
                IsFolderPicker = true
            };

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string path = cofd.FileName;
                MapEdit_Directorypath_TextBox.Text = path;
                UpdateWorldController(path);
            }
        }

        /// <summary>
        /// Worldsフォルダ内のWorld.ocsファイルを取得
        /// </summary>
        /// <param name="directoryPath"></param>
        private void UpdateWorldController(string directoryPath)
        {
            WorldController = new WorldController(directoryPath);
            var names = WorldController.GetWorldNames();
            MapEdit_ListBox.Items.AddRange(names.ToArray());
        }

        /// <summary>
        /// DGVの内容からWorld.ocsを保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapEdit_Save_Button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 選択したワールド情報を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapEdit_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            int index = listBox.SelectedIndex;
            if (index == -1)
                return;

            SelectedWorldIndex = index;
            WorldModel world = WorldController.GetWorld(false, index);
            UpdateWorldEdit_DataGridView(world);
        }

        /// <summary>
        /// WorldModelからDGVを更新
        /// </summary>
        private void UpdateWorldEdit_DataGridView(WorldModel world)
        {
            // 左上から順に埋めていく
            int colmunNumber = MapEdit_DataGridView.Columns.Count;
            var islandRows = world.WorldSave.Value.IslandInfos.Select((v, i) => new { v, i })
                .GroupBy(x => x.i / colmunNumber)
                .Select(g => g.Select(x => x.v));

            foreach (var row in islandRows.Select((v, y) => new { v, y }))
            {
                foreach (var info in row.v.Select((v, x) => new { v, x }))
                {
                    MapEdit_DataGridView[info.x, row.y].Value = MapPieceController.GetMapPieceByPieceID(info.v.MapPieceId);
                    var cell = (DataGridViewComboBoxCell)MapEdit_DataGridView[info.x, row.y];
                }
            }
        }

        /// <summary>
        /// MAP編集DGVの選択中のセル位置
        /// </summary>
        private (int column, int row) SelectedCell = (-1, -1);

        /// <summary>
        /// ComboBoxをワンクリックで開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapEdit_DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex < 0)
                return;

            if (dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                SendKeys.Send("{F4}");
                SelectedCell = (e.ColumnIndex, e.RowIndex);
            }
                
        }

        /// <summary>
        /// MAP編集DGV Comboboxの描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapEdit_DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(e.Control is ComboBox)
            {
                ComboBox combo = (ComboBox)e.Control;
                combo.DrawMode = DrawMode.OwnerDrawFixed;
                combo.DrawItem -= ComboBox_DrawItem;
                combo.DrawItem += ComboBox_DrawItem;
            }
        }

        /// <summary>
        /// MAP編集DGV ComboBox色描画処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            MapPieceModel item = (MapPieceModel)combo.Items[e.Index];
            IslandInfo origin = WorldController?.GetIsland(true, SelectedWorldIndex, SelectedCell.column, SelectedCell.row);

            Brush brush;
            if (origin == null)
            {
                brush = Brushes.Black;
            }
            else
            {
                if (item.ID == origin.MapPieceId)
                    brush = Brushes.Red;
                else
                    brush = Brushes.Black;
            }

            // 背景描画
            e.DrawBackground();
            // テキスト描画
            e.Graphics.DrawString(item.Name, e.Font, brush, e.Bounds.X, e.Bounds.Y);
            // フォーカス描画
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// MAP編集DGVセル編集後処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapEdit_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedWorldIndex < 0)
                return;

            DataGridView dgv = (DataGridView)sender;
            MapPieceModel editValue = (MapPieceModel)dgv[e.ColumnIndex, e.RowIndex].Value;
            IslandInfo island = WorldController?.GetIsland(true, SelectedWorldIndex, e.ColumnIndex, e.RowIndex);
            if (island == null)
                return;

            bool isEqualOrigin;
            if (editValue == null)
                isEqualOrigin = (island.MapPieceId == 0);
            else
                isEqualOrigin = (editValue.ID == island.MapPieceId);

            //if (isEqualOrigin)
            //    dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
            //else
            //    dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;

        }
        #endregion

        
    }
}
