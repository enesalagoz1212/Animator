using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	Animator anim;
	float _speed = 3f;
	
	void Start()
	{
		anim = GetComponent<Animator>();
	}


	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			transform.position += move * _speed * Time.deltaTime;
			anim.SetFloat("Speed", 0.4f);
			if (Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.W))
			{
				anim.SetFloat("Speed", 2f);
			}
		}
		else
		{
			anim.SetFloat("Speed", 0f);
		}
	}
	
}

