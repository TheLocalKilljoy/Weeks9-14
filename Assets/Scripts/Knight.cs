using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    SpriteRenderer spr;
    Animator animator;

    public AudioSource audios;

    public AudioClip[] clips;

    public bool canRun = true;

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");

        spr.flipX = (direction < 0);

        animator.SetFloat("movement", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");

            canRun = false;
        }


        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
    }

    public void AttackEnd()
    {
        canRun = true;
    }

    public void Footstep()
    { 
        int randomNum = Random.Range(0, clips.Length);

        audios.PlayOneShot(clips[randomNum]);
    }
}
