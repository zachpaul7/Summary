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

    // set�� �����ϰ� ����ؾ���
    /*void Setting()
    {
        property.Num = 10;
        Debug.Log(property.Num);
    }*/
}
