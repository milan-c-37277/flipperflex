using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driveAround : MonoBehaviour
{
    [SerializeField] Transform center;

    [SerializeField] float distaneFromCenter;

    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(distaneFromCenter, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.position, Vector3.up, speed * Time.deltaTime);
        transform.LookAt(center, Vector3.up);
        transform.Rotate(0, -90, 0);
    }
}
