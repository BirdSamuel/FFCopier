using System;
using System.Collections.Generic;

namespace FFCopier.Data
{
    internal class CoreData
    {
        public static readonly List<string> requiredFiles = new() { "ACQ.DAT", "ADDON.DAT", "COMMON.DAT",
                        "CONTROL0.DAT", "CONTROL1.DAT", "GEARSET.DAT", "GS.DAT", "HOTBAR.DAT", "ITEMFDR.DAT",
                        "ITEMODR.DAT", "KEYBIND.DAT", "LOGFLTR.DAT", "MACRO.DAT", "UISAVE.DAT" };

        public static readonly string addNewCharacter = "Add New Character...";
        public static readonly string removeCharacter = "Remove Character...";
        public static readonly string allCharacters = "All Other Characters";

        public static readonly string characterFileName = "characters.json";
    }
}
