using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question07 : MonoBehaviour
{
    public float inch;

    void Start()
    {
        Debug.Log("7. inch�� ��� ������ �����ϰ�, ��ġ�� ��Ƽ���ͷ� �ٲٴ� �޼��带 ���� Ŭ���� InchToCm�� �����϶�. �׸��� �� Ŭ������ �̿��Ͽ� ��ġ�� ��Ƽ���ͷ� �ٲٴ� ��ũ��Ʈ�� �ۼ��϶�.");
        
        InchToCm inchToCm = new InchToCm();
        inchToCm.inch = inch;

        Debug.Log(inch + " ��ġ�� " + inchToCm.change(inchToCm.inch) + " ��Ƽ�����Դϴ�.");
    }
}

public class InchToCm
{
    public float inch;

    public float change(float n)
    {
        return n * 2.54f;
    }
}
