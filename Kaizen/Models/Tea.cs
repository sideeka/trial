namespace Kaizen.Models
{
    public class Tea
    {
        public int TeaId { get; set; }
        public string TeaName { get; set;}
        public string TeaDescription { get; set;}

        public decimal Price { get; set;}
        public int Tea_Stock { get; set;}
        public string pic { get; set; }

        public int Seasonid { get; set;}
        public Season Season { get; set;}
    }// end 
}
