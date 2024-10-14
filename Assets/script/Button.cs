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
            Debug.Log("1번 버튼은 일반 프리팹입니다.");

        }
        else if (ButtonNumber == 2)
        {
            Debug.Log("2번 버튼은 Variant Prefab입니다.");
        }
        else if (ButtonNumber == 3)
        {
            Debug.Log("3번 버튼은 Nested Prefab입니다. 1번 버튼과 2번 버튼을 포함하고 있습니다.");
        }
        else
        {
            Debug.Log("설정된 버튼이 아닙니다.");

        }
    }




}
