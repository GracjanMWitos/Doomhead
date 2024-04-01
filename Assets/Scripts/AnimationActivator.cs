using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationActivator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("Start");
        }
    }
}
