using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question01 : MonoBehaviour
{
    public float inch, cm;
    
    void Start()
    {
        Debug.Log("1. 변수 inch와 cm을 float로 선언하고 각각 실숫값을 지정하여 출력하는 스크립트를 작성하라.");
        
        Debug.Log(inch + " inch, " + cm + " cm");



        Debug.Log("2. 1번에서 정의한 변수를 사용하여 인치를 센티미터로 변환하여 출력하는 스크립트를 작성하라(1인치는 2.54센티미터).");
        
        float inchToCm;
        inchToCm = inch * 2.54f;
        Debug.Log(inch + " 인치는 " + inchToCm + " 센티미터입니다.");



        Debug.Log("3. 사용자가 유니티 에디터에서 인치 데이터를 입력할 수 있도록 2번 스크립트를 약간 수정하라.");
    }
}
