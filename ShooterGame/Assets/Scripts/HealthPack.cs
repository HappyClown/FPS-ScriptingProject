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
			if (other.GetComponent<EnemyLife>().currentHealth < other.GetComponent<EnemyLife>().totalHealth)
			{
				other.GetComponent<EnemyLife>().currentHealth += hpHealed;
				Destroy(this.gameObject);
			}
		}

		if (other.tag == "Player")
		{
			if (other.GetComponent<PlayerLife>().currentHealth < other.GetComponent<PlayerLife>().totalHealth)
			{
				other.GetComponent<PlayerLife>().currentHealth += hpHealed;
				Destroy(this.gameObject);
			}
		}
	}
}
