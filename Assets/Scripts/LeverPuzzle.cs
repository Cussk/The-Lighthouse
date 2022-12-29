using UnityEngine;

public class LeverPuzzle : MonoBehaviour
{
    //public variables
    public bool gateLocked = true;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

   private void OnTriggerStay(Collider collider)
    {
        if (Input.GetKeyDown(KeyCode.E) && gateLocked)
        {
            animator.SetTrigger("Lever1");
            animator.SetTrigger("Lever2");
            gateLocked = false;
            //ui text gate unlocked
            Debug.Log("You hear the sound of a mechanism releasing in the distance...");
        }
        else if (!gateLocked)
        {
            //ui for text
            Debug.Log("Gate is already unlocked");
        }
    }
}
