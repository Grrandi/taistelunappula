using System.Collections.Generic;
using System.IO;
using SimpleJSON;

public static class Utils {

    static readonly Dictionary<string, int> Human = new Dictionary<string, int>()
    {
        {"baseStr", 10 },
        {"baseInt", 10 },
        {"baseAgi", 10 },
        {"baseHp", 50},
        {"baseMp", 50 }
    }; 
    static readonly Dictionary<string, int> Orc = new Dictionary<string, int>()
    {
        {"baseStr", 10 },
        {"baseInt", 10 },
        {"baseAgi", 10 },
        {"baseHp", 100},
        {"baseMp", 50 }
    }; 
    static readonly Dictionary<string, int> Rittari = new Dictionary<string, int>()
    {
        {"strGain", 3 },
        {"intGain", 1 },
        {"agiGain", 2 },
    }; 

    public static Dictionary<string, int> ReadAttributes(string race)
    {
//        Dictionary<string, int> dict;
//        using (StreamReader r = new StreamReader("Assets/" + startRace + ".json"))
//        {
//           string json = r.ReadToEnd();
//        }
//        return new Dictionary<string, int>();
        switch (race)
        {
            //Classes
            case "Rittari":
                return Rittari;
            //Races
            case "Orc":
                return Orc;
            case "Human":
                return Human;
            default:
                return new Dictionary<string, int>();
        }
    }
}
