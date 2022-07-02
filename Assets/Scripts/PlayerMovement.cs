using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Transform tCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 axis = new Vector3(h,0f,v);
        transform.Translate(axis * speed * Time.deltaTime);
    }

    void Rotate()
    {
        Quaternion rotation = Quaternion.LookRotation(tCamera.position - transform.position);
        rotation.x = 0f;
        rotation.z = 0f;
        rotation *= Quaternion.Euler(0, 180, 0);
        transform.rotation = rotation;
    }
    
}
