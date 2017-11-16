using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour 
{
	public int enemyCount;
	public GameObject[] enemyList;

	public GameObject winText;

	
	void Update () 
	{
		enemyList = GameObject.FindGameObjectsWithTag("Enemy");
		enemyCount = enemyList.Length;

		if (enemyCount <= 0)
		{
			winText.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
