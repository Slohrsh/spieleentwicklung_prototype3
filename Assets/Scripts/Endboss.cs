using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endboss : MonoBehaviour {

    public Rigidbody player;
    public float WaveDist;
    public float TauntDist;


    private Animator animator;
    // Use this for initialization
    void Start () {
        animator = this.GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if(player != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);
            Debug.Log(distance);
            if (distance <= WaveDist && distance > TauntDist)
            {
                animator.SetTrigger("Wave");
            }
            else if (distance <= TauntDist)
            {
                animator.SetTrigger("Taunt");
            }
        }
    }
}
