using UnityEngine;
using System.Collections;

public class creature : MonoBehaviour
{

    public int hp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeHit(int dmg)
    {
        hp = hp - dmg;
    }

    public int getHealth()
    {
        return hp;
    }
}
public enum CreatureKlass {Rittari, Raiskari, Ryöväri, Runkkari};

public enum CreatureRace {Human, Haltija, Dwarf, Orc};
