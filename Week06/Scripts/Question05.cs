using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question05 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("5. �ݺ����� �̿��Ͽ� 1���� 10������ �հ踦 ���ϴ� ��ũ��Ʈ�� �ۼ��϶�.");

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
