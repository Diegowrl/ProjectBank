using static ProjectBank.Aplication.Enum.BasicEnum;

namespace ProjectBank.Aplication.Models.Bank
{
    public class TicketModel
    {
        public string operation { get; set; }
        public decimal unitCost { get; set; }
        public int quantity { get; set; }
    }
}
