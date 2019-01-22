using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerGravity : MonoBehaviour
{

    
    public float height;
    public bool gravity = false;
    private Rigidbody rb;
    Collider box;
    private void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        box = GetComponent<Collider>();
    }
    private void Update()
    {
        
    }
public void gravityFall()
    {
        if (gameObject.transform.position.y >= height)
        {
            box.enabled = true;

            rb.useGravity = true;
            rb.isKinematic = false;

            if (gravity == true)
            {
                box.enabled = false;
                rb.useGravity = false;
                rb.isKinematic = true;

            }
        }
    }
}

/*
    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name == "pullupCollide")
        if(gameObject.transform.position.y >= height)
        {

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
      
            audio.clip = scream;
            audio.Play();
            anim.Play("Armature|PullingUPGrow");
            Debug.Log("collision");
        }
    }
}
*/
