using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathAdder : MonoBehaviour
{
    public static PathAdder instance;

    public GameObject area1, area2, area3;
    public bool area1Con, area2Con, area3Con;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
