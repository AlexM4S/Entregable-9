using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSides : MonoBehaviour
{
    public float speed = 7f;
    private float horizontalInput;

    SavePlayerPos playerPosData;

    private void Awake()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();
        playerPosData.PlayerPosLoad();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * Time.deltaTime * speed * horizontalInput);
    }
}
