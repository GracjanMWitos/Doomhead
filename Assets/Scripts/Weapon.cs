using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform rayOrigin;
    [SerializeField] private Transform rayTarget;
    [SerializeField] public StarterAssetsInputs starterAssetsInputs;

    LineRenderer lineRenderer;

    public bool dynamiteAvailable;
    [SerializeField] private GameObject weapon1;
    [SerializeField] private GameObject weapon2;
    public GameObject weapon3;
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
        if (starterAssetsInputs.weapon1)
        {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
            weapon3.SetActive(false);
        }
        if (starterAssetsInputs.weapon2)
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
            weapon3.SetActive(false);
        }
        if (starterAssetsInputs.weapon3 && dynamiteAvailable)
        {
            weapon1.SetActive(false);
            weapon2.SetActive(false);
            weapon3.SetActive(true);
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
            if (hit.transform.CompareTag("Detonatable") && (dynamiteAvailable))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
