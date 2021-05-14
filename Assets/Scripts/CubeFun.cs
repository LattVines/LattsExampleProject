using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFun : MonoBehaviour
{

    public AudioClip sfx_SoundEffect;//SET IN EDITOR

    Collider my_col;

    public int health = 100;


    Animator animator;

    private void Awake()
    {
        //gets called first.

        //I always assign references to components in awake
        my_col = GetComponent<Collider>();


        PlayerPrefs.SetInt("Health", health);
    }

    private void OnEnable()
    {
        //rarely used, but I find this one very useful for unity canvas UI objects, so that
        //when they are actived or deactivated, they can always reset whatever they need to reset one they are reactivated.

        //but be careful, because if you overly rely on OnEnable, you will hit null pointers, because it gets called After Awake, and before Update. and Before Start.
        //and this also means, if you're referencing other objects in the scene, when this OnEnable is called, those other objects haven't run Start yet, potentially.
    }



    //Start can be a IEnumerator
    IEnumerator Start()
    {
        //it is right before the first update is called on the object
        InvokeRepeating("PrintAMessage", 1f, 0.5f);

        //StartCoroutine(MyCorouting());

        yield return null;

        while (true)
        {
            //print("hello");
            yield return new WaitForSeconds(1f);
        }

    }

    public void PrintAMessage()
    {
        //print("Hi There");
    }


    IEnumerator MyCorouting()
    {
        yield return null;

        while (true)
        {
            print("hello");
            yield return new WaitForSeconds(0.5f);
        }
    }





    private void FixedUpdate()
    {
        //this gets called specifically every step of the Physics engine
        //if you have a RigidBody on your object, this gets called


        animator.SetFloat("Velocity_X", GetComponent<Rigidbody>().velocity.x);
        animator.SetFloat("Velocity_Y", GetComponent<Rigidbody>().velocity.y);
    }


    private void Update()
    {
        //happens REALLY fast, every frame
        //be careful about putting things here.


        //THIS IS WHERE YOU SHOULD DETECT USER INPUTS
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 5 * Time.deltaTime, this.transform.position.z);

        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 5 * Time.deltaTime, this.transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(this.transform.position.x - 5 * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(this.transform.position.x + 5 * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
    }



    private void LateUpdate()
    {
        //gets called after all other Updates

        //I use LateUpdate for smooth Camera following scripts
    }



    private void OnDestroy()
    {
        //rarely needed
    }


    private void OnDisable()
    {
        //similar

    }


    private void OnBecameVisible()
    {
        //not as useful as it sounds, because of how culling works. But sometimes you can use it
    }


    private void OnBecameInvisible()
    {
        //not as useful as it sounds, because of how culling works. But sometimes you can use it
    }




    //OTHER USEFUL ONE FOR PHYSICS STUFF
    public LayerMask what_i_can_hit;
    private void OnCollisionEnter(Collision other)
    {
        print("I collided with" + other.gameObject.name);

        health -= 1;
        SFXController.PlayClip(sfx_SoundEffect);

        PlayerPrefs.SetInt("Health", health);

        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SendMessage("Damage", 3);
        }

        //other approach
        //other.gameObject.GetComponent<SecondCube>().Damage(3);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

    }


    private void OnCollisionStay(Collision other)
    {

    }

    private void OnCollisionStay2D(Collision2D other)
    {

    }


    private void OnCollisionExit(Collision other)
    {

    }

    private void OnCollisionExit2D(Collision2D other)
    {

    }


    //these are really useful

    private void OnMouseDown()
    {
        print("onMouseDown");
    }

    private void OnMouseDrag()
    {
        print("OnMouseDrag");
    }


    private void OnMouseExit()
    {
        print("OnMouseExit");
    }

    private void OnMouseOver()
    {
        print("OnMouseOver");
    }

    private void OnMouseUp()
    {
        print("OnMouseUp");
    }

    private void OnMouseUpAsButton()
    {
        print("OnMouseUpAsButton");
    }


}
