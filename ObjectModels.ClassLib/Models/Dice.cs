namespace ObjectModels.ClassLib.Models{
    public class Dice{
        public int CurrentSide { get; set; }
        public readonly int[] Sides = {1,2,3,4,5,6,7,8,9};
    }
}