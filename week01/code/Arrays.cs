public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Plan:
        // 1. Create a new double array with the same size as length.
        // 2. Use a for loop to visit each index in the array.
        // 3. Since array indexes start at 0, use i + 1 to calculate the correct multiple.
        // 4. Store number * (i + 1) in the current index.
        // 5. Return the completed array.

        double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = number * (i + 1);
            }

            return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Plan:
        // 1. Create a temporary list to store the rotated values.
        // 2. Loop through each position in the original list.
        // 3. For each new position, calculate which old index should provide the value.
        // 4. Use (i + data.Count - amount) % data.Count so the index wraps around to the beginning when needed.
        // 5. Add each selected value to the temporary result list.
        // 6. Clear the original list because the method must modify the existing list.
        // 7. Add all values from the temporary list back into the original list.

        List<int> result = new List<int>();

        for (int i = 0; i < data.Count; i++)
        {
            result.Add(data[(i + data.Count - amount) % data.Count]);
        }

        data.Clear();
        data.AddRange(result);
    }
}
