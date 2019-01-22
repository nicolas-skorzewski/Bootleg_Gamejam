using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpAboveGround : MonoBehaviour
{

    Vector3 minscale;
    public Vector3 maxscale;
    public bool repeatable;
    public float speed = 2.0f;
    public float duration = 5.0f;
   


    // Use this for initialization
    IEnumerator Start()
    {
        minscale = transform.localScale;
        yield return RepeatLerp(minscale, maxscale, duration);
        // yield return RepeatLerp(maxscale, minscale, duration);

    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
       
            float i = 0.0f;
            float rate = (1f / time) * speed;
            while (i < 1.0f)
            {
                i += Time.deltaTime * rate;
                transform.localScale = Vector3.Lerp(a, b, i);
                yield return null;
            }
        
    }
   
}


