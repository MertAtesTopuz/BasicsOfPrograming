using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float hız;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + hız * Time.fixedDeltaTime, transform.position.y, transform.position.z );
    }
}
