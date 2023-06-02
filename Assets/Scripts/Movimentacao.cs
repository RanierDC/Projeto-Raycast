 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public Rigidbody rb;

    public int velocidade;

    private float direcao;




    // Start is called before the first frame update

    void Start()

    {

        rb = GetComponent<Rigidbody>();

    }




    // Update is called once per frame

    void Update()

    {

        direcao = Input.GetAxis("Horizontal");




        rb.velocity = new Vector3(direcao * velocidade, rb.velocity.y, rb.velocity.z);

    }
}
