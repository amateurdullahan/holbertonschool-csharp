using System;

namespace Enemies
{
    /// <summary>
    /// Sasquatch, Godzilla, King Kong, Lochness, Goblin, Ghoul, a zombie with no conscience
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Health value of zombie
        /// </summary>
        public int health;

        /// <summary>
        /// zombie constructor
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
        
        /// <summary>
        /// zombie constructor, with value
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be geater than or equal to 0");
            }
            this.health = value;
        }

    }
}
