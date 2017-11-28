using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour 
{

	public int hpHealed;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
		{
			other.GetComponent<EnemyLife>().currentHealth += hpHealed;
			Destroy(this.gameObject);
		}

		if (other.tag == "Player")
		{
			other.GetComponent<PlayerLife>().currentHealth += hpHealed;
			Destroy(this.gameObject);
		}
	}
}
