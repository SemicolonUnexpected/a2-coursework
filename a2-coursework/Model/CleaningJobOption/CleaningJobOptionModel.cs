namespace a2_coursework.Model.JobOption; 
public class CleaningJobOptionModel(int id, string name, string description, decimal unitCost, bool archived) {
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public decimal UnitCost { get; set; } = unitCost;
    public bool Archived { get; set; } = archived;
}
