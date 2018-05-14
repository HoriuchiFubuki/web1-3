using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public void Attack()
    {

    }
}

public class Test3 : MonoBehaviour {

    int add(int a, int b)
    {
        int c;
        c = a + b;

        return c;
    }
    void SayHello()
    {
        Debug.Log("Hello");
    }
    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }

	// Use this for initialization
	void Start () {
        SayHello();
        CallName("Horiuchi");
        int ans;
        ans = add(2, 3);
        Debug.Log(ans);

        Player myplayer = new Player();
        myplayer.Attack();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
