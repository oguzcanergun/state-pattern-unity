using UnityEngine;

public class JumpingState : IState
{
    private StatePatternExample _statePatternExample;
    private StateMachine _stateMachine;
    
    public JumpingState(StatePatternExample statePatternExample, StateMachine stateMachine)
    {
        _statePatternExample = statePatternExample;
        _stateMachine = stateMachine;
    }
    
    public void Enter()
    {
        Debug.Log("JumpingState Enter");

        _statePatternExample.IdleButtonPressed += OnIdleButtonPressed;
        _statePatternExample.WalkButtonPressed += OnWalkButtonPressed;
    }

    public void LogicUpdate()
    {
        Debug.Log("JumpingState LogicUpdate");
    }

    public void PhysicsUpdate()
    {
        Debug.Log("JumpingState PhysicsUpdate");
    }

    public void Exit()
    {
        Debug.Log("JumpingState Exit");

        _statePatternExample.IdleButtonPressed -= OnIdleButtonPressed;
        _statePatternExample.WalkButtonPressed -= OnWalkButtonPressed;
    }

    private void OnIdleButtonPressed()
    {
        Debug.Log("JumpingState OnIdleButtonPressed");
        
        _stateMachine.ChangeState(_statePatternExample.IdleState);
    }

    private void OnWalkButtonPressed()
    {
        Debug.Log("JumpingState OnWalkButtonPressed");
        
        _stateMachine.ChangeState(_statePatternExample.WalkingState);
    }
}
