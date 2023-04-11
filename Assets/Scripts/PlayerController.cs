using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	Rigidbody rb;
	public float speed;
	[SerializeField] private float sensivity;
	public int jumpForce;

	void Start()
	{
		
		//  rb.GetComponent<Rigidbody>();
	}

	void Update()
	{
		

		Movement();

	}
	void Movement()
	{
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		transform.position += move * speed * Time.deltaTime;

	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Cube")
		{
			Destroy(collision.gameObject);
		}
	}
}
