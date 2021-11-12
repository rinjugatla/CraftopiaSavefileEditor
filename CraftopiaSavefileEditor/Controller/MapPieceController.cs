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
        private const int DefaultID = 0;

        private const string MapPieceFilepath = "./MapPieceList.csv";

        private List<MapPieceModel> MapPieces { get; set; } = new List<MapPieceModel>();

        private Dictionary<int, MapPieceModel> MapPiecesDict { get; set; } = new Dictionary<int, MapPieceModel>();

        public MapPieceController()
        {
            AddDefaultMapPiece();
            LoadMapPiece();
            CreateDict();
        }

        private void AddDefaultMapPiece()
        {
            // 未開放
            MapPieces.Add(new MapPieceModel(DefaultID, "", "", MapPieceModel.IslandBiome.None, -1, -1, -1, -1, MapPieceModel.IslandStatus.Enabled  ));
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

        private void CreateDict()
        {
            List<MapPieceModel> validPieces = GetValidMapPieces();
            foreach (var piece in validPieces)
                MapPiecesDict[piece.ID] = piece;
        }

        /// <summary>
        /// 有効なマップ情報を取得
        /// </summary>
        /// <returns></returns>
        public List<MapPieceModel> GetValidMapPieces()
        {
            return MapPieces.Where(p => p.Status == MapPieceModel.IslandStatus.Enabled).ToList();
        }

        public MapPieceModel GetMapPieceByPieceID(int id)
        {
            if (MapPiecesDict.Keys.Contains(id))
                return MapPiecesDict[id];
            return MapPiecesDict[DefaultID];
        }
    }
}
