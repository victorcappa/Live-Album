using System;
using UnityEngine;
using UnityEngine.Video;

public class VideoAnimControl : MonoBehaviour
{
    VideoPlayer videoPlayer;
    Animator animControl;
    bool tocouAnim;
    
    void Awake()
    {
        GameObject videoPlayback = GameObject.Find("VideoPlayer");
        videoPlayer = videoPlayback.GetComponent<VideoPlayer>();
        animControl = this.gameObject.GetComponent<Animator>();
        tocouAnim = false;

    }


  

    public void EndVideo()
    {

        animControl.Play("FadeOut");
        tocouAnim = true;


    }

    private void Update()
    {
        CheckOver();
    }


    private void CheckOver()
    {
        long playerCurrentFrame = videoPlayer.GetComponent<VideoPlayer>().frame;
        long playerFrameCount = Convert.ToInt64(videoPlayer.GetComponent<VideoPlayer>().frameCount);
        
        if (playerCurrentFrame >= playerFrameCount)
        {
            if (tocouAnim == false)
                EndVideo();
        }
    
    }



}
