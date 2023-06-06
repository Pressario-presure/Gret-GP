using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // скорость движения персонажа
    private Rigidbody2D rb; // Rigidbody2D компонент
    private Vector2 direction; // Направление движения персонажа

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Получаем Rigidbody2D компонент
         // Получаем Animator компонент
    }

    void Update()
    {
        // Получаем направление движения
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
        // Двигаем персонажа
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}