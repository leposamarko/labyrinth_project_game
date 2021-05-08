// <copyright file="IStorageRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.Repository
{
    using System;
    using System.Collections.Generic;
    using Haunted.GameModel;

    /// <summary>
    /// Interface for the repo.
    /// </summary>
    public interface IStorageRepository // save game, load game, new time/score, get scores to load the leaderboard
    {
        /// <summary>
        /// To save a game.
        /// </summary>
        /// <param name="name">The players name.</param>
        /// <param name="model">The model.</param>
        void SaveGame(string name, IGameModel model);

        /// <summary>
        /// Load the game.
        /// </summary>
        /// <param name="name">Players name, how it was saved.</param>
        /// <returns>A model.</returns>
        HauntedModel LoadGame(string name);

        /// <summary>
        /// The new time.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="time">New time.</param>
        void NewTime(string name, TimeSpan time);

        /// <summary>
        /// Time to a list.
        /// </summary>
        /// <returns>A list.</returns>
        List<TimeToXML> GetTime();
    }
}
