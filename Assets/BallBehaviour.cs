using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehaviour : MonoBehaviour
{
    public float impulseFactor;
    public float forceFactor;
    Vector3 BallStartPos;
    // Start is called before the first frame update
    void Start()
    {
        BallStartPos = GameObject.FindGameObjectWithTag("Ball").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
            return;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
            return;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
            return;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ResetBall();
            return;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            LoadScene();
            return;
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Scene1");
    }

    void ThrowBall()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * forceFactor);
    }

    void MoveRight()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right * impulseFactor, ForceMode.Impulse);
    }

    void MoveLeft()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left * impulseFactor, ForceMode.Impulse);
    }

    void ResetBall()
    {
        this.gameObject.GetComponent<Rigidbody>().position = BallStartPos;
        this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }
}


