using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject projectilePrefab;
    bool shoot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectEnemy();
    }

    void DetectEnemy()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.tag == "Player" && !shoot)
            {
                ShootProjectile();
                shoot = true;
                Invoke("ShootActive", 2f);
            }
        }
    }

    void ShootActive()
    {
        shoot = false;
    }

    void ShootProjectile()
    {
        GameObject pj = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Destroy(pj, 5f);
    }

}
