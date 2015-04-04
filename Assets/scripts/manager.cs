using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour
{

    public GameObject player;
    public GameObject monster;
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
        }

    }

    public void hurtPlayer()
    {
    }
}
