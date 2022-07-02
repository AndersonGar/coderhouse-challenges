using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform posPlayer;
    TipoEnemigo tipoActual;
    public TipoEnemigo tipoElegido;
    public float speed;


    public enum TipoEnemigo
    {
        enemigo1,
        enemigo2
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name=="Enemy1")
        {
            tipoActual = TipoEnemigo.enemigo1;
        }
        else if (this.name == "Enemy2")
        {
            tipoActual = TipoEnemigo.enemigo2;
        }
        else
        {
            tipoActual = tipoElegido;
        }
        SetBehaviour();
    }

    void SetBehaviour()
    {
        switch (tipoActual)
        {
            case TipoEnemigo.enemigo1:
                LookPlayer();
                break;
            case TipoEnemigo.enemigo2:
                FollowPlayer();
                break;
            default:
                break;
        }
    }
    void LookPlayer()
    {
        transform.LookAt(posPlayer);
    }
    void FollowPlayer()
    {
        if (CheckDistance())
        {
            transform.position = Vector3.Lerp(transform.position, posPlayer.position,speed*Time.deltaTime);

        }
    }

    bool CheckDistance()
    {
        bool response = true;
        float dist = Vector3.Distance(transform.position, posPlayer.position);
        if(dist < 2)
        {
            response = false;
        }
        return response;
    }
}
