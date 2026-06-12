namespace FinanceBilling.Application.DTOs.Customer;
public class CreateCustomerDto
{
    public string CustomerCode { get; set; }= string.Empty;
    public string Name { get; set; }= string.Empty;
    public string Email { get; set; }= string.Empty;
    public string Phone { get; set; }= string.Empty;
    public string Address { get; set; } = string.Empty;
}