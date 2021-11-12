using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftopiaSavefileEditor.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Jil;

    public partial class WorldModel
    {
        [JilDirective(Name = "WorldSave")]
        public WorldSave WorldSave { get; set; }
    }

    public partial class WorldSave
    {
        [JilDirective(Name = "__type")]
        public string Type { get; set; }

        [JilDirective(Name = "value")]
        public Value Value { get; set; }
    }

    public partial class Value
    {
        [JilDirective(Name = "name")]
        public string Name { get; set; }

        [JilDirective(Name = "worldSeed")]
        public long WorldSeed { get; set; }

        [JilDirective(Name = "IslandSaveDatas")]
        public List<object> IslandSaveDatas { get; set; }

        [JilDirective(Name = "IslandInfos")]
        public List<IslandInfo> IslandInfos { get; set; }

        [JilDirective(Name = "lastIsland")]
        public long LastIsland { get; set; }

        [JilDirective(Name = "worldLevel")]
        public long WorldLevel { get; set; }

        [JilDirective(Name = "latestHour")]
        public double LatestHour { get; set; }

        [JilDirective(Name = "latestDay")]
        public long LatestDay { get; set; }

        [JilDirective(Name = "supplyPodTimer")]
        public double SupplyPodTimer { get; set; }

        [JilDirective(Name = "supplyPodInterval")]
        public double SupplyPodInterval { get; set; }

        [JilDirective(Name = "openFirstSpring")]
        public bool OpenFirstSpring { get; set; }

        [JilDirective(Name = "openFirstEmpty")]
        public bool OpenFirstEmpty { get; set; }

        [JilDirective(Name = "openFirstAutumn")]
        public bool OpenFirstAutumn { get; set; }

        [JilDirective(Name = "openFirstHell")]
        public bool OpenFirstHell { get; set; }

        [JilDirective(Name = "openFirstPoison")]
        public bool OpenFirstPoison { get; set; }

        [JilDirective(Name = "gameDifficulty")]
        public long GameDifficulty { get; set; }

        [JilDirective(Name = "gameMode")]
        public long GameMode { get; set; }

        [JilDirective(Name = "worldHeritage_TheStatueOfLiberty_EpRate")]
        public long WorldHeritageTheStatueOfLibertyEpRate { get; set; }

        [JilDirective(Name = "worldHeritage_TheStatueOfLiberty_EpNum")]
        public long WorldHeritageTheStatueOfLibertyEpNum { get; set; }

        [JilDirective(Name = "questNpcDataDic")]
        public QuestNpcDataDic QuestNpcDataDic { get; set; }

        [JilDirective(Name = "creativeModeSetting")]
        public CreativeModeSetting CreativeModeSetting { get; set; }

        [JilDirective(Name = "plStartingData")]
        public PlStartingData PlStartingData { get; set; }

        [JilDirective(Name = "createdDate")]
        public CreatedDate CreatedDate { get; set; }
    }

    public partial class CreatedDate
    {
        [JilDirective(Name = "ticks")]
        public double Ticks { get; set; }
    }

    public partial class CreativeModeSetting
    {
        [JilDirective(Name = "debugCraft")]
        public bool DebugCraft { get; set; }

        [JilDirective(Name = "worldLevel")]
        public long WorldLevel { get; set; }

        [JilDirective(Name = "islandLevel")]
        public long IslandLevel { get; set; }

        [JilDirective(Name = "noDeath")]
        public bool NoDeath { get; set; }

        [JilDirective(Name = "noDamage")]
        public bool NoDamage { get; set; }

        [JilDirective(Name = "noHunger")]
        public bool NoHunger { get; set; }

        [JilDirective(Name = "infinitST")]
        public bool InfinitSt { get; set; }

        [JilDirective(Name = "forceDayTime")]
        public long ForceDayTime { get; set; }

        [JilDirective(Name = "noBuildingDamage")]
        public bool NoBuildingDamage { get; set; }

        [JilDirective(Name = "limitBuild")]
        public bool LimitBuild { get; set; }
    }

    public partial class IslandInfo
    {
        [JilDirective(Name = "islandID")]
        public long IslandId { get; set; }

        [JilDirective(Name = "mapPieceID")]
        public int MapPieceId { get; set; }

        [JilDirective(Name = "islandLevel")]
        public long IslandLevel { get; set; }

        [JilDirective(Name = "islandName")]
        public object IslandName { get; set; }
    }

    public partial class PlStartingData
    {
        [JilDirective(Name = "Level")]
        public long Level { get; set; }

        [JilDirective(Name = "Money")]
        public long Money { get; set; }

        [JilDirective(Name = "SkillPoint")]
        public long SkillPoint { get; set; }

        [JilDirective(Name = "EnchantPoint")]
        public long EnchantPoint { get; set; }

        [JilDirective(Name = "Health")]
        public long Health { get; set; }

        [JilDirective(Name = "Mana")]
        public long Mana { get; set; }

        [JilDirective(Name = "Stamina")]
        public long Stamina { get; set; }
    }

    public partial class QuestNpcDataDic
    {
    }
}
