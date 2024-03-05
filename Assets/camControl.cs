using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
   public Transform target;
   public float distance;

    void Update()
    {
        float x = target.position.z + distance;
        transform.position = new Vector3(target.position.x , transform.position.y, x);
    }
}
