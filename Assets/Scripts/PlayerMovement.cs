using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject cam1, cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraControl();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 axis = new Vector3(h,0f,v);
        if (axis != Vector3.zero)
        {
            GetComponent<AudioSource>().mute = false;
        }
        else
        {
            GetComponent<AudioSource>().mute = true;
        }
        transform.Translate(axis * speed * Time.deltaTime);
    }

    void CameraControl()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.SetActive(cam2.activeSelf);
            cam2.SetActive(!cam1.activeSelf);
        }
    }
}
