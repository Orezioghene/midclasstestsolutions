namespace midclasstestsoln.Models
{
    public class Wine_models
    {
        public string Name { get; set; }
        public int Collection_year { get; set; }
        public Wine_type_definition Wine_Type { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Collection_location { get; set; }
    }

    public enum Wine_type_definition
    {
        alcoholic=0,

        Non_alcoholic=1

    }
}
