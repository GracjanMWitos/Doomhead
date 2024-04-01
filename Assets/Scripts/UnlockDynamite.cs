using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDynamite : MonoBehaviour
{
    [SerializeField] private Weapon weapon;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            weapon.dynamiteAvailable = true;
            weapon.weapon3.SetActive(true);
        }
    }
}
