using System.Collections.Generic;
using System.IO;
using SimpleJSON;

public static class Utils {

    public static Dictionary<string, int> ReadAttributesFromJson(string race)
    {
        Dictionary<string, int> dict;
        using (StreamReader r = new StreamReader("Assets/" + race + ".json"))
        {
            string json = r.ReadToEnd();
            JSONNode node = JSON.Parse(json);
            dict = new Dictionary<string, int>()
            {
                
            };

        }
        return new Dictionary<string, int>();
    }
}
