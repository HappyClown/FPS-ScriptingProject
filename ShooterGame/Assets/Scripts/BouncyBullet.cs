using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBullet : MonoBehaviour 
{
	public float force;
	private bool wasForceAdded = false;

	void Update () 
	{
		if (wasForceAdded == false)
		{
			this.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
			wasForceAdded = true;
		}
	}
}
