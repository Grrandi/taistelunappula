﻿using System;
using UnityEngine;
using System.Collections;

public class creature : baseCreature
{


	// Use this for initialization
	void Start ()
	{
        var random = new System.Random();

	    var values = Enum.GetValues(typeof (CreatureKlass));
	    startKlass = (CreatureKlass) values.GetValue(random.Next(values.Length));

	    values = Enum.GetValues(typeof (CreatureRace));
	    startRace = (CreatureRace) values.GetValue(random.Next(values.Length));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}