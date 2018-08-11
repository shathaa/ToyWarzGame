using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    
    private Animator anim;
    private float inputH;
    private float inputV;
    private Rigidbody rb;
    private bool run;

    public GameObject CottonBallprojectile;
    public float projectileSpeed; 
	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        run = false; 
	}
	
	// Update is called once per frame
	void Update () {
        AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);

        float playbackTime = currentState.normalizedTime % 1;
        if (Input.GetKeyDown("1"))
        {
            anim.Play("WAIT01", -1, 0f);
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
        }
        if (Input.GetKeyDown("3"))
        {
            anim.Play("WAIT03", -1, 0f);
        }
        if (Input.GetKeyDown("4"))
        {
            anim.Play("WAIT04", -1, 0f);
        }

        //Debug.Log("HI IM HERE Playbacktime is" + playbackTime);
        if (Input.GetKeyDown("5"))
        {

            //print("5 IM HERE");
            //float time = anim.GetCurrentAnimatorStateInfo(0).length;
            //Debug.Log("time is" + time);
            anim.Play("AngelTeddyCottonBall", -1, 0f);
            //float time = anim.GetCurrentAnimatorStateInfo(-1).length;
           // Debug.Log("time is" + time);
            //if(playbackTime == 0.4213391f){
            //    GameObject cottonBall = Instantiate(CottonBallprojectile, transform) as GameObject;
            //    Rigidbody cottonBallRB = cottonBall.GetComponent<Rigidbody>();
            //    cottonBallRB.velocity = transform.forward * projectileSpeed; 
            //}

        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    int random = Random.Range(0, 2);

        //    if (random == 0)
        //    {
        //    anim.Play("DAMAGED00", -1, 0f);

        //    }
        //    else
        //    {
        //        anim.Play("DAMAGED01", -1, 0f);

        //    }
        //}
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    run = true; 
        //}
        //else
        //{
        //    run = false; 
        //}
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
        anim.SetBool("run", run);
        float moveX = inputH * 20f * Time.deltaTime;
        float moveZ = inputV * 50f * Time.deltaTime;
        if(moveZ <= 0)
        {
            moveX = 0; 
        }
        else if (run)
        {
            moveX *= 3f;
            moveZ *= 3f;
        }
        rb.velocity = new Vector3(moveX, 0, moveZ);
    }

    public void shoot(){

        GameObject cottonBall = Instantiate(CottonBallprojectile, transform.GetChild(0)) as GameObject;
                Rigidbody cottonBallRB = cottonBall.GetComponent<Rigidbody>();
                cottonBallRB.velocity = transform.forward * projectileSpeed; 
    }
}
