void replaceBorderElementsByWaterImage(int R, int C, int matrix[][C])
{
    for(int i = 1; i < (R / 2); i++)
    {
        int temp1 = matrix[i][0], temp2 = matrix[i][C - 1];
        matrix[i][0] = matrix[R - i - 1][0];
        matrix[i][C - 1] = matrix[R - i - 1][C - 1];
        matrix[R - i - 1][0] = temp1;
        matrix[R - i - 1][C - 1] = temp2;
    }
    for(int i = 0; i < C; i++) {
        int temp = matrix[0][i];
        matrix[0][i] = matrix[R - 1][i];
        matrix[R - 1][i] = temp;
    }
}