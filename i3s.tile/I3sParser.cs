﻿using System.IO;

namespace I3s.Tile
{
    public static class I3sParser
    {
        public static I3s ParseI3s(Stream stream)
        {
            var i3s = new I3s();

            // assume defaultGeometrySchema as a start...

            // read header
            using (var reader = new BinaryReader(stream))
            {
                i3s.VertexCount = (int)reader.ReadUInt32();
                i3s.FeatureCount = (int)reader.ReadUInt32();

                // todo: read rest of items

                // header
                //uint32 vertexCount;
                //uint32 featureCount;

                //// vertex attributes
                //float32 position[3 * vertexCount];
                //float32 normal[3 * vertexCount];
                //float32 uv0[2 * vertexCount];
                //uint8 color[4 * vertexCount];

                //// feature attributes
                //uint64 id[featureCount];
                //uint32 faceRange[2 * featureCount];
            }
            return i3s;
        }
    }
}
