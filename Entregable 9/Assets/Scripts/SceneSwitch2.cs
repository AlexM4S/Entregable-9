using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch2 : MonoBehaviour
{
    SavePlayerPos playerPosData;

    void Start()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();
    }
    void OnTriggerEnter(Collider other)
    {

        playerPosData.PlayerPosSave();
        SceneManager.LoadScene(0);
        playerPosData.PlayerPosLoad();
        
    }
}
