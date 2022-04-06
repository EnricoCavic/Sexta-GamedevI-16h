// bibliotecas de scripts
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// começa a classe
public class MovePersonagem : MonoBehaviour
{
    // C# possui tipagem F O R T E
    string nome = "Enrico";
    int idade = 25;
    float altura = 1.84f;

    Rigidbody meuRb;
    public Vector2 inputVector;
    public float velocidadeMovimento;
    
    // uma função que é chamada no inicio do jogo
    void Start()
    {
        Init();
    }

    // uma função que é chamada uma vez por frame (fps)
    // game loop
    void Update()
    {
        RegistrarInputs();
    }

    void FixedUpdate()
    {
        Mover();
    }

    void Init()
    {
        meuRb = GetComponent<Rigidbody>();

        // instanciar
        inputVector = new Vector2();
    }

    void RegistrarInputs()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
    }

    void Mover()
    {
        Vector3 dir = new Vector3(inputVector.x, 0, inputVector.y);

        meuRb.AddForce(dir * velocidadeMovimento, ForceMode.Force);
    }

}
