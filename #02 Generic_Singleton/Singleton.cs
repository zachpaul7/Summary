using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T _instance = null;

    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;
                if(_instance == null)
                {
                    Debug.Log("�̱��� " +  typeof(T) + "�� ���� �������� ����");
                }
            }
            return _instance;
        }
        set => _instance = value;
    }
}
