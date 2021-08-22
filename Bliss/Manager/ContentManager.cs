﻿using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Unity;

namespace Bliss.Manager
{
    public class ContentManager
    {
        [Dependency]
        public JamGame JamGame { get; set; }
        
        public Texture2D TableTexture => JamGame.Content.Load<Texture2D>("Sprites/Table");
        public Texture2D InvoiceTexture => JamGame.Content.Load<Texture2D>("Sprites/Invoice");
        public Texture2D ClockTexture => JamGame.Content.Load<Texture2D>("Sprites/Clock");

        public Texture2D ClockZeroTexture => JamGame.Content.Load<Texture2D>("Sprites/0");
        public Texture2D ClockOneTexture => JamGame.Content.Load<Texture2D>("Sprites/1");
        public Texture2D ClockTwoTexture => JamGame.Content.Load<Texture2D>("Sprites/2");
        public Texture2D ClockThreeTexture => JamGame.Content.Load<Texture2D>("Sprites/3");
        public Texture2D ClockFourTexture => JamGame.Content.Load<Texture2D>("Sprites/4");
        public Texture2D ClockFiveTexture => JamGame.Content.Load<Texture2D>("Sprites/5");
        public Texture2D ClockSixTexture => JamGame.Content.Load<Texture2D>("Sprites/6");
        public Texture2D ClockSevenTexture => JamGame.Content.Load<Texture2D>("Sprites/7");
        public Texture2D ClockEightTexture => JamGame.Content.Load<Texture2D>("Sprites/8");
        public Texture2D ClockNineTexture => JamGame.Content.Load<Texture2D>("Sprites/9");
        public Texture2D ClockColonTexture => JamGame.Content.Load<Texture2D>("Sprites/Colon");

        public SoundEffect DocumentLandedSoundEffect => JamGame.Content.Load<SoundEffect>("Sounds/DocumentLanded");
        public SoundEffect DocumentSpawnedSoundEffect => JamGame.Content.Load<SoundEffect>("Sounds/DocumentSpawned");
        public SoundEffect DocumentPickedUpSoundEffect => JamGame.Content.Load<SoundEffect>("Sounds/DocumentPickedUp");
        public SoundEffect DocumentPutDownSoundEffect => JamGame.Content.Load<SoundEffect>("Sounds/DocumentPutDown");

        public SpriteFont ArialSpriteFont => JamGame.Content.Load<SpriteFont>("Fonts/Arial");
    }
}
