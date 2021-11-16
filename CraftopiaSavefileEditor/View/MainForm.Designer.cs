
namespace CraftopiaSavefileEditor.View
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConvertOcsJson_TabPage = new System.Windows.Forms.TabPage();
            this.OcsJsonConvert_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConvertOcs2Json_Panel = new System.Windows.Forms.Panel();
            this.ConvertOcs2Json_Label = new System.Windows.Forms.Label();
            this.ConvertJson2Ocs_Panel = new System.Windows.Forms.Panel();
            this.ConvertJson2Ocs_Label = new System.Windows.Forms.Label();
            this.Manual_TabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Manual_Scintilla = new ScintillaNET.Scintilla();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Manual_Filepath_TextBox = new System.Windows.Forms.TextBox();
            this.Manual_FileSave_Button = new System.Windows.Forms.Button();
            this.Manual_Open_Button = new System.Windows.Forms.Button();
            this.Manual_FileBrowse_Button = new System.Windows.Forms.Button();
            this.MapEdit_TabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MapEdit_Directorypath_TextBox = new System.Windows.Forms.TextBox();
            this.MapEdit_Save_Button = new System.Windows.Forms.Button();
            this.MapEdit_Open_Button = new System.Windows.Forms.Button();
            this.MapEdit_Browse_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.MapEdit_DataGridView = new System.Windows.Forms.DataGridView();
            this.MapEdit_ListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ConvertOcsJson_TabPage.SuspendLayout();
            this.OcsJsonConvert_TableLayoutPanel.SuspendLayout();
            this.ConvertOcs2Json_Panel.SuspendLayout();
            this.ConvertJson2Ocs_Panel.SuspendLayout();
            this.Manual_TabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MapEdit_TabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapEdit_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConvertOcsJson_TabPage);
            this.tabControl1.Controls.Add(this.Manual_TabPage);
            this.tabControl1.Controls.Add(this.MapEdit_TabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // ConvertOcsJson_TabPage
            // 
            this.ConvertOcsJson_TabPage.Controls.Add(this.OcsJsonConvert_TableLayoutPanel);
            this.ConvertOcsJson_TabPage.Location = new System.Drawing.Point(4, 22);
            this.ConvertOcsJson_TabPage.Name = "ConvertOcsJson_TabPage";
            this.ConvertOcsJson_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConvertOcsJson_TabPage.Size = new System.Drawing.Size(956, 424);
            this.ConvertOcsJson_TabPage.TabIndex = 0;
            this.ConvertOcsJson_TabPage.Text = "OCS<->JSON変換";
            this.ConvertOcsJson_TabPage.UseVisualStyleBackColor = true;
            // 
            // OcsJsonConvert_TableLayoutPanel
            // 
            this.OcsJsonConvert_TableLayoutPanel.AllowDrop = true;
            this.OcsJsonConvert_TableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.OcsJsonConvert_TableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.OcsJsonConvert_TableLayoutPanel.ColumnCount = 2;
            this.OcsJsonConvert_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OcsJsonConvert_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OcsJsonConvert_TableLayoutPanel.Controls.Add(this.ConvertOcs2Json_Panel, 0, 0);
            this.OcsJsonConvert_TableLayoutPanel.Controls.Add(this.ConvertJson2Ocs_Panel, 1, 0);
            this.OcsJsonConvert_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OcsJsonConvert_TableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OcsJsonConvert_TableLayoutPanel.Name = "OcsJsonConvert_TableLayoutPanel";
            this.OcsJsonConvert_TableLayoutPanel.RowCount = 1;
            this.OcsJsonConvert_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OcsJsonConvert_TableLayoutPanel.Size = new System.Drawing.Size(950, 418);
            this.OcsJsonConvert_TableLayoutPanel.TabIndex = 0;
            // 
            // ConvertOcs2Json_Panel
            // 
            this.ConvertOcs2Json_Panel.AllowDrop = true;
            this.ConvertOcs2Json_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ConvertOcs2Json_Panel.Controls.Add(this.ConvertOcs2Json_Label);
            this.ConvertOcs2Json_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertOcs2Json_Panel.Location = new System.Drawing.Point(6, 6);
            this.ConvertOcs2Json_Panel.Name = "ConvertOcs2Json_Panel";
            this.ConvertOcs2Json_Panel.Size = new System.Drawing.Size(464, 406);
            this.ConvertOcs2Json_Panel.TabIndex = 0;
            this.ConvertOcs2Json_Panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ConvertOcs2Json_Panel_DragDrop);
            this.ConvertOcs2Json_Panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // ConvertOcs2Json_Label
            // 
            this.ConvertOcs2Json_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConvertOcs2Json_Label.AutoSize = true;
            this.ConvertOcs2Json_Label.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConvertOcs2Json_Label.Location = new System.Drawing.Point(117, 159);
            this.ConvertOcs2Json_Label.Name = "ConvertOcs2Json_Label";
            this.ConvertOcs2Json_Label.Size = new System.Drawing.Size(228, 40);
            this.ConvertOcs2Json_Label.TabIndex = 0;
            this.ConvertOcs2Json_Label.Text = "JSONに変換";
            // 
            // ConvertJson2Ocs_Panel
            // 
            this.ConvertJson2Ocs_Panel.AllowDrop = true;
            this.ConvertJson2Ocs_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ConvertJson2Ocs_Panel.Controls.Add(this.ConvertJson2Ocs_Label);
            this.ConvertJson2Ocs_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertJson2Ocs_Panel.Location = new System.Drawing.Point(479, 6);
            this.ConvertJson2Ocs_Panel.Name = "ConvertJson2Ocs_Panel";
            this.ConvertJson2Ocs_Panel.Size = new System.Drawing.Size(465, 406);
            this.ConvertJson2Ocs_Panel.TabIndex = 0;
            this.ConvertJson2Ocs_Panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ConvertJson2Ocs_Panel_DragDrop);
            this.ConvertJson2Ocs_Panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // ConvertJson2Ocs_Label
            // 
            this.ConvertJson2Ocs_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConvertJson2Ocs_Label.AutoSize = true;
            this.ConvertJson2Ocs_Label.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConvertJson2Ocs_Label.Location = new System.Drawing.Point(136, 159);
            this.ConvertJson2Ocs_Label.Name = "ConvertJson2Ocs_Label";
            this.ConvertJson2Ocs_Label.Size = new System.Drawing.Size(207, 40);
            this.ConvertJson2Ocs_Label.TabIndex = 0;
            this.ConvertJson2Ocs_Label.Text = "OCSに変換";
            // 
            // Manual_TabPage
            // 
            this.Manual_TabPage.Controls.Add(this.tableLayoutPanel1);
            this.Manual_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Manual_TabPage.Name = "Manual_TabPage";
            this.Manual_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Manual_TabPage.Size = new System.Drawing.Size(956, 424);
            this.Manual_TabPage.TabIndex = 1;
            this.Manual_TabPage.Text = "OCS手動編集";
            this.Manual_TabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Manual_Scintilla, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 418);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Manual_Scintilla
            // 
            this.Manual_Scintilla.AllowDrop = true;
            this.Manual_Scintilla.AutoCMaxHeight = 9;
            this.Manual_Scintilla.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.Manual_Scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manual_Scintilla.Location = new System.Drawing.Point(3, 38);
            this.Manual_Scintilla.Name = "Manual_Scintilla";
            this.Manual_Scintilla.ScrollWidth = 49;
            this.Manual_Scintilla.Size = new System.Drawing.Size(944, 377);
            this.Manual_Scintilla.TabIndents = true;
            this.Manual_Scintilla.TabIndex = 4;
            this.Manual_Scintilla.UseRightToLeftReadingLayout = false;
            this.Manual_Scintilla.WrapMode = ScintillaNET.WrapMode.None;
            this.Manual_Scintilla.DragDrop += new System.Windows.Forms.DragEventHandler(this.Manual_Scintilla_DragDrop);
            this.Manual_Scintilla.DragEnter += new System.Windows.Forms.DragEventHandler(this.Manual_Scintilla_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.Manual_Filepath_TextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Manual_FileSave_Button, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Manual_Open_Button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Manual_FileBrowse_Button, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(944, 29);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Manual_Filepath_TextBox
            // 
            this.Manual_Filepath_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manual_Filepath_TextBox.Location = new System.Drawing.Point(5, 5);
            this.Manual_Filepath_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Manual_Filepath_TextBox.Name = "Manual_Filepath_TextBox";
            this.Manual_Filepath_TextBox.Size = new System.Drawing.Size(754, 19);
            this.Manual_Filepath_TextBox.TabIndex = 0;
            // 
            // Manual_FileSave_Button
            // 
            this.Manual_FileSave_Button.Location = new System.Drawing.Point(887, 3);
            this.Manual_FileSave_Button.Name = "Manual_FileSave_Button";
            this.Manual_FileSave_Button.Size = new System.Drawing.Size(54, 23);
            this.Manual_FileSave_Button.TabIndex = 1;
            this.Manual_FileSave_Button.Text = "保存";
            this.Manual_FileSave_Button.UseVisualStyleBackColor = true;
            this.Manual_FileSave_Button.Click += new System.EventHandler(this.Manual_FileSave_Button_Click);
            // 
            // Manual_Open_Button
            // 
            this.Manual_Open_Button.Location = new System.Drawing.Point(767, 3);
            this.Manual_Open_Button.Name = "Manual_Open_Button";
            this.Manual_Open_Button.Size = new System.Drawing.Size(54, 23);
            this.Manual_Open_Button.TabIndex = 1;
            this.Manual_Open_Button.Text = "開く";
            this.Manual_Open_Button.UseVisualStyleBackColor = true;
            this.Manual_Open_Button.Click += new System.EventHandler(this.Manual_Open_Button_Click);
            // 
            // Manual_FileBrowse_Button
            // 
            this.Manual_FileBrowse_Button.Location = new System.Drawing.Point(827, 3);
            this.Manual_FileBrowse_Button.Name = "Manual_FileBrowse_Button";
            this.Manual_FileBrowse_Button.Size = new System.Drawing.Size(54, 23);
            this.Manual_FileBrowse_Button.TabIndex = 1;
            this.Manual_FileBrowse_Button.Text = "参照";
            this.Manual_FileBrowse_Button.UseVisualStyleBackColor = true;
            this.Manual_FileBrowse_Button.Click += new System.EventHandler(this.Manual_FileBrowse_Button_Click);
            // 
            // MapEdit_TabPage
            // 
            this.MapEdit_TabPage.Controls.Add(this.tableLayoutPanel3);
            this.MapEdit_TabPage.Location = new System.Drawing.Point(4, 22);
            this.MapEdit_TabPage.Name = "MapEdit_TabPage";
            this.MapEdit_TabPage.Size = new System.Drawing.Size(956, 424);
            this.MapEdit_TabPage.TabIndex = 2;
            this.MapEdit_TabPage.Text = "MAP編集";
            this.MapEdit_TabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(956, 424);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Controls.Add(this.MapEdit_Directorypath_TextBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.MapEdit_Save_Button, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.MapEdit_Open_Button, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.MapEdit_Browse_Button, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(950, 29);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // MapEdit_Directorypath_TextBox
            // 
            this.MapEdit_Directorypath_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapEdit_Directorypath_TextBox.Location = new System.Drawing.Point(5, 5);
            this.MapEdit_Directorypath_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MapEdit_Directorypath_TextBox.Name = "MapEdit_Directorypath_TextBox";
            this.MapEdit_Directorypath_TextBox.Size = new System.Drawing.Size(760, 19);
            this.MapEdit_Directorypath_TextBox.TabIndex = 0;
            // 
            // MapEdit_Save_Button
            // 
            this.MapEdit_Save_Button.Location = new System.Drawing.Point(893, 3);
            this.MapEdit_Save_Button.Name = "MapEdit_Save_Button";
            this.MapEdit_Save_Button.Size = new System.Drawing.Size(54, 23);
            this.MapEdit_Save_Button.TabIndex = 1;
            this.MapEdit_Save_Button.Text = "保存";
            this.MapEdit_Save_Button.UseVisualStyleBackColor = true;
            this.MapEdit_Save_Button.Click += new System.EventHandler(this.MapEdit_Save_Button_Click);
            // 
            // MapEdit_Open_Button
            // 
            this.MapEdit_Open_Button.Location = new System.Drawing.Point(773, 3);
            this.MapEdit_Open_Button.Name = "MapEdit_Open_Button";
            this.MapEdit_Open_Button.Size = new System.Drawing.Size(54, 23);
            this.MapEdit_Open_Button.TabIndex = 1;
            this.MapEdit_Open_Button.Text = "開く";
            this.MapEdit_Open_Button.UseVisualStyleBackColor = true;
            this.MapEdit_Open_Button.Click += new System.EventHandler(this.MapEdit_Open_Button_Click);
            // 
            // MapEdit_Browse_Button
            // 
            this.MapEdit_Browse_Button.Location = new System.Drawing.Point(833, 3);
            this.MapEdit_Browse_Button.Name = "MapEdit_Browse_Button";
            this.MapEdit_Browse_Button.Size = new System.Drawing.Size(54, 23);
            this.MapEdit_Browse_Button.TabIndex = 1;
            this.MapEdit_Browse_Button.Text = "参照";
            this.MapEdit_Browse_Button.UseVisualStyleBackColor = true;
            this.MapEdit_Browse_Button.Click += new System.EventHandler(this.MapEdit_Browse_Button_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.MapEdit_DataGridView, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.MapEdit_ListBox, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(950, 383);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // MapEdit_DataGridView
            // 
            this.MapEdit_DataGridView.AllowUserToAddRows = false;
            this.MapEdit_DataGridView.AllowUserToDeleteRows = false;
            this.MapEdit_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapEdit_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapEdit_DataGridView.Location = new System.Drawing.Point(203, 3);
            this.MapEdit_DataGridView.Name = "MapEdit_DataGridView";
            this.MapEdit_DataGridView.RowTemplate.Height = 21;
            this.MapEdit_DataGridView.Size = new System.Drawing.Size(744, 377);
            this.MapEdit_DataGridView.TabIndex = 2;
            this.MapEdit_DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MapEdit_DataGridView_CellEndEdit);
            this.MapEdit_DataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MapEdit_DataGridView_CellEnter);
            this.MapEdit_DataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.MapEdit_DataGridView_EditingControlShowing);
            // 
            // MapEdit_ListBox
            // 
            this.MapEdit_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapEdit_ListBox.FormattingEnabled = true;
            this.MapEdit_ListBox.ItemHeight = 12;
            this.MapEdit_ListBox.Location = new System.Drawing.Point(3, 3);
            this.MapEdit_ListBox.Name = "MapEdit_ListBox";
            this.MapEdit_ListBox.Size = new System.Drawing.Size(194, 377);
            this.MapEdit_ListBox.TabIndex = 3;
            this.MapEdit_ListBox.SelectedIndexChanged += new System.EventHandler(this.MapEdit_ListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 424);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Craftopia セーブファイル編集ツール";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ConvertOcsJson_TabPage.ResumeLayout(false);
            this.OcsJsonConvert_TableLayoutPanel.ResumeLayout(false);
            this.ConvertOcs2Json_Panel.ResumeLayout(false);
            this.ConvertOcs2Json_Panel.PerformLayout();
            this.ConvertJson2Ocs_Panel.ResumeLayout(false);
            this.ConvertJson2Ocs_Panel.PerformLayout();
            this.Manual_TabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MapEdit_TabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapEdit_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConvertOcsJson_TabPage;
        private System.Windows.Forms.TabPage Manual_TabPage;
        private System.Windows.Forms.TabPage MapEdit_TabPage;
        private System.Windows.Forms.TableLayoutPanel OcsJsonConvert_TableLayoutPanel;
        private System.Windows.Forms.Label ConvertOcs2Json_Label;
        private System.Windows.Forms.Button Manual_FileSave_Button;
        private System.Windows.Forms.Button Manual_FileBrowse_Button;
        private System.Windows.Forms.TextBox Manual_Filepath_TextBox;
        private System.Windows.Forms.Label ConvertJson2Ocs_Label;
        private System.Windows.Forms.Panel ConvertOcs2Json_Panel;
        private System.Windows.Forms.Panel ConvertJson2Ocs_Panel;
        private System.Windows.Forms.Button Manual_Open_Button;
        private ScintillaNET.Scintilla Manual_Scintilla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox MapEdit_Directorypath_TextBox;
        private System.Windows.Forms.Button MapEdit_Save_Button;
        private System.Windows.Forms.Button MapEdit_Open_Button;
        private System.Windows.Forms.Button MapEdit_Browse_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView MapEdit_DataGridView;
        private System.Windows.Forms.ListBox MapEdit_ListBox;
    }
}

