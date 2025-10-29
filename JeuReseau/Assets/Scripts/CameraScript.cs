using System;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private float vitesseRotation = 2;
    [SerializeField] private float hauteur = 1;
    [SerializeField] private float distance = 0;
    
    private Transform cible;
    
    private float rotationX = 0;
    private float rotationY = 0;

    private void Awake()
    {
        cible = transform.parent;
    }

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * vitesseRotation;
        rotationX -= Input.GetAxis("Mouse Y") * vitesseRotation;

        rotationX = Mathf.Clamp(rotationX, -30, 30);

        Quaternion rotation = Quaternion.Euler(rotationX, rotationY, 0);
        transform.rotation = rotation;

        Vector3 position = cible.position + rotation * new Vector3(0, 0.8f, -distance) + new Vector3(0, hauteur, 0);
        transform.position = position;

    }
}
