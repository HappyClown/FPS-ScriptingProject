using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyShooting : MonoBehaviour 
{
	private NavMeshAgent agent;
	private GameObject player;
	private EnemyLife enemyLifeScript;

	public float attackRange;
	private float distToPlyr;

	public float regularSpeed;
	public float firingSpeed;

	private float attackTimer;
	public float attackCooldown;

	public int enemyAmmo;
	//public int enemyStartAmmo;

	public GameObject enemyBullet;
	public GameObject bulletSpawnPoint;

	private bool checkedAmmoPickUps = false;
	private float ammoShortestDist = 999f;
	private int shortestDistIndex;
	private GameObject shortestDistAmmo;

	// private bool checkedHealthPickUps = false;
	// private float healthShortestDist = 999f;
	// private GameObject shortestDistHealth;

	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindWithTag("Player");
		bulletSpawnPoint = transform.Find("Enemy Bullet Spawner").gameObject;
		enemyLifeScript = GetComponent<EnemyLife>();

		agent.speed = regularSpeed;
	}
	

	void Update () 
	{
		attackTimer += Time.deltaTime;

		distToPlyr = Vector3.Distance(player.transform.position, this.transform.position);

		// If in range of player, slow down and start shooting whenever you are off cooldown. (Attack state)
		if (enemyAmmo > 0)
		{ 
			agent.destination = player.transform.position;

			if (distToPlyr <= attackRange)
			{
				agent.speed = firingSpeed;

				if (attackTimer > attackCooldown)
				{
					Instantiate(enemyBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

					attackTimer = 0;

					enemyAmmo -= 1;
					if (enemyAmmo <= 0) { checkedAmmoPickUps = false;}
				}

			}
			if (distToPlyr > attackRange)
			{
				agent.speed = regularSpeed;
			}
		}


		// If enemy is out of ammo, go towards the nearest ammo pack (GetAmmo state)
		if (enemyAmmo <= 0 && checkedAmmoPickUps == false)
		{
			List<GameObject> ammoPickUps = new List<GameObject>();

			List<float> ammoDistances = new List<float>();

			// Set bool to true to only run once
			checkedAmmoPickUps = true;

			agent.speed = regularSpeed;

			// Find all the ammo pick ups currently active in the scene
			ammoPickUps.AddRange(GameObject.FindGameObjectsWithTag("AmmoPickUp"));

			
			// Check and store the distance between the enemy and all the ammo pick ups
			for (int i = 0; i < ammoPickUps.Count; i++)
			{
				ammoDistances.Add(Vector3.Distance(this.transform.position, ammoPickUps[i].transform.position));

				// At each loop check to see if the distance is smaller then the last, store that dist, index and obj
				if (ammoDistances[i] < ammoShortestDist) { ammoShortestDist = ammoDistances[i]; shortestDistIndex = i; shortestDistAmmo = ammoPickUps[i];}
			}
			// Set new destination to the nearest ammo pick up
			agent.destination = shortestDistAmmo.transform.position;
		}


		// if (enemyLifeScript.currentHealth <= 1 && checkedHealthPickUps == false)
		// {
		// 	List<GameObject> healthPickUps = new List<GameObject>();

		// 	List<float> healthDistances = new List<float>();

		// 	checkedHealthPickUps = true;

		// 	agent.speed = regularSpeed;

		// 	healthPickUps.AddRange(GameObject.FindGameObjectsWithTag("HealthPickUp"));

		// 	for (int i = 0; i < healthPickUps.Count; i++)
		// 	{
		// 		healthDistances.Add(Vector3.Distance(this.transform.position, healthPickUps[i].transform.position));

		// 		if(healthDistances[i] < healthShortestDist)  { ammoShortestDist = healthDistances[i]; shortestDistIndex = i; shortestDistHealth = healthPickUps[i];}
		// 	}

		// 	agent.destination = shortestDistHealth.transform.position;

		// }


	}
}