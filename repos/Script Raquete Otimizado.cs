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

    //Identificando se eu sou o Player 1
    public bool Jogador;
    
    void Start()
    {
        //Pegando a posição inicial da raquete e aplicando à minha posição
        minhaPosicao = transform.position;
    }
    
    void Update()
    {
        //Passando o meuY para o eixo Y da minhaPosicao
        minhaPosicao.y = meuY;

        //Modificar a posição da minha raquete.
        transform.position = minhaPosicao;

        //Velocidade Multiplicada pelo deltatime
        float deltaVelocidade = Velocidade*Time.deltaTime;

        //Controlando a raquete como player 1
        if (Jogador == true)
        {
            //Subindo
            if (Input.GetKey(KeyCode.UpArrow))
            {
               meuY = meuY + deltaVelocidade;
            }
            //Descendo
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                meuY = meuY - deltaVelocidade;
            }
        }
        else
        {   
            //Subindo
            if (Input.GetKey(KeyCode.W))
            { 
                meuY = meuY + deltaVelocidade;
            }
            //Descendo
            else if (Input.GetKey(KeyCode.S))
            {
                meuY = meuY - deltaVelocidade;
            }
        }
         //Impedindo que eu saia por baixo da tela
         if (meuY < -meuLimite)
        {
            meuY = -meuLimite;
        } 
         //Impedindo que eu saia por cima da tela
        else if (meuY > meuLimite)
        {
            meuY = meuLimite;
        }
    }
}
