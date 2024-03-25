using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform rayOrigin;
    [SerializeField] private Transform rayTarget;
    [SerializeField] private StarterAssetsInputs starterAssetsInputs;

    LineRenderer lineRenderer;
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        if (starterAssetsInputs.shoot)
        {
            Shooting();
            starterAssetsInputs.shoot = false;
        }
    }
    private void Shooting()
    {
        Vector3 rayDirection = rayTarget.position - rayOrigin.position;
        Ray ray = new Ray(rayOrigin.position, rayDirection);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("Enemy"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
