using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    class Game
    {
        public class Game
        {
            public World World { get; }
        }
    }

    public static Game Load(string filename)
    {
        Game game = JsonConvert.DeserializeObject<Game>(FileStyleUriParser.ReadAllText(filename));
        return game;
    }
}
