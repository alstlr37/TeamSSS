using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Character
{
    Warrior,
    Assassin,
    Wizard,
    Gunner
}

public class SelectJob : MonoBehaviour
{
    public static SelectJob instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public Character currentCharacter;
}
