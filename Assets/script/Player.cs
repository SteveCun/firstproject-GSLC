using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playerAnimator;
    public GameObject RawImageVideo;
    
    public void playerAttack()
    {
        playerAnimator.SetTrigger("Isattack");
    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }

    public void playVideo()
    {
        RawImageVideo.SetActive(true);
    }
}
