using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace inventory
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        bool invenActive = false;
        SpriteFont font;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D invenBackGround;

        Input In = new Input();
        Inventory inven = new Inventory();
        Meters health = new Meters(100,"Health");
        Meters power = new Meters(0, "Attack Power");

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
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

            inven.AddItem(new Weapons("voulge", 1,Items.Type.weapon,150));
            inven.AddItem(new consumable("health pot", 2, Items.Type.consumable,200));
            inven.AddItem(new consumable("bread", 3, Items.Type.consumable,100));
            inven.AddItem(new Weapons("sythe", 35, Items.Type.weapon,100));
            inven.AddItem(new consumable("bread", 3, Items.Type.consumable,100));
            inven.AddItem(new consumable("bread", 3, Items.Type.consumable,100));


            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = this.Content.Load<SpriteFont>("file");
            invenBackGround = this.Content.Load<Texture2D>("background/inventorybackground");
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

            base.Update(gameTime);
            if (In.Iispressed())
            {
                invenActive = !invenActive;
            }
            if (invenActive)
            {



                if (In.Spaceispressed())
                {
                    if (inven.GetSelected().type == Items.Type.weapon)
                    {
                        inven.UseSelected(power);

                    }
                    else if (inven.GetSelected().type == Items.Type.consumable)
                    {
                        inven.UseSelected(health);
                        inven.RemoveItem(inven.GetSelected());
                    }

                }

                if (Keyboard.GetState().IsKeyDown(Keys.S))
                {
                    inven.SortById();
                }
                if (Keyboard.GetState().IsKeyDown(Keys.D))
                {
                    inven.SortByName();
                }


                if (In.DOWNispressed())
                {
                    inven.SelectDown();
                }
                if (In.UPispressed())
                {

                    inven.SelectUp();
                }
                if (Keyboard.GetState().IsKeyDown(Keys.L))
                {
                    inven.AddItem(new consumable("bread", 3, Items.Type.consumable, 100));
                }
                if (Keyboard.GetState().IsKeyDown(Keys.O))
                {
                    inven.AddItem(new consumable("Healt pot", 3, Items.Type.consumable, 150));
                }

            }
        }

       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            if (invenActive == true)
            {
                spriteBatch.Draw(invenBackGround, new Vector2(0, 0));
                inven.DrawInventory(spriteBatch, font);
            }
            health.DrawMeter(spriteBatch, font, new Vector2(500, 500), Color.DarkGreen);
            power.DrawMeter(spriteBatch, font, new Vector2(500, 550), Color.DarkRed);

            spriteBatch.DrawString(font, "I open inventory,O add health,L add bread,S sort by id,D sort by name,Space use item" , new Vector2(10,600), Color.White);

            spriteBatch.End();
            
            base.Draw(gameTime);
        }


    }
}
