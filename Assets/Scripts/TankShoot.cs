using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public GameObject pf_Projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K)  || Input.GetKeyDown(KeyCode.L))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        GameObject pj = Instantiate(pf_Projectile, this.transform.position, Quaternion.identity);
        StartCoroutine(DeleteProjectile(pj));
    }

    IEnumerator DeleteProjectile(GameObject projectile)
    {
        yield return new WaitForSeconds(5);
        Destroy(projectile);
    }
}
