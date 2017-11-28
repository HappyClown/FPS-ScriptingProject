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
			other.GetComponent<EnemyShooting>().enemyAmmo += Mathf.Abs(ammoAmount / 4);
			Destroy(this.gameObject);
		}

		if (other.tag == "Player")
		{
			other.GetComponent<Shooting>().playerAmmoCount += ammoAmount;
			Destroy(this.gameObject);
		}
	}
}
