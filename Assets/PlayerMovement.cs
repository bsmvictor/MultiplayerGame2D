using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Velocidade de movimento do jogador
    private Rigidbody2D rb;         // Componente Rigidbody2D do objeto
    private Vector2 moveInput;      // Entrada do jogador transformada em vetor de movimento

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Obt�m o componente Rigidbody2D
    }

    void Update()
    {
        // L� as entradas do teclado nas dire��es horizontal e vertical
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveInput.Normalize();  // Normaliza o vetor para garantir movimento uniforme em todas as dire��es
    }

    void FixedUpdate()
    {
        // Aplica o vetor de movimento ao Rigidbody2D para mover o objeto
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}
