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
        public List<WorldModel> Worlds { get; private set; } = new List<WorldModel>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directoryPath">Worldsフォルダパス</param>
        public WorldController(string directoryPath)
        {
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
                    Worlds.Add(world);
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// ワールド名を取得
        /// </summary>
        /// <returns></returns>
        public List<string> GetWorldNames()
        {
            var names = Worlds.Select(w => w.WorldSave.Value.Name).ToList();

            return names;
        }
    }
}
