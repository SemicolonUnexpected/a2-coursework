namespace a2_coursework._Helpers;
public static class GeneralHelpers {
    public static int LevenshteinDistance(string a, string b) {
        // Two work arrays
        int[] rowOne = new int[b.Length + 1];
        int[] rowTwo = new int[b.Length + 1];

        // If a or b in empty return the length
        if (a == "") return b.Length;
        if (b == "") return a.Length;

        for (int i = 0; i <= b.Length; i++) rowOne[i] = i;

        for (int i = 0; i <= a.Length - 1; i++) {
            rowOne[0] = i + 1;

            for (int j = 0; j <= b.Length - 1; j++) {
                int deletionCost = rowOne[j + 1] + 1;
                int insertionCost = rowTwo[j] + 1;
                int substitutionCost;

                if (a[i] == b[j]) {
                    substitutionCost = rowOne[j];
                }
                else {
                    substitutionCost = rowOne[j] + 1;
                }

                rowTwo[j + 1] = Math.Min(deletionCost, Math.Min(insertionCost, substitutionCost));
            }

            (rowOne, rowTwo) = (rowTwo, rowOne);
        }

        return rowOne[b.Length];
    }

    /// <summary>
    /// Checks if string b is a substring of string a with a tolerance for errors
    /// Returns the minimum Levenshtein distance found when sliding the shorter string across the longer one
    /// </summary>
    public static int SubstringLevenshteinDistance(string a, string b) {
        // Ensure b is the shorter string
        if (a.Length < b.Length) {
            (a, b) = (b, a);
        }

        if (b.Length == 0) return 0;

        int minDistance = int.MaxValue;

        // Slide the shorter string across the longer string
        for (int i = 0; i <= a.Length - b.Length; i++) {
            string subA = a.Substring(i, b.Length);
            int distance = LevenshteinDistance(subA, b);
            minDistance = Math.Min(minDistance, distance);

            // Early exit if exact match found
            if (minDistance == 0)
                break;
        }

        return minDistance;
    }
}
