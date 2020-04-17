using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // 'sortingOrder' and 'SpriteRenderer sprite' are used for sorting orders + other sprite-based manipulations.
    public SpriteRenderer sprite;
    public int sortingOrder = 0;

    // Need to define what a 'player' is in the script (this acts as an input in the 'Inspector' when clicking on objects).
    public static GameObject player;
    float walkSpeed = 10.0f;
    float jumpSpeed = 25.0f;

    // Makes falling smoother - no jittering violently in the air.
    Rigidbody2D rb;

    // These variables are for a smooth falling.
    bool debounce = false;

    // Start is called before the first frame update
    void Start()
    {
        // States sprite is the equivalent to the sprite rendered to the object this script is attached to.
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            MovePlayer("up");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MovePlayer("down");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MovePlayer("left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MovePlayer("right");
        }

    }

    string MovePlayer(string InputDirection)
    {
        switch (InputDirection)
        {
            case ("up"): // Checks if input is 'up arrow' which is renamed 'Jump'.
                if (transform.position.y < 12)
                {
                    transform.position = transform.position + Vector3.up * jumpSpeed * Time.deltaTime;
                }
                else
                {
                    break;
                }
                break;


            case ("down"): // Checks if input is 'down'.
                if (transform.position.y > -7)
                {
                    transform.position = transform.position + Vector3.down * Time.deltaTime;
                }
                else
                {
                    break;
                }
                break;

            case ("left"): // Checks if input is 'left'.
                if (transform.position.x > -17.5)
                {
                    transform.position = transform.position + Vector3.left * walkSpeed * Time.deltaTime;
                    sprite.flipX = true;
                }
                else
                {
                    break;
                }
                break;

            case("right"): // Checks if input is 'right'.
                if (transform.position.x < 17.5)
                {
                    transform.position = transform.position + Vector3.right * walkSpeed * Time.deltaTime;
                    sprite.flipX = false;
                }
                else
                {
                    break;
                }
                break;

            default:
                print("NO INPUT");
                break;
        }

        return InputDirection;
    }
}

