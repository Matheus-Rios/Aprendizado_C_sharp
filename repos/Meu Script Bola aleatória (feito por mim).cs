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
        minhaVelocidade.x = velocidade;
        minhaVelocidade.y = velocidade;

        //Tentando gerar um valor aleatório
        int direcao = Random.Range(0, 4);
        switch (direcao)
        {
            case 0:
                Debug.Log("Superior Direita");
                minhaVelocidade.x = velocidade;
                minhaVelocidade .y = velocidade;
            break;

            case 1:
                Debug.Log("Superior Esquerda");
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = +velocidade;
            break;

            case 2:
                Debug.Log("Inferior Esquerda");
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = -velocidade;
            break;

            case 3:
                Debug.Log("Inferior Direita");
                minhaVelocidade.x = +velocidade;
                minhaVelocidade.y = -velocidade;
            break;

            default: 
                Debug.Log("Direção inválida!");
            break;
        }
        //Adicionando velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;
    }

    
    void Update()
    {
        
    }
}
