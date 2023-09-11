using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    //Criando a variável para saber quem é o meu rigidBody
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;

    public float velocidade = 5f;
    
    void Start()
    {
        //Tentando gerar um valor aleatório
        int direcao = Random.Range(0, 4);
        
        //Retornos do direção muda a direção da bola
        if (direcao == 0)
        {
            minhaVelocidade.x = velocidade;
            minhaVelocidade.y = velocidade;
        }
        else if (direcao == 1)
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = velocidade;
        }
        else if (direcao == 2)
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = -velocidade;
        }
        else
        {
            minhaVelocidade.x = +velocidade;
            minhaVelocidade.y = -velocidade;
        }
        //Adicionando velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;
    }

    
    void Update()
    {
        
    }
}
