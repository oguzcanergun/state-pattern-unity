using UnityEngine;

public class WalkingState : IState
{
    private StatePatternExample _statePatternExample;
    private StateMachine _stateMachine;
    
    public WalkingState(StatePatternExample statePatternExample, StateMachine stateMachine)
    {
        _statePatternExample = statePatternExample;
        _stateMachine = stateMachine;
    }
    
    public void Enter()
    {
        Debug.Log("Walking State Enter");

        _statePatternExample.IdleButtonPressed += OnIdleButtonPressed;
        _statePatternExample.JumpButtonPressed += OnJumpButtonPressed;
    }

    public void LogicUpdate()
    {
        Debug.Log("Walking State LogicUpdate");
    }

    public void PhysicsUpdate()
    {
        Debug.Log("Walking State PhysicsUpdate");
    }

    public void Exit()
    {
        Debug.Log("Walking State Exit");

        _statePatternExample.IdleButtonPressed -= OnIdleButtonPressed;
        _statePatternExample.JumpButtonPressed -= OnJumpButtonPressed;
    }

    private void OnIdleButtonPressed()
    {
        Debug.Log("Walking State OnIdleButtonPressed");
        
        _stateMachine.ChangeState(_statePatternExample.IdleState);
    }

    private void OnJumpButtonPressed()
    {
        Debug.Log("Walking State OnJumpButtonPressed");
        
        _stateMachine.ChangeState(_statePatternExample.JumpingState);
    }
}
