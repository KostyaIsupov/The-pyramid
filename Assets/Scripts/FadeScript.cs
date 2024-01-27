using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public string nextLevel;
    private Animator FadePanelAnimator;
    // Start is called before the first frame update
    void Start()
    {
        FadePanelAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeScreen()
    {
        FadePanelAnimator.SetTrigger("Fade");
    }   
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
