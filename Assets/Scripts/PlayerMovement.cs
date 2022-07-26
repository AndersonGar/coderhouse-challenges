using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float sensibilidadMouse = 100f;
    public float xRotacion;
    public float yRotacion;
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
        Shoot();
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
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadMouse * Time.deltaTime;

        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -70, 70);

        yRotacion += mouseX;//esto es asi sino funciona al reves
        transform.localRotation = Quaternion.Euler(0, yRotacion, 0);
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Transform cameraPos = Camera.main.transform;
            if (Physics.Raycast(cameraPos.position, cameraPos.forward, out hit))
            {
                if (hit.collider.tag == "Projectile")
                {
                    Destroy(hit.collider.gameObject);
                    GameManager.score++;
                    GameManager.ShowFullScore();
                }
            }
        }
    }
    

}
