using System;
using UnityEngine;

public class StatePatternExample : MonoBehaviour
{
    private StateMachine _stateMachine;
    
    private IState _idleState;
    private IState _walkingState;
    private IState _jumpingState;
    
    public IState IdleState => _idleState;
    public IState WalkingState => _walkingState;
    public IState JumpingState => _jumpingState;
    
    public event Action IdleButtonPressed;
    public event Action WalkButtonPressed;
    public event Action JumpButtonPressed;
    
    private void Start()
    {
        _stateMachine = new StateMachine();

        _idleState = new IdleState(this, _stateMachine);
        _walkingState = new WalkingState(this, _stateMachine);
        _jumpingState = new JumpingState(this, _stateMachine);
        
        _stateMachine.Initialize(_idleState);
    }
    
    private void Update()
    {
        _stateMachine.CurrentState.LogicUpdate();
    }

    private void FixedUpdate()
    {
        _stateMachine.CurrentState.PhysicsUpdate();
    }

    public void PressIdleButton()
    {
        IdleButtonPressed?.Invoke();
    }

    public void PressWalkButton()
    {
        WalkButtonPressed?.Invoke();
    }

    public void PressJumpButton()
    {
        JumpButtonPressed?.Invoke();
    }
}
