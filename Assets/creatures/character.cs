using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class character : baseCreature
{

    private int hp;
    private int mp;


	// Use this for initialization
	void Start ()
	{
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