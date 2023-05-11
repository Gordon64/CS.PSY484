using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(RotateDoor1());
        }
        */
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DoorCollider1")
        {
            StartCoroutine(RotateDoor1());
        }
        else if (other.gameObject.tag == "DoorCollider2")
        {
            StartCoroutine(RotateDoor2());
        }
        else if (other.gameObject.tag == "DoorCollider3")
        {
            StartCoroutine(RotateDoor3());
        }
    }

    public IEnumerator RotateDoor1()
    {
        for (float i = -90f; i <= 0f; i += 1)
        {
            door1.transform.rotation = Quaternion.Euler(-90f, i, 0f);
            yield return new WaitForSeconds(0f);
        }
    }

    public IEnumerator RotateDoor2()
    {
        for (float i = -90f; i <= 0f; i += 1)
        {
            door2.transform.rotation = Quaternion.Euler(-90f, i, 0f);
            yield return new WaitForSeconds(0f);
        }
    }

    public IEnumerator RotateDoor3()
    {
        for (float i = -90f; i <= 0f; i += 1)
        {
            door3.transform.rotation = Quaternion.Euler(-90f, i, 0f);
            yield return new WaitForSeconds(0f);
        }
    }
}
