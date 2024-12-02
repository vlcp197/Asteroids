using Microsoft.Xna.Framework;


namespace Asteroids.Model
{
    public class Player : IEntity
    {
        public EntityType Type => EntityType.Player;

        public Vector2 Position { get; }
        public bool isDestroyed { get;}

        public Player(){}

        
        public void Update(GameTime gameTime) { }


    }
}
