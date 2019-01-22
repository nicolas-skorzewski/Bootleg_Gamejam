using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPikmin : MonoBehaviour
{

    public GameObject pikmin;
    public GameObject spawn;
    public GameObject newPikmin;
    public float Timer = 2;
    public GameObject flower;
    GameObject pikminClone;
    public bool canCreate = true;
    //public GameObject newSpawn;
    private GameObject spawnClone;
    Vector3 rSpawn;


    private void Update()
    {

        if (spawn.gameObject.transform.position.y >= .5)
        {
            if (canCreate == false)
            {
                Vector3 rposition = new Vector3(Random.Range(-8.0f, 8.0f), 0.3f, Random.Range(-8.0f, 8.0f));
                pikminClone = Instantiate(pikmin, spawn.gameObject.transform.position, Quaternion.identity) as GameObject;
                spawnClone = Instantiate(newPikmin, rposition, Quaternion.identity) as GameObject;
               

                Timer = .15f;
                canCreate = true;
                flower = GetComponent<GameObject>();
                pikminClone.transform.parent = spawn.transform;
                flower.transform.parent = pikminClone.transform;
                Debug.Log("yay!");
            }
        }
    }
}
 





