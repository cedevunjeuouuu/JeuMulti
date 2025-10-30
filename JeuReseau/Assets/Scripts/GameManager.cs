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
    public CameraScript CameraLookMe(Transform playerTransform)
    {
        GameObject camObject = Instantiate(camera, playerTransform);
        CameraScript newCamera = camObject.GetComponent<CameraScript>();
        newCamera.cible = playerTransform;
        return newCamera;
    }
}
