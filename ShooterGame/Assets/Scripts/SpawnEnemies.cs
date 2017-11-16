using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour 
{
	public GameObject enemy;

	private float spawnTimer;
	public float spawnCooldown;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		spawnTimer += Time.deltaTime;

		if (spawnTimer > spawnCooldown)
		{
			Instantiate(enemy, this.transform.position, this.transform.rotation);
			spawnTimer = 0;
		}


	}
}
