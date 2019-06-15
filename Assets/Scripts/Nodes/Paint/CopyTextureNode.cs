﻿using System;
using UnityEngine;
using XNode;

[CreateNodeMenu("Paint/Copy Texture")]
public class CopyTextureNode : Node
{
    [Input(ShowBackingValue.Never, ConnectionType.Override)] public NodeVariables.Texture Texture;
    [Input(ShowBackingValue.Never, ConnectionType.Override)] public NodeVariables.NextTask PreviousTask;
    [Output] public NodeVariables.NextTask NextTask;
    [NonSerialized()] public int landLayerFrom, textureFrom, topologyFrom;
    [NonSerialized()] public string[] landLayers = { "Ground", "Biome", "Alpha", "Topology" };
    public override object GetValue(NodePort port)
    {
        NodeVariables.Texture Texture = GetInputValue("Texture", this.Texture);
        return Texture;
    }
    public object GetValue()
    {
        return GetInputValue<object>("Texture");
    }
    public void RunNode()
    {
        var layer = (NodeVariables.Texture)GetValue();
        MapIO mapIO = GameObject.FindGameObjectWithTag("MapIO").GetComponent<MapIO>();
        if (layer == null) // Check for if the textures node is not connected.
        {
            return;
        }
        switch (layer.LandLayer)
        {
            case 0: // Ground
                mapIO.CopyTexture(landLayers[landLayerFrom], "Ground", textureFrom, TerrainSplat.TypeToIndex(layer.GroundTexture));
                break;
            case 1: // Biome
                mapIO.CopyTexture(landLayers[landLayerFrom], "Biome", textureFrom, TerrainBiome.TypeToIndex(layer.BiomeTexture));
                break;
            case 2: // Alpha
                mapIO.CopyTexture(landLayers[landLayerFrom], "Alpha", textureFrom, layer.AlphaTexture);
                break;
            case 3: // Topology. Going to overhaul the topology layers soon to avoid all the changing of layer values.
                mapIO.CopyTexture(landLayers[landLayerFrom], "Topology", textureFrom, layer.TopologyTexture, topologyFrom, layer.TopologyLayer);
                break;
        }
    }
}