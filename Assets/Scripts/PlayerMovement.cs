using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 initPos, finalPos;
    bool touchDoor;

    // Start is called before the first frame update
    void Start()
    {
        touchDoor = false;
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "BumpWall")
    //    {
    //        touchDoor = true;
    //    }
    //}
    private void OnTriggerExit(Collider other)
    {
        string hitName = other.gameObject.name;
        if(hitName == "ShrinkerWall")
        {
            print("Hay un shrinker");
            ChangeScale();
        }
        else if (other.gameObject.name == "BumpWall")
        {
            touchDoor = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "BumpWall")
        {
            touchDoor = true;
        }
    }

    IEnumerator TeleportDoor(Transform door)
    {
        Vector3 randPos = GetRandomPos();
        yield return new WaitForSeconds(2);
        if (touchDoor)
        {
            door.position = randPos;
            door.LookAt(transform);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BumpWall")
        {
            StartCoroutine(TeleportDoor(other.gameObject.transform));
            
        }
    }
    void ChangeScale()
    {
        if (transform.localScale == Vector3.one)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else
        {
            transform.localScale = Vector3.one;
        }
    }

    Vector3 GetRandomPos()
    {
        return new Vector3(Random.Range(initPos.x,finalPos.x), Random.Range(initPos.y, finalPos.y), Random.Range(initPos.z, finalPos.z));
    }

}
