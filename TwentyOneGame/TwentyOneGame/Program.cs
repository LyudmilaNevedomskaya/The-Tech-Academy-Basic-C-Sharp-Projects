﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Mila", "Max", "Yarik" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Mila";
            //game = game + player;

            Deck deck = new Deck();

            ////// Lambda Expressions ///////////////////////////
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);
            //////////////////////////////////////////////////////

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i =0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
