using UnityEngine;

public class IdleState : IState
{
    private StatePatternExample _statePatternExample;
    private StateMachine _stateMachine;
    
    public IdleState(StatePatternExample statePatternExample, StateMachine stateMachine)
    {
        _statePatternExample = statePatternExample;
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("Idle State Enter");
        
        _statePatternExample.WalkButtonPressed += OnWalkButtonPressed;
        _statePatternExample.JumpButtonPressed += OnJumpButtonPressed;
    }

    public void LogicUpdate()
    {
        Debug.Log("Idle State LogicUpdate");
    }

    public void PhysicsUpdate()
    {
        Debug.Log("Idle State PhysicsUpdate");
    }

    public void Exit()
    {
        Debug.Log("Idle State Exit");

        _statePatternExample.WalkButtonPressed -= OnWalkButtonPressed;
        _statePatternExample.JumpButtonPressed -= OnJumpButtonPressed;
    }

    private void OnWalkButtonPressed()
    {
        Debug.Log("IdleState OnWalkButtonPressed");
        
        _stateMachine.ChangeState(_statePatternExample.WalkingState);
    }

    private void OnJumpButtonPressed()
    {
        Debug.Log("IdleState OnJumpButtonPressed");
        
        _stateMachine.ChangeState(_statePatternExample.JumpingState);
    }
}