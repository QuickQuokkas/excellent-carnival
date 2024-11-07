using UnityEngine;
using System.Collections;

public class Circular8direction : MonoBehaviour {
    public float speed = 5f;
    private Vector2 movement;


    // Use this for initialization
    void Start () {

    }
   
    // Update is called once per frame
    void FixedUpdate () {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(inputX, inputY);

        //Diagonals

        if (inputX != 0 && inputY != 0) {
            if (movement.y == 1 && movement.x == -1)
            {
                Debug.Log ("move_up_left");
            }

            if (movement.y == 1 && movement.x == 1)
            {
                Debug.Log ("move_up_right");
            }

            if (movement.y == -1 && movement.x == -1)
            {
                Debug.Log ("move_down_left");
            }

            if (movement.y == -1 && movement.x == 1)
            {
                Debug.Log ("move_down_right");
            }
        }

        else
        {

            //left/right/up/down
            if (movement.x == -1)
            {
                //Moving Left
                Debug.Log ("Left");
            }

            if (movement.x == 1)
            {
                //Moving Right
                Debug.Log ("Right");
            }

            if (movement.y == 1)
            {
                //Moving Up
                Debug.Log ("Up");
            }
            if (movement.y == -1)
            {
                //Moving Down
                Debug.Log ("Down");
            }
        }




        transform.Translate(movement * speed * Time.deltaTime);
    }

   
}