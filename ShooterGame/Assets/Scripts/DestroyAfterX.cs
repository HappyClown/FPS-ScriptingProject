using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterX : MonoBehaviour 
{
	public float timer;
	public float timeBeforeDestroy = 1f;

	void Update () 
	{
		timer += Time.deltaTime;

		if (timer >= timeBeforeDestroy)
		{
			Destroy(this.gameObject);
		}
	}
}
