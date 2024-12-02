using Microsoft.Xna.Framework;

namespace Asteroids.Model
{
    // This is the skeleton for all entities in the game: player, rocks, projectiles etc...
    public interface IEntity
    {
        EntityType Type { get; }
        Vector2 Position { get; }
        bool isDestroyed { get; }

        void Update(GameTime gameTime);
    }
}
