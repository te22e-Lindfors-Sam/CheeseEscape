using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatJumpScareAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void setAnimation()
    {
        animator.SetBool("Jumpscare", !animator.GetBool("Jumpscare"));
    }
}
