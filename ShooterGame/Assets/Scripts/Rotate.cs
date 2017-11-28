using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour 
{
	public float rotateSpeed;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		this.transform.eulerAngles += Vector3.up * rotateSpeed * Time.deltaTime;
	}
}
