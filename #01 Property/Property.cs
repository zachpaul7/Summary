using OpenCover.Framework.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;

public class Property : MonoBehaviour
{
    // Private �ʵ� (����)
    [SerializeField] private int num = 10;

    // get : �ܺο��� �ش� ������Ƽ�� �����Ͽ� �о�� �ϴ� ��Ȳ���� ȣ���
    // set : �ܺο��� �ش� ������Ƽ�� �����Ͽ� ���� �Ҵ��ϴ� ��Ȳ���� ȣ���

    /// <summary>
    /// �б�����
    /// </summary>
    public int Num
    {
        get
        {
            return num;
        }
    }

    /// <summary>
    /// ��������
    /// </summary>
    /*public int Num
    {
        set
        {
            num = value;
        }
    }*/

    /// <summary>
    /// �Ѵ� ����Ҷ�
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
    /// �ڵ�����
    /// </summary>
    //public int Num { get; set; }

    /// <summary>
    /// �ʱ�ȭ����
    /// </summary>
    //public int Num { get { return num; } }

    /// <summary>
    /// ���ٽ��� ����� ǥ�� ����
    /// </summary>
    //public int Num { get => num; set => num = value; }
}
