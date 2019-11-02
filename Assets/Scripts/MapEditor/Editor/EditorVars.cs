﻿using UnityEngine;

public static class EditorVars
{
    public static class ToolTips
    {
        public static GUIContent editorInfo = new GUIContent("Editor Info", "Info about the current editor, when reporting bugs make sure to include a copy of these values.");
        public static GUIContent systemOS = new GUIContent("OS: " + SystemInfo.operatingSystem);
        public static GUIContent systemRAM = new GUIContent("RAM: " + SystemInfo.systemMemorySize);
        public static GUIContent unityVersion = new GUIContent("Unity Version: " + Application.unityVersion);
        public static GUIContent editorVersion = new GUIContent("Editor Version: v2.2-prerelease");

        public static GUIContent prefabCategory = new GUIContent("Category:", "The Category group assigned to the prefab.");
        public static GUIContent prefabID = new GUIContent("ID:", "The Prefab ID assigned to the prefab.");
        public static GUIContent prefabName = new GUIContent("Name:", "The Prefab name.");

        public static GUIContent assetBundle = new GUIContent("Asset Bundle");
        public static GUIContent loadBundle = new GUIContent("Load", "Loads the Rust asset bundle into memory.");
        public static GUIContent unloadBundle = new GUIContent("Unload", "Unloads the loaded bundle.");

        public static GUIContent presets = new GUIContent("Node Presets", "List of all the node presets in the project.");
        public static GUIContent openPreset = new GUIContent("Open", "Opens the Node preset.");
        public static GUIContent refreshPresets = new GUIContent("Refresh presets list.", "Refreshes the list of all the Node Presets in the project.");
        public static GUIContent noPresets = new GUIContent("No presets in list.", "Try creating a some presets first.");

        public static GUIContent editorLinks = new GUIContent("Links", "Links to discord, wiki and the project GitHub.");
        public static GUIContent reportBug = new GUIContent("Report Bug", "Opens up the editor bug report in GitHub.");
        public static GUIContent requestFeature = new GUIContent("Request Feature", "Opens up the editor feature request in GitHub.");
        public static GUIContent roadMap = new GUIContent("RoadMap", "Opens up the editor roadmap in GitHub.");
        public static GUIContent wiki = new GUIContent("Wiki", "Opens up the editor wiki in GitHub.");
        public static GUIContent discord = new GUIContent("Discord", "Discord invitation link.");

        public static GUIContent tools = new GUIContent("Tools");
        public static GUIContent editorSettings = new GUIContent("Settings");
        public static GUIContent saveSettings = new GUIContent("Save", "Sets and saves the current settings.");
        public static GUIContent discardSettings = new GUIContent("Discard", "Discards the changes to the settings.");
        public static GUIContent defaultSettings = new GUIContent("Default", "Sets the settings back to the default.");
        public static GUIContent rustDirectory = new GUIContent("Rust Directory", @"The base install directory of Rust. Normally located at steamapps\common\Rust");
        public static GUIContent browseRustDirectory = new GUIContent("Browse", "Browse and select the base directory of Rust.");
        public static GUIContent rustDirectoryPath = new GUIContent(MapEditorSettings.rustDirectory, "The install directory of Rust on the local PC.");
        public static GUIContent objectQuality = new GUIContent("Object Quality", "Changes the distance objects can be seen from.");


        public static GUIContent mapInfo = new GUIContent("Map Info", "General info about the currently loaded map.");
        public static GUIContent loadMap = new GUIContent("Load", "Opens a file viewer to find and open a Rust .map file.");
        public static GUIContent saveMap = new GUIContent("Save", "Opens a file viewer to find and save a Rust .map file.");
        public static GUIContent newMap = new GUIContent("New", "Creates a new map with the selected size.");
        public static GUIContent mapSize = new GUIContent("Size", "The size to create any new maps. Must be between (1000-6000)");

        public static GUIContent exportMapPrefabs = new GUIContent("Export Map Prefabs", "Exports all map prefabs to a .JSON file.");
        public static GUIContent exportMapLootCrates = new GUIContent("Export LootCrates", "Exports all lootcrates that don't yet respawn in Rust to a JSON for use with the LootCrateRespawn plugin.");
        public static GUIContent deleteOnExport = new GUIContent("Delete on Export.", "Deletes prefabs/lootcrates after exporting.");
        public static GUIContent groupRustEditPrefabs = new GUIContent("Group RustEdit Custom Prefabs", "Groups all custom prefabs saved in the map file.");
        public static GUIContent breakRustEditPrefabs = new GUIContent("Break RustEdit Custom Prefabs", "Breaks down all custom prefabs saved in the map file.");
        public static GUIContent hidePrefabsInRustEdit = new GUIContent("Hide Prefabs in RustEdit", "Changes all the prefab categories to a semi-colon. Hides all of the prefabs from appearing in RustEdit.");
        
        public static GUIContent deleteMapPrefabs = new GUIContent("Delete All Map Prefabs", "Removes all the prefabs from the map.");
        public static GUIContent deleteMapPaths = new GUIContent("Delete All Map Paths", "Removes all the paths from the map.");

        public static GUIContent snapToGround = new GUIContent("Snap To Ground", "Snap the selected prefab to the terrain height.");

        public static GUIContent toggleBlend = new GUIContent("Blend", "Blends out the active texture to create a smooth transition the surrounding textures.");
        public static GUIContent rangeLow = new GUIContent("From:", "The lowest value to paint the active texture.");
        public static GUIContent rangeHigh = new GUIContent("To:", "The highest value to paint the active texture.");
        public static GUIContent blendLow = new GUIContent("Blend Low:", "The lowest value to blend out to.");
        public static GUIContent blendHigh = new GUIContent("Blend High:", "The highest value to blend out to.");

        public static GUIContent fromZ = new GUIContent("From Z", "The starting point to paint the active texture.");
        public static GUIContent toZ = new GUIContent("To Z", "The ending point to paint the active texture.");
        public static GUIContent fromX = new GUIContent("From X", "The starting point to paint the active texture.");
        public static GUIContent toX = new GUIContent("To X", "The ending point to paint the active texture.");

        public static GUIContent paintRivers = new GUIContent("Paint Rivers", "Paints the active texture wherever the water is above 500.");
        public static GUIContent eraseRivers = new GUIContent("Erase Rivers", "Paints the inactive texture wherever the water is above 500.");
        public static GUIContent aboveTerrain = new GUIContent("Above Terrain", "Paint only where there is water above sea level and above the terrain.");

        public static GUIContent groundTextureSelect = new GUIContent("Texture:", "The Ground texture the tools will paint with.");
        public static GUIContent biomeTextureSelect = new GUIContent("Texture:", "The Biome texture the tools will paint with.");
        public static GUIContent topologyLayerSelect = new GUIContent("Topology Layer:", "The Topology layer to display.");

        public static GUIContent paintSlopes = new GUIContent("Paint Slopes", "Paints the active texture within the slope range.");
        public static GUIContent eraseSlopes = new GUIContent("Erase Slopes", "Paints the inactive texture within the slope range.");

        public static GUIContent paintHeights = new GUIContent("Paint Heights", "Paints the active texture within the height range.");
        public static GUIContent eraseHeights = new GUIContent("Erase Heights", "Paints the inactive texture within the height range.");

        public static GUIContent rotate90 = new GUIContent("Rotate 90°", "Rotate the layer 90°.");
        public static GUIContent rotate270 = new GUIContent("Rotate 270°", "Rotate the layer 270°.");

        public static GUIContent terrace = new GUIContent("Terrace", "Terrace the entire terrain.");
        public static GUIContent featureSize = new GUIContent("Feature Size", "The higher the value the more terrace levels generated.");
        public static GUIContent cornerWeight = new GUIContent("Corner Weight", "The strength of the corners of the terrace.");
        public static GUIContent terraceMap = new GUIContent("Terrace Map", "Terraces the heightmap.");

        public static GUIContent smooth = new GUIContent("Smooth", "Smooth the entire terrain.");
        public static GUIContent smoothStrength = new GUIContent("Strength", "The strength of the smoothing operation.");
        public static GUIContent blurDirection = new GUIContent("Blur Direction", "The direction the terrain should blur towards. Negative is down, positive is up.");
        public static GUIContent smoothMap = new GUIContent("Smooth Map", "Smoothes the heightmap the selected amount of times.");

        public static GUIContent normalise = new GUIContent("Normalise", "Scales the terrain between the two heights.");
        public static GUIContent normaliseLow = new GUIContent("Low", "The lowest point on the map after being normalised.");
        public static GUIContent normaliseHigh = new GUIContent("High", "The highest point on the map after being normalised.");
        public static GUIContent normaliseMap = new GUIContent("Normalise", "Normalises the heightmap between these heights.");
        public static GUIContent autoUpdateNormalise = new GUIContent("Auto Update", "Automatically normalises the changes to the terrain on value change.");
    }
}