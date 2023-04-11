using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // �������� �������� ���������
    private Rigidbody2D rb; // Rigidbody2D ���������
    private Vector2 direction; // ����������� �������� ���������

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // �������� Rigidbody2D ���������
         // �������� Animator ���������
    }

    void Update()
    {
        // �������� ����������� ��������
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
        // ������� ���������
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}