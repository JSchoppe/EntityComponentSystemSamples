﻿using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// Defines the component data for fish actors.
/// </summary>
public struct FishComponent : IComponentData
{
    /// <summary>
    /// The current depth of the fish under the water.
    /// </summary>
    public float depth;
    /// <summary>
    /// The current target position of the fish.
    /// </summary>
    public float3 target;
    /// <summary>
    /// The speed of the fish.
    /// </summary>
    public float speed;
    /// <summary>
    /// The scale of the fish mesh.
    /// </summary>
    public float3 scale;
    /// <summary>
    /// Controls how far a fish will travel before changing directions.
    /// </summary>
    public float wanderMagnitude;
}