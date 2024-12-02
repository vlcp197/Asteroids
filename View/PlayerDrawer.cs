using Asteroids.Model;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace Asteroids.View
{
    public class PlayerDrawer : IEntityDrawer<Player>
    {
        // Still don't know why doing this ↓↓↓
        public EntityType Type => EntityType.Player;

        public void LoadContent(ContentManager contentManager){}
        public void Draw(SpriteBatch spriteBatch, IEntity entity){}
        public void Draw(SpriteBatch spriteBatch, Player player) {}

    }
}
