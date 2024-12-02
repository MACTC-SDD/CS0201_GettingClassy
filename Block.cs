using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS0201_GettingClassy
{

    internal class Block
    {
        // Properties //
        public string Id { get; set; }

        // Methods //
        public void Interact(int playerId, string action)
        {
            Console.WriteLine($"Player {playerId} {action} block {Id}");
        }
    }
}
