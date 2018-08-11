using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSPAttack : MonoBehaviour {

    public GameObject bomb;

    public bool throwBomb()
    {
        bomb.SetActive(true);
        return true;
    }

    public bool bombOff()
    {
        bomb.SetActive(false);
        return false;
    } 
}
