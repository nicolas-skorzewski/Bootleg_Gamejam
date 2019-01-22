using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public float velocidadMax;

    public float xMax;
    public float zMax;
    public float xMin;
    public float zMin;

    private float x;
    private float z;
    private float tiempo;
    private float angulo;

    public GameObject pikmin;
    public bool canMove = false;
    public Collider pikminclone;
    private Rigidbody rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //   pikminclone = GetComponent<Collider>();
        x = Random.Range(-velocidadMax, velocidadMax);
        z = Random.Range(-velocidadMax, velocidadMax);
        angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
        transform.localRotation = Quaternion.Euler(0, angulo, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (pikminclone.enabled == true)
        {
            if (pikmin.gameObject.transform.position.y >= .3 && pikmin.gameObject.transform.position.y <= .5)
            {
                canMove = true;
                
               


                tiempo += Time.deltaTime;

                if (transform.localPosition.x > xMax)
                {
                    x = Random.Range(-velocidadMax, 0.0f);
                    angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
                    transform.localRotation = Quaternion.Euler(0, angulo, 0);
                    tiempo = 0.0f;
                }
                if (transform.localPosition.x < xMin)
                {
                    x = Random.Range(0.0f, velocidadMax);
                    angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
                    transform.localRotation = Quaternion.Euler(0, angulo, 0);
                    tiempo = 0.0f;
                }
                if (transform.localPosition.z > zMax)
                {
                    z = Random.Range(-velocidadMax, 0.0f);
                    angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
                    transform.localRotation = Quaternion.Euler(0, angulo, 0);
                    tiempo = 0.0f;
                }
                if (transform.localPosition.z < zMin)
                {
                    z = Random.Range(0.0f, velocidadMax);
                    angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
                    transform.localRotation = Quaternion.Euler(0, angulo, 0);
                    tiempo = 0.0f;
                }


                if (tiempo > 1.0f)
                {
                    x = Random.Range(-velocidadMax, velocidadMax);
                    z = Random.Range(-velocidadMax, velocidadMax);
                    angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
                    transform.localRotation = Quaternion.Euler(0, angulo, 0);
                    tiempo = 0.0f;
                }

                transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
            }
        }
        else if (pikmin.gameObject.transform.position.y <= .3 || pikmin.gameObject.transform.position.y >= 1)
        {
            canMove = false;


        }
    }
}

    