using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;

namespace Valley
{
    public class Map
    {
        private int id = 1;
        public int Id { get { return id; } set { id = value; } }
        private string name = "owo";
        public string Name { get { return name; } set { name = value; } }
        private string tiles = "0,0,0\n0,0,0";
        public string Tiles { get { return tiles; } set { tiles = value; } }




        /*
        public static void ConvertTextToXml(string input, string output)
        {
            if (string.IsNullOrEmpty(input)) { return; }
            if (string.IsNullOrEmpty(output)) { return; }

            string pathIn = Path.Combine("Content", "map", input);
            string pathOut = Path.Combine("Content", "map", output);

            string[] lines = File.ReadAllLines(pathIn);

            XElement xnaContent = new XElement("XnaContent", new XAttribute(XNamespace.Xmlns + "Valley-Prot", "Valley-Prot"));

            XElement mapAsset = new XElement("Asset", new XAttribute("Type", "Valley-Prot:Map"));
            XElement objectAsset = new XElement("Asset", new XAttribute("Type", "Valley-Prot:Object"));
            XElement tileMap = new XElement("TileMap");

            bool isMapSection = false;


            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if(string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith("#"))
                {
                    if(trimmedLine.StartsWith("# Map")) 
                        isMapSection = true;
                }
                else
                {
                    if(isMapSection)
                    {
                        string values = trimmedLine.Replace(" ", "");
                        XElement row = new XElement("Row");

                        row.Add(values);
                        tileMap.Add(row);
                    }
                }
            }

            if (isMapSection)
            {
                mapAsset.Add(tileMap);
            }

            xnaContent.Add(mapAsset);
            xnaContent.Add(objectAsset);

            XDocument xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), xnaContent);

            xmlDoc.Save(output);
        }
        public static List<List<int>> CreateListOfXml(XDocument xmlMap)
        {
            List<List<int>> map = new List<List<int>>();

            foreach (XElement row in xmlMap.Descendants("row"))
            {
                List<int> rowList = new List<int>();

                foreach(XElement tile in row.Elements("tile"))
                {
                    row.Add(int.Parse(tile.Value));
                }

                map.Add(rowList);
            }

            return map;
        }
        */

    }
}