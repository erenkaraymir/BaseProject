using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimHash
{
    public static readonly int Walk = Animator.StringToHash("Walk");
    public static readonly int Idle = Animator.StringToHash("Idle");
    public static readonly int Run = Animator.StringToHash("Run");
    public static readonly int Jump = Animator.StringToHash("Jump");
    public static readonly int Attack = Animator.StringToHash("Attack");

}
