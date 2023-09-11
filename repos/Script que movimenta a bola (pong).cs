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
        //Passando a velocidade para a minhavelocidade
        minhaVelocidade.x = -velocidade;
        //Adicionando velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;

        
    }

    
    void Update()
    {
        
    }
}
