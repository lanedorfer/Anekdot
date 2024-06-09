using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFire : Trap
{
    private Animator _animator;
    private bool _isWorking;
    [SerializeField] private float _cooldown;
    private float _cooldownTimer;
    

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _cooldownTimer -= Time.deltaTime;
        if (_cooldownTimer < 0)
        {
            _isWorking = !_isWorking;
            _cooldownTimer = _cooldown;
            
            _animator.SetBool("isWorking", _isWorking);
        }
    }
    protected override void OnTriggerEnter2D(Collider2D colission)
    {
        if (_isWorking)
        {
            base.OnTriggerEnter2D(colission);
        }
    }
}
