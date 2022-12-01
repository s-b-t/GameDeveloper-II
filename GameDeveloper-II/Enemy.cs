public class Enemy
{
    // Descriptive Fields
    public string name;
    public int hlthAmt;
    public List<Attack> AttackList;

    // Constructors
    public Enemy(string n, int h)
    {
        name = n;
        hlthAmt = h;
        AttackList = new List<Attack>();
    }

    // Methods
    public virtual Attack? RandomAttack()
    {
        Random rand = new Random();
        int attackIdx = rand.Next(0, AttackList.Count);
        System.Console.WriteLine($"{AttackList[attackIdx].name} ");
        return AttackList[attackIdx];
    }
}