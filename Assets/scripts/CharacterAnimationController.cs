using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    Animator animator;

    bool sad = false;
    bool happy = false;
    bool dance = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            sad = !sad;
            happy = false;
            dance = false;

            animator.SetBool("sad", sad);
            animator.SetBool("happy", false);
            animator.SetBool("dance", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            happy = !happy;
            sad = false;
            dance = false;

            animator.SetBool("happy", happy);
            animator.SetBool("sad", false);
            animator.SetBool("dance", false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            dance = !dance;
            sad = false;
            happy = false;

            animator.SetBool("dance", dance);
            animator.SetBool("sad", false);
            animator.SetBool("happy", false);
        }
    }
}