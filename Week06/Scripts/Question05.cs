using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question05 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("5. 반복문을 이용하여 1부터 10까지의 합계를 구하는 스크립트를 작성하라.");

        int sub = 0;
        for (int i = 1; i < 11; i++)
        {
            sub += i;

            if (sub-i == 0)
                continue;
            Debug.Log(sub-i + " + " + i + " = " + sub);
        }
    }
}
