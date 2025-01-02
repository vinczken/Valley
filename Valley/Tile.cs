using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley
{
    public class Tile
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        private string texture;
        public string Texture { get { return texture; } set { texture = value;  } }
    }
}

