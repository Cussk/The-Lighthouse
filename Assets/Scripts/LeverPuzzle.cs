using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LeverPuzzle : MonoBehaviour
{
    //public variables
    public bool gateLocked = true;

    //private variables
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider collider)
    {
        if (Input.GetKeyDown(KeyCode.E) && gateLocked)
        {
            animator.SetTrigger("PressE");
        }
        else if (!gateLocked)
        {
            //ui for text
            Debug.Log("Gate is already unlocked");
        }
    }
}
