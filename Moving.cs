using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    void Start()
    {
        Vector2 vec = new Vector2(10, 0);
        transform.Translate(vec); // 오브젝트는 transform변수를 기본으로 가지고 있음(변수 선언 필요 x )
    }

    void Update()
    {
        // Vector2 vec = new Vector2(Input.GetAxis("Horizontal")*Time.deltaTime, Input.GetAxis("Vertical")*Time.deltaTime);
        // transform.Translate(vec);

        Vector2 vec = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(vec*Time.deltaTime);
    }
}
