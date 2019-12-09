using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Animations : MonoBehaviour {
	private Animator animator;
	private float w,r,run;

	void Start () {
		animator = GetComponent <Animator> ();
	}
	
	void Update () {
		w=Input.GetAxis("Vertical");
		r=Input.GetAxis("Horizontal");
		if (animator.GetFloat("Run")==0.2f){
				if (Input.GetKeyDown("space")){
						animator.SetBool("Jump",true);
				}
		}
		Sprinting();
	}

	void FixedUpdate (){
			animator.SetFloat("Walk",w);
			animator.SetFloat("Run",run);
			animator.SetFloat("Turn",r);
	}

	void Sprinting(){
		if (Input.GetKey(KeyCode.LeftShift))
			run=0.2f;
		else
			run=0.0f;
	}
}