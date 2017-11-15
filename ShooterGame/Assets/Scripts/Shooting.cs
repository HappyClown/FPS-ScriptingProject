using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour 
{
	public GameObject curntBullet;
	public GameObject bouncyBullet;

	public GameObject bulletSpawnPoint;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			
			if(curntBullet.name == "BouncyBullet")
			{
				Instantiate(bouncyBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
			}

		}
	}
}
