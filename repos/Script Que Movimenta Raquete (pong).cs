using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaqueteController : MonoBehaviour
{
    //Criando o meu vector 3
    private Vector3 minhaPosicao;
    private float meuY;
    public float Velocidade = 5f;
    public float meuLimite = 3.5f;
    public bool Jogador;
    // Start is called before the first frame update
    void Start()
    {
        //Pegando a posição inicial da raquete e aplicando à minha posição]
        minhaPosicao = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Passando o meuY para o eixo Y da minhaPosicao
        minhaPosicao.y = meuY;

        //Modificar a posição da minha raquete.
        transform.position = minhaPosicao;


        //Pegando a setinha para cima
        //SE eu apertar a setinha para cima, ele vai subir a raquete
        //Controlando a raquete como player 1
        if (Jogador == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Checar se o meuY é menor do que o meu limite
                if (meuY < meuLimite)
                {
                    //Aumentar o valor do meuY APENAS se ele for menor do que o meu limite
                    meuY = meuY + Velocidade * Time.deltaTime;

                }


            }
            else if (Input.GetKey(KeyCode.DownArrow) && meuY > -meuLimite)
            {
                //Diminuir o valor do meuY APENAS se ele for maior do que o meu limite
                meuY = meuY - Velocidade * Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                //Checar se o meuY é menor do que o meu limite
                if (meuY < meuLimite)
                {
                    //Aumentar o valor do meuY APENAS se ele for menor do que o meu limite
                    meuY = meuY + Velocidade * Time.deltaTime;

                }


            }
            else if (Input.GetKey(KeyCode.S) && meuY > -meuLimite)
            {
                //Diminuir o valor do meuY APENAS se ele for maior do que o meu limite
                meuY = meuY - Velocidade * Time.deltaTime;
            }
        }
            
    }
}
