using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    public GameObject DoorLeft;
    public GameObject DoorRight;
    public GameObject Elevator;
    //public Collider TriggerCollider;
    public GameObject Trigger;
    //public GameObject DoorTwo;
    public Animator ElevatorAnim;
    Animator leftAnim;
    Animator rightAnim;
    bool DoorIsOpening;

    private void Start()
    {
        //TriggerCollider = Trigger.GetComponent<BoxCollider>;
        leftAnim = DoorLeft.GetComponent<Animator>();
        rightAnim = DoorRight.GetComponent<Animator>();
        ElevatorAnim = Elevator.GetComponent<Animator>();
    }
    private void Update()
    {

        if (DoorIsOpening == true)
        {
            ElevatorAnim.SetInteger("ElevatorSlider", 1);

            //SlideDoor(true);
        }
        /*if (ElevatorAnim.GetCurrentAnimatorStateInfo(0).IsTag("Zero"))
        {
            //Debug.Log("siema");
            
            
        }*/
    }
    void OnMouseDown()
    {

        DoorIsOpening = true;
        SlideDoor(true);
        //Debug.Log(ElevatorAnim.GetCurrentAnimatorStateInfo(0).GetTag);

    }
    void OnMouseUp()
    {
        SlideDoor(false);
        DoorIsOpening = false;
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SlideDoor(true);
        }

    }
    private void OnTriggerStay(Collider coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            SlideDoor(true);
        }

    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SlideDoor(false);
        }
    }
    public void SlideDoor(bool state)
    {
        leftAnim.SetBool("slide", state);
        rightAnim.SetBool("slide", state);
    }
    public void ElevatorSlides(float state)
    {
        ElevatorAnim.SetFloat("ElevatorSlider", state);
    }
}
