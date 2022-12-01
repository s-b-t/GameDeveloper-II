public class MeleeFighter : Enemy
{
    public MeleeFighter(string n) : base(n, 120) 
    {
        AttackList.Add(new Attack("Punch", 20));
        AttackList.Add(new Attack("Kick", 15));
        AttackList.Add(new Attack("Tackle", 25));
    }

    // Methods
    public override Attack RandomAttack()
    {
        Random rand = new Random();
        int attackIdx = rand.Next(0, AttackList.Count);
        System.Console.WriteLine($"{name} performs a {AttackList[attackIdx].name}!");
        return AttackList[attackIdx];
    }

    public void RageAttack()
    {
        Attack RageAttack = RandomAttack();
        RageAttack.dmgAmt += 10;
        System.Console.WriteLine($"{name} deals 10 extra damage using Rage {RageAttack.name}!");
    }
}