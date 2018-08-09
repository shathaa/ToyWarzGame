using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatEnemyAI : MonoBehaviour {
	private Animator anim; 
	private UnityEngine.AI.NavMeshAgent nav ; 
	private bool aliveTarget = true ;
    public float miniDistance = 2f;
    public float MaxDist = 10f;
    private float MyTarget; 
	//string bunny = GameObject.FindWithTag ("Bunny");

	// Use this for initialization
	void Start () {
		//Targets = GameObject.FindGameObjectsWithTag ("Player");
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> (); 
		anim.SetBool ("isDead",false);
        nav.speed = 0f;
	}

	void Update(){
		if (GameObject.FindWithTag ("Player") && GameObject.FindWithTag ("Player") != null) {
			nav.SetDestination (GameObject.FindWithTag ("Player").transform.position);
			Vector3 direction = GameObject.FindWithTag ("Player").transform.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
            MyTarget = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, this.transform.position);

            anim.SetBool("isIdle", true);

            if (MyTarget <= MaxDist && MyTarget > miniDistance)
            {
                anim.SetBool("isIdle", false);
                anim.SetBool("isWlaking", true);
                nav.speed = 1.5f;
            } 
            else if(MyTarget <= miniDistance && MyTarget > 0)
            {
                anim.SetBool("isWlaking", false);
                anim.SetBool("isAttacking", true);
                nav.speed = 0f;
            } else
            {
                anim.SetBool("isIdle", true);
                anim.SetBool("isWlaking", false);
                anim.SetBool("isAttacking", false);
                nav.speed = 0f;
            }

		}
        else {
			anim.SetBool ("isIdle", true);
            nav.speed = 0f;
        }


	}//end Update ()


}
