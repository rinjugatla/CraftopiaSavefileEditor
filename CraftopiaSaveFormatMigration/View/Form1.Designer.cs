
namespace CraftopiaSaveFormatMigration
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
            this.CurrentSaveFormat_Label = new System.Windows.Forms.Label();
            this.BrowseSaveDirectory_Button = new System.Windows.Forms.Button();
            this.CurrentSaveFormat_View_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.MigrationNewToOld_Button = new System.Windows.Forms.Button();
            this.MigrationOldToNew_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentSaveFormat_Label
            // 
            this.CurrentSaveFormat_Label.AutoSize = true;
            this.CurrentSaveFormat_Label.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.CurrentSaveFormat_Label.Location = new System.Drawing.Point(12, 9);
            this.CurrentSaveFormat_Label.Name = "CurrentSaveFormat_Label";
            this.CurrentSaveFormat_Label.Size = new System.Drawing.Size(147, 19);
            this.CurrentSaveFormat_Label.TabIndex = 0;
            this.CurrentSaveFormat_Label.Text = "現在のセーブ形式";
            // 
            // BrowseSaveDirectory_Button
            // 
            this.BrowseSaveDirectory_Button.Location = new System.Drawing.Point(425, 1);
            this.BrowseSaveDirectory_Button.Name = "BrowseSaveDirectory_Button";
            this.BrowseSaveDirectory_Button.Size = new System.Drawing.Size(197, 41);
            this.BrowseSaveDirectory_Button.TabIndex = 1;
            this.BrowseSaveDirectory_Button.Text = "セーブフォルダ参照";
            this.BrowseSaveDirectory_Button.UseVisualStyleBackColor = true;
            this.BrowseSaveDirectory_Button.Click += new System.EventHandler(this.BrowseSaveDirectory_Button_Click);
            // 
            // CurrentSaveFormat_View_Label
            // 
            this.CurrentSaveFormat_View_Label.AutoSize = true;
            this.CurrentSaveFormat_View_Label.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.CurrentSaveFormat_View_Label.Location = new System.Drawing.Point(165, 9);
            this.CurrentSaveFormat_View_Label.Name = "CurrentSaveFormat_View_Label";
            this.CurrentSaveFormat_View_Label.Size = new System.Drawing.Size(59, 19);
            this.CurrentSaveFormat_View_Label.TabIndex = 2;
            this.CurrentSaveFormat_View_Label.Text = "Stable";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(387, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "新形式\r\nAlpha, AlphaEdge\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 100);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "旧型式\r\nStable";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MigrationNewToOld_Button
            // 
            this.MigrationNewToOld_Button.Enabled = false;
            this.MigrationNewToOld_Button.Location = new System.Drawing.Point(253, 104);
            this.MigrationNewToOld_Button.Name = "MigrationNewToOld_Button";
            this.MigrationNewToOld_Button.Size = new System.Drawing.Size(128, 41);
            this.MigrationNewToOld_Button.TabIndex = 5;
            this.MigrationNewToOld_Button.Text = "<--移行--";
            this.MigrationNewToOld_Button.UseVisualStyleBackColor = true;
            this.MigrationNewToOld_Button.Click += new System.EventHandler(this.Migration_Button_Click);
            // 
            // MigrationOldToNew_Button
            // 
            this.MigrationOldToNew_Button.Enabled = false;
            this.MigrationOldToNew_Button.Location = new System.Drawing.Point(253, 45);
            this.MigrationOldToNew_Button.Name = "MigrationOldToNew_Button";
            this.MigrationOldToNew_Button.Size = new System.Drawing.Size(128, 41);
            this.MigrationOldToNew_Button.TabIndex = 5;
            this.MigrationOldToNew_Button.Text = "--移行-->";
            this.MigrationOldToNew_Button.UseVisualStyleBackColor = true;
            this.MigrationOldToNew_Button.Click += new System.EventHandler(this.Migration_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 156);
            this.Controls.Add(this.MigrationOldToNew_Button);
            this.Controls.Add(this.MigrationNewToOld_Button);
            this.Controls.Add(this.BrowseSaveDirectory_Button);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CurrentSaveFormat_View_Label);
            this.Controls.Add(this.CurrentSaveFormat_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Craftopia 新旧セーブ形式移行ツール";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentSaveFormat_Label;
        private System.Windows.Forms.Button BrowseSaveDirectory_Button;
        private System.Windows.Forms.Label CurrentSaveFormat_View_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MigrationNewToOld_Button;
        private System.Windows.Forms.Button MigrationOldToNew_Button;
    }
}

