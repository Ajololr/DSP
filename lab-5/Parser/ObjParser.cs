﻿using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ObjParser
{
    public class ObjParser
    {
        public async Task<WavefrontObject> ReadFromFile(string filename)
        {
            var builder = new ObjBuilder();
            var file = File.OpenRead(filename);

            await file.ReadToEnd(async line =>
            {
                if (line.StartsWith("#") || line.Length == 0)
                {
                    return;
                }

                var splitLine = line.Split(' ');
                splitLine = splitLine.Where(
                val => val != "").ToArray();
                if (splitLine.Length < 2)
                {
                    throw new FormatException("Line has the wrong format");
                }

                if (splitLine[0] == "mtllib")
                {
                    var materialFile = Path.Combine(Path.GetDirectoryName(filename) ?? string.Empty, splitLine[1]);
                    var materials = await new MaterialParser().ReadFromFile(materialFile);
                    builder.SetMaterials(materials);
                }
                else
                {
                    ParseCommand(builder, splitLine);
                }
            });
           
            return builder.Build();
        }

        private static void ParseCommand(ObjBuilder builder, string[] line)
        {
            var command = line[0];
            var values = new ReadOnlySpan<string>(line, 1, line.Length - 1);
            switch (command)
            {
                case "s": builder.AddSmoothGroup(values); break;
                case "v": builder.AddPosition(values); break;
                case "vt": builder.AddTexture(values); break;
                case "vn": builder.AddNormal(values); break;
                case "f": builder.AddFace(values); break;
                case "g": builder.AddGroup(values);break;
                case "usemtl": builder.UseMaterial(values); break;
                case "o": break; // Don't care about object right now
                case "new": break; // Don't care about new right now


                default: Console.WriteLine($"{command} is not recognized as a wavefront obj identifier"); break;
            }
        }
    }
}