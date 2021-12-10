using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(DarkMode.BuildInfo.Description)]
[assembly: AssemblyDescription(DarkMode.BuildInfo.Description)]
[assembly: AssemblyCompany(DarkMode.BuildInfo.Company)]
[assembly: AssemblyProduct(DarkMode.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + DarkMode.BuildInfo.Author)]
[assembly: AssemblyTrademark(DarkMode.BuildInfo.Company)]
[assembly: AssemblyVersion(DarkMode.BuildInfo.Version)]
[assembly: AssemblyFileVersion(DarkMode.BuildInfo.Version)]
[assembly: MelonInfo(typeof(DarkMode.UIset), DarkMode.BuildInfo.Name, DarkMode.BuildInfo.Version, DarkMode.BuildInfo.Author, DarkMode.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("BricksVR", "BricksVR")]