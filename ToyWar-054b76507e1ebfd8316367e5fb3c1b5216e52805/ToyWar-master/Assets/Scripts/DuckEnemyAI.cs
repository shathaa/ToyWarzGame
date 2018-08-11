using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckEnemyAI : MonoBehaviour {

	private Animator anim; 
	private UnityEngine.AI.NavMeshAgent nav ; 
	private bool aliveTarget = true ; 
	//string bunny = GameObject.FindWithTag ("Bunny");

	// Use this for initialization
	void Start () {
		//Targets = GameObject.FindGameObjectsWithTag ("Player");
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> (); 
		anim.SetBool ("isDead",false);
	}

	void Update(){
		if (GameObject.FindWithTag ("Dog") && GameObject.FindWithTag ("Dog") != null) {
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
					anim.SetBool ("isAttacking", false);
				} else {
					anim.SetBool ("isAttacking", true);
					anim.SetBool ("isPunch", true);
					anim.SetBool ("isSowrd", true);
					anim.SetBool ("isWalking", false);
				}

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isAttacking", false);
			}



		} else if (GameObject.FindWithTag ("Bunny") && GameObject.FindWithTag ("Bunny") != null) {
			nav.SetDestination (GameObject.FindWithTag ("Bunny").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Bunny").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
			if (Vector3.Distance (GameObject.FindWithTag ("Bunny").transform.position, this.transform.position) < 10 && angle < 30) {
				direction.y = 0;

				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				anim.SetBool ("isIdle", false);
				if (direction.magnitude > 5) {
					this.transform.Translate (0, 0, 0.05f);
					anim.SetBool ("isWalking", true);
					anim.SetBool ("isAttacking", false);
				} else {
					anim.SetBool ("isAttacking", true);
					anim.SetBool ("isPunch", true);
					anim.SetBool ("isSowrd", true);
					anim.SetBool ("isWalking", false);
				}

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isAttacking", false);
			}

		}else if(GameObject.FindWithTag ("Bear") && GameObject.FindWithTag ("Bear") != null){
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
					anim.SetBool ("isAttacking", false);
				} else {
					anim.SetBool ("isAttacking", true);
					anim.SetBool ("isPunch", true);
					anim.SetBool ("isSowrd", true);
					anim.SetBool ("isWalking", false);
				}

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isAttacking", false);
			}

		}else {
			anim.SetBool ("isIdle", true);
		}


	}//end Update ()

}
