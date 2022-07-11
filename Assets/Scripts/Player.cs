using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Animator playerAnimator = null;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }

    void Awake()
    {
        
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float g = Input.GetAxis("Vertical");

        if (h == 0 && g == 0)
        {
            this.GetComponent<Animator>().SetBool("isRun", false);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("isRun", true);
            h = h * moveSpeed * Time.deltaTime;
            g = g * moveSpeed * Time.deltaTime;
            Vector3 vector = new Vector3(h, 0, g);
            this.transform.position += vector;
            if (vector != Vector3.zero)
            {
                transform.forward = vector.normalized;
            }
        }
    }

    private void Attack()
    {
        bool bot = Input.GetButtonDown("Fire1");

        if(bot == true)
        {
            playerAnimator.SetBool("isRun", false);
            playerAnimator.SetBool("isAttack", true);
        }
    }

    public void AndAttackAnimation()
    {
        playerAnimator.SetBool("isAttack", false);
    }
}
