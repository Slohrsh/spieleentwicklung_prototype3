using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimationController : MonoBehaviour {

    Animator animator;
    NavMeshAgent agent;

    void Start () {
        animator = this.GetComponentInChildren<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
    }
	
	void Update () {
        animator.SetFloat("Speed", agent.velocity.magnitude);
        //animator.SetTrigger("Attack");
    }
}
