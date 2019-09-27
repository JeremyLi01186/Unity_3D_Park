using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float movespeed;
	public Rigidbody theRB;
	public float jumpForce;
	public float Rotate;

	// Use this for initialization
	void Start () {
		theRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		// theRB.velocity = new Vector3(Input.GetAxis("Horizontal")*movespeed, theRB.velocity.y, Input.GetAxis("Vertical")*movespeed);

		if(Input.GetButtonDown("Jump"))
		{
			theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
		}


		if (Input.GetKey(KeyCode.A))
		{
			theRB.transform.Rotate(Vector3.up* -Rotate*Time.deltaTime);
			Debug.Log("A");

		}
		if (Input.GetKey(KeyCode.D))
		{
			theRB.transform.Rotate(Vector3.up* +Rotate*Time.deltaTime);
			Debug.Log("D");

		}
		transform.Translate(0,0,Input.GetAxis("Vertical")*movespeed*Time.deltaTime);
	}
}
