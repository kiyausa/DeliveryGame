using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                Type type = typeof(T);

                instance = (T)FindObjectOfType(type);
                if (instance == null)
                {
                    Debug.LogError(type + "���A�^�b�`���Ă���GameObject�͂���܂���");
                }
            }

            return instance;
        }
    }

    virtual protected void Awake()
    {
        CheckInstance();
    }

    protected bool CheckInstance()
    {
        if (instance == null)
        {
            instance = this as T;
            return true;
        } 
        else if (Instance == this)
        {
            return true;
        }

        Destroy(this);
        return false;
    }
}
