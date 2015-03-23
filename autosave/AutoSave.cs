using System;
using Rocket.RocketAPI;
using SDG;
using UnityEngine;

namespace AutoSave
{
    internal class AutoSave : RocketPlugin<AutoSaveConfiguration>
    {
        public DateTime start = DateTime.Now;
        public bool msgYorN;

        public void save() {
            if (!this.Configuration.Enabled)
            {
                return;
            }
                
            if (this.Loaded != false && this.start != null && (DateTime.Now - this.start).TotalSeconds > (double) this.Configuration.SaveInterval)
            {
                if (!this.msgYorN)
                {
                    RocketChatManager.Say(this.Configuration.SaveMsg, (EChatMode)0);
                    this.msgYorN = true;
                }
                SaveManager.save();
                this.msgYorN = false;
                this.start = DateTime.Now;
                Debug.Log("Saved at " + DateTime.Now);
            }
        }
        public void FixedUpdate()
        {
            this.save();
        }
    }
}
