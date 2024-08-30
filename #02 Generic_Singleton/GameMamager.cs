using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMamager : Singleton<GameMamager>
{
    // Singleton<T>로 상속받아서 사용

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
