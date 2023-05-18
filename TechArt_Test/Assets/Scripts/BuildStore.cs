using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildStore : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OpenStore()
    {
        _animator.Play("openBuildWindow");
    }

    public void CloseStore()
    {
        _animator.Play("closeBuildWindow");
    }
}
