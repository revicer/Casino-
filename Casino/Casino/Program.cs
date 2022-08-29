using Casino;

GameProcess game = new GameProcess();
CasinoPlayer firstPlayer = new CasinoPlayer();
CasinoPlayer secondPlayer = new CasinoPlayer();
CasinoPlayer[] arrayPlayers = new CasinoPlayer[] { firstPlayer,  secondPlayer };
game.StartGame(arrayPlayers);
