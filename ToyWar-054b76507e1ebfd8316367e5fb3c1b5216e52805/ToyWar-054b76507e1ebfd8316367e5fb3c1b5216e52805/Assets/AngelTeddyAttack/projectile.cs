using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

    //public GameObject explosionVFX;

     void OnTriggerEnter(Collider other)
    {
        Debug.Log(other+ "YES");
        Destroy(gameObject,6f);
        //Instantiate(explosionVFX, transform.position, transform.rotation);
    }
}
