using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DriveMe : MonoBehaviour
{
   [SerializeField]  Vector3 begin = new Vector3(-2, -2, -2);
    [SerializeField] Vector3 end = new Vector3(2, 2, 2);



    Vector3 velocity;
    float distance;



    void Start()
    {
        transform.position = begin;
    }



    void Update()
    {
        velocity = (end - begin).normalized;
        distance = (end - transform.position).magnitude;
        if (distance < 0.1)
        {
            transform.position = begin;
        }
        transform.position += velocity * Time.deltaTime;
    }
}
