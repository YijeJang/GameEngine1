using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question07 : MonoBehaviour
{
    public float inch;

    void Start()
    {
        Debug.Log("7. inch를 멤버 변수로 선언하고, 인치를 센티미터로 바꾸는 메서드를 가진 클래스 InchToCm을 정의하라. 그리고 이 클래스를 이용하여 인치를 센티미터로 바꾸는 스크립트를 작성하라.");
        
        InchToCm inchToCm = new InchToCm();
        inchToCm.inch = inch;

        Debug.Log(inch + " 인치는 " + inchToCm.change(inchToCm.inch) + " 센티미터입니다.");
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
