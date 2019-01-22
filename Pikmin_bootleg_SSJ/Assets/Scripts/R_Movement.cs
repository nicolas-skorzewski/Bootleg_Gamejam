using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class R_Movement : MonoBehaviour
{
    public GameObject destination_box;
    private GameObject boxClone;
    public GameObject pikmin;
    public float max_d = 8.0f;

    private void Update()
    {
        pikmin.transform.position = Vector3.MoveTowards(pikmin.transform.position, destination_box.transform.position, max_d*Time.deltaTime);
            
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 rposition = new Vector3(Random.Range(-8.0f, 8.0f), 0.3f, Random.Range(-8.0f, 8.0f));
        if (other.gameObject.name == "destination_box")
        {
            boxClone = Instantiate(destination_box, rposition, Quaternion.identity) as GameObject;
        }


    }
}















  /*  NavMeshAgent navmeshagent;
    public float timerfornewpath;
    bool inCoRoutine;

	// Use this for initialization
	void Start () {
        navmeshagent = GetComponent<NavMeshAgent>();
	}
    private void Update()
    {
        if (!inCoRoutine)
        {
            StartCoroutine(Dosomething());
        }
    }

    Vector3 getNewRandomPosition ()
    {
        float x = Random.Range(-8.0f, 8.0f);
        float z = Random.Range(-8.0f, 8.0f);

        Vector3 pos = new Vector3(x, .3f, z);
        return pos;
    }

IEnumerator Dosomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timerfornewpath);
        getNewPath();
    }
    void getNewPath()
    {
        navmeshagent.SetDestination(getNewRandomPosition());
    }
}
*/