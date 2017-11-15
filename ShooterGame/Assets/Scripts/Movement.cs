using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
	private float h;
	public float movementSpeed;
	public float horizontalSpeed;

	private Vector3 forward;
	private Vector3 back;
	private Vector3 left;
	private Vector3 right;

	public Vector3 movementVector;


	void Update () 
	{
		CharacterMovement();

		CharacterRotation();
	}


	void CharacterMovement()
	{
		if (Input.GetKey("w"))
		{ forward = Vector3.forward; } else { forward = Vector3.zero; }

		if (Input.GetKey("s"))
		{ back = Vector3.back; } else { back = Vector3.zero; }

		if (Input.GetKey("a"))
		{ left = Vector3.left; } else { left = Vector3.zero; }

		if (Input.GetKey("d"))
		{ right = Vector3.right; } else { right = Vector3.zero; }

		movementVector = (forward + back + left + right).normalized;

		this.transform.Translate(movementVector * movementSpeed * Time.deltaTime);
	}


	void CharacterRotation()
	{
		h = horizontalSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;

		this.transform.Rotate(0, h, 0);
	}
}
