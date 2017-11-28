using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour 
{
	public DifficultyTimer diffTimerScript;

	public float currentHealth;
	public float totalHealth;



	void Start () 
	{
		diffTimerScript = GameObject.Find("GameEngine").GetComponent<DifficultyTimer>();

		currentHealth = totalHealth + diffTimerScript.diffLevel;
	}
	
	void Update () 
	{
		if (currentHealth <= 0)
		{
			Destroy(this.gameObject);
		}

		if(currentHealth > totalHealth)
		{
			currentHealth = totalHealth;
		}
		
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "PlayerAttack")
		{
			currentHealth -= 1;
		}
	}
}
