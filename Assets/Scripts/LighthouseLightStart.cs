using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighthouseLightStart : MonoBehaviour
{
    //public variables
    public bool lightbulbBroken = true;
    public Animator animator;
    public Light spotLight;

    //private variables
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        spotLight = GetComponent<Light>();
    }

    //restarts lighbulb on entering trigger area if lightbulb held
    private void OnTriggerStay(Collider collider)
    {
        if (Input.GetKeyDown(KeyCode.E) && playerController.currentPickup == PickupType.Lightbulb)
        {
            lightbulbBroken = false;
            playerController.currentPickup = PickupType.None;
            // door opening animation
            animator.SetTrigger("PressE");
            spotLight.enabled = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.E) && lightbulbBroken)
        {
            //ui text "Door is Locked"
            Debug.Log("Lightbulb is broken, you need a new lightbulb.");
        }
    }
}
