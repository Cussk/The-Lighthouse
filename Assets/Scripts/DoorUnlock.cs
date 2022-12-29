using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    //public variables
    public bool doorLocked = true;
    public Animator animator;

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
            if (Input.GetKeyDown(KeyCode.E) && playerController.currentPickup == PickupType.Key)
            {
                doorLocked = false;
                playerController.currentPickup = PickupType.None;
                // door opening animation
                animator.SetTrigger("PressE");
            }
             else if (Input.GetKeyDown(KeyCode.E) && doorLocked)
            {
                //ui text "Door is Locked"
                Debug.Log("Door is locked, you need a key.");
            }
    }
}
