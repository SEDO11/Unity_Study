using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; //Rigidbody2D 객체 선언
    public float jumpPower;
    // Start is called before the first frame update
    //처음 실행할 때 딱 한 번 동작
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // 매 프레임 마다 동작
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //왼쪽 마우스가 눌렸을 때
        {
            rb.velocity = Vector2.up * jumpPower; // Vector2 = (0, 3) x, y
        }
    }
}