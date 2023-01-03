using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    //public variables
    public TextMeshProUGUI interactText;

    //private variables
    private Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider collider)
    {
        interactText.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("PressE");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        interactText.gameObject.SetActive(false);
    }
}
