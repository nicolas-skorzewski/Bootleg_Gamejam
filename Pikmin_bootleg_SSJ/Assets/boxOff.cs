using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxOff : MonoBehaviour
{


    public float height;
    public bool on_off = false;
    public Collider box;
    public Collider pikmin;
    public bool ignore = true;
    private void Start()
    {

        pikmin = GetComponent<Collider>();
        box = GetComponent<Collider>();
        Physics.IgnoreCollision(box.GetComponent<Collider>(), pikmin.GetComponent<Collider>());

    }



    private void Update()
    {
       // if (gameObject.transform.position.y >= height)
        //{
            Physics.IgnoreCollision(box.GetComponent<Collider>(), pikmin.GetComponent<Collider>());
            /*box.enabled = false;
            if (on_off == true)
            {
               // box.enabled = true;
               // Destroy(GetComponent<Collider>());


            }
        } */
       // }
    }
}