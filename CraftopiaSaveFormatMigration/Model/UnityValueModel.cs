using Jil;

namespace CraftopiaSaveFormatMigration.Model
{
    /// <summary>
    /// PocketPair\Craftopia\Unity\4b4f4030-f8ea-4fd0-95d5-9976d9288868\Analytics\values
    /// </summary>
    internal partial class UnityValueModel
    {
        [JilDirective(Name = "config_etag")]
        public string ConfigEtag { get; set; }

        [JilDirective(Name = "app_info_hash")]
        public long AppInfoHash { get; set; }

        [JilDirective(Name = "app_installed")]
        public bool AppInstalled { get; set; }

        [JilDirective(Name = "engine_ver")]
        public string EngineVer { get; set; }

        [JilDirective(Name = "app_ver")]
        public string AppVer { get; set; }

        [JilDirective(Name = "registered_events")]
        public RegisteredEvents RegisteredEvents { get; set; }
    }

    public partial class RegisteredEvents
    {
    }
}
