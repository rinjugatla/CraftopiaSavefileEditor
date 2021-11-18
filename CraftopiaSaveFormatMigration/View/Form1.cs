using CraftopiaSaveFormatMigration.Model;
using Jil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftopiaSaveFormatMigration
{
    public partial class Form1 : Form
    {
        private bool IsCurrentSaveFormatStable;
        private string CraftopiaDirectoryPath;
        private string SaveDirectoryPath;
        private string OldSaveDirectoryPath;
        private string TempSaveDirectoryPath;

        private bool IsPrevPlayedGameVersionStable;
        private string UnityValueFilepath;
        private string PrevPlayedGameVersion;
        private const string StableGameVersion = "20211011.1313";

        private const string MigrationTempDirectoryName = "CraftopiaSaveFormatMigration";

        

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += $" {this.ProductVersion}";

            if (!IsExistNeedDirectory())
                return;
            GetCurrentSaveFormat();
        }

        private void Init()
        {
            string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            CraftopiaDirectoryPath = $@"{local}\..\LocalLow\PocketPair\Craftopia";
            SaveDirectoryPath = $@"{CraftopiaDirectoryPath}\Save";
            OldSaveDirectoryPath = $@"{CraftopiaDirectoryPath}\OldSaveData\Save";
            TempSaveDirectoryPath = $@"{CraftopiaDirectoryPath}\{MigrationTempDirectoryName}";

            UnityValueFilepath = $@"{CraftopiaDirectoryPath}\Unity\4b4f4030-f8ea-4fd0-95d5-9976d9288868\Analytics\values";
        }

        /// <summary>
        /// 想定のフォルダが存在するか
        /// </summary>
        /// <returns>すべてのフォルダが存在する</returns>
        private bool IsExistNeedDirectory()
        {
            if (!Directory.Exists(SaveDirectoryPath))
            {
                MessageBox.Show($"Saveフォルダが存在しません。\n" +
                    $"パス {SaveDirectoryPath}\n\n" +
                    $"セーブデータが存在しないためデータの移行は不要です。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Directory.Exists(OldSaveDirectoryPath))
            {
                MessageBox.Show($"OldSaveData/Saveフォルダが存在しません。\n" +
                    $"パス {OldSaveDirectoryPath}\n\n" +
                    $"このフォルダが存在しない場合、一度もAlpha, AlphaEdgeでゲームをプレイしていない可能性があります。\n" +
                    $"Stableのみでゲームをプレイしている場合はデータの移行は不要です。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 前回プレイ時のゲームバージョンを取得
        /// </summary>
        private void GetPrevPlayedGameVersion()
        {
            //if (!File.Exists(UnityValueFilepath))
            //{
            //    MessageBox.Show("前回プレイ時のゲームバージョンの取得に失敗しました。");
            //    PrevPlayedGameVersion_Show_Label.Text = "取得失敗";
            //    PrevPlayedGameVersion_Show_Label.BackColor = Color.Yellow;
            //    return;
            //}

            //string json;
            //using (StreamReader sr = new StreamReader(UnityValueFilepath, Encoding.UTF8))
            //    json = sr.ReadToEnd();

            //UnityValueModel valueModel = JSON.Deserialize<UnityValueModel>(json);

            //PrevPlayedGameVersion = valueModel.AppVer;
            //IsPrevPlayedGameVersionStable = (PrevPlayedGameVersion == StableGameVersion);
            //PrevPlayedGameVersion_Show_Label.Text = IsPrevPlayedGameVersionStable ? "Stable" : "Alpha, AlphaEdge";
        }

        /// <summary>
        /// 現在のセーブ形式を取得
        /// </summary>
        private void GetCurrentSaveFormat()
        {
            // Craftopia.ocsが存在しなければStable
            IsCurrentSaveFormatStable = !File.Exists($@"{SaveDirectoryPath}\Craftopia.ocs");
            CurrentSaveFormat_View_Label.Text = IsCurrentSaveFormatStable ? "旧型式(Stable)" : "新形式(Alpha, AlphaEdge)";

            MigrationOldToNew_Button.Enabled = IsCurrentSaveFormatStable;
            MigrationNewToOld_Button.Enabled = !IsCurrentSaveFormatStable;
        }

        /// <summary>
        /// セーブフォルダを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseSaveDirectory_Button_Click(object sender, EventArgs e)
        {
            ShowDirectory(CraftopiaDirectoryPath);
        }

        /// <summary>
        /// 形式入れ替え
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Migration_Button_Click(object sender, EventArgs e)
        {
            int errorFiles = 0;
            errorFiles = MoveFiles(SaveDirectoryPath, TempSaveDirectoryPath);
            if (errorFiles > 0)
            {
                MessageBox.Show($"現在のセーブデータを一時フォルダに移動できませんでした。\n" +
                    $"移動に失敗したファイル数{errorFiles}\n" +
                    $"ファイル移動前後のフォルダを表示します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            errorFiles = MoveFiles(OldSaveDirectoryPath, SaveDirectoryPath);
            if (errorFiles > 0)
            {
                MessageBox.Show($"OldSaveDataフォルダのファイルをSaveフォルダに移動できませんでした。\n" +
                    $"移動に失敗したファイル数{errorFiles}\n" +
                    $"ファイル移動前後のフォルダを表示します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            errorFiles = MoveFiles(TempSaveDirectoryPath, OldSaveDirectoryPath);
            if (errorFiles > 0)
            {
                MessageBox.Show($"一時フォルダのセーブデータをOldSaveDataフォルダに移動できませんでした。\n" +
                    $"移動に失敗したファイル数{errorFiles}\n" +
                    $"ファイル移動前後のフォルダを表示します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("移行が成功しました。\n\nセーブデータの状態を再取得します。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ラベルなどの状態を更新
            GetCurrentSaveFormat();
        }

        /// <summary>
        /// フォルダ内のファイルをすべて移動
        /// </summary>
        /// <remarks>
        /// すべてのファイルの移動に成功した場合は、移動元フォルダは削除
        /// </remarks>
        /// <param name="from">移動元</param>
        /// <param name="to">移動先</param>
        /// <returns>処理に失敗したファイル数</returns>
        private int MoveFiles(string from, string to)
        {
            if (Directory.Exists(to))
                Directory.Delete(to);
            Directory.CreateDirectory(to);

            var errorList = new List<string>();
            var pathList = Directory.EnumerateFiles(from, "*", SearchOption.AllDirectories);
            foreach (var pathFrom in pathList)
            {
                string pathTo = pathFrom.Replace(from, to);
                string targetDirectory = Path.GetDirectoryName(pathTo);
                if (!Directory.Exists(targetDirectory))
                    Directory.CreateDirectory(targetDirectory);

                // フォルダごと移動した場合に存在しなくなっているのでチェック
                if (!File.Exists(pathFrom)) { continue; }

                bool isDirectory = IsDirectory(pathFrom);
                try
                {
                    if (isDirectory)
                    {
                        Directory.Move(pathFrom, pathTo);
                    }
                    else
                    {
                        if (File.Exists(pathTo)) { File.Delete(pathTo); }
                        File.Move(pathFrom, pathTo);
                    }
                }
                catch (Exception)
                {
                    errorList.Add(pathFrom);
                }
            }

            // 処理後に再取得
            pathList = Directory.EnumerateFiles(from, "*", SearchOption.AllDirectories);
            var fileList = pathList.Where(p => !IsDirectory(p));
            if (fileList.Count() > 0 || errorList.Count() > 0)
            {
                ShowDirectory(from);
                ShowDirectory(to);
                ShowErrorList(errorList);
                return fileList.Count();
            }
            else
            {
                Directory.Delete(from, true);
                return 0;
            }
        }

        private bool IsDirectory(string path)
        {
            return File.GetAttributes(path).HasFlag(FileAttributes.Directory);
        }

        private void ShowDirectory(string path)
        {
            Process.Start("EXPLORER.EXE", path);
        }

        private void ShowErrorList(IReadOnlyList<string> path)
        {
            string filename = $"Error_{DateTime.Now:MMddHHmmss}.txt";
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                sw.WriteLine("以下のファイルの移動に失敗しました。\n\n");
                sw.Write(string.Join("\n", path));
            }
            Process.Start("NOTEPAD.EXE", filename);
        }
    }
}
