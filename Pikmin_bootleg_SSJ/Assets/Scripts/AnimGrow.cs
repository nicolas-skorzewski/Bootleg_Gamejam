using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimGrow : MonoBehaviour
{

    
    public AudioClip scream;
    private Animation anim;
    public float height;
    public bool canAnim = false;
    

    private void Start()
    {
        anim = GetComponent<Animation>();
       ;

    }
    private void Update()
    {
        if (gameObject.transform.position.y >= height)
        {
            
            if (canAnim == true)
            {
                
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();

                audio.clip = scream;
                audio.Play();
                anim.Play("Armature|PullingUPGrow");
                Debug.Log("collision");
                canAnim = false;
                
                
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