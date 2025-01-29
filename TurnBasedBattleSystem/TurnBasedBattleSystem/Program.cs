
int playerHp=100;
int enemyHp=75;
int maxPlayerHp = 100;
int maxEnemyHp = 75;
int minPlayerHp = 0;
int minEnemyHp = 0;

Random random = new Random();

int playerHeal = 25;
int enemyHeal = 15;


Console.WriteLine($"Welcome to the Turn based battle game \n Player HP : {playerHp} \n EnemyHp : {enemyHp}");
Console.WriteLine("How many turns you want to play?");
int turns = Convert.ToInt32(Console.ReadLine());
int i=0;
while (i <= turns && playerHp > 0 && enemyHp > 0) 
{ Console.WriteLine("Its your turn what will you do? \n" +
    "Choose options:\n" +
    "Attack-a\n" +
    "Heal-h");
    int playerAttack = random.Next(20, 30);
    int enemyAttack = random.Next(40, 50);
    string playerChoice = Console.ReadLine();

    if (playerChoice == "a")
    {
        Console.WriteLine("You choose to attack");
        enemyHp = Math.Max(enemyHp - playerAttack, 0);
        Console.WriteLine($"You did{playerAttack} damage \n Enemy Hp : {enemyHp}");
    }
    else if (playerChoice == "h")
    {
        playerHp = Math.Min(playerHp + playerHeal, maxPlayerHp);
        Console.WriteLine($"You healed {playerHeal} \n Your health : {playerHp}");
    }
    if (enemyHp <= 0) break;
    int enemyChoice=random.Next(1,2);
    if (enemyChoice == 1)
    {
        Console.WriteLine("Enemy choose to attack");
        playerHp = Math.Max(playerHp - enemyAttack, 0);
        Console.WriteLine($"Enemy did{enemyAttack} damage \n Your Hp : {playerHp}");
    }
    else if (enemyChoice == 2)
    {
        enemyHp = Math.Min(enemyHp + enemyHeal, maxEnemyHp);
        Console.WriteLine($"Enemy healed {enemyHeal} \n Enemy health : {enemyHp}");
    }
    i++;
 
    }
if (playerHp > enemyHp)
{
    Console.WriteLine("You Won");
}
else if (playerHp == enemyHp) { Console.WriteLine("Draw"); }
else
{
    Console.WriteLine("Enemy Won");
}
Console.ReadLine();