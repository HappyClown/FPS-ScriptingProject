using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shooting : MonoBehaviour 
{
	public GameObject curntBullet;
	public GameObject bouncyBullet;

	public GameObject bulletSpawnPoint;

	public float attackCooldown = 0.5f;
	private float attackTimer;

	public int playerAmmoCount = 10;

	public int playerInClipCount;
	public int playerMaxClipAmnt;

	public Text clip;
	public Text totalAmmo;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		attackTimer += Time.deltaTime;


		if (Input.GetMouseButtonDown(0) && attackTimer > attackCooldown && playerInClipCount > 0)
		{
			
			if(curntBullet.name == "BouncyBullet")
			{
				Instantiate(bouncyBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

				attackTimer = 0;

				playerInClipCount -= 1;
			}
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


		totalAmmo.text = "Ammo: " + playerAmmoCount;
		clip.text = "Clip: " + playerInClipCount + "/" + playerMaxClipAmnt;
	}
}
