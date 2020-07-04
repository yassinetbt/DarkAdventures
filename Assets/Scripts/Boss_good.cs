using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_good : MonoBehaviour
{
    private Animator bossAnimation;
    public float endingDelay = 4f;

    // Start is called before the first frame update
    void Start()
    {
        bossAnimation = GetComponent<Animator>();
        bossAnimation.SetBool("triggerGoodAnimation", true);
        StartCoroutine("DelayGoodEnding");
    }

    // Update is called once per frame
    void Update()
    {


    }
    private IEnumerator DelayGoodEnding()
    {

        yield return new WaitForSeconds(endingDelay);

        SceneManager.LoadScene(7);
    }
}