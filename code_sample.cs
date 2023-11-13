using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    int level = 5;
    float stat = 7.5f;
    string playername = "이론";
    bool isFullLevel = false;
    int hp = 30;
    int mp = 15;
    void Start()
    {
        // 0. 콘솔 출력 방법
        Debug.Log("hello unity");

        // 1. 변수
        
        
        Debug.Log(level);
        Debug.Log(stat);
        Debug.Log(playername);
        Debug.Log(isFullLevel);

        // 2. 그룹형 변수
        string[] monsters = {"슬라임","악마","천사","골렘","뱀"};
        int[] monsterlevel = new int[5];
        monsterlevel[0] = 1;
        monsterlevel[1] = 10;
        monsterlevel[2] = 10;
        monsterlevel[3] = 15;
        monsterlevel[4] = 5;

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
        items.Add("파워앨릭서30");
        
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

        
        bool badcondition = hp <= 50 && mp <= 20;
        //bool badcondition = hp <= 50 || mp <= 20;
        string condition = badcondition ? "bad" : "good";

        Debug.Log(badcondition);
        Debug.Log(condition);

        // 4. 조건문
        if (condition == "bad") {
            Debug.Log("상태 나쁨");
        }
        else {
            Debug.Log("상태 좋음");
        }

        if (badcondition && items[0] == "생명물약30") {
            items.RemoveAt(0);
            hp += 30;
            Debug.Log("생명포션30 사용");
        }
        else if (badcondition && items[0] == "마나물약30") {
            items.RemoveAt(0);
            mp += 30;
            Debug.Log("마나포션30 사용");
        }

        switch (monsters[4]) {
            case "슬라임":
                Debug.Log("소형몬스터");
                break;
            case "악마":
            case "천사":
                Debug.Log("중형몬스터");
                break;
            case "골렘":
                Debug.Log("대형몬스터");
                break;
            default:
                Debug.Log("???몬스터");
                break;
        }

        // 5. 반복문
        while (hp > 0) {
            hp--;
            if (hp >0) {
                Debug.Log("독 " + hp);
            }
            else {
                Debug.Log("사망");
            }

            if (hp == 10) {
                Debug.Log("해독제");
                break;
            }
            
        }

        for (int count=0 ; count<10 ; count++) {
            hp++;
            Debug.Log("붕대 " + hp);
        }

        for (int index=0 ; index < monsters.Length ; index++) {
            Debug.Log("몬스터 " + monsters[index]);
        }

        for (int index=0 ; index < items.Count ; index++) {
            Debug.Log("포션 " + items[index]);
        }

        foreach (string monster in monsters) {
            Debug.Log("몬스터 " + monster);
        }

        foreach (string item in items) {
            Debug.Log("아이템 " + item);
        }

        hp = Heal(hp);
        Healing();

        for(int index=0 ; index < monsters.Length ; index++) {
            Debug.Log(monsters[index] + " 에게 " + Battle(monsterlevel[index]));
        }

        // 8. 클래스

        Player player = new Player();
        player.id = 0;
        player.name = "이론";
        player.title = "모든것의 ";
        player.weapon = "지팡이";
        player.stat = 3.5f;
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());
        Debug.Log(player.move());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level);


    }

    // 7. 함수(메소드)
    int Heal(int currenthp)
    {
        currenthp += 10;
        Debug.Log("힐 " + currenthp);
        return currenthp;
    }

    void Healing()
    {
        hp += 10;
        Debug.Log("힐링 " + hp);
    }

    string Battle(int monsterlevel)
    {
        string result;
        if (level >= monsterlevel)
            result = "승리";
        else 
            result = "패배";
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
