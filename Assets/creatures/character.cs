using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class character : MonoBehaviour {


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
	    Dictionary<string, int> wup = Utils.ReadAttributesFromJson(race.ToString());
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
}

public enum Klass {Rittari, Raiskari, Ryöväri, Runkkari};

public enum Race {human, Haltija, Dwarf, Orc};