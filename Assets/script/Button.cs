using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public int ButtonNumber = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonClick()
    {
        if (ButtonNumber == 1)
        {
            Debug.Log("1�� ��ư�� �Ϲ� �������Դϴ�.");

        }
        else if (ButtonNumber == 2)
        {
            Debug.Log("2�� ��ư�� Variant Prefab�Դϴ�.");
        }
        else if (ButtonNumber == 3)
        {
            Debug.Log("3�� ��ư�� Nested Prefab�Դϴ�. 1�� ��ư�� 2�� ��ư�� �����ϰ� �ֽ��ϴ�.");
        }
        else
        {
            Debug.Log("������ ��ư�� �ƴմϴ�.");

        }
    }




}
