using BepInEx;
using HarmonyLib;
using I2.Loc;
using Oc;
using Oc.Maps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftopiaSavefileEditorMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class ServerUtilityPlugin : BaseUnityPlugin
    {
        private const string PluginGuid = "me.rin_jugatla.craftopia.mod.CraftopiaSavefileEditorMod";
        private const string PluginName = "CraftopiaSavefileEditorMod";
        private const string PluginVersion = "0.0.1";

        void Awake()
        {
            new Harmony(PluginGuid).PatchAll();
        }

        [HarmonyPatch(typeof(OcWorldManager))]
        public class OcWorldManager_Hook
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="__instance"></param>
            /// <param name="___mapPieceList">すべてのマップ</param>
            /// <param name="___validMapPieceList">有効なマップ</param>
            /// <param name="___islandTypeCounts">マップタイプ数</param>
            /// <param name="___islandList">転移画面で表示される島情報</param>
            [HarmonyPatch("OnUnityAwake"), HarmonyPostfix]
            static void OnUnityAwake_Postfix(OcWorldManager __instance, 
                SoMapPieceList  ___mapPieceList, SoMapPiece[] ___validMapPieceList, Dictionary<BiomeType, int> ___islandTypeCounts)
            {
                Directory.CreateDirectory(PluginName);

                string header = "ID,SceneName,IslandName,IslandBiome,MapSize,HellLevel,MinimumLevel,RandomWeight,Status\n";
                StringBuilder sb = new StringBuilder(header);
                foreach (var map in ___mapPieceList.GetAll())
                {
                    // マップ名取得
                    string islandName = LocalizationManager.GetTranslation($"900_IslandName/{map.ID}", true, 0, true, false, null, null);
                    sb.AppendLine($"{map.ID},{map.SceneName},{islandName},{map.IslandBiome},{map.MapSize},{map.HellLevel},{map.MinimumLevel},{map.RandomWeight},{map.Status}");
                }
                
                using (StreamWriter sw = new StreamWriter($@"{PluginName}\MapPieceList.csv", false, Encoding.UTF8))
                    sw.Write(sb.ToString());                
            }
        }
    }
}
