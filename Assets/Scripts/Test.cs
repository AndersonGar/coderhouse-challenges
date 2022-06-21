using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //comision 31520
    public int life;
    public float speed;
    public Vector3 dirMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    void HealthUp()
    {
        life++;
    }

    void HealthDown()
    {
        life--;
    }

    void MoveObject()
    {
        transform.position += dirMovement * speed * Time.deltaTime;
    }
}
