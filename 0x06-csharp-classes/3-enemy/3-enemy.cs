using System;

namespace Enemies
{
    /// <summary>
    /// Zombie enemy :)
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie health
        /// </summary>
        private int health;

        /// <summary>
        /// Starts zombie at 0 health
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Set health
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// return health
        /// </summary>

        public int GetHealth()
        {
            return (this.health);
        }
    }
}
