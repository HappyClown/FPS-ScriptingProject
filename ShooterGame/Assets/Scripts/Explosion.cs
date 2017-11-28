using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour 
{

	public string otherCollisionTag;
	public GameObject explosionAreaDmg;


	void OnCollisionEnter (Collision other) 
	{
		if (other.gameObject.tag == otherCollisionTag)
		{
			Instantiate(explosionAreaDmg, this.transform.position, this.transform.rotation);
		}
		
	}
}
