using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    private int randomSpot;
    private float waitTime;
    public float startWaitTime;
    private Animator anim;
    
    void Start()
    {
        waitTime = startWaitTime;
        anim=GetComponent<Animator>();
        randomSpot = Random.Range(0, moveSpots.Length);
    }


    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, moveSpots[randomSpot].position)<0.2f)
        {
            if (waitTime <= 0)
            {   anim.SetBool("walk",true);
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {anim.SetBool("walk",false);
                waitTime -= Time.deltaTime;
            }
        }
        if(transform.position.x > moveSpots[randomSpot].transform.position.x)
        {
                transform.rotation = Quaternion.Euler(0f,180f, 0f);
        }else
        { 
            transform.rotation = Quaternion.Euler(0f,0f, 0f);
        }

        
    }
}
