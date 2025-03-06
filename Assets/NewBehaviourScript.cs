using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("遊戲執行 Start");
    }

    private void Awake()
    {
        Debug.Log($"Awake");
    }

    private void OnEnable()
    {
        Debug.Log($"OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log($"OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log($"OnDestroy");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log($"碰到地板");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log($"進入偵測區域");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log($"離開偵測區域");
    }
}
