using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyAi : MonoBehaviour 
{
	private NavMeshAgent agent;
	private GameObject player;

	public float aggroRange;
	public float distToPlyr;


	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindWithTag("Player");
	}
	

	void Update () 
	{
		distToPlyr = Vector3.Distance(player.transform.position, this.transform.position);

		if (distToPlyr <= aggroRange)
		{
			agent.destination = player.transform.position;
			agent.isStopped = false;
		}
		else if (distToPlyr > aggroRange)
		{
			agent.isStopped = true;
		}
	}
}
