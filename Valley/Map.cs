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

namespace Valley
{
    public class Map
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string tiles;
        public string Tiles { get { return tiles; } set { tiles = value; } }

    }
}