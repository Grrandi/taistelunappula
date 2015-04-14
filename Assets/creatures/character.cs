using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class character : baseCreature
{

    private int hp;
    private int mp;

    public int level = 1;
    public int experienceTotal = 0;
    public int experienceToNextLevel;

    private Dictionary<int, int> experienceChart = new Dictionary<int, int>()
    {
        {2, 1000},
        {3, 3000},
        {4, 7000},
        {5, 14000},
        {6, 20000},
        {7, 27000},
        {8, 35000},
        {9, 43000},
        {10, 53000},
         
    };

	// Use this for initialization
	void Start ()
	{
	    hp = baseHp;
	    mp = baseMp;
	    experienceChart.TryGetValue(2, out experienceToNextLevel);

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

    public void earnExp(int amount)
    {
        experienceTotal += amount;
        if (experienceTotal >= experienceToNextLevel)
        {
            ding();
        }

    }

    private void ding()
    {
        level++;
        // tähän pitäisi laskea sit int/agi/str gainin perusteella suurentuneet statsit
        experienceChart.TryGetValue(level+1, out experienceToNextLevel);
    }
}