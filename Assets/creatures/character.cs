using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class character : MonoBehaviour
{

    private int hp;
    private int mp;

    public int baseHp = 10;

    public int baseMp = 50;

    public Race starting_race;
    public Klass starting_klass;

    private int baseStr;
    private int baseInt;
    private int baseAgi;
    private int agiGain;
    private int strGain;
    private int intGain;

    private Race race;
    private Klass klass;


	// Use this for initialization
	void Start ()
	{
	    race = starting_race;
	    klass = starting_klass;
	    Dictionary<string, int> raceAttrs = Utils.ReadAttributes(race.ToString());
	    Dictionary<string, int> klassAttrs = Utils.ReadAttributes(klass.ToString());
	    raceAttrs.TryGetValue("baseStr", out baseStr);
	    raceAttrs.TryGetValue("baseInt", out baseInt);
	    raceAttrs.TryGetValue("baseAgi", out baseAgi);
	    raceAttrs.TryGetValue("baseHp", out baseHp);
	    raceAttrs.TryGetValue("baseMp", out baseMp);
	    klassAttrs.TryGetValue("strGain", out strGain);
	    klassAttrs.TryGetValue("intGain", out intGain);
	    klassAttrs.TryGetValue("agiGain", out agiGain);
	    hp = baseHp;
	    mp = baseMp;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    // Attack method of character. Returns amount of damage done as a double
    public double Attack()
    {
        return 0.0;
    }

    private double calc_damage()
    {
        return 0.0;
    }

    public int getHealth()
    {
        return hp;
    }

    public void takeHit(int amount)
    {
        hp = hp - amount;
    }
}

public enum Klass {Rittari, Raiskari, Ryöväri, Runkkari};

public enum Race {Human, Haltija, Dwarf, Orc};