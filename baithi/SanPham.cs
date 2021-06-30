namespace baithi
{
    public class SanPham
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id}\t\t{Name}\t\t{Price}";
        }
    }
}