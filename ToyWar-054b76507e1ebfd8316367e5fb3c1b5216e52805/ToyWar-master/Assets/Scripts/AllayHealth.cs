using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class AllayHealth : MonoBehaviour {
	Animator anim ; 
	public float StartHealth = 100 ; 
	private float PlayerHealth; 
	public int damage = 5 ; 

	[Header ("Unity Stuff")]
	public Image healthBar ; 
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		//currentHealth = MaxEvileHealth;
		PlayerHealth = StartHealth ; 
		print (PlayerHealth);
	}

	// Update is called once per frame
	void Update () {
		if(PlayerHealth == 0 ){
			anim.SetBool ("isDead",true);
            Destroy(gameObject, 3.0f);

        }
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "EvileBear" || col.gameObject.tag == "Cat"|| col.gameObject.tag == "Duck" ){
			PlayerHealth -= damage; 
			healthBar.fillAmount = PlayerHealth / StartHealth; 
			print ("Damage has been happend " + PlayerHealth);
		}
	}
}
