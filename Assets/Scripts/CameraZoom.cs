using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    #region Variables
    
    Camera mycamera;
    public GameObject[] Objects;
    static int a = 0;
    


    #endregion

    void Start()
    {

        mycamera = Camera.main;
      

    }

   




    void OnMouseDown()
    {
        print(this.gameObject.name);
        print(a);

        if (this.gameObject.name == "Character")
        {
          

            if (a == 0)
            {
                a = 1;
                mycamera.GetComponent<Animator>().Play("Base Layer.ZoomChar");

                //disable collides to unable to click in a diferent mehs
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0) continue; // skip this value
                    Objects[i].GetComponent<BoxCollider>().enabled = false;

                }


            }
            else if (a == 1 && mycamera.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) // verifying if the animations is still playing
            {
                a = 0;
                mycamera.GetComponent<Animator>().SetTrigger("TriZoomOutChar");

                //enable collides to unable to click in a diferent mehs
                for (int i = 0; i < 4; i++)
                {
                    
                    Objects[i].GetComponent<BoxCollider>().enabled = true;

                }

            }
        }


        if (this.gameObject.name == "Clock")
        {

            if (a == 0)
            {
                a = 1;
                mycamera.GetComponent<Animator>().Play("Base Layer.ZoomClock");


                for (int i = 0; i < 4; i++)
                {
                    if (i == 3) continue;
                    Objects[i].GetComponent<BoxCollider>().enabled = false;

                }




            }
            else if (a == 1 && mycamera.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) // verifying if the animations is still playing
            {


                a = 0;
                mycamera.GetComponent<Animator>().SetTrigger("ZoomOutClock");


                for (int i = 0; i < 4; i++)
                {
                    
                    Objects[i].GetComponent<BoxCollider>().enabled = true;

                }



            }
        }




        if (this.gameObject.name == "Propeller")
        {

            if (a == 0)
            {
                a = 1;
                mycamera.GetComponent<Animator>().Play("Base Layer.ZoomPropeller");


                for (int i = 0; i < 4; i++)
                {
                    if (i == 2) continue;
                    Objects[i].GetComponent<BoxCollider>().enabled = false;

                }


            }
            else if (a == 1 && mycamera.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) // verifying if the animations is still playing
            {
                a = 0;
                mycamera.GetComponent<Animator>().SetTrigger("ZoomOutPropeller");

                for (int i = 0; i < 4; i++)
                {
                    
                    Objects[i].GetComponent<BoxCollider>().enabled = true;

                }


            }
        }




        if (this.gameObject.name == "window")
        {

            if (a == 0)
            {
                a = 1;
                mycamera.GetComponent<Animator>().Play("Base Layer.ZoomWindows");


                for (int i = 0; i < 4; i++)
                {
                    if (i == 1) continue;
                    Objects[i].GetComponent<BoxCollider>().enabled = false;

                }


            }
            else if (a == 1 && mycamera.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) // verifying if the animations is still playing
            {
                a = 0;
                mycamera.GetComponent<Animator>().SetTrigger("ZoomOutWindow");


                for (int i = 0; i < 4; i++)
                {
                    Objects[i].GetComponent<BoxCollider>().enabled = true;

                }


            }
        }









    }
}
