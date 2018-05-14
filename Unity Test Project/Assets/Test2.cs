using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 5;
        array[2] = 10;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int[] point = { 83, 15, 91, 93, 55 };
        for (int i = 0; i < point.Length; i++)
        {
            if (point[i] > 90)
                Debug.Log(point[i]);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
