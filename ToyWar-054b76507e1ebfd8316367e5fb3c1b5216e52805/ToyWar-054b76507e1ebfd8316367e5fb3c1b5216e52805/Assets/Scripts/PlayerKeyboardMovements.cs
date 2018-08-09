using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardMovements : MonoBehaviour {


    //protected float moveSpeed = 0;
    Animator anim; 

    void Start()
    {
        anim = GameObject.FindWithTag("Player").GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {

        /*transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        moveSpeed = 2;*/

        //if (Input.GetButtonDown(""))
        //{

        //}
    }


}
