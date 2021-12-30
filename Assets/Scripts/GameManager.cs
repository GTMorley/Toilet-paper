using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    protected static GameManager _Instance;
    public static GameManager Instance { get => _Instance; }

    void Awake()
    {
        if (_Instance != null)
            GameObject.Destroy(_Instance);
        else
            _Instance = this;

        DontDestroyOnLoad(this);
    }
    #endregion

    public static int points = 10;
}
