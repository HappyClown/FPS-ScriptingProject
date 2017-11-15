using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseYRotation : MonoBehaviour 
{
	
	private float v;
	public float verticalSpeed;

	private float zRot;
	
	public bool invertedY;
	private float invertedYValue;
	

	void Update () 
	{
		invertedYValue = invertedY? invertedYValue = 1f: invertedYValue = -1f;
		//zRot = this.transform.rotation.z;
		zRot = this.transform.eulerAngles.z;
		zRot = 0;
		//zRot = 0f;

		
		v = verticalSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime * invertedYValue;

		this.transform.Rotate(v, 0, 0);
	}
}
