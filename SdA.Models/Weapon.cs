namespace SdA.Models
{
    public class Weapon(string label, int cost)
    {
        #region Properties
        public string Label { get; set; } = label;

        public int Cost { get; init; } = cost;

        //private int costF;
        //public int Cost
        //{
        //    get;
        //    //{
        //    //    return this.costF;
        //    //}
        //    set;
        //    //{
        //    //    this.costF = value;
        //    //}
        //}
        #endregion
    }
}
