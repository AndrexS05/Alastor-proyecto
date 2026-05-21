public abstract class EstadoEnemigo
{
    protected AIEnemigo enemigo;

    public EstadoEnemigo(AIEnemigo enemigo)
    {
        this.enemigo= enemigo;
    }
    
    public virtual void Enter()
    {

    }
    public virtual void Update()
    {

    }
    public virtual void Exit()
    {
        
    }
}