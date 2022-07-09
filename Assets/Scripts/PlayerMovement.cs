using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Transform tCamera;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
        if (axis == Vector3.zero)
        {
            PlayAnimation(false);
        }
        else
        {
            PlayAnimation(true);
        }
    }

    void Rotate()
    {
        Quaternion rotation = Quaternion.LookRotation(tCamera.position - transform.position);
        rotation.x = 0f;
        rotation.z = 0f;
        rotation *= Quaternion.Euler(0, 180, 0);
        transform.rotation = rotation;
    }
    
    void PlayAnimation(bool run)
    {
        animator.SetBool("Runing",run);
    }

}
