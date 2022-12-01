// Enemy StormTrooper = new Enemy("Bobby", 120);

// Attack PlasmaRifle = new Attack("Plasma Rifle", 20);
// Attack LightSaber = new Attack("Light Saber", 15);
// Attack RoundhouseKick = new Attack("Roundhouse Kick", 10);

// StormTrooper.AttackList.Add(PlasmaRifle);
// StormTrooper.AttackList.Add(LightSaber);
// StormTrooper.AttackList.Add(RoundhouseKick);

// StormTrooper.RandomAttack();

MeleeFighter MF = new MeleeFighter("Blazin' Bob");
RangedFighter RF = new RangedFighter("Sniper Steve");
MagicCaster MC = new MagicCaster("Magical Mike");

MF.RandomAttack();
MF.RageAttack();
RF.RandomAttack();
RF.Dash();
RF.RandomAttack();
MC.RandomAttack();
MC.Heal(RF);
MC.Heal(MC);


