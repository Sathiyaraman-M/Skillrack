#include<stdio.h> 
#include <stdlib.h> 
void printDiagonal(int N, int *matrix)
{ 
	for(int i = 0; i < N; i++) 
	{ 
		printf("%d ", *(matrix + i * (N + 1)));
	} 
} 

int main() 
{ 
	int N; 
	scanf("%d", &N); 
	int matrix[N][N]; 
	for(int row = 0; row < N; row++) 
	{ 
		for(int col = 0; col < N; col++) 
		{ 
			scanf("%d", &matrix[row][col]); 
		} 
	} 
	printDiagonal(N, matrix); 
}