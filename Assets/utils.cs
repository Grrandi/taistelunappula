using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public static class Utils {

    public static Dictionary<string, int> ReadAttributesFromJson(string race)
    {
        Dictionary<string, int> dict;
        using (StreamReader r = new StreamReader(race + ".json"))
        {
            string json = r.ReadToEnd();
            dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
        }
        return dict;
    }
}
