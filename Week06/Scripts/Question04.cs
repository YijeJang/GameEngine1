using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question04 : MonoBehaviour
{
    public int num;
    
    void Start()
    {
        Debug.Log("4. ����Ƽ �����Ϳ��� ���ڸ� �Է¹޾� 80 �̻��̸� '���', 60 �̻��̸� '����', 60 �̸��̸� '����'�� ����ϴ� ��ũ��Ʈ�� �ۼ��϶�.");
        
        if (num >= 80)
            Debug.Log("���");
        else if (num >= 60)
            Debug.Log("����");
        else
            Debug.Log("����");
    }
}
