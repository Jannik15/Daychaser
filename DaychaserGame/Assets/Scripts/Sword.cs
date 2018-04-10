﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    public Animator animator;

	
	void Start () 
    {
        animator = GetComponent<Animator>();
	}
    public static void PerformAttack(Animator animator)
    {
        animator.SetTrigger("Base_Attack");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            col.GetComponent<IEnemy>().TakeDamage(1);
        }
    }
}