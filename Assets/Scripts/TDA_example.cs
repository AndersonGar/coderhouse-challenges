using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDA_example : MonoBehaviour
{
    Queue last_names = new Queue();
    Stack colors = new Stack();
    // Start is called before the first frame update
    void Start()
    {
        last_names.Enqueue("Pepe pepon");
        last_names.Enqueue("Lalo leo");
        last_names.Enqueue("Juanita juanela");

        last_names.Dequeue();

        colors.Push("Rojo");
        colors.Push("Azul");
        colors.Pop();//Elimina el ultimo
        colors.Peek();//Visualiza el ultimo
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
