using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ugandali
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D smileyImage;
        Vector2 smileyPossition;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //smileyPossition = Vector2.Zero;  //aynısı
            smileyPossition = new Vector2(0.0f, 0.0f);
           
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            smileyImage = Content.Load<Texture2D>("Smiley");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            float time = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float speed = 100.0f;
            float move = speed * time;
            KeyboardState state = Keyboard.GetState();

            if(state.IsKeyDown(Keys.Down))
            {
                smileyPossition.Y += move; 
            }
            if(state.IsKeyDown(Keys.Up))
            {
                smileyPossition.Y -= move;
            }
            if (state.IsKeyDown(Keys.Left))
            {
                smileyPossition.X -= move;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                smileyPossition.X += move;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(smileyImage, smileyPossition,Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
