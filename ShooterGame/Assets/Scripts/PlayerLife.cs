using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour 
{
	public float totalHealth;
	public float currentHealth;
	public GameObject deadText;



	void Start () 
	{
		currentHealth = totalHealth;
	}
	
	void Update () 
	{
		if(currentHealth <= 0)
		{
			deadText.SetActive(true);
			Time.timeScale = 0;
		}

		if(currentHealth > totalHealth)
		{
			currentHealth = totalHealth;
		}
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "EnemyAttack")
		{
			currentHealth -= 1;
		}
	}
}
