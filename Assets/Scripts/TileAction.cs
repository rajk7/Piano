using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TileAction : MonoBehaviour
{
    public SpriteRenderer color;
    public int scoreValue = 1;
    public Rigidbody2D rb;
    public float speed = 500f;
    bool isClicked;
    public AudioClip touchSound;
    int i = 1;

private void Start() {
    isClicked = false;
}
    void Update() {
    rb.velocity = new Vector3(0,-speed * Time.deltaTime,0);
    if(FindObjectOfType<Score>().scoree > i * 10)
        {
            speed +=100f;
            i++;
        }
}
    private void OnMouseOver() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(isClicked == false)
            {
                //AudioSource.PlayClipAtPoint(touchSound, transform.position);
                color.color = Color.yellow;
                FindObjectOfType<Score>().ScoreUpdate(scoreValue);
                isClicked = true;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D cal) 
    {
        if(color.color == Color.yellow)
        {
            Debug.Log("You Are Fine");
        }
        else if (cal.collider.tag == "boder")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Debug.Log("Game has ended");
        }
    }
}
