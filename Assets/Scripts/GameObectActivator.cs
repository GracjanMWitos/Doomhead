using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObectActivator : MonoBehaviour
{
    [SerializeField] private GameObject gameObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(true);
        }
    }
}
