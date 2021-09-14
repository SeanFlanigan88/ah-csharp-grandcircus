using System;

namespace review_lab13
{
    public enum RPS
    {
        rock,
        paper,
        scissors
    }

    public class RPSApp
    {
        public int wins = 0;
        public int losses = 0;
        public int draw = 0;

        public void Start()
        {
            var human = PromptForUserName();

            do
            {
                Update(human);

                Console.WriteLine("Would you like to play again? [yes(y), no(n)]");
                var input = Console.ReadLine().ToLower();

                if (input == "no" || input == "n")
                {
                    break;
                }
            }
            while(true);
        }

        public void Update(HumanPlayer humanPlayer)
        {
            Console.WriteLine($"Wins: {wins} Losses: {losses} Draws: {draw}");

            try
            {
                Player opponent = SelectOpponent();
                Console.WriteLine($"You selected: {opponent.Name}");

                PromptUserForTurn(humanPlayer);
                
                Compare(humanPlayer, opponent);
            }
            catch(NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public HumanPlayer PromptForUserName()
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            return new HumanPlayer(name);
        }

        public void PromptUserForTurn(HumanPlayer player)
        {
            Console.WriteLine($"What would you like to play? [rock(r), paper(p), or scissors(s)]");
            var input = Console.ReadLine();
            var play = RPS.rock;
            
            switch (input)
            {
                case "rock": 
                case "r": play = RPS.rock; break;
                case "paper": 
                case "p": play = RPS.paper; break;
                case "scissors": 
                case "s": play = RPS.scissors; break;
                default:
                    throw new NotSupportedException($"'{input}' is not a valid move");
            }

            player.SetPlay(play);
        }

        public Player SelectOpponent()
        {
            Console.WriteLine($"Would you like to play Sheldon(S) or Lenard(L)?");
            var opponent = Console.ReadLine().ToLower();
            switch (opponent)
            {
                case "sheldon": 
                case "s": return new RockPlayer("sheldon");
                case "lenard": 
                case "l": return new RandomPlayer("lenard");
                default:
                    throw new ApplicationException($"There is no opponent named '{opponent}'");
            }
        }

        public void Compare(Player one, Player two)
        {
            var oneValue = one.GenerateRPS();
            var twoValue = two.GenerateRPS();

            Console.WriteLine($"{one.Name}: {oneValue}");
            Console.WriteLine($"{two.Name}: {twoValue}");

            if (oneValue == twoValue)
            {
                Console.WriteLine($"Game is a draw.");
                draw++;

            }
            else if ((oneValue == RPS.paper && twoValue == RPS.rock) || (oneValue == RPS.rock && twoValue == RPS.scissors) || (oneValue == RPS.scissors && twoValue == RPS.paper))
            {
                Console.WriteLine($"Player '{one.Name}' wins");
                wins++;
            }
            else 
            {
                Console.WriteLine($"Player '{two.Name}' wins");
                losses++;
            }
        }
    }

    public abstract class Player
    {
        public string Name { get; set; }

        public abstract RPS GenerateRPS();
    }

    public interface IPlayer
    {
        string Name { get; set; }

        RPS GenerateRPS();
    }

    public class RockPlayer: Player
    {
        public RockPlayer(string name)
        {
            this.Name = name;
        }

        public override RPS GenerateRPS()
        {
            return RPS.rock;
        }
    }

    public class RandomPlayer: Player
    {
        public RandomPlayer(string name)
        {
            this.Name = name;
        }

        public override RPS GenerateRPS()
        {
            var rand = new Random();
            return (RPS)rand.Next(0, 2);
        }
    }

    public class HumanPlayer: Player
    {
        private RPS _play { get; set; }

        public HumanPlayer(string name)
        {
            this.Name = name;
        }

        public void SetPlay(RPS play)
        {
            this._play = play;
        }

        public override RPS GenerateRPS()
        {
            return _play;
        }
    }


}