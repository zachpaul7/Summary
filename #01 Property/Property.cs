using OpenCover.Framework.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;

public class Property : MonoBehaviour
{
    // Private 필드 (변수)
    [SerializeField] private int num = 10;

    // get : 외부에서 해당 프로퍼티에 접근하여 읽어야 하는 상황에서 호출됨
    // set : 외부에서 해당 프로퍼티에 접근하여 값을 할당하는 상황에서 호출됨

    /// <summary>
    /// 읽기전용
    /// </summary>
    public int Num
    {
        get
        {
            return num;
        }
    }

    /// <summary>
    /// 쓰기전용
    /// </summary>
    /*public int Num
    {
        set
        {
            num = value;
        }
    }*/

    /// <summary>
    /// 둘다 사용할때
    /// </summary>
    /*public int Num
    {
        get
        {
            return num;
        }
        set
        {
            num = value;
        }
    }*/

    /// <summary>
    /// 자동구현
    /// </summary>
    //public int Num { get; set; }

    /// <summary>
    /// 초기화전용
    /// </summary>
    //public int Num { get { return num; } }

    /// <summary>
    /// 람다식을 사용해 표현 가능
    /// </summary>
    //public int Num { get => num; set => num = value; }
}
