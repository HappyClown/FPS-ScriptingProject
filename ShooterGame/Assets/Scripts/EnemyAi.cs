using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyAi : MonoBehaviour 
{
	private NavMeshAgent agent;
	private GameObject player;
	private EnemyLife enemyLifeScript;


	public float aggroSprintRange;
	public float distToPlyr;
	public float sprintSpeed;
	public float regularSpeed;


	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindWithTag("Player");
		enemyLifeScript = GetComponent<EnemyLife>();

		agent.speed = regularSpeed;
	}
	

	void Update () 
	{
		agent.destination = player.transform.position;
		

		distToPlyr = Vector3.Distance(player.transform.position, this.transform.position);

		if (distToPlyr <= aggroSprintRange)
		{
			agent.speed = sprintSpeed;

		}
		else if (distToPlyr > aggroSprintRange)
		{
			agent.speed = regularSpeed;
		}
	}
}
