using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int score = 0;

    private void Awake()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update

    public static void ShowFullScore()
    {
        Debug.ClearDeveloperConsole();
        Debug.Log("Total de proyectiles muertos: "+ score);
    }
}
