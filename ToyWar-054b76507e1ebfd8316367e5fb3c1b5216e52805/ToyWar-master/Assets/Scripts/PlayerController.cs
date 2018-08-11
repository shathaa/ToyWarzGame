using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardeForce = 10f;
   
    public GameObject particalLaunch;

    public bool moduleEnabled;

    // Use this for initialization
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        //particalLuncher = GetComponent<ParticleSystem>();
       
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardeForce * Time.deltaTime);
     /** if (beak.transform.position.y > 0.005671469)
        {
            particalLaunch.SetActive(true);
        }
        if (beak.transform.position.y <= 0.005671469)
        {
            particalLaunch.SetActive(false);

        }  **/




    } 

    void waveAttackStart() {
        particalLaunch.SetActive(true);
       // particalLaunch.SetActive(false);
    }

    void waveAttackStop()
    {
       // particalLaunch.SetActive(true);
        particalLaunch.SetActive(false);
    }

}
