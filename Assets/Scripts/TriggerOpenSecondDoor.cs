using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class TriggerOpenSecondDoor : MonoBehaviour
{
    public GameObject SecondDoorLeft;
    public GameObject SecondDoorRight;
    public GameObject SecondTrigger;

    Animator leftAnimSecond;
    Animator rightAnimSecond;
    
    private void Start()
    {
        leftAnimSecond = SecondDoorLeft.GetComponent<Animator>();
        rightAnimSecond = SecondDoorRight.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        Debug.Log("siema");
        if (coll.gameObject.tag == "Player")
        {
            SecondSlideDoor(true);
        }
    }
    
    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SecondSlideDoor(false);
        }
    }
    public void SecondSlideDoor(bool state)
    {
        leftAnimSecond.SetBool("SecondSlide", state);
        rightAnimSecond.SetBool("SecondSlide", state);
    }
}*/
