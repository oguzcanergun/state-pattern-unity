public class StateMachine
{
    public IState CurrentState;

    public void Initialize(IState initialState)
    {
        CurrentState = initialState;
        CurrentState.Enter();
    }

    public void ChangeState(IState newState)
    {
        CurrentState.Exit();
        
        CurrentState = newState;
        CurrentState.Enter();
    }
}
