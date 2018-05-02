using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("Hello World");

        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f,height2;
        height2 = height1;
        Debug.Log(height2);

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);
        answer = 3 - 4;
        Debug.Log(answer);
        answer = 4 / 2;
        Debug.Log(answer);
        answer = 2 * 3;
        answer = answer + age;
        Debug.Log(answer);
        answer += 5;
        Debug.Log(answer);
        answer++;
        Debug.Log(answer);

        string str1 = "happy",str2 = "birthday";
        str1 = str1 + str2;
        Debug.Log(str1);

        string str3;
        str3 = str1 + age;
        Debug.Log(str3);

        int Num = 1;
        if(Num == 1)
        {
            Debug.Log("HPが５０回復");
        }
        int Hp = 180;
        if(Hp <= 50)
        {
            Debug.Log("逃走！");
        }
        else if(Hp >= 200)
        {
            Debug.Log("攻撃！");
        }
        else
        {
            Debug.Log("防御！");
        }

        int x = 1;
        if(x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        for(int j = 3; j <= 8; j += 2)
        {
            Debug.Log(j);
        }
        for(int k = 5; k > 0; k--)
        {
            Debug.Log(k);
        }
        int sum = 0;
        for(int n = 0; n <= 10; n++)
        {
            sum += n;
        }
        Debug.Log(sum);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
