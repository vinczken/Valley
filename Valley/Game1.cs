using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Valley
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private int gameWidth = 800;
        private int gameHeight = 600;

        private List<Tile> tileType;
        private Map map;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = gameWidth;
            _graphics.PreferredBackBufferHeight = gameHeight;
        }

        protected override void Initialize()
        {

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            tileType = new List<Tile>();

            Texture2D tileZeroTex = Content.Load<Texture2D>("map/map-textures/0");
            //Tile tileZero = new Tile(0, tileZeroTex);
            Texture2D tileOneTex = Content.Load<Texture2D>("map/map-textures/1");
            //Tile tileOne = new Tile(1, tileOneTex);

            //tileType.Add(tileZero);
            //tileType.Add(tileOne);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            _spriteBatch.Begin();

            /*
            for(int i = 0; i < mapLines.Length; i++)
            {
                string[] map = mapLines[i].Split(",");
                for(int j = 0; j < map.Length; j++)
                {
                    int x = (j * 20) % gameWidth;
                    int y = (i * 20) % gameHeight;
                    Vector2 position = new Vector2(x, y);

                    int textureIndex = int.Parse(map[j]);
                    Texture2D texture = mapTextures[textureIndex];
                    _spriteBatch.Draw(texture, position, null, Color.White, 0f, new Vector2(texture.Width / 2, texture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
                }
            }
            */

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
