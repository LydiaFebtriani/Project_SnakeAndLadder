namespace Engine
{
  ///<summary>
  ///kelas controller.
  /// yang menjalankan semua proses yang diperlukan untuk menjalankan game ini.
  ///</summary>
  class Game{
    
    ///<summary>
    /// Atribut yang menyimpan board.
    ///</summary>
    private Board papan ;
    
    ///<summary>
    /// Atribut yang menyimpan banyak player yang ada didalam game.
    ///</summary>
    private Player[] players ;
    
    ///<summary>
    /// Atribut yang menyimpan object player yang menang.
    ///</summary>
    private Player winner;
    
    ///<summary>
    /// Atribut yang menyimpan object Dice.
    ///</summary>
    private Dice dice;
    
    ///<summary>
    /// Atribut yang menyimpan int banyak player.
    ///</summary>
    private int totalPlayer;
    
    ///<summary>
    /// Konstruktor.
    ///</summary>
    public Game(Board b, Player[] pemain, Dice d){
      this.dice = d;
      this.papan = b;
      this.players = pemain;
      this.winner = null;
      this.totalPlayer = pemain.length;
    }
    
    ///<summary>
    /// Method untuk menjalankan permainan ular tangga.
    ///</summary>
    public void runTheGame(){
      int turn = 0;
      boolean pemenang=false;
      while(pemenang==false){
        
        //suruh player gerak dengan mengocok dadu
        //dan mentukan posisi barunya.
        players[turn].move(this.dice);
        int pos = players[turn].getPosition();
        
        //apakah player pada posisi tersebut
        //menemukan tangga atau ular.
        int newPos = papan.getIntoTile();
        players[turn].setPosition(newPos);
        
         //setiap pergerakan player,
         //lakukan pengecekan apakah dia sudah mencapai finish
         pemenang=players[turn].isWin();
         if(pemenang){
          setWinner(players[turn]);
         }
        
        //giliran player lain.
        turn=turn+1;
        //setelah semua telah mendapat giliran bermain,
        //dikembalikan ke giliran pertama.
        if(turn==this.totalPlayer){
          turn = 0;
        }
        
      }
    }
    
    ///<summary>
    /// Method untuk menentukan pemenang.
    ///</summary>
    public void setWinner(Player p){
      this.winner = p;
    }
    
    ///<summary>
    ///Mengembalikan informasi nama pemenang.
    ///</summary>
    public String getWinnerInformation(){
      return this.winner.getName();
    }
  }
  
}
