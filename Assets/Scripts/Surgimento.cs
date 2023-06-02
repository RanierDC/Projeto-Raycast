using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surgimento : MonoBehaviour
{
    public GameObject Inimigo;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        int qtd = 3;
        for (int i = 0; i < qtd; i++)
        {
            position.Set(Random.Range(1,8), 3, 3);
            Instantiate(Inimigo, position, Quaternion.identity);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Raycast.contador == 3)
        {
            Raycast.contador = 0;
            Raycast.rodada++;
            int qtd2 = 3;
            for (int i = 0; i < qtd2; i++)
            {
                position.Set(Random.Range(1, 8), 3, 3);
                Instantiate(Inimigo, position, Quaternion.identity);
            }
        }
    }
}
