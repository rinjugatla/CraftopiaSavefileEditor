using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftopiaSavefileEditor.Controller
{
    internal class OcsController
    {
        /// <summary>
        /// ocsファイルをjsonファイルに変換
        /// </summary>
        /// <param name="path">ocsファイルパス</param>
        public static void ConvertOcs2Json(string path)
        {
            string text = LoadOcs(path);
            string savePath = $@"{Path.GetDirectoryName(path)}\{Path.GetFileNameWithoutExtension(path)}.json";

            using (StreamWriter sw = new StreamWriter(savePath, false, Encoding.UTF8))
                sw.Write(text);
        }

        /// <summary>
        /// Ocsファイルをテキストで取得
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string LoadOcs(string path)
        {
            byte[] buffer = new byte[1024];

            StringBuilder sb = new StringBuilder();
            using (FileStream fsIn = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (GZipStream gz = new GZipStream(fsIn, CompressionMode.Decompress))
            {
                int size = 0;
                while ((size = gz.Read(buffer, 0, buffer.Length)) > 0)
                {
                    sb.Append(Encoding.UTF8.GetString(buffer, 0, size));
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// テキストファイルをocsファイルに変換
        /// </summary>
        /// <param name="path">jsonファイルパス</param>
        public static void ConvertJson2Ocs(string path)
        {
            string text = null;
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                text = sr.ReadToEnd();

            string savePath = $@"{Path.GetDirectoryName(path)}\{Path.GetFileNameWithoutExtension(path)}.ocs";
            SaveOcs(savePath, text);
        }

        /// <summary>
        /// テキストをocsファイルに保存
        /// </summary>
        /// <param name="path">保存先</param>
        /// <param name="text"></param>
        public static void SaveOcs(string path, string text)
        {
            string ext = Path.GetExtension(path);
            if (ext == "" || ext != ".ocs")
                path += "ocs";

            byte[] data = Encoding.UTF8.GetBytes(text);
            using (FileStream fsOut = new FileStream(path, FileMode.Create))
            using (GZipStream gz = new GZipStream(fsOut, CompressionMode.Compress))
            {
                gz.Write(data, 0, data.Length);
            }
        }
    }
}
