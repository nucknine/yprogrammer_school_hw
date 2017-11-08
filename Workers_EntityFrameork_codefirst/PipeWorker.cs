namespace Workers_EntityFrameork_codefirst
{
    public class PipeWorker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position;
        public int Salary { get; set; }

        public PipeWorker() { }

        public PipeWorker(string FirstName, string LastName, int Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
        
            Position = "Мастер по прокату труб";
        }

    }
}
