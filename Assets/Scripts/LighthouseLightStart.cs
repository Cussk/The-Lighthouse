using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LighthouseLightStart : MonoBehaviour
{
    //public variables
    public bool lightbulbBroken = true;
    public Animator animator;
    public Light spotLight;
    public Material brokenLight;
    public Material fixedLight;
    public TextMeshProUGUI lighthouseBroken;
    public TextMeshProUGUI interactText;

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
        interactText.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E) && playerController.currentPickup == PickupType.Lightbulb)
        {
            lightbulbBroken = false;
            playerController.currentPickup = PickupType.None;
            // door opening animation
            animator.SetTrigger("PressE");
            spotLight.enabled = true; //enables light component
            GetComponent<Renderer>().material = fixedLight; //changes material
            
        }
        else if (Input.GetKeyDown(KeyCode.E) && lightbulbBroken)
        {
            //ui text
            lighthouseBroken.gameObject.SetActive(true);
            Debug.Log("Lightbulb is broken, you need a new lightbulb.");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        interactText.gameObject.SetActive(false);
        lighthouseBroken.gameObject.SetActive(false);   
    }
}
