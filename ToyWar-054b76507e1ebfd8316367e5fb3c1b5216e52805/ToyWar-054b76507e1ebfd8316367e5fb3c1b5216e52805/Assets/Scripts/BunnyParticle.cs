using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyParticle : MonoBehaviour {

	public GameObject CrackPre; //crack prefabe
	//public AudioSource crackSound ; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void StartParticle(){
		CrackPre.SetActive (true);
	}

	void EndParticle(){
		CrackPre.SetActive (false);
	}
		
	/*void OnCollisionEnter(Collision col ){
		crackSound.Play ();
		crack.Play ();
	}*/
}
