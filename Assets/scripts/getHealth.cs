using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getHealth : MonoBehaviour
{
    public Transform managerObject;
    private Text text;
    private character player;
    private creature monster;
    public homo runkkari;

    // Use this for initialization
    void Start ()
    {
        text = GetComponent<Text>();
        player = GameObject.FindWithTag("Player").GetComponent<character>();
    }

    public void setMonster()
    {
        if (monster != null) return;
        try
        {
            monster = GameObject.FindWithTag("Monster").GetComponent<creature>();
        }
        catch (NullReferenceException)
        {
            Debug.Log("Tähän ei pitäisi tulla");
        }
    }

    // Update is called once per frame
	void Update ()
	{

	    switch (runkkari)
	    {
	            case homo.Sankari:
	            if (player != null)
	            {
                    text.text = "" + player.getHealth();
	            }
                break;

                case homo.Monsteri:
	            if (monster != null)
	            {
                    text.text = "" + monster.getHealth();
	            }
                break;

	    }
	}
}

public enum homo {Sankari, Monsteri}
