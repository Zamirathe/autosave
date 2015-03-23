using Rocket.RocketAPI;

namespace AutoSave
{
    public class AutoSaveConfiguration : RocketConfiguration
    {
        public bool Enabled;
        public int SaveInterval;
        public string SaveMsg;

        public RocketConfiguration DefaultConfiguration 
        {
            get 
            {
                AutoSaveConfiguration configuration = new AutoSaveConfiguration();
                configuration.Enabled = true;
                configuration.SaveInterval = 1800;
                configuration.SaveMsg = "Saving world...";
            return (RocketConfiguration) configuration;
            }
        }
        public AutoSaveConfiguration() : base()
        {
            return;
        }
    }
}
