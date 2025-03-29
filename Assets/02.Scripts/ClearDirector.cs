using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneMangement;

public class ClearDirector : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManger.LoadScene("GameScene");

        }
    }
}
