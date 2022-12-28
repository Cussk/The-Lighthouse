using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public variables
    public bool hasPickup;
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
            Debug.Log("Key held.");
        }

        if (currentPickup == PickupType.Lightbulb)
        {
            //Ui to show Lightbulb
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            hasPickup = true;
            currentPickup = other.gameObject.GetComponent<Pickup>().pickupType;
            Destroy(other.gameObject);
        }
    }
}
