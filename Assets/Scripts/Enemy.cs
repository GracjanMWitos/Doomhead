using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform target;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        Quaternion quaterion = transform.rotation;
        transform.rotation = new Quaternion(0, quaterion.y, 0, quaterion.w);
    }
}
