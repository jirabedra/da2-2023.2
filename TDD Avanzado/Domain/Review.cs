namespace Domain
{
    public class Review
    {
        private double _rating;
        public Movie Movie { get; set; }
        public double Rating
        {
            get => _rating;
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Rating must be a number between 0 and 5.");
                }
                else
                {
                    _rating = value;
                }
            }
        }
    }
}