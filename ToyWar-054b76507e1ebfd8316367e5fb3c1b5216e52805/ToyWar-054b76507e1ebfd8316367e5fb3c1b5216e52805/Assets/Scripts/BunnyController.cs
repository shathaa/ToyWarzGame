using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour {
    //public Animator anim1;
    public float walkSpeed = 2; 
	public float runSpeed = 6 ; 

	public float turnTime = 0.2f ; 
	float timeVelocity ; 

	public float SpeedTime = 0.1f; 
	float speedVelocity; 
	float currenSpeed ; 

	private Animator anim ; 

	void Start(){
		anim = GetComponent<Animator> ();
        //anim1 = GetComponent<Animator>();

    }

    void Update(){
       /* if (Input.GetButtonDown("X_Button"))
            anim1.Play("AngelTeddyBellydancing", -1, 0f);
         /*else if (Input.GetButtonDown("O_Button"))
            anim.Play("AngelTeddyDwarfWalk", -1, 0f);
        else if (Input.GetButtonDown("Triangle_Button"))
            anim.Play("AngelTeddyJumping", -1, 0f);
        else if (Input.GetButtonDown("Square_Button"))
            anim.Play("Falling Forward Death", -1, 0f);*/
		Vector2 myInput = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		Vector2 InputDir = myInput.normalized; 
		if(InputDir != Vector2.zero){
			float targetRot = Mathf.Atan2 (InputDir.x , InputDir.y) * Mathf.Rad2Deg;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle (transform.eulerAngles.y , targetRot , ref timeVelocity , turnTime);
		}

		bool running = Input.GetKey (KeyCode.LeftShift);
		float targetSpeed = ((running) ? runSpeed : walkSpeed) * InputDir.magnitude;
		currenSpeed = Mathf.SmoothDamp (currenSpeed , targetSpeed , ref speedVelocity , SpeedTime);

		transform.Translate (transform.forward * currenSpeed * Time.deltaTime, Space.World);

		float animPercent = ((running) ? 1 : .5f) * InputDir.magnitude; 
		anim.SetFloat ("SpeedPrecent",animPercent , SpeedTime , Time.deltaTime);
	}

}
