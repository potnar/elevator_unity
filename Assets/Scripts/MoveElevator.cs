using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MoveElevator : MonoBehaviour
{
    public AudioSource elevatorSound;
    public GameObject SecondDoorLeft;
    public GameObject SecondDoorRight;
    public GameObject SecondTrigger;
    
    //public GameObject Player;
    //public Collider PlayerColl;

    public GameObject Elevator;
    //public Animator ElevatorAnim;
    public Animator leftAnimSecond;
    public Animator rightAnimSecond;
    public Animator ElevatorAnim;
    private bool ElevatorIsMove;
   
    private void Start()
    {
        leftAnimSecond = SecondDoorLeft.GetComponent<Animator>();
        rightAnimSecond = SecondDoorRight.GetComponent<Animator>();
        ElevatorAnim = Elevator.GetComponent<Animator>();
        //ElevatorSlides(1);
        //PlayerColl = Player.GetComponent<Collider>();
        ElevatorIsMove = false;
    }
    private void Update()
    {
        //ElevatorIsMove = false;
        if (ElevatorIsMove == true)
        {
            ElevatorSlides(1.2f);
            
        }

        
        /*if (Elevator.transform.position.y > 7f)
        {
            
        }*/
    }
    private void OnTriggerEnter(Collider coll)
    {
        
        if (coll.gameObject.tag == "Player")
        {
            SecondSlideDoor(true);
            elevatorSound.Stop();

        }
        if (coll.gameObject.tag == "Player")
        {
            ElevatorSlides(2.4f);
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
        ElevatorIsMove = true;
        elevatorSound.Play();
        SecondSlideDoor(true);
        if (Elevator.transform.position.y > 7f)
        {
            ElevatorSlides(0.7f);
        }

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

    public void ElevatorSlides(float state)
    {
        ElevatorAnim.SetFloat("ElevatorSlider", state);
    }
    
}
