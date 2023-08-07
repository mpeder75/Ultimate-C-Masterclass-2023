/* ----- Nested loops ---- */

// Her gang det ydre loop valideres til true, køres det inderste loop
for (int i = 0; i < 4; i++) {

    for (int j = 0; j < 3; j++) {
        Console.WriteLine($"i is {i}, j is {j}");
    }
}