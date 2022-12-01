public class RangedFighter : Enemy
{
    // Fields
    public int DistanceTracking;
    
    // Constructors
    public RangedFighter(string n) : base(n, 110)
    {
        DistanceTracking = 5;
        AttackList.Add(new Attack($"{name} shoots an arrow for 20 damage!", 20));
        AttackList.Add(new Attack($"{name} throws a knife for 15 damage!", 15));
    }
    
    // Methods
    public override Attack? RandomAttack()
    {
        if(DistanceTracking < 10)
        {
            System.Console.WriteLine($"{name} is too close to the enemy!");
            return null;
        }
        else {
            return base.RandomAttack();
        }
    }

    public void Dash()
    {
        DistanceTracking = 20;
        System.Console.WriteLine($"{name} has performed a Dash and is {DistanceTracking} feet away!");
    }
}