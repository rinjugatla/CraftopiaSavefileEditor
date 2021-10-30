﻿
namespace CraftopiaSavefileEditor
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OcsJsonConvert_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConvertOcs2Json_Panel = new System.Windows.Forms.Panel();
            this.ConvertOcs2Json_Label = new System.Windows.Forms.Label();
            this.ConvertJson2Ocs_Panel = new System.Windows.Forms.Panel();
            this.ConvertJson2Ocs_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Manual_FileSave_Button = new System.Windows.Forms.Button();
            this.Manual_FileBrowse_Button = new System.Windows.Forms.Button();
            this.Manual_Open_Button = new System.Windows.Forms.Button();
            this.Manual_Filepath_TextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Manual_Scintilla = new ScintillaNET.Scintilla();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.OcsJsonConvert_TableLayoutPanel.SuspendLayout();
            this.ConvertOcs2Json_Panel.SuspendLayout();
            this.ConvertJson2Ocs_Panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OcsJsonConvert_TableLayoutPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OCS<->JSON変換";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.OcsJsonConvert_TableLayoutPanel.Size = new System.Drawing.Size(786, 418);
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
            this.ConvertOcs2Json_Panel.Size = new System.Drawing.Size(382, 406);
            this.ConvertOcs2Json_Panel.TabIndex = 0;
            this.ConvertOcs2Json_Panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ConvertOcs2Json_Panel_DragDrop);
            this.ConvertOcs2Json_Panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // ConvertOcs2Json_Label
            // 
            this.ConvertOcs2Json_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConvertOcs2Json_Label.AutoSize = true;
            this.ConvertOcs2Json_Label.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConvertOcs2Json_Label.Location = new System.Drawing.Point(76, 159);
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
            this.ConvertJson2Ocs_Panel.Location = new System.Drawing.Point(397, 6);
            this.ConvertJson2Ocs_Panel.Name = "ConvertJson2Ocs_Panel";
            this.ConvertJson2Ocs_Panel.Size = new System.Drawing.Size(383, 406);
            this.ConvertJson2Ocs_Panel.TabIndex = 0;
            this.ConvertJson2Ocs_Panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ConvertJson2Ocs_Panel_DragDrop);
            this.ConvertJson2Ocs_Panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // ConvertJson2Ocs_Label
            // 
            this.ConvertJson2Ocs_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConvertJson2Ocs_Label.AutoSize = true;
            this.ConvertJson2Ocs_Label.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConvertJson2Ocs_Label.Location = new System.Drawing.Point(95, 159);
            this.ConvertJson2Ocs_Label.Name = "ConvertJson2Ocs_Label";
            this.ConvertJson2Ocs_Label.Size = new System.Drawing.Size(207, 40);
            this.ConvertJson2Ocs_Label.TabIndex = 0;
            this.ConvertJson2Ocs_Label.Text = "OCSに変換";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OCS手動編集";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Manual_FileSave_Button
            // 
            this.Manual_FileSave_Button.Location = new System.Drawing.Point(723, 3);
            this.Manual_FileSave_Button.Name = "Manual_FileSave_Button";
            this.Manual_FileSave_Button.Size = new System.Drawing.Size(54, 23);
            this.Manual_FileSave_Button.TabIndex = 1;
            this.Manual_FileSave_Button.Text = "保存";
            this.Manual_FileSave_Button.UseVisualStyleBackColor = true;
            this.Manual_FileSave_Button.Click += new System.EventHandler(this.Manual_FileSave_Button_Click);
            // 
            // Manual_FileBrowse_Button
            // 
            this.Manual_FileBrowse_Button.Location = new System.Drawing.Point(663, 3);
            this.Manual_FileBrowse_Button.Name = "Manual_FileBrowse_Button";
            this.Manual_FileBrowse_Button.Size = new System.Drawing.Size(54, 23);
            this.Manual_FileBrowse_Button.TabIndex = 1;
            this.Manual_FileBrowse_Button.Text = "参照";
            this.Manual_FileBrowse_Button.UseVisualStyleBackColor = true;
            this.Manual_FileBrowse_Button.Click += new System.EventHandler(this.Manual_FileBrowse_Button_Click);
            // 
            // Manual_Open_Button
            // 
            this.Manual_Open_Button.Location = new System.Drawing.Point(603, 3);
            this.Manual_Open_Button.Name = "Manual_Open_Button";
            this.Manual_Open_Button.Size = new System.Drawing.Size(54, 23);
            this.Manual_Open_Button.TabIndex = 1;
            this.Manual_Open_Button.Text = "開く";
            this.Manual_Open_Button.UseVisualStyleBackColor = true;
            this.Manual_Open_Button.Click += new System.EventHandler(this.Manual_Open_Button_Click);
            // 
            // Manual_Filepath_TextBox
            // 
            this.Manual_Filepath_TextBox.Location = new System.Drawing.Point(5, 5);
            this.Manual_Filepath_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Manual_Filepath_TextBox.Name = "Manual_Filepath_TextBox";
            this.Manual_Filepath_TextBox.Size = new System.Drawing.Size(590, 19);
            this.Manual_Filepath_TextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MAP編集";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.Manual_Scintilla.Size = new System.Drawing.Size(780, 377);
            this.Manual_Scintilla.TabIndents = true;
            this.Manual_Scintilla.TabIndex = 4;
            this.Manual_Scintilla.UseRightToLeftReadingLayout = false;
            this.Manual_Scintilla.WrapMode = ScintillaNET.WrapMode.None;
            this.Manual_Scintilla.DragDrop += new System.Windows.Forms.DragEventHandler(this.Manual_Scintilla_DragDrop);
            this.Manual_Scintilla.DragEnter += new System.Windows.Forms.DragEventHandler(this.Manual_Scintilla_DragEnter);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 29);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.OcsJsonConvert_TableLayoutPanel.ResumeLayout(false);
            this.ConvertOcs2Json_Panel.ResumeLayout(false);
            this.ConvertOcs2Json_Panel.PerformLayout();
            this.ConvertJson2Ocs_Panel.ResumeLayout(false);
            this.ConvertJson2Ocs_Panel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
    }
}

