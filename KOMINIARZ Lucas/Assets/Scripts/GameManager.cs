using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager INSTANCE;
    [SerializeField] private GameObject camera;
    [SerializeField] private Vector3 cameraOffset;
    private void Awake()
    {
        if (INSTANCE !=null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            INSTANCE = this;
            DontDestroyOnLoad(this);
        }
    }

    public void CursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public Transform CameraLookMe(Transform playerTransform)
    {
        GameObject newCamera = Instantiate(camera, playerTransform);
        return newCamera.transform;
    }
}
