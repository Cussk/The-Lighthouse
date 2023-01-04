using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoryTrigger : MonoBehaviour
{
    //public variables
    public TextMeshProUGUI storyIntro;

    //triggers story ui coroutine on entering
    private void OnTriggerEnter(Collider other)
    {
        storyIntro.gameObject.SetActive(true);
        StartCoroutine(StoryIntro());

    }

    //deactivates story text if outside of trigger area for 10 seconds
    IEnumerator StoryIntro()
    {
        yield return new WaitForSeconds(10);
        storyIntro.gameObject.SetActive(false);
    }
}
