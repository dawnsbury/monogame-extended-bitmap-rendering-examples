using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.BitmapFonts;

namespace App1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private BitmapFont _bitmapFont;
    private BitmapFont _bitmapFont2;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _bitmapFont = Content.Load<BitmapFont>("Mia32");
        _bitmapFont2 = Content.Load<BitmapFont>("Mia8");

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Beige);

        // TODO: Add your drawing code here
        _spriteBatch.Begin(SpriteSortMode.Deferred);
        _spriteBatch.DrawString(_bitmapFont, "The effects are determined by the target's Will save.\n\nOn a critical failure, the target becomes dominated\nuntil the end of your next turn or until you fall\nunconscious, whichever comes first.", new Vector2(10,10), Color.Black);
        _spriteBatch.DrawString(_bitmapFont2, "The effects are determined by the target's Will save.\n\nOn a critical failure, the target becomes dominated\nuntil the end of your next turn or until you fall\nunconscious, whichever comes first.", new Vector2(10,300), Color.Black);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}