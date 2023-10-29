using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffSet = 0.05f;
    public ContactFilter2D moveFilter;
    // public SpriteRenderer playerSpriteRenderer;
    // private List<Sprite> sprites = new List<Sprite>();

    Vector2 moveInput;
    Rigidbody2D player;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        // MakeSprites();
        // playerSpriteRenderer.sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        // ChangeDirection();
    }
    private void FixedUpdate()
    {
        if (moveInput != Vector2.zero)
        {
            float overload = moveSpeed * Time.fixedDeltaTime + collisionOffSet;
            int collisions = player.Cast(moveInput, moveFilter, castCollisions, overload);

            if (collisions == 0)
            {
                player.MovePosition(player.position + moveInput * moveSpeed * Time.fixedDeltaTime);
            }
        }
    }

    void OnMove(InputValue move)
    {
        moveInput = move.Get<Vector2>();
    }

    // void ChangeDirection()
    // {
    //     if (playerSpriteRenderer != null && moveInput != Vector2.zero)
    //     {
    //         if (moveInput != Vector2.zero)
    //         {
    //             if (moveInput.y > 0)
    //             {
    //                 playerSpriteRenderer.sprite = sprites[1];
    //             }
    //             else if (moveInput.y < 0)
    //             {
    //                 playerSpriteRenderer.sprite = sprites[0];
    //             }
    //             else if (moveInput.x < 0)
    //             {
    //                 playerSpriteRenderer.sprite = sprites[2];
    //             }
    //             else if (moveInput.x > 0)
    //             {
    //                 playerSpriteRenderer.sprite = sprites[2];
    //             }
    //         }
    //         else
    //         {
    //             playerSpriteRenderer.sprite = sprites[0];
    //         }
    //     }
    // }

//     void MakeSprites()
//     {
//         Sprite left = Resources.Load<Sprite>("C:\Users\fairy\OneDrive\Desktop\WalkyWalky\Assets\Pixel Art Top Down - Basic\Texture\pleft.png");
//         Sprite back = Resources.Load<Sprite>("C:\Users\fairy\OneDrive\Desktop\WalkyWalky\Assets\Pixel Art Top Down - Basic\Texture\pback.png");
//         Sprite front = Resources.Load<Sprite>("C:\Users\fairy\OneDrive\Desktop\WalkyWalky\Assets\Pixel Art Top Down - Basic\Texture\pfront.png");
//         Sprite right = Resources.Load<Sprite>("Assets/Pixel Art Top Down - Basic/Texture/pright.png");
//         sprites.Add(front);
//         sprites.Add(back);
//         sprites.Add(left);
//     }
}