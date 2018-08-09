using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAnim : MonoBehaviour {
	private Animator anim; 
	private UnityEngine.AI.NavMeshAgent nav ; 
	private bool aliveTarget = true ; 
	public BunnyParticle myParticle; 
	// Use this for initialization
	void Start () {
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> (); 
		anim.SetBool ("isDead",false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Bear") && GameObject.FindWithTag ("Bear") != null) {
			nav.SetDestination (GameObject.FindWithTag ("Bear").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Bear").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
			if (Vector3.Distance (GameObject.FindWithTag ("Bear").transform.position, this.transform.position) < 10 && angle < 30) {
				direction.y = 0;

				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				anim.SetBool ("isIdle", false);
				if (direction.magnitude > 5) {
					this.transform.Translate (0, 0, 0.05f);
					anim.SetBool ("isWalking", true);
					anim.SetBool ("isHeadbutt", false);
				} else {
					anim.SetBool ("isHeadbutt", true);
					anim.SetBool ("isWalking", false);
				}

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isHeadbutt", false);
			}



		} else if (GameObject.FindWithTag ("Dog") && GameObject.FindWithTag ("Dog") != null) {
			nav.SetDestination (GameObject.FindWithTag ("Dog").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Dog").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
			if (Vector3.Distance (GameObject.FindWithTag ("Dog").transform.position, this.transform.position) < 10 && angle < 30) {
				direction.y = 0;

				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				anim.SetBool ("isIdle", false);
				if (direction.magnitude > 5) {
					this.transform.Translate (0, 0, 0.05f);
					anim.SetBool ("isWalking", true);
					anim.SetBool ("isHeadbutt", false);
				} else {
					anim.SetBool ("isHeadbutt", true);
					//myParticle.GetComponent<BunnyParticle> ();

					anim.SetBool ("isWalking", false);
				}

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isHeadbutt", false);
			}

		}else if(GameObject.FindWithTag ("Player") && GameObject.FindWithTag ("Player") != null){
			nav.SetDestination (GameObject.FindWithTag ("Player").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Player").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
			if (Vector3.Distance (GameObject.FindWithTag ("Player").transform.position, this.transform.position) < 10 && angle < 30) {
				direction.y = 0;

				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				anim.SetBool ("isIdle", false);
				if (direction.magnitude > 5) {
					this.transform.Translate (0, 0, 0.05f);
					anim.SetBool ("isWalking", true);
					anim.SetBool ("isHeadbutt", false);
				} else {
					anim.SetBool ("isHeadbutt", true);
					anim.SetBool ("isWalking", false);
				}

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isHeadbutt", false);
			}

		}else {
			anim.SetBool ("isIdle", true);
		}


	}//end Update ()


}
