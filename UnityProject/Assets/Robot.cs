using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {
    [Header("對話")]
    public string SayStart = "嗨!你好";
    [Header("對話速度")]
    public float speed = 1.5f;
    [Header("任務相關")]
    public bool Complete = false;
    public int BateryFinish  = 5;
    public int Batery = 0;
    // Use this for initialization
    void Start () {
        
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
