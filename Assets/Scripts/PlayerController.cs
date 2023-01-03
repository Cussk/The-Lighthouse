using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public variables
    public bool hasPickup;
    public Image keyImage;
    public Image lighterImage;
    public TextMeshProUGUI interactText;
    public PickupType currentPickup = PickupType.None;
   
    //private variables
    [SerializeField] private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (currentPickup == PickupType.Key)
        {
            //UI to show key
            keyImage.gameObject.SetActive(true);
            Debug.Log("Key held.");
        } 
        else
        {
            keyImage.gameObject.SetActive(false);
        }

        if (currentPickup == PickupType.Lightbulb)
        {
            //Ui to show Lightbulb
            lighterImage.gameObject.SetActive(true);
            Debug.Log("Lightbulb Held");
        }
    }

    private void PlayerMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }

    private void OnTriggerStay(Collider other)
    {
        interactText.gameObject.SetActive(true);
        if (other.gameObject.CompareTag("Pickup") && Input.GetKeyDown(KeyCode.E))
        {
            hasPickup = true;
            currentPickup = other.gameObject.GetComponent<Pickup>().pickupType;
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        interactText.gameObject.SetActive(false);
    }
}
