using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{

    public static CanvasController _instance_;
    public Text health_label;//SET IN EDITOR


    //CubeFun player_cube; // I wont even use a reference to the player

    private void Awake()
    {
        _instance_ = this;

        //quick note on singletons. Some people online will detect if it exists and then delete it if an extra copy is there.
        //THIS is one reason NEVER to use DontDestroyOnLoad



        /* instead of doing this,
                player_cube = GameObject.FindGameObjectWithTag("Player").GetComponent<CubeFun>();
                player_cube = FindObjectOfType<CubeFun>();
        */

    }


    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);


            //set player health label
            health_label.text = PlayerPrefs.GetInt("Health", -1).ToString();//-1 is default value
        }
    }


}
