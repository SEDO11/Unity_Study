using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    void Start() //한 번만 실행
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() //프레임 마다 실행
    {
        if(Input.GetMouseButtonDown(0)){ //마우스 좌클릭
            rb.velocity = Vector2.up * jumpPower; //터치 하면 점프
        }
    }
}
