using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_input : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("아무키 누름");
        
        if (Input.anyKey)
            Debug.Log("아무키 누르고 있음");

        // if (Input.GetKeyDown(KeyCode.Return)) // Return = enter, Escape = Esc
        //     Debug.Log("엔터 누름");
        
        // if (Input.GetKey(KeyCode.LeftArrow)) // LeftArrow = 방향키 좌측
        //     Debug.Log("좌방향 누르고 있음");
        
        // if (Input.GetKeyUp(KeyCode.RightArrow)) // RightArrow = 방향키 우측
        //     Debug.Log("우방향 뗌");

        if (Input.GetMouseButtonDown(0)) // MouseButtonDown(0) = 마우스 좌클릭
            Debug.Log("마우스 좌클릭 누름");
        
        if (Input.GetMouseButton(0))
            Debug.Log("마우스 좌클릭 누르고 있음"); // MouseButtonDown(1) = 마우스 우클릭
        
        if (Input.GetMouseButtonUp(0))
            Debug.Log("마우스 좌클릭 뗌");

        if (Input.GetButtonDown("Jump")) // Input Manager의 다양한 입력키를 사용가능
            Debug.Log("점프 누름");

        if (Input.GetButton("Jump"))  // Jump는 스페이스바 기본
            Debug.Log("점프 누르는 중");

        if (Input.GetButtonUp("Jump")) // 좌우 이동은 ad,방향키 좌우 가능 등
            Debug.Log("점프 뗌");

        if (Input.GetButton("Horizontal"))
            Debug.Log("횡 이동 " + Input.GetAxis("Horizontal")); // 살짝 누르면 작은 값, 길게 누를 수록 단위 시간 당 1까지 증가
            // Debug.Log("횡 이동 " + Input.GetAxisRaw("Horizontal")); // 짧고 길고 상관없이 단위 시간 당 1씩 증가

        if (Input.GetButton("Vertical"))
            // Debug.Log("종 이동 " + Input.GetAxis("Vertical")); // 살짝 누르면 작은 값, 길게 누를 수록 단위 시간 당 1까지 증가
            Debug.Log("종 이동 " + Input.GetAxisRaw("Vertical")); // 짧고 길고 상관없이 단위 시간 당 1씩 증가
    }

}
