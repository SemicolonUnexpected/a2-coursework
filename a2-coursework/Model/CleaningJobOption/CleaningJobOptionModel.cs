namespace a2_coursework.Model.CleaningJobOption; 
public class CleaningJobOptionModel(int id, string name, string description, decimal unitCost, bool archived) {
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public decimal UnitCost { get; set; } = unitCost;
    public bool Archived { get; set; } = archived;
    public int Quantity { get; set; }
    public decimal? CostAtTime { get; set; }
}
