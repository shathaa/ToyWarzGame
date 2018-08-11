                                          using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Animator anim;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("RightStick_X_Axis "))
          anim.Play("Gunplay", -1, 0f);
         else if (Input.GetButtonDown("RightStick_Y_Axis "))
            anim.Play("Dying", -1, 0f);
        else if (Input.GetButtonDown("X_Button"))
            anim.Play("Jumping", -1, 0f);
        else if (Input.GetButtonDown("Y_Button"))
            anim.Play("Kick", -1, 0f);
       /*  else if (Input.GetButtonDown("Right_Stick_X-Axis"))//  if (Input.GetButtonDown("X_Button")),
        else if (Input.GetButtonDown("Right_Stick_y-Axis")) //if (Input.GetButtonDown("O_Button"))
            anim.Play("walking", -1, 0f);
        else if (Input.GetButtonDown("Left_Stick_X-Axis")) //if (Input.GetButtonDown("Triangle_Button"))
            anim.Play("Jumping", -1, 0f);
        else if (Input.GetButtonDown("Left_Stick_y-Axis")) //if (Input.GetButtonDown("Square_Button"))
            anim.Play("dying", -1, 0f);

        if (Input.GetKeyDown("1")) {
           anim.Play("Idle", -1, 0f);
       }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("dying", -1, 0f);

        }*/
    }
}
