namespace Orders.Shared.DTOs;

public class PaginationDTO // DTO (Data Transformation Order)
{
    public int Id { get; set; }
    public int Page { get; set; } = 1; // default value
    public int RecordsNumber { get; set; } = 10; // Amount of elements by page (default  value)
}