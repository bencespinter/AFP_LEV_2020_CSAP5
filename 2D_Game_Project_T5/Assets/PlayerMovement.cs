﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public int coincount = 0;
    public Animator animator;
    public float runSpeed = 30f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public Text myText;

    public Image[] _hearts;
    public int lifeLeft;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            _hearts[i].gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        myText = GameObject.Find("CollectedGems").GetComponent<Text>();
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coincount++;
            myText.text = "Gems : " + coincount;
        }
        else if (other.gameObject.CompareTag("Respawn") || other.gameObject.CompareTag("Enemy"))
        {
           
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            coincount = 0;
            LifeLost();
        }
    }
    public void LifeLost()
    {
        _hearts[lifeLeft].gameObject.SetActive(false);
        lifeLeft--;
    }
}
