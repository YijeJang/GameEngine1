using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question06 : MonoBehaviour
{
    public float inch;

    void Start()
    {
        Debug.Log("6. ����ڰ� �Է��� ��ġ �����͸� �μ��� �޾Ƽ� �̰��� ��Ƽ���ͷ� �ٲپ� ��ȯ�ϴ� �Լ��� �ۼ��϶�.");
        
        Debug.Log(inch + " ��ġ�� " + InchToCm(inch) + " ��Ƽ�����Դϴ�.");
    }

    float InchToCm(float n)
    {
        return n * 2.54f;
    }
}
