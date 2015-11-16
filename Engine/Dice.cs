namespace Engine

  class Dice
  {
    private int sides;
    public Dice(int sides) {
        this.sides = sides;
    }
  //constructor tanpa parameter
    public Dice() {
        this.sides=6;
    }
    // random dari 1-6
    public int rollDice(){
        Random r=new Random();
        int dices = rnd.Next(1, 7);
        return dices;
  }
}
