namespace Logic.Abstraction
{
    public class Message
    {
        public string Id { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format($"{this.Id}-{this.Value}");
        }
    }
}
