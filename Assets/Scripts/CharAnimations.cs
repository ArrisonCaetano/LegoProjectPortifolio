using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimations : MonoBehaviour
{
    public GameObject charMe;
    void Start()
    {
        charMe = GameObject.Find("Character");



    }

    private void OnMouseDown()
    {
        charMe.GetComponent<Animator>().SetTrigger("TriCharHi");
    }


}
