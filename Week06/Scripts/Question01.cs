using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question01 : MonoBehaviour
{
    public float inch, cm;
    
    void Start()
    {
        Debug.Log("1. ���� inch�� cm�� float�� �����ϰ� ���� �Ǽ����� �����Ͽ� ����ϴ� ��ũ��Ʈ�� �ۼ��϶�.");
        
        Debug.Log(inch + " inch, " + cm + " cm");



        Debug.Log("2. 1������ ������ ������ ����Ͽ� ��ġ�� ��Ƽ���ͷ� ��ȯ�Ͽ� ����ϴ� ��ũ��Ʈ�� �ۼ��϶�(1��ġ�� 2.54��Ƽ����).");
        
        float inchToCm;
        inchToCm = inch * 2.54f;
        Debug.Log(inch + " ��ġ�� " + inchToCm + " ��Ƽ�����Դϴ�.");



        Debug.Log("3. ����ڰ� ����Ƽ �����Ϳ��� ��ġ �����͸� �Է��� �� �ֵ��� 2�� ��ũ��Ʈ�� �ణ �����϶�.");
    }
}
