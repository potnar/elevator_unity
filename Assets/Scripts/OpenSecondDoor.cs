using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSecondDoor : MonoBehaviour
{
    public GameObject SecondDoorLeft;
    public GameObject SecondDoorRight;
    public GameObject SecondTrigger;
    public Animator leftAnimSecond;
    public Animator rightAnimSecond;
    //public Animator ElevatorAnim;

    private void Start()
    {
        leftAnimSecond = SecondDoorLeft.GetComponent<Animator>();
        rightAnimSecond = SecondDoorRight.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            SecondSlideDoor(true);
            //elevatorSound.Stop();
        }

    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SecondSlideDoor(false);
            //SecondSlideDoor(false);
        }
    }
    void OnMouseDown()
    {
        SecondSlideDoor(true);
    }
    void OnMouseUp()
    {
        SecondSlideDoor(false);
    }
    public void SecondSlideDoor(bool state)
    {
        leftAnimSecond.SetBool("SecondSlide", state);
        rightAnimSecond.SetBool("SecondSlide", state);
    }
}
