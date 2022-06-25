using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public GameObject pf_Projectile;
    GameObject projectile;
    public float timer;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = timer;
        Shoot();
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Shoot()
    {
        projectile = Instantiate(pf_Projectile, this.transform.position, Quaternion.identity);
    }

    void Timer()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            Destroy(projectile);
            Shoot();
            RestartTimer();
        }
    }

    void RestartTimer()
    {
        time = timer;
    }
}
