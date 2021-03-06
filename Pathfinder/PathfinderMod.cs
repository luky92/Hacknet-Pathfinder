﻿namespace Pathfinder
{
    public abstract class PathfinderMod
    {
        /// <summary>
        /// This function returns the mod identifier of your mod.
        /// </summary>
        /// <returns>String - The mod identifier of your mod</returns>
        public abstract string GetIdentifier();


        /// <summary>
        /// Called when the mod is loaded
        /// </summary>
        public abstract void Load();


        public abstract void LoadContent();

        /// <summary>
        /// Called when the mod is unloaded
        /// </summary>
        public abstract void Unload();
    }
}
