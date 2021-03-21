/********************************************************************
*** NAME : Nathan Aamodt                                          ***
*** CLASS : CSC 346                                               ***
*** ASSIGNMENT : AamodtA3 - Assign 3                              ***
*** DUE DATE : Febuary 26th 2021                                  ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : This Assignment is creating 2 players in a game ***
*** one using defult constructor then anouther using values passed***
*** in from the Program.cs file, this allows 2 differnt types of  ***
*** players/characters in this game.                              ***
********************************************************************/
using System;

namespace HeroNS
{
    class Program
    {
        public static void Main()
        {
            Hero Soul = new Hero();
            Hero evil = new Hero("Triss", Global.RaceType.HUMAN, 225,35, Global.WeaponType.SPELL);
            View.ViewH(Soul);
            View.ViewV(evil);
        }
    }
}
