using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyTimer : MonoBehaviour 
{
	public float difficultyTimer;
	public float difficultyNewLevel;
	public float diffLevel;

	void Start () 
	{
		

	}
	
	void Update () 
	{
		difficultyTimer += Time.deltaTime;

		if(difficultyTimer >= difficultyNewLevel)
		{
			diffLevel += 1;

			difficultyTimer = 0;
		}
	}
}
