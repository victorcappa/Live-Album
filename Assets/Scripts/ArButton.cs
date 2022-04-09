
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class ArButton : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    bool pause;
    public VideoPlayer vp;
    Animator animCtrl;
    GameObject button; 
    
  
    void Awake()
    {
        animCtrl = GetComponent<Animator>();
        pause = false;
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                unityEvent.Invoke();
            }
        }
    }

    public void PausePlay()
    {

        pause = !pause;


        if (!pause)
        {
           vp.Pause();
           animCtrl.Play("btn_Play");

        }
        else
        {
            vp.Play();
            animCtrl.Play("btn_Pause");

        }


    }
   
}

