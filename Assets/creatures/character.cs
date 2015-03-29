using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {


    public int baseHp = 10;
    public int baseMp = 50;
    public int baseStr= 10;
    public Race starting_race;
    public Klass starting_klass;

    private int hp;
    private int mp;
    private int str;
    private Race race;
    private Klass klass;


	// Use this for initialization
	void Start ()
	{
	    race = starting_race;
	    klass = starting_klass;
	    hp = baseHp;
	    mp = baseMp;
	    str = baseStr;
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

public enum Race {Valkonen, Kiinalainen, Neekeri, Homo };