using TMPro;
using UnityEngine;

public class LeverPuzzle : MonoBehaviour
{
    //public variables
    public bool gateLocked = true;
    public Animator animator;
    public TextMeshProUGUI gateUnlockedText;
    public TextMeshProUGUI interactText;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

   private void OnTriggerStay(Collider collider)
    {
        interactText.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E) && gateLocked)
        {
            animator.SetTrigger("PressE");
            gateLocked = false;
            //ui text gate unlocked
            gateUnlockedText.gameObject.SetActive(true);
            Debug.Log("You hear the sound of a mechanism releasing in the distance...");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        interactText.gameObject.SetActive(false);
        gateUnlockedText.gameObject.SetActive(false);
    }
}
