namespace Practice_MVC_class6.Models
{
    public class PopsciclesOrder
    {
        public string CustomerName { get; set; }
        public int NumPopscicles { get; set; }
        public string IceCreamFlavour { get; set; }
        public decimal PopsciclesCost { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Taxrate { get; set; }
        public decimal HstAmt { get; set; }
        public decimal OrderTotal { get; set; }
    }
}