using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Player Components")]
    [SerializeField] private Rigidbody2D rb;
     PlayerInput playerInput;
     InputAction moveAction;

    [Header("Player Variables")]
    [SerializeField] float moveSpeed;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
    }
    public void Update()
    {
        MovePlayer();
    }
    #region Player_Controls
    
    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        rb.position += new Vector2(direction.x, direction.y) * moveSpeed * Time.deltaTime;
    }

    #endregion

}
