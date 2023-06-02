using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    public Behaviour movimento;
    public Behaviour raio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Raycast.pontos < 0)
        {
            raio.enabled = false;
            movimento.enabled = false;
        }
    }
}
