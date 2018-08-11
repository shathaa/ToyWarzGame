using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAttack : MonoBehaviour {
    public GameObject particleLauncher;
	// Use this for initialization
	 public void startAttack () {
        particleLauncher.SetActive(true);
	}
	
	// Update is called once per frame
	public void stopAttack () {
        particleLauncher.SetActive(false);
	}
}
