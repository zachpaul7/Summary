using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
// Singleton<T>로 상속받아서 사용
public class GameMamager : Singleton<GameMamager>
{
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
