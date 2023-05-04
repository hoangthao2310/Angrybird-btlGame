using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Vector3 InitialPos;
    public float springRange;
    public int scene;

    private void Start()
    {
        InitialPos = transform.position;
    }
    private void OnMouseDrag()
    {    
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        float distance = (InitialPos - mousePos).magnitude;
        if(distance < springRange)
        {
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
        
    }

    private void OnMouseUp()
    {
        Vector3 vectorForce = InitialPos - transform.position;
        GetComponent<Rigidbody2D>().AddForce(vectorForce * 250);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(scene);
        score.diem = 0;
    }
    public void NextGame()
    {
        SceneManager.LoadScene(scene+1);
        score.diem = 0;
    }

}
