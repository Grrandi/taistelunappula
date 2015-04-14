using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour
{

    public GameObject player;
    private GameObject monster;
    private creature monsterScript;
    private character playerScript;
	// Use this for initialization
	void Start ()
	{
	    playerScript = player.GetComponent<character>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void createMonster()
    {
        if (monster != null) return;

        monster = Instantiate(Resources.Load("monster")) as GameObject;
        if (monster != null) monsterScript = monster.GetComponent<creature>();
    }

    private void killMonster()
    {
        Destroy(monster);
        monsterScript = null;
        monster = null;

        awardXp(500);
    }

    private void awardXp(int amount)
    {
        playerScript.earnExp(amount);
    }

    public void hurtPlayer()
    {

    }

    public void hurtMonster(int dmg)
    {
        if (monsterScript == null)
            return;

        monsterScript.takeHit(dmg);
        if (monsterScript.getHealth() <= 0)
        {
            killMonster();
        }
    }
}
