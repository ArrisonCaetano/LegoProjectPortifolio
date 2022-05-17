using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUi : MonoBehaviour
{
    #region Variable
    //Component
    private Renderer _renderClock;

    //Game Object
    public GameObject clockCanvas;
    public GameObject clock;

    static int a = 0;
    #endregion
    [SerializeField] private Slider _sliderSeconds;
    [SerializeField] private Slider _sliderMinutes;
    [SerializeField] private Slider _sliderHours;

    private void Start()
    {
        clockCanvas = GameObject.Find("CanvasClock");
        clock = GameObject.Find("Clock");

        _renderClock = clock.GetComponent<Renderer>();
       





    }

    public void ChangeSeconds() 
    {
        

        _renderClock.material.SetFloat("_MoveSeconds", _sliderSeconds.value);
     

    }

    public void ChangeMinutes()
    {


       
         _renderClock.material.SetFloat("_MoveMinutes", _sliderMinutes.value);
        

    }
    public void ChangeHours()
    {


        
        _renderClock.material.SetFloat("_MoveHours", _sliderHours.value);

    }





    private void OnMouseDown()
    {
        if (this.gameObject.name == "Clock")
        {

            if (a == 0)
            {
                a = 1;
                clockCanvas.GetComponent<Animator>().SetTrigger("UIclockOpen");


            }
            else if (a == 1 && clockCanvas.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) // verifying if the animations is still playing
            {
                a = 0;
                clockCanvas.GetComponent<Animator>().SetTrigger("UIclockClose");

            }
        }
    }

}
