namespace BATCH1_DET_2022
{
    internal class ScienceStudent : Student
    {
        public int physics { get; set; }
        public int chemistry { get; set; }

        public int maths { get; set; }

        public override double GetAvgMarks()
        {
            return (physics + chemistry + maths) / 3;
        }
    }
}
