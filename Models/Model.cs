namespace vega.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Each model is associated with a make
        public Make Make { get; set; }

        public int MakeId { get; set; }
    }
}