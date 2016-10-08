using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatGame_2015
{
    #region States enum
    /// <summary>
    /// Enumerated value for the Game1 class to use to determine the current FSM of the game
    /// </summary>
    enum States
    {
        map,
        docked,
        titleMenu,
        gameOver,
        fishing,
        pause,
        controls,
        invent
    }
    #endregion

    #region Directions enum
    /// <summary>
    /// Enumerated value for any class that moves to determine orientation of the object moving
    /// </summary>
    enum Directions
    {
        up,
        down,
        left,
        right,
        idle
    }
    #endregion

    #region ObjectType enum
    /// <summary>
    /// Enumerated value to make sure to have any object inheriting this class identify itself
    /// </summary>

    enum ObjectType
    {
        player,
        island,
        fishingSpot,
        storm,
        pirate
    }
    #endregion

    #region ChangeValue enum
    /// <summary>
    /// Enumerated value for the Button class to change the value displayed
    /// </summary>

    enum ChangeValue
    {
        health,
        fuel,
        crew,
        currency,
        inventoryBuy,
        inventorySell
    }
    #endregion

    #region Doom enum
    /// <summary>
    /// Enum to determine if a player is dead
    /// </summary>

    public enum Doom
    {
        alive,
        noHP,
        noFuel,
        noCrew
    }
    #endregion

    class _ALL_ENUMS
    {
    }
}
