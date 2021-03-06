﻿using Game1.Factories;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.States
{
    class HiddenBlockState: IBlockState
    {
        public ISprite Sprite { get; set; }

        public HiddenBlockState()
        {
            Sprite = BlockSpritesFactory.Instance.CreateHiddenBlockSprite();
        }

      
        public void Update(GameTime gametime)
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Sprite.Draw(spriteBatch, location);
        }
    }
}
