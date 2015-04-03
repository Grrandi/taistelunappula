using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getHealth : MonoBehaviour
{
    public Transform playerObject;
    public int score;
    private Text text;

    // Use this for initialization
    void Start ()
    {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    character player = playerObject.GetComponent<character>();
	    text.text = "" + player.getHealth();


	}
}
