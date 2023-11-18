using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    Vector2 target = new Vector2(40,8.5f);
    void Update()
    {
        // 1. MoveTowards
        // transform.position = Vector2.MoveTowards(transform.position, target, 0.1f);

        // 2. SmoothDamp
        // Vector2 vel = Vector2.zero;
        // transform.position = Vector2.SmoothDamp(transform.position, target, ref vel, 0.05f);

        // 3. Lerp(선형보간)
        transform.position = Vector2.Lerp(transform.position, target, 0.005f);

        // 4. SLerp(구면선형보간 3D에서만 사용가능, 원의 호를 따라서 선형보간이동)
        // transform.position = Vector2.SLerp(transform.position, target, 0.01f);
    }
}
