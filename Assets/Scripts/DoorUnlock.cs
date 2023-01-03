using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DoorUnlock : MonoBehaviour
{
    //public variables
    public bool doorLocked = true;
    public Animator animator;
    public TextMeshProUGUI doorLockedText;
    public TextMeshProUGUI interactText;
       
    //private variables
    private PlayerController playerController;
    

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
    }

    //opens door on trigger enter if key held
    private void OnTriggerStay(Collider collider)
    {
        interactText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && playerController.currentPickup == PickupType.Key)
            {
                doorLocked = false;
                playerController.currentPickup = PickupType.None;
                playerController.keyImage.gameObject.SetActive(false);
                // door opening animation
                animator.SetTrigger("PressE");
            }
             else if (Input.GetKeyDown(KeyCode.E) && doorLocked)
            {
            //ui text "Door is Locked"
            doorLockedText.gameObject.SetActive(true);
            Debug.Log("Door is locked, you need a key.");
            }
    }

    private void OnTriggerExit(Collider collider)
    {
        interactText.gameObject.SetActive(false);
        doorLockedText.gameObject.SetActive(false);
    }

}
