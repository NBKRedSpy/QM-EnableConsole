using BepInEx;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QM_EnableConsole
{
    [BepInPlugin("nbk_redspy.QM_EnableConsole", "QM_EnableConsole", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {

        public static BepInEx.Logging.ManualLogSource Log { get; set; }

        private void Awake()
        {
            Log = Logger;

            Harmony harmony = new Harmony("nbk_redspy.QM_EnableConsole");
            harmony.PatchAll();

        }
    }
}
