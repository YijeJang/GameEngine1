using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question06 : MonoBehaviour
{
    public float inch;

    void Start()
    {
        Debug.Log("6. 사용자가 입력한 인치 데이터를 인수로 받아서 이것을 센티미터로 바꾸어 변환하는 함수를 작성하라.");
        
        Debug.Log(inch + " 인치는 " + InchToCm(inch) + " 센티미터입니다.");
    }

    float InchToCm(float n)
    {
        return n * 2.54f;
    }
}
