// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;

namespace RealityCollective.Utilities.Gltf.Schema
{
    /// <summary>
    /// A texture and its sampler.
    /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/texture.schema.json
    /// </summary>
    [Serializable]
    public class GltfTexture : GltfChildOfRootProperty
    {
        /// <summary>
        /// The index of the sampler used by this texture.
        /// </summary>
        public int sampler = -1;

        /// <summary>
        /// The index of the image used by this texture.
        /// </summary>
        public int source = -1;

        /// <summary>
        /// Unity Texture2D wrapper for GltfTexture
        /// </summary>
        public Texture2D Texture { get; internal set; }
    }
}