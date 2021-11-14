using CraftopiaSavefileEditor.Model;
using Jil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftopiaSavefileEditor.Controller
{
    internal class WorldController
    {
        /// <summary>
        /// フォルダから取得した初期値
        /// </summary>
        private List<WorldModel> OriginWorlds { get; set; }
        /// <summary>
        /// 変更用
        /// </summary>
        public List<WorldModel> ModifyWorlds { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directoryPath">Worldsフォルダパス</param>
        public WorldController(string directoryPath)
        {
            OriginWorlds = new List<WorldModel>();

            string[] files = Directory.GetFiles(directoryPath, "World*.ocs", SearchOption.TopDirectoryOnly);
            string json;
            WorldModel world;
            foreach (var file in files)
            {
                try
                {
                    json = OcsController.LoadOcs(file);
                    if (json == null)
                        continue;
                    world = JSON.Deserialize<WorldModel>(json);
                    OriginWorlds.Add(world);
                }
                catch (Exception)
                {
                }
            }

            ModifyWorlds = new List<WorldModel>(OriginWorlds);
        }

        /// <summary>
        /// ワールド名を取得
        /// </summary>
        /// <returns></returns>
        public List<string> GetWorldNames()
        {
            var names = OriginWorlds.Select(w => w.WorldSave.Value.Name).ToList();

            return names;
        }

        /// <summary>
        /// World情報取得
        /// </summary>
        /// <param name="isOrigin">初期値で取得するか</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public WorldModel GetWorld(bool isOrigin, int index)
        {
            if (isOrigin)
                return OriginWorlds[index];
            return ModifyWorlds[index];
        }
    }
}
