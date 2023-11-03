using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GinyuDisplay
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Our game world data and assets
        Texture2D ginyuTexture;
        Rectangle ginyuRect;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            //positions the sprite image on the screen
            ginyuRect = new Rectangle(
                0, //X position of top left corner
                0, //Y position of top left corner
                GraphicsDevice.Viewport.Width, //rectangle width
                GraphicsDevice.Viewport.Height); //rectangle height

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //Loads 2D texture xnb file
            ginyuTexture = Content.Load<Texture2D>("ginyu_force");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //code to draw sprites on screen
            _spriteBatch.Begin();
            _spriteBatch.Draw(ginyuTexture, ginyuRect, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}