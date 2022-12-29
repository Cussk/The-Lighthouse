using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    //public variables
    public Animator animator;

    //private variables
    private LeverPuzzle leverPuzzle;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        leverPuzzle = GameObject.Find("Lever Puzzle").GetComponent<LeverPuzzle>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!leverPuzzle.gateLocked)
        {
            animator.SetTrigger("PressE");
        }
        else if (leverPuzzle.gateLocked)
        {
            //ui text hinting to lever puzzle
            Debug.Log("Gate is locked.  It seems it is controlled by a mechanism nearby...");
        }
    }
}
