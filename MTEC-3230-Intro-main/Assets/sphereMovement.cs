using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour
{
    private Transform myTransform;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        speed = Random.Range(-0.1f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += (Vector3.right * Time.deltaTime * speed);
    }
}