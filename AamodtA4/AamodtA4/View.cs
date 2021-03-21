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
using System.Collections.Generic;
using System.Text;

namespace HeroNS
{
    public static class View
    {
        /********************************************************************
        *** METHOD void VeiwH                                             ***
        *********************************************************************
        *** DESCRIPTION : This prints the characters stats Horizontaly    ***
        *** INPUT ARGS : Name,Race,Health,Protection, and Weapon.         ***
        *** OUTPUT ARGS: NONE                                             ***
        *** IN/OUT ARGS : NONE                                            ***
        *** RETURN : NONE                                                 ***
        ********************************************************************/
        public static void ViewH(Hero h)
        {
            Console.WriteLine("Name \t Race \t Health  Protection  Weapon");
            Console.WriteLine(h.Name + "\t " + h.Race + "    " + h.Health + "      " +h.Protection + "       " + h.Weapon );
        }
        /********************************************************************
        *** METHOD void VeiwV                                             ***
        *********************************************************************
        *** DESCRIPTION : This prints the characters stats Verticaly      ***
        *** INPUT ARGS : Name,Race,Health,Protection, and Weapon.         ***
        *** OUTPUT ARGS: NONE                                             ***
        *** IN/OUT ARGS : NONE                                            ***
        *** RETURN : NONE                                                 ***
        ********************************************************************/
        public static void ViewV(Hero h)
        {
            Console.WriteLine("\n\nName: " + h.Name);
            Console.WriteLine("\nRace: " + h.Race);
            Console.WriteLine("\nHealth: " + h.Health);
            Console.WriteLine("\nProtection: " + h.Protection);
            Console.WriteLine("\nWeapon: "+ h.Weapon );
        }


    }
}

