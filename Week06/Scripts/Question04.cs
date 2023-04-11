using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question04 : MonoBehaviour
{
    public int num;
    
    void Start()
    {
        Debug.Log("4. 유니티 에디터에서 숫자를 입력받아 80 이상이면 '우수', 60 이상이면 '보통', 60 미만이면 '미흡'을 출력하는 스크립트를 작성하라.");
        
        if (num >= 80)
            Debug.Log("우수");
        else if (num >= 60)
            Debug.Log("보통");
        else
            Debug.Log("미흡");
    }
}
