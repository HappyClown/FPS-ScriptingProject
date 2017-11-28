using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shooting : MonoBehaviour 
{
	public GameObject curntBullet;
	public GameObject[] bullets;

	public GameObject bouncyBullet;
	public GameObject rocketBullet;
	public GameObject normalBullet;

	public GameObject bulletSpawnPoint;

	public float attackCooldown = 0.5f;
	private float attackTimer;

	public int playerAmmoCount = 10;

	public int playerInClipCount;
	public int playerMaxClipAmnt;

	public Text clip;
	public Text totalAmmo;


	
	void Update () 
	{
		attackTimer += Time.deltaTime;


		if (Input.GetMouseButtonDown(0) && attackTimer > attackCooldown && playerInClipCount > 0)
		{
			
			ShootBouncyBullet();

			ShootRocketBullet();

			ShootNormalBullet();

		}


		if (Input.GetKey("r") && playerAmmoCount > 0)
		{
			if (playerAmmoCount >= (playerMaxClipAmnt - playerInClipCount))
			{
				playerAmmoCount -= (playerMaxClipAmnt - playerInClipCount);

				playerInClipCount = playerMaxClipAmnt;
			}

			if (playerAmmoCount < (playerMaxClipAmnt - playerInClipCount))
			{
				playerInClipCount = playerAmmoCount;

				playerAmmoCount = 0;	
			}
		}

		if (Input.GetKey("1"))
		{ curntBullet = bouncyBullet; }
		if (Input.GetKey("2"))
		{ curntBullet = rocketBullet; }
		if (Input.GetKey("3"))
		{ curntBullet = normalBullet; }


		totalAmmo.text = "Ammo: " + playerAmmoCount;
		clip.text = "Clip: " + playerInClipCount + "/" + playerMaxClipAmnt;
	}




	void ShootBouncyBullet()
	{
		if(curntBullet.name == "BouncyBullet")
		{
			Instantiate(curntBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

			attackTimer = 0;

			playerInClipCount -= 1;
		}
	}


	void ShootRocketBullet()
	{
		if(curntBullet.name == "RocketBullet")
		{
			Instantiate(curntBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

			attackTimer = 0;

			playerInClipCount -= 1;
		}
	}


	void ShootNormalBullet()
	{
		if(curntBullet.name == "NormalBullet")
		{
			Instantiate(curntBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

			attackTimer = 0;

			playerInClipCount -= 1;
		}
	}
}
