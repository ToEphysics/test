using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("플레이어 생성");
    }

    void OnEnable()
    {
        Debug.Log("플레이어 로그인");
    }

    void Start()
    {
        Debug.Log("준비완료");
    }

    void FixedUpdate()
    {
        Debug.Log("이동");
    }

    void Update()
    {
        Debug.Log("사냥");
    }

    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }

    void OnDisable()
    {
        Debug.Log("플레이어 로그아웃");
    }

    void OnDestroy()
    {
        Debug.Log("플레이어 삭제");
    }
}
