using CraftopiaSavefileEditor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftopiaSavefileEditor.Controller
{
    internal class MapPieceController
    {
        private const string MapPieceFilepath = "./MapPieceList.csv";

        private List<MapPieceModel> MapPieces { get; set; } = new List<MapPieceModel>();

        public MapPieceController()
        {
            AddDefaultMapPiece();
            LoadMapPiece();
        }

        private void AddDefaultMapPiece()
        {
            MapPieces.Add(new MapPieceModel(-1, "", "未開放", MapPieceModel.IslandBiome.None, -1, -1, -1, -1, MapPieceModel.IslandStatus.Enabled  ));
        }

        private void LoadMapPiece()
        {
            if (!File.Exists(MapPieceFilepath))
                return;

            string text = "";
            using (StreamReader sr = new StreamReader(MapPieceFilepath, Encoding.UTF8))
                text = sr.ReadToEnd();
            string[] lines = text.Split('\n');

            int skipHeader = 1;
            foreach (var line in lines.Skip(skipHeader))
            {
                try
                {
                    MapPieces.Add(new MapPieceModel(line));
                }
                catch (NullReferenceException)
                {
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 有効なマップ情報を取得
        /// </summary>
        /// <returns></returns>
        public List<MapPieceModel> GetValidMapPieces()
        {
            return MapPieces.Where(p => p.Status == MapPieceModel.IslandStatus.Enabled).ToList();
        }
    }
}
