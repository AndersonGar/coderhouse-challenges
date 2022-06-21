using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public GameObject pf_Projectile;
    // Start is called before the first frame update
    void Start()
    {
        GameObject pj = Instantiate(pf_Projectile, this.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
