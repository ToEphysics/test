using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 0. 콘솔 출력 방법
        Debug.Log("hello unity");

        // 1. 변수
        int level = 5;
        float stat = 1.5f*(float)level;
        string playername = "이론";
        bool isFullLevel = false;
        
        Debug.Log(level);
        Debug.Log(stat);
        Debug.Log(playername);
        Debug.Log(isFullLevel);

        // 2. 그룹형 변수
        string[] monsters = {"슬라임","악마","천사"};
        int[] monsterlevel = new int[3];
        monsterlevel[0] = 1;
        monsterlevel[1] = 10;
        monsterlevel[2] = 10;

        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        Debug.Log(monsterlevel[0]);
        Debug.Log(monsterlevel[1]);
        Debug.Log(monsterlevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        items.Add("앨릭서30");
        
        items.RemoveAt(2); // 지우기
        
        Debug.Log(items[0]);
        Debug.Log(items[1]);
        // Debug.Log(items[2]);

        // 3. 연산자
        int exp = 1000;

        exp = 1500 + 200;
        exp = exp - 100;
        level = exp / 300;
        stat = level * 2.5f;

        Debug.Log(exp);
        Debug.Log(level);
        Debug.Log(stat);

        int nextExp = 300 - (exp % 300);

        Debug.Log(nextExp);

        string title = "모든 것의";
        Debug.Log(title + " " + playername);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log(isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log(isEndTutorial);

        int hp = 30;
        int mp = 25;
        bool badcondition = hp <= 50 && mp <= 20;
        //bool badcondition = hp <= 50 || mp <= 20;
        string condition = badcondition ? "bad" : "good";

        Debug.Log(badcondition);
        Debug.Log(condition);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
