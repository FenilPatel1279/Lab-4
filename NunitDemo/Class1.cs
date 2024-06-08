namespace NUnitDemo
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180) // Introduced mutation here
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
