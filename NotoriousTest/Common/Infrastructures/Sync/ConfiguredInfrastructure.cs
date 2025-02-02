﻿namespace NotoriousTest.Common.Infrastructures.Sync
{
    public abstract class ConfiguredInfrastructure<TConfig> : Infrastructure where TConfig: new()
    {
        public TConfig Configuration { get; set; }
        public ConfiguredInfrastructure(bool initialize = false, bool autoreset = true) : base(initialize, autoreset)
        {

        }
    }

    public abstract class ConfiguredInfrastructure : ConfiguredInfrastructure<Dictionary<string, string>>
    {
        public ConfiguredInfrastructure(bool initialize = false, bool autoreset = true) : base(initialize, autoreset)
        {

        }
    }
}
