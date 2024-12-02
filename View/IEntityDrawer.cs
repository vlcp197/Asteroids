using Asteroids.Model;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroids.View
{
    // This is the skeleton for all classes that will draw something on the screen. May it be the player, the asteroids, the laser beam, etc.
    public interface IEntityDrawer<in T> where T: IEntity
    {
        EntityType Type { get; }

        void LoadContent(ContentManager contentManager);
        void Draw(SpriteBatch spriteBatch, IEntity entity);
        void Draw(SpriteBatch spriteBatch, T entity);


    }
}
