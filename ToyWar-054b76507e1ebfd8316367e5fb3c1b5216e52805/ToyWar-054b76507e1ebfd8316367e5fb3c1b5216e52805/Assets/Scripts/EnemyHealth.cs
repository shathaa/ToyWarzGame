using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
	Animator anim ; 
	public float StartHealth = 100 ; 
	private float EvileHealth; 
	//public int currentHealth ;//damage from player 
	public int damage = 10 ;

	[Header ("Unity Stuff")]
	public Image healthBar ; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		//currentHealth = MaxEvileHealth;
		EvileHealth = StartHealth ; 
		print (EvileHealth);
	}
	
	// Update is called once per frame
	void Update () {
		if(EvileHealth == 0 ){
			anim.SetBool ("isDead",true);
			//let die animation finish and then destroy the object 
			//StartCoroutine(Wait());
			Destroy (gameObject,5.0f);
		}
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Bunny" || col.gameObject.tag == "Dog"|| col.gameObject.tag == "AngleBear" ){
			EvileHealth -= damage; 
			healthBar.fillAmount = EvileHealth / StartHealth; 
			print ("Damage has been happend " + EvileHealth);
		}
		/*if(col.gameObject.tag == "Dog" ){
			EvileHealth -= damage; 
			healthBar.fillAmount = EvileHealth / StartHealth; 
			print ("Damage has been happend " + EvileHealth);

		}
		if(col.gameObject.tag == "AngleBear"){
			EvileHealth -= damage; 
			healthBar.fillAmount = EvileHealth / StartHealth; 
			print ("Damage has been happend " + EvileHealth);
		}*/
	}

	/*IEnumerator Wait(){
		//yield return new WaitForSeconds (60);
	}*/
		
}
