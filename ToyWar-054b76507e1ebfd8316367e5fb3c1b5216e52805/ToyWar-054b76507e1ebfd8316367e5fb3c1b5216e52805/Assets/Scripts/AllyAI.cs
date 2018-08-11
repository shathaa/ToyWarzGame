using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AllyAI : MonoBehaviour
{

    public float targetDistance;
    public float allowedDistance;
    public float miniDistance = 1.9f;
    public Transform myTrans;
    static Animator ani;
    NavMeshAgent nav;
    private Vector3 direction;
    private float angle;
    private Vector3 angelTeddyCurrPos;
    private bool isMoving;
    private bool isEnemyMoving;
    public GameObject bomb;
    public Transform Duck;
    public Transform Cat;
    public Transform EBear;

    private void Start()
    {
        ani = GetComponent<Animator>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        angelTeddyCurrPos = GameObject.FindWithTag("Player").transform.position;
        isMoving = true;
        isEnemyMoving = true;
        //allowedDistance = 20f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        nav.SetDestination(Duck.transform.position);
        nav.SetDestination(Cat.transform.position);
        nav.SetDestination(EBear.transform.position);
        bomb.SetActive(false);
        
        //distanceCal(target);
        if (isMoving)
            playerMoved();
        else if(isEnemyMoving)
           distanceCal();
    }

    // Detect and Follow The Enemies to Attack Them
    protected void distanceCal()
    {

        
        if (Cat != null)
        {
            nav.SetDestination(Cat.transform.position);
            direction = Cat.transform.position - this.transform.position;
            angle = Vector3.Angle(direction, this.transform.forward);
            targetDistance = Vector3.Distance(Cat.transform.position, myTrans.transform.position);

            direction.y = 0;


            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            if (targetDistance <= allowedDistance && targetDistance > miniDistance && angle < 90)
            {
                
                ani.SetBool("isIdle", false);
                ani.SetBool("isAttackingSp", false);
                ani.SetBool("isWalking", true);

                transform.Translate(Vector3.forward * nav.speed * Time.deltaTime);
                nav.speed = 1.5f;

                if (targetDistance <= 8 && targetDistance > 7)
                {

                    ani.SetBool("isIdle", false);
                    ani.SetBool("isWalking", false);
                    ani.SetBool("isAttackingSp", true);
                    nav.speed = 0f;
                }
                else if (targetDistance <= miniDistance)
                {


                    ani.SetBool("isIdle", false);
                    ani.SetBool("isWalking", false);
                    ani.SetBool("isAttackingSp", false);
                    ani.SetBool("isAttacking", true);

                    transform.Translate(Vector3.forward * nav.speed * Time.deltaTime);
                    nav.speed = 0f;
                }
            }
             
            
            else
            {
                nav.speed = 0f;
                ani.SetBool("isIdle", true);
                ani.SetBool("isWalking", false);
                ani.SetBool("isAttackingSp", false);
                ani.SetBool("isAttacking", false);
            }
        }
        else if (Duck != null)
        {
            nav.SetDestination(Duck.transform.position);
            direction = Duck.transform.position - this.transform.position;
            angle = Vector3.Angle(direction, this.transform.forward);
            targetDistance = Vector3.Distance(Duck.transform.position, myTrans.transform.position);

            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                Quaternion.LookRotation(direction), 0.1f);
            
            if (targetDistance <= allowedDistance && targetDistance > miniDistance && angle < 90)
            {


                ani.SetBool("isIdle", false);
                ani.SetBool("isAttacking", false);
                ani.SetBool("isWalking", true);

                transform.Translate(Vector3.forward * nav.speed * Time.deltaTime);
                nav.speed = 1.5f;

                if (targetDistance <= 8 && targetDistance > 7)
                {

                    ani.SetBool("isIdle", false);
                    ani.SetBool("isWalking", false);
                    ani.SetBool("isAttackingSp", true);
                    nav.speed = 0f;
                }
                else if (targetDistance <= miniDistance)
                {


                    ani.SetBool("isIdle", false);
                    ani.SetBool("isWalking", false);
                    ani.SetBool("isAttacking", true);

                    transform.Translate(Vector3.forward * nav.speed * Time.deltaTime);
                    nav.speed = 0f;
                }
            }
            
            else
            {
                nav.speed = 0f;
                ani.SetBool("isIdle", true);
                ani.SetBool("isWalking", false);
                ani.SetBool("isAttacking", false);
            }
        }
        else if (EBear != null)
        {
            nav.SetDestination(EBear.transform.position);
            direction = EBear.transform.position - this.transform.position;
            angle = Vector3.Angle(direction, this.transform.forward);
            targetDistance = Vector3.Distance(EBear.transform.position, myTrans.transform.position);

            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                Quaternion.LookRotation(direction), 0.1f);

            if (targetDistance <= allowedDistance && targetDistance > miniDistance && angle < 90)
            {


                ani.SetBool("isIdle", false);
                ani.SetBool("isAttacking", false);
                ani.SetBool("isWalking", true);

                transform.Translate(Vector3.forward * nav.speed * Time.deltaTime);
                nav.speed = 1.5f;

                if (targetDistance <= 8 && targetDistance > 7)
                {

                    ani.SetBool("isIdle", false);
                    ani.SetBool("isWalking", false);
                    ani.SetBool("isAttackingSp", true);
                    nav.speed = 0f;
                }
                else if (targetDistance <= miniDistance)
                {


                    ani.SetBool("isIdle", false);
                    ani.SetBool("isWalking", false);
                    ani.SetBool("isAttacking", true);

                    transform.Translate(Vector3.forward * nav.speed * Time.deltaTime);
                    nav.speed = 0f;
                }
            }
            
            else
            {
                nav.speed = 0f;
                ani.SetBool("isIdle", true);
                ani.SetBool("isWalking", false);
                ani.SetBool("isAttacking", false);
            }
        }
        else
        {
            ani.SetBool("isIdle", true);
            ani.SetBool("isWalking", false);
            ani.SetBool("isAttacking", false);
            ani.SetBool("isAttackingSp", false);
        }


    }

    private void playerMoved()

    {
        if (angelTeddyCurrPos.x < GameObject.FindWithTag("Player").transform.position.x
            || angelTeddyCurrPos.x > GameObject.FindWithTag("Player").transform.position.x
            || angelTeddyCurrPos.z < GameObject.FindWithTag("Player").transform.position.z
            || angelTeddyCurrPos.z > GameObject.FindWithTag("Player").transform.position.z)
        {
            ani.SetBool("isIdle", false);
            ani.SetBool("isWalking", true);
            isMoving = false;
        }
    }

    private void EnemyMoved()
    {
        if (angelTeddyCurrPos.x < GameObject.FindWithTag("Duck").transform.position.x
           || angelTeddyCurrPos.x > GameObject.FindWithTag("Duck").transform.position.x
           || angelTeddyCurrPos.z < GameObject.FindWithTag("Duck").transform.position.z
           || angelTeddyCurrPos.z > GameObject.FindWithTag("Duck").transform.position.z)
        {
            ani.SetBool("isIdle", true);
            ani.SetBool("isWalking", false);
            isEnemyMoving = false;
        }
    }
}
