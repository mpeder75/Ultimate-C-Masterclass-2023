/*
Implement the FindMax method, which given a two-dimensional array of integers,
returns the maximal value from this array.

If any of the array's dimensions is zero, it means the array is empty,
and the method should return -1.

For example:
for an empty array of size [0,3] the result should be -1
for an array like this, the result should be 12
*/


int FindMax(int[,] numbers) {
    int height = numbers.GetLength(0);
    if (height == 0) {
        return -1;
    }

    int width = numbers.GetLength(1);
    if (width == 0) {
        return -1;
    }

    int maxValue = numbers[0, 0];

    for (var i = 0; i < height; i++) {
        for (var j = 0; j < width; j++) {
            var number = numbers[i, j];
            if (number > maxValue) {
                maxValue = number;
            }
        }
    }
    return maxValue;
}