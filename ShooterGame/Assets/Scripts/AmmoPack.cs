using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour 
{

	public int ammoAmount;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
		{
			//other.GetComponent<EnemyLife>().currentHealth += hpHealed;
			Destroy(this.gameObject);
		}

		if (other.tag == "Player")
		{
			other.GetComponent<Shooting>().playerAmmoCount += ammoAmount;
			Destroy(this.gameObject);
		}
	}
}
