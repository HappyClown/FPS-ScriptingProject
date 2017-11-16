using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour 
{
	public string otherCollisionTag;


	void OnCollisionEnter (Collision other) 
	{
		if (other.gameObject.tag == otherCollisionTag)
		{
			Destroy(this.gameObject);
		}
		
	}
}
