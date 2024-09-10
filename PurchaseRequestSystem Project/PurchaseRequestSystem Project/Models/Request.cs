namespace PurchaseRequestSystem_Project.Models
{
    internal class Request
    {
        public int Id { get; set; }
        public User UserId { get; set; }
        public string RequestNumber { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public DateOnly DateNeeded { get; set; }
        public string DeliveryMode { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string ReasonForRejection { get; set; }


        // constructor
        public Request(int id, User userId, string reqNum, string desc, string justification, DateOnly dateNeeded, string deliveryMode, string status, decimal total, DateTime summittedDate, string reasonForRejection)
        {
            this.Id = id;
            this.UserId = userId;
            this.RequestNumber = reqNum;
            this.Description = desc;
            this.Justification = justification;
            this.DateNeeded = dateNeeded;
            this.DeliveryMode = deliveryMode;
            this.Status = status;
            this.Total = total;
            this.SubmittedDate = summittedDate;
            this.ReasonForRejection = reasonForRejection;
        }

        public override string ToString()
        {
            return $"{Id},{UserId}, {RequestNumber}, {Description}, {Justification}, {DateNeeded}, {DeliveryMode}, {Status}, {Total}, {SubmittedDate}, {ReasonForRejection}";
        }

    }


}
