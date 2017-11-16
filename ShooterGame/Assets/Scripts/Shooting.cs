using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour 
{
	public GameObject curntBullet;
	public GameObject bouncyBullet;

	public GameObject bulletSpawnPoint;

	public float attackCooldown = 0.5f;
	private float attackTimer;

	public int playerAmmoCount = 10;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		attackTimer += Time.deltaTime;


		if (Input.GetMouseButtonDown(0) && attackTimer > attackCooldown && playerAmmoCount > 0)
		{
			
			if(curntBullet.name == "BouncyBullet")
			{
				Instantiate(bouncyBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

				attackTimer = 0;

				playerAmmoCount -= 1;
			}
		}



	}
}
