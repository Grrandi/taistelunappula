using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour
{

    public GameObject player;
    public GameObject monster;
    private creature monsterScript;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void createMonster()
    {
        if (monster == null)
        {
            monster = Instantiate(Resources.Load("monster")) as GameObject;
            monsterScript = monster.GetComponent<creature>();
        }

    }

    private void killMonster()
    {
        Destroy(monster);
        monsterScript = null;
        monster = null;
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
