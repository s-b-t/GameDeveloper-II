public class MagicCaster : Enemy
{
    public MagicCaster(string n) : base(n, 80)
    {
        AttackList.Add(new Attack($"{name} unleashes a Fireball for 25 damage!", 25));
        AttackList.Add(new Attack($"{name} blocks with Shield!", 0));
        AttackList.Add(new Attack($"{name} unleashes a Staff Strike for 15 damage!", 15));
    }

    public void Heal(Enemy Target)
    {
        Target.hlthAmt += 40;
        Console.WriteLine($"{name} heals {Target.name} and {Target.name}'s health is now {Target.hlthAmt}!");
    }
}