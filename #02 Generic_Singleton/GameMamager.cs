using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMamager : Singleton<GameMamager>
{
    // Singleton<T>�� ��ӹ޾Ƽ� ���

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
