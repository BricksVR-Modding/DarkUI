using MelonLoader;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace DarkMode
{
    public static class BuildInfo
    {
        public const string Name = "DarkUI"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "A DarkUI mod for BricksVR."; // Description for the Mod.  (Set as null if none)
        public const string Author = "BelugaTheAxolotl#2134"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.1.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class UIset : MelonMod
    {
        public override void OnSceneWasInitialized(int buildindex, string sceneName)
        {
            GameObject.Find("MenuBoard/Background").GetComponent<Image>().color = new Color(0, 0, 0, 0.75f);
            var allOBJ = Resources.FindObjectsOfTypeAll<GameObject>();
            for (var e = 0; e < allOBJ.Length; e++)
            {
                if (!allOBJ[e].GetComponent<Button>()) continue;
                if (allOBJ[e].GetComponent<Image>() && allOBJ[e].transform.GetChild(0).GetComponent<TextMeshProUGUI>())
                {
                    allOBJ[e].GetComponent<Image>().color = new Color(0, 0, 0, 0.75f);
                    allOBJ[e].transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(0.5755f, 0.5755f, 0.5755f, 1);
                    allOBJ[e].transform.GetChild(0).GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255);
                }

            }
        }
    }
}