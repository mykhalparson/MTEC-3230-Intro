using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverseSphereMovement : MonoBehaviour
{
    private Transform myTransform;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        speed = Random.Range(-3.50f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += (Vector3.right * Time.deltaTime * speed);
    }
}