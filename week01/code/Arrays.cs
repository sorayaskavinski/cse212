public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double baseNumber, int count)
    {
        // Step 1: Create an array to store the results.
        //The size of the array is equal to the number of multiples required.
        double[] multiples = new double[count];

        //Step 2: Loop through each index of the array.
        //For each index, calculate the multiple of the base number and store it in the array.
        for(int i=0; i< count; i++)
        {
            //Calculte the i-th multiple as a baseNumber * (i+1)
            multiples[i]= baseNumber * (i + 1);
        }
        //Step 3: Return the array of multiples.
        return multiples; 
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
        // Step 1: Validade inputs.
        //Ensure the list is not null or empty and the amount is withing the valid range.
        if(data == null|| data.Count == 0 || amount < 1 || amount > data.Count)
        {
            return; //Do nothing if inputs are invalid.
        }

        // If the amount equals the size of the list, no need to rotate.
        if (amount % data.Count == 0)
        {
            return;
        }

        //Step 2: Calculate the effective rotation amount.
        int rotation = amount % data.Count;

        //Step 3: Split the list into two parts.
        //Use GetRange to create two sublists: one for the last 'rotation' elements and one for the rest.
        List<int> lastPart = data.GetRange(data.Count - rotation, rotation);
        List<int> firstPart = data.GetRange(0, data.Count - rotation);

        //Step 4: Combine the two parts in rotated order.
        data.Clear(); //Clear the original list.
        data.AddRange(lastPart); // Add the last part first.
        data.AddRange(firstPart); //Add the first part after.
    }
}
