using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class what : MonoBehaviour
{
    
	public Animator animator;
	public GameObject Dragon;

    void Start()
    {
      animator = GetComponent<Animator>();  
    }

    
    void Update()
    {
	  animator.speed =1.0f;
	}

	public void sss(){
	animator = GetComponent<Animator>();
	animator.speed =0.0f;
	}
	
	public void ooo(){
	animator = GetComponent<Animator>();
	animator.speed =1.0f;
	}
	
	public void www(){
	Dragon.SetActive(true);
	}
	public void ddd(){
	Dragon.SetActive(false);
	}
}
