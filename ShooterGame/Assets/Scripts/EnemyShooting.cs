using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyShooting : MonoBehaviour 
{
	private NavMeshAgent agent;
	private GameObject player;

	public float attackRange;
	public float distToPlyr;
	//public float sprintSpeed;
	public float regularSpeed;
	public float firingSpeed;

	public float attackTimer;
	public float attackCooldown;

	public GameObject enemyBullet;
	public GameObject bulletSpawnPoint;


	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindWithTag("Player");
		bulletSpawnPoint = transform.Find("Enemy Bullet Spawner").gameObject;

		agent.speed = regularSpeed;
	}
	

	void Update () 
	{
		agent.destination = player.transform.position;

		attackTimer += Time.deltaTime;
		

		distToPlyr = Vector3.Distance(player.transform.position, this.transform.position);

		if (distToPlyr <= attackRange)
		{
			agent.speed = firingSpeed;

			if (attackTimer > attackCooldown)
			{
				Instantiate(enemyBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

				attackTimer = 0;
			}

		}
		else if (distToPlyr > attackRange)
		{
			agent.speed = regularSpeed;
		}
	}
}