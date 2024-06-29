using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QM_EnableConsole
{
    [HarmonyPatch(typeof(VertTableParser<MGSC.GlobalSettings>), "ParseLine")]
    public static class VertTableParser_ParseLine_Patch
    {

        public static void Prefix(string[] parsed)
        {
            try
            {
                if (parsed[0] == "Console" && parsed[1] == "false")
                {
                    parsed[1] = "true";
                }

            }
            catch (Exception ex)
            {
                Plugin.Log.LogError("ParseLine prefix error: " + ex.ToString());
            }
        }

    }
}
