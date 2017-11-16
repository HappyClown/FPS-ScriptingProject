using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticle : MonoBehaviour 
{
	public GameObject particle;

	public string otherCollisionTag;

	

	void OnCollisionEnter (Collision other) 
	{
		if (other.gameObject.tag == otherCollisionTag)
		{
			Instantiate(particle, this.transform.position, this.transform.rotation);
		}
		
	}
}
