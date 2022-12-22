using CSharpEntityFrameworkPlayers;
using (SchoolContext db = new SchoolContext())
{
    Player Player01 = new Player() { MatchAttended = 8, MatchWon = 8, Name = "Michael", Surname = "Jordan" };
    //Add
    db.Add(Player01);
    
    Console.WriteLine("Michael è stato aggiunto");
    db.SaveChanges();
} 
