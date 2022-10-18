using Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh1_konzi
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            List<Player> playingField = new();

            playingField.Add(new Player() { HP = 1});
            playingField.Add(new Player() { HP = 2 });
            playingField.Add(new Player() { HP = 3 });

            var maxHP = playingField.Max(p => p.HP);
            var maxHpPlayer = playingField.Where(p => p.HP == maxHP).First();

            // Console.WriteLine($"Max HP player with )

            Console.WriteLine(maxHpPlayer);

            var healing = new Healing(3) // ->konstruktor parameter //{ Strength = 3 }; ->property
            healing.Cast(maxHpPlayer);


            Console.WriteLine("All players:");
            foreach (var p  in playingField)   
                Console.WriteLine(p);


            // Sum using Aggregate
            var sumHP = playingField.Aggregate(0,(sum,p) => sum + p.HP);
        }
    }
}
