using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSetTest : MonoBehaviour
{
    public Property property;

    void Getting()
    {
        Debug.Log(property.Num);
    }

    // set을 설정하고 사용해야함
    /*void Setting()
    {
        property.Num = 10;
        Debug.Log(property.Num);
    }*/
}
