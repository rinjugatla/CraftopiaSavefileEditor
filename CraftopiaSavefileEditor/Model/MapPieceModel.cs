using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftopiaSavefileEditor.Model
{
    internal class MapPieceModel
    {
        public int ID { get; private set; }
        public string SceneName { get; private set; }
        public string Name { get; private set; }
        public IslandBiome Biome { get; private set; }
        public int Size { get; private set; }
        public int HellLevel { get; private set; }
        public int MinimumLevel { get; private set; }
        public float RandomWeight { get; private set; }
        public IslandStatus Status { get; private set; }

        public enum IslandBiome
        {
            None,
            Grassland,
            Complex,
            Volcano,
            Desert,
            Hell,
            Poison,
            Snowfield,
        }

        public enum IslandStatus
        {
            Enabled = 0,
            EditorOnly = 3,
            Disabled = 99
        }

        public MapPieceModel Self
        {
            get { return this; }
        }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// CSV読み取り結果からモデル情報を作成
        /// </summary>
        /// <remarks>
        /// ID,SceneName,IslandName,IslandBiome,MapSize,HellLevel,MinimumLevel,RandomWeight,Status
        /// </remarks>
        /// <param name="param"></param>
        public MapPieceModel(string line)
        {
            string[] param = line.Split(',');
            if (line == null || line == "")
                throw new NullReferenceException();
            if (param.Length != 9)
                throw new Exception("要素に過不足があります。");

            ID = int.Parse(param[0]);
            SceneName = param[1];
            Name = param[2];
            Biome = (IslandBiome)Enum.Parse(typeof(IslandBiome), param[3]);
            Size = int.Parse(param[4]);
            HellLevel = int.Parse(param[5]);
            MinimumLevel = int.Parse(param[6]);
            RandomWeight = float.Parse(param[7]);
            Status = (IslandStatus)Enum.Parse(typeof(IslandStatus), param[8]);
        }

        public MapPieceModel(int id, string sceneName, string name, IslandBiome biome, 
            int size, int hellLevel, int minimumLevel, float randomWeight, IslandStatus status)
        {
            ID = id;
            SceneName = sceneName;
            Name = name;
            Biome = biome;
            Size = size;
            HellLevel = hellLevel;
            MinimumLevel = minimumLevel;
            RandomWeight = randomWeight;
            Status = status;
        }
    }
}
