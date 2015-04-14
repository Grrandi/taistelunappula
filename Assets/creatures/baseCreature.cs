using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class baseCreature : MonoBehaviour {

    protected int baseStr;
    protected int baseInt;
    protected int baseAgi;

    public int baseHp = 10;
    public int baseMp = 50;

    private int agiGain;
    private int strGain;
    private int intGain;

    public CreatureRace startRace;
    public CreatureKlass startKlass;

	// Use this for initialization
	void Start () {
	    Dictionary<string, int> raceAttrs = Utils.ReadAttributes(startRace.ToString());
	    Dictionary<string, int> klassAttrs = Utils.ReadAttributes(startKlass.ToString());
	    raceAttrs.TryGetValue("baseStr", out baseStr);
	    raceAttrs.TryGetValue("baseInt", out baseInt);
	    raceAttrs.TryGetValue("baseAgi", out baseAgi);
	
	    raceAttrs.TryGetValue("baseHp", out baseHp);
	    raceAttrs.TryGetValue("baseMp", out baseMp);
	    klassAttrs.TryGetValue("strGain", out strGain);
	    klassAttrs.TryGetValue("intGain", out intGain);
	    klassAttrs.TryGetValue("agiGain", out agiGain);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
public enum CreatureKlass {Rittari, Raiskari, Ryöväri, Runkkari};

public enum CreatureRace {Human, Haltija, Dwarf, Orc};
