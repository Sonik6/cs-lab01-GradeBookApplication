namespace GradeBook.GradeBooks;

public class RankedGradeBooks : BaseGradeBook {
  public RankedGradeBooks(string name) : base(name) {
    Type = Enums.GradeBookType.Ranked;
  }
}