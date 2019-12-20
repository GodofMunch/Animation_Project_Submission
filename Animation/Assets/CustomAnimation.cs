using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAnimation : MonoBehaviour {

	// Use this for initialization
	private Animator animator;
	void Start ()
	{
		animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
			animator.SetFloat("Forward", 1.0f);
		if(Input.GetKeyUp(KeyCode.W))
			animator.SetFloat("Forward", -0.1f);
		if(Input.GetKey(KeyCode.C))
			animator.SetBool("Crouch", true);
		if(Input.GetKeyUp(KeyCode.C))
			animator.SetBool("Crouch", false);
		if(Input.GetKeyDown(KeyCode.Space))
			animator.SetBool("Kick", true);
		if(Input.GetKeyUp(KeyCode.Space))
			animator.SetBool("Kick", false);
	}
}
