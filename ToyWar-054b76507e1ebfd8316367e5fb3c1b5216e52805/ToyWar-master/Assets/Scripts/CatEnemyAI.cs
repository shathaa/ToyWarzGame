using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatEnemyAI : MonoBehaviour {
	private Animator anim; 
	private UnityEngine.AI.NavMeshAgent nav ; 
	private bool aliveTarget = true ;
    public  float miniDistance = 2f;
    public float MaxDist = 10.0f;
    public float targetDistance;
    public GameObject Bunny;
    public GameObject Dog;
    public GameObject AngleBear; 
    //string bunny = GameObject.FindWithTag ("Bunny");

    // Use this for initialization
    void Start () {
		//Targets = GameObject.FindGameObjectsWithTag ("Player");
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> (); 
		anim.SetBool ("isDead",false);
	}

	void Update(){
		if (GameObject.FindWithTag ("Bunny") && GameObject.FindWithTag ("Bunny") != null) {
			nav.SetDestination (GameObject.FindWithTag ("Bunny").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Bunny").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
            targetDistance = Vector3.Distance(GameObject.FindWithTag("Bunny").transform.position, this.transform.position); 

            if (targetDistance < 10 && angle < 30 && targetDistance > miniDistance && targetDistance < MaxDist) {
				direction.y = 0;

				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				anim.SetBool ("isIdle", false);
				if (direction.magnitude > 5) {
					//this.transform.Translate (0, 0, 0.05f);
					anim.SetBool ("isWalking", true);
					anim.SetBool ("isAttacking", false);
				} else {
					anim.SetBool ("isAttacking", true);
					anim.SetBool ("isWalking", false);
				}

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isAttacking", false);
			}



		} else if (GameObject.FindWithTag ("Player") && GameObject.FindWithTag ("Player") != null) {
			nav.SetDestination (GameObject.FindWithTag ("Player").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Player").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
            targetDistance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, this.transform.position);
            if (targetDistance < 10 && angle < 30 && targetDistance > miniDistance && targetDistance < MaxDist) {
				direction.y = 0;

				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				anim.SetBool ("isIdle", false);
				if (direction.magnitude > 5) {
					//this.transform.Translate (0, 0, 0.05f);
					anim.SetBool ("isWalking", true);
					anim.SetBool ("isAttacking", false);
				} else if (direction.magnitude <= miniDistance)
                {
                    anim.SetBool("isAttacking", true);
                    anim.SetBool("isWalking", false);
                }

			} else {
				anim.SetBool ("isIdle", true);
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isAttacking", false);
			}

		}else if(GameObject.FindWithTag ("Dog") && GameObject.FindWithTag ("Dog") != null){
			nav.SetDestination (GameObject.FindWithTag ("Dog").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Dog").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
            targetDistance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, this.transform.position);
            if (targetDistance < 10 && angle < 30 && targetDistance > miniDistance && targetDistance < MaxDist) {
				direction.y = 0;

				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				anim.SetBool ("isIdle", false);
				if (direction.magnitude > 5) {
					//this.transform.Translate (0, 0, 0.05f);
					anim.SetBool ("isWalking", true);
					anim.SetBool ("isAttacking", false);
				} else {
                    anim.SetBool("isAttacking", true);
                    anim.SetBool("isWalking", false);
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
