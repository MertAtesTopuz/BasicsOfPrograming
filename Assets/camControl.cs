using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
   public Transform target;
   public float distance;

    void Update()
    {
        transform.position = new Vector3(target.position.x + distance, transform.position.y, transform.position.z);
    }
}
