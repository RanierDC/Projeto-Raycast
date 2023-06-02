using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Raycast : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;

    public Text pontuacao;
    public Text ganhou;
    public Text verifica;

    public static int contador = 0;
    public static int pontos = 0;
    public static int rodada = 0;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao.text = "Pontuação: " + pontos;
        
    }

    // Update is called once per frame
    void Update()

    {

        if (UnityEngine.Input.GetMouseButtonDown(0))
        {
            ray = new Ray(transform.position, transform.forward);

            Debug.Log("Origem: " + ray.origin);
            Debug.Log("Direção: " + ray.direction);

            Debug.DrawRay(ray.origin, ray.direction * 10, Color.blue);


            if (Physics.Raycast(ray, out hitData))
            {
                contador++;
                pontos = pontos + 10;

                pontuacao.text = "Pontuação: " + pontos;
                verifica.color = Color.blue;
                verifica.text = "Acertou!";

                GameObject hitObject = hitData.transform.gameObject;


                string tag = hitData.collider.tag;
                Debug.Log("Você acertou um " + tag);


                hitObject.SetActive(false);

            }
            else
            {
                verifica.color = Color.red;
                verifica.text = "Errou!";
                pontos = pontos - 4;
                pontuacao.text = "Pontuação: " + pontos;
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.magenta);
            }


            if (rodada == 3)
            {
                Debug.Log("Você ganhou!!");
                ganhou.text = "Você ganhou!!";
                Time.timeScale = 0.1f;
            }

            if( pontos < 0)
            {
                ganhou.color = Color.red;
                ganhou.text = "Você perdeu!!";
                Time.timeScale = 0.1f;
            }
        }
    }
}
