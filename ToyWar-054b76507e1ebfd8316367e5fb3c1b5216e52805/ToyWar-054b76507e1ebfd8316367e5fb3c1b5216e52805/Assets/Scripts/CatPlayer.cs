using UnityEngine;

public class CatPlayer : MonoBehaviour {
    
    public float moveSpeed = 8f;
    //Left joystick on screen
    public Joystick LeftJoystick;
    //Right joystick on screen
    public Joystick RightJoystick;
    public FixedButton jumpButton;
    public FixedButton attackButton;
    public FixedButton attackButton2;
    public FixedButton attackButton3;
    public ParticleSystem particleLuncher;
    //ray from the camera
    float camRayLength=100f;
    int floorMask;
    // create object from Animator Controller to call specific animation & control it by conditions
     Animator anim;
   
     void Start()
    {
        floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
    }

    void Update () 
	{
        // Create Two variables for control 
        Vector3 moveVector = (Vector3.right * LeftJoystick.Horizontal + Vector3.forward * LeftJoystick.Vertical);
        Vector3 moveVector2 = (Vector3.right * RightJoystick.Horizontal + Vector3.forward * RightJoystick.Vertical);
        if (moveVector != Vector3.zero)
        {
            //move to walking animation 
            anim.SetBool("isIdle", false);
            //To move around place
            transform.rotation = Quaternion.LookRotation(moveVector);
            transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
        }
        else{
            //Back to Idle 
            anim.SetBool("isIdle", true);

        }

  
        if(jumpButton.Pressed){
            //start jumping animation 
            anim.SetBool("isJumping", true);
            transform.Translate(moveVector2 * moveSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            //Back to Idle 
            anim.SetBool("isJumping", false);

        }

        if (attackButton.Pressed)
        {
            //start Attack1 animation 
            particleLuncher.Emit(1);
            anim.SetBool("isAttack", true);
            transform.Translate(moveVector2 * moveSpeed * Time.deltaTime, Space.World);

        }
        else
        {
            //Back to Idle 
            particleLuncher.Stop();
            anim.SetBool("isAttack", false);

        }

        if (attackButton2.Pressed)
        {
            //start Attack2 animation
            anim.SetBool("isAttack2", true);
            transform.Translate(moveVector2 * moveSpeed * Time.deltaTime, Space.World);

        }
        else
        {
            //Back to Idle 
            anim.SetBool("isAttack2", false);

        }
        if (attackButton3.Pressed)
        {
            //start Attack3 animation
            anim.SetBool("isAttack3", true);
            transform.Translate(moveVector2 * moveSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            //Back to Idle 
            anim.SetBool("isAttack3", false);

        }

	}

}