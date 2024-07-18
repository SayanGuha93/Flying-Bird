using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public Logicscript logic;
    public bool birdisAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdisAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisAlive = false;
    }
}
