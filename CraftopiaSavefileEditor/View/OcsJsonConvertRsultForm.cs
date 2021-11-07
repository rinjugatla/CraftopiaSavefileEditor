using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftopiaSavefileEditor.View
{
    public partial class OcsJsonConvertRsultForm : Form
    {
        public OcsJsonConvertRsultForm(IReadOnlyList<(string path, bool isSuccess, string message)> convertResult)
        {
            InitializeComponent();

            SetDataToDataGridView(convertResult);
        }

        private void SetDataToDataGridView(IReadOnlyList<(string path, bool isSuccess, string message)> result)
        {
            DataTable table = new DataTable();
            foreach (var header in new string[] { "ファイルパス", "結果", "エラー" })
            {
                table.Columns.Add(header);
            }

            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var r in result)
            {
                DataRow row = table.NewRow();
                row["ファイルパス"] = r.path;
                row["結果"] = r.isSuccess ? "O" : "X";
                row["エラー"] = r.message;

                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 600;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 300;
        }
    }
}
