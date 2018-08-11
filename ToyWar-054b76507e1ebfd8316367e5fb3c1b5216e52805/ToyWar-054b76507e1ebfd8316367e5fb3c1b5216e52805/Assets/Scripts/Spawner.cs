using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


    public GameObject projectile;
    public void StartAttack()
    {
        projectile.SetActive(true);
    }
    public void EndAttack()
    {
        projectile.SetActive(false);
    }
    /* public GameObject projectile;
     void Update () {
         if (Input.GetKeyDown("1")) {
             GameObject cotton = Instantiate(projectile, transform) as GameObject;
             Rigidbody rb = cotton.GetComponent<Rigidbody>();
             rb.velocity = transform.forward * 20;
         }}*/

}
