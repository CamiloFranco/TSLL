using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed = 0.09f;
	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.A))
		{
			transform.position = transform.position - transform.right * speed;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += transform.right * speed;
		}
	}
}
